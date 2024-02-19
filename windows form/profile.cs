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
    public partial class profile : Form
    {
        public int Customer = 1;
        public profile()
        {
            InitializeComponent();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            fillProfile();
        }

        private void fillProfile()
        {
            string strConnString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
            string str;
            SqlCommand com;

            SqlConnection con = new SqlConnection(strConnString);
            con.Open();
            str = "SELECT Username, Password, Phone, Email, DateJoined FROM Customer WHERE CustomerID = "+ Customer;
            com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();

            reader.Read();
            CustName.Text = reader["Username"].ToString();
            Email.Text = reader["Email"].ToString();
            Phone.Text = reader["Phone"].ToString();
            DateJoined.Text = reader["DateJoined"].ToString();
            Password.Text = reader["Password"].ToString();
            con.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string strConnString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
                int result = 0;
                SqlConnection con = new SqlConnection(strConnString);
                string str = "DELETE FROM Customer WHERE CustomerID = " + Customer;
                SqlCommand com = new SqlCommand(str, con);
                con.Open();
                result = com.ExecuteNonQuery();
                Console.WriteLine(result);
                if (result==1)
                {
                    MessageBox.Show("Account Deleted Successfully.");
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Failed");
                    this.Hide();
                    con.Close();
                }
            }
            else if (dialog == DialogResult.No)
            {
                
            }
            else
            {
                MessageBox.Show("Error Occurred. Try Again");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Form formbackground = new Form();
            try
            {
                using (EditForm uu = new EditForm())
                {
                    formbackground.StartPosition = FormStartPosition.Manual;
                    formbackground.FormBorderStyle = FormBorderStyle.None;
                    formbackground.Opacity = .50d;  
                    formbackground.BackColor = Color.Black;
                    formbackground.WindowState = FormWindowState.Maximized;
                    formbackground.Location = this.Location;
                    formbackground.ShowInTaskbar = false;
                    formbackground.Show();

                    uu.Owner = formbackground;
                    uu.ShowDialog();
                    formbackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formbackground.Dispose();
            }
        }
    }
}
