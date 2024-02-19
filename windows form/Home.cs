using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCarpark
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
