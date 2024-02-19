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
    public partial class Form_update : Form
    {
        public Form_update()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - (this.Width / 2);
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - (this.Height / 2);
            this.Location = new Point(x, y);
        }

        string strConnectionString = ConfigurationManager.ConnectionStrings["SmartCarparkDatabaseConnection"].ConnectionString;

        private void Form_update_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-- Update --//
            if (UpdateCustAccDetails() > 0)
                MessageBox.Show("Update Successful!");
            else
                MessageBox.Show("Update Failed.");
        }

        private int UpdateCustAccDetails()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            String strCommandText = "UPDATE CustAccs SET Email=@Email, Phone=@Phone, Password=@Password WHERE Username=@Username";
            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);

            updateCmd.Parameters.AddWithValue("@Username", textBox4.Text);
            updateCmd.Parameters.AddWithValue("@Email", textBox1.Text);
            updateCmd.Parameters.AddWithValue("@Phone", textBox2.Text);
            updateCmd.Parameters.AddWithValue("@Password", textBox3.Text);

            myConnect.Open();

            int result = updateCmd.ExecuteNonQuery();

            myConnect.Close();
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_admin back = new Form_admin();
            back.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Ignore. //
        }
    }
}
