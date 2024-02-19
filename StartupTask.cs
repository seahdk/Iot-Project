using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Background;
using System.Diagnostics;
using System.Threading.Tasks;
using GrovePi;
using GrovePi.Sensors;
// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace Project2
{

    public sealed class StartupTask : IBackgroundTask

    {
        // Dictionary to store occupants uniquerfid as key and Datetime as value
        IDictionary<string, DateTime> occupants = new Dictionary<string, DateTime>();

        // For Data Comms
        DataComms dataComms;

        //Use D8 for ultrasonic sensor
        IUltrasonicRangerSensor sensor = DeviceFactory.Build.UltraSonicSensor(Pin.DigitalPin8);

        int num_lots_avail = 0;




        //used by sensor for internal processing
        private int distance = 400;

        //This is the main logic controller to check for distance
        int sensorDistance;

        private System.Threading.Semaphore sm = new System.Threading.Semaphore(1, 1);

        private static SerialComms uartComms;
        private static string strRfidDetected = ""; //used to check for RFID

        private void Sleep(int NoOfMs)
        {
            Task.Delay(NoOfMs).Wait();
        } //end of sleep

        // ============== rfid method ==============

        // >> card detect callback >>
        //This method is automatically called when there is card detected
        static void UartDataHandler(object sender, SerialComms.UartEventArgs e)
        {
            //strRfidDetected can be used anywhere in the program to check
            //for card detected
            strRfidDetected = e.data;       // >> populate card data >>
            Debug.WriteLine("Card Detected : " + strRfidDetected);
        }

        //Must call this to initialise the Serial Comms
        private void StartUart()
        {
            uartComms = new SerialComms();
            // init serial comms with callback
            uartComms.UartEvent += new SerialComms.UartEventDelegate(UartDataHandler);
        } //end of StartUart()

        // Initialise Data Comms for handling data from main to form
        private void initComms()
        {
            dataComms = new DataComms();
        }

        private void clr_card_details()
        {
            if (!strRfidDetected.Equals(""))
            {
                strRfidDetected = "";
            }
        }

        // ============== rfid method ==============

        // ============== card method ==============
        private void handle_card(string card_num)
        {
            // Display card detection
            switch (card_num)
            {
                case "6A003E1A7A34":
                    Debug.WriteLine("CARD 1 Detected");
                    break;
                case "6A003E38A6CA":
                    Debug.WriteLine("CARD 2 Detected");
                    break;
                case "6A003E7290B6":
                    Debug.WriteLine("CARD 3 Detected");
                    break;
                case "6A003E2AF987":
                    Debug.WriteLine("CARD 4 Detected");
                    break;
                default:
                    break;
            }

            // Check event type 
            DateTime now = DateTime.Now;

            string eventString;

            // Event type - entry
            if (!occupants.ContainsKey(card_num))
            {
                // Add entry to dicitonary
                occupants[card_num] = now;

                // Compile Event Data
                eventString = String.Format(
                    "entry,{0},{1},{2},{3},{4}",
                    card_num, now.ToString("O"), num_lots_avail, occupants.Count, 0
                );

                // Send entry event to Windows Form
                dataComms.sendData(eventString);
                return;
            }

            
            // Event type - exit

            // Extract entry time
            DateTime entryTime = occupants[card_num];

            //remove 
            occupants.Remove(card_num);


            // original codes for per hour

            //TimeSpan ts = now - entryTime;
            //double hours = ts.TotalHours;
            //hours = Math.Ceiling(hours);

            // Parking cost
            //double costPerHour = 2.0;
            //double parkingCost = hours * costPerHour;

            //end original

            // Get number of seconds, 2.0 per seconds, round up.
            TimeSpan ts = now - entryTime;
            double seconds = ts.TotalSeconds;
            double costPerSecond = 2.0;
            double parkingCost = Math.Ceiling(seconds) * costPerSecond;



            // Compile Event Data
            eventString = String.Format(
                "exit,{0},{1},{2},{3},{4}",
                card_num, now.ToString("O"), num_lots_avail, occupants.Count, parkingCost
            );

            // Send exit event to Windows Form
            dataComms.sendData(eventString);
            
        }


        // ============== ultrasonic method ==============





        private int getDistance()
        {
            //need to ensure you cover the correct FOV before distance is reported correctly
            //better to cover with a big object like a file
            //will take some time to init before scanning
            sm.WaitOne();
            int distanceRead = sensor.MeasureInCentimeters();
            sm.Release();
            if (distanceRead < 400 && distanceRead > 0)

                distance = distanceRead;


            return distance;
        }//end of getDistance
        
        private int get_lots(int dist)
        {
            int lots_dist_int = 5;
            return dist / lots_dist_int;
        }



        // ============== ultrasonic method ==============




        

        public void Run(IBackgroundTaskInstance taskInstance)
        {

            // =========================== setup start ===========================
            // call uart init 
            StartUart();
            // call initComms
            initComms();
            


            // =========================== setup end ===========================

            while (true)
            {
                Sleep(300);

          
                sensorDistance = getDistance();
                num_lots_avail = get_lots(sensorDistance);
                Debug.WriteLine("Number of lots available: {0}", num_lots_avail, "");



                // rfid detect
                if (strRfidDetected != "")
                {
                    // if rfid detected,
                    handle_card(strRfidDetected);
                    clr_card_details();
                }
                
            }
        }
    }
}