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
    public partial class Report : Form
    {
        public int Customer = 1;
        public Report()
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

        private void btnhome_Click(object sender, EventArgs e)
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

        //list of variables for functions to share
        public List<string> filePath = new List<string>();
        public string Textbox1Text;
        public string Pathing;
        public string filename;
        public int ID;
        private void btnAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Office Files|*.docx;*.xls;*.ppt;*.doc;*.pdf; | Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string extn = new FileInfo(filename).Extension;
                foreach (string fileName in openFileDialog.FileNames)
                {
                    filePath.Add(fileName);
                    filename = fileName;
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (string Path in filePath)
            {
                string strConnString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
                SqlConnection myconnect = new SqlConnection(strConnString);

                string strcommandtext = "INSERT INTO ReportFiles(Id, Data, DataExtn, CustID, Comments) VALUES (@Id, @Data, @DataExtn, @CustID, @Comments)";
                SqlCommand cmd = new SqlCommand(strcommandtext, myconnect);

                byte[] fileBytes = File.ReadAllBytes(Path);
                string extn = new FileInfo(Path).Extension;

                cmd.Parameters.AddWithValue("@Id", IDCalc());
                cmd.Parameters.AddWithValue("@Data", fileBytes);
                cmd.Parameters.AddWithValue("@DataExtn", extn);
                cmd.Parameters.AddWithValue("@CustID", Customer);
                cmd.Parameters.AddWithValue("@Comments", Textbox1Text);

                myconnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Console.WriteLine("hello");
                    reader.Close();
                    myconnect.Close();
                }
                else
                {
                    reader.Close();
                    myconnect.Close();
                }
            }
            DialogResult dialog = MessageBox.Show("Submitted");
            
        }
        public static int IDCalc()
        {
            string strConnString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
            SqlConnection myconnect = new SqlConnection(strConnString);

            string strcommandtext = "SELECT COUNT(*) FROM ReportFiles";
            SqlCommand cmd = new SqlCommand(strcommandtext, myconnect);
            myconnect.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Textbox1Text = textBox1.Text;
        }

        /* This prob will not work but I put it for you to reference DK
         private void btnReadFromDb_Click(object sender, EventArgs e)
        {
        string strConnString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
        SqlConnection myconnect = new SqlConnection(strConnString);
        string strcommandtext = "SELECT * FROM ReportFiles WHERE Id = @Id'";
        cmd.Parameters.AddWithValue("@Id", "2");
        myconnect.Open();
        SqlDataReader reader = cmd.ExecuteReader();


        string path = "YOUR_PATH\\Test";
        DataTable dt = DAL.Database.GetDataTable(strcommandtext);
        if (dt != null && dt.Rows.Count > 0)
            {
            Byte[] file = (Byte[])dt.Rows[0]["Data"];
            string extn = dt.Rows[0]["DataExtn"].ToString();
            path = Path.Combine(path, "Test321"+extn);

            File.WriteAllBytes(path, file);
            Process.Start(path);
            }
        }
         */

        //https://stackoverflow.com/questions/70884833/how-to-save-1-file-pdf-to-sql-server-with-winform
    }
}
