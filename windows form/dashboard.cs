using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace SmartCarpark
{
    public partial class dashboard : Form
    {
        public int Customer = 1;
        public dashboard()
        {
            InitializeComponent();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnprofile.Height;
            panelLeft.Top = btnprofile.Top;

            profile myForm = new profile();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnhome.Height;
            panelLeft.Top = btnhome.Top;

            Home myForm = new Home();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btnwallet_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnwallet.Height;
            panelLeft.Top = btnwallet.Top;

            wallet myForm = new wallet();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btndashboard.Height;
            panelLeft.Top = btndashboard.Top;

            dashboard myForm = new dashboard();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }


        private void btnreport_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnreport.Height;
            panelLeft.Top = btnreport.Top;

            Report myForm = new Report();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            fillchart();
        }

        private void fillchart()
        {

            //Chart 1 Payment VS Day
            string strConnectionString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            DataSet ds = new DataSet();
            myConnect.Open();
      
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT VisitDate, sum(Deduction) AS TotalDeducted FROM Trans WHERE CustomerID = " + Customer + " GROUP BY VisitDate", myConnect);
            
            adapt.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Deducted"].XValueMember = "VisitDate";
            chart1.Series["Deducted"].YValueMembers = "TotalDeducted";
            chart1.Titles.Add("Payment by Day");

            //Chart 2 Total Visits
            DataSet ds2 = new DataSet();
            SqlDataAdapter adapt2 = new SqlDataAdapter("WITH Counting AS (SELECT COUNT(Id) AS CountVisits, Month(VisitDate) AS Month, CustomerID FROM Trans GROUP BY CustomerID,VisitDate) SELECT SUM(CountVisits) AS TotalVisits, Month FROM Counting WHERE CustomerID ="+ Customer + " GROUP BY Month", myConnect); 
            Console.WriteLine(adapt2);
            adapt2.Fill(ds2);
            chart2.DataSource = ds2;
            chart2.Series["Total Visits"].XValueMember = "Month"; // Change to Month to test
            chart2.Series["Total Visits"].YValueMembers = "TotalVisits";
            chart2.Titles.Add("Total Visits Over Month");

            //Chart 2 Total Visits
            DataSet ds3 = new DataSet();
            SqlDataAdapter adapt3 = new SqlDataAdapter("WITH Counting AS (SELECT COUNT(Id) AS CountVisits, Year(VisitDate) AS Year, CustomerID FROM Trans GROUP BY CustomerID,VisitDate) SELECT SUM(CountVisits) AS TotalVisits, Year FROM Counting WHERE CustomerID =" + Customer + "  GROUP BY Year", myConnect);
            Console.WriteLine(adapt3);
            adapt3.Fill(ds3);
            chart3.DataSource = ds3;
            chart3.Series["Yearly Visits"].XValueMember = "Year"; // Change to Month to test
            chart3.Series["Yearly Visits"].YValueMembers = "TotalVisits";
            chart3.Titles.Add("Total Visits Over Years");
            myConnect.Close();
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
