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
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class Form_admin : Form
    {
        public Form_admin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - (this.Width / 2);
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - (this.Height / 2);
            this.Location = new Point(x, y);
        }

        string strConnectionString = ConfigurationManager.ConnectionStrings["SmartCarparkDatabaseConnection"].ConnectionString;

        private void Form_admin_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RetrieveCustAccounts();
        }

        private void RetrieveCustAccounts()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            string strCommandText = "SELECT * FROM CustAccs";

            SqlDataAdapter adapter = new SqlDataAdapter(strCommandText, myConnect);
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = dTable;
            }
            else
            {
                MessageBox.Show("No Accounts Found.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-- Link to Update Form --//
            var newForm = new Form_update();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //-- Blacklist --//
            if (BlacklistCust() > 0)
                MessageBox.Show("Blacklist Successful.");
            else
                MessageBox.Show("Blacklist Failed.");
        }

        private int BlacklistCust()
        {
            string change = "Yes";
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "UPDATE CustAccs SET Blacklisted=@Blacklisted WHERE Username=@Username";
            SqlCommand blacklistCmd = new SqlCommand(strCommandText, myConnect);

            blacklistCmd.Parameters.AddWithValue("@Username", textBox1.Text);
            blacklistCmd.Parameters.AddWithValue("@Blacklisted", change);

            myConnect.Open();

            int result = blacklistCmd.ExecuteNonQuery();

            myConnect.Close();
            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //-- Delete --//
            if (DeleteCust() > 0)
                MessageBox.Show("Deletion Successful.");
            else
                MessageBox.Show("Deletion Failed.");
        }

        private int DeleteCust()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "DELETE FROM CustAccs WHERE Username=@Username";
            SqlCommand deleteCmd = new SqlCommand(strCommandText, myConnect);

            deleteCmd.Parameters.AddWithValue("@Username", textBox1.Text);

            myConnect.Open();

            int result = deleteCmd.ExecuteNonQuery();

            myConnect.Close();
            return result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_AdminUI back = new Form_AdminUI();
            back.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //-- Remove Blacklist --//
            if (UnBlacklistCust() > 0)
                MessageBox.Show("Blacklist Removed Successfully.");
            else
                MessageBox.Show("Blacklist Removal Failed.");
        }

        private int UnBlacklistCust()
        {
            string change = "No";
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "UPDATE CustAccs SET Blacklisted=@Blacklisted WHERE Username=@Username";
            SqlCommand blacklistCmd = new SqlCommand(strCommandText, myConnect);

            blacklistCmd.Parameters.AddWithValue("@Username", textBox1.Text);
            blacklistCmd.Parameters.AddWithValue("@Blacklisted", change);

            myConnect.Open();

            int result = blacklistCmd.ExecuteNonQuery();

            myConnect.Close();
            return result;
        }
    }
}
