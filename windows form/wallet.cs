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
    public partial class wallet : Form
    {
        public int Customer = 1;
        public wallet()
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


        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void wallet_Load(object sender, EventArgs e)
        {
            gridbind();
        }

        private void gridbind()
        {
            string strConnectionString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
            using (SqlConnection myConnect = new SqlConnection(strConnectionString))
            {
                myConnect.Open();
                SqlCommand cmd = new SqlCommand("SELECT VisitDate,Deduction,EntryTime,ExitTime FROM Trans WHERE CustomerID =" + Customer + "GROUP BY VisitDate,Deduction,EntryTime,ExitTime", myConnect);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                myConnect.Close();
            }
        }
    }
}
