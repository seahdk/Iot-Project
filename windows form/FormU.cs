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
    public partial class FormU : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SmartCarparkDatabaseConnection"].ConnectionString;
        public FormU()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - (this.Width / 2);
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - (this.Height / 2);
            this.Location = new Point(x, y);
        }

        // SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-D7UTGJ2S;Initial Catalog=Smart Carpark Database;Integrated Security=True");

        private void button_GoToLogin_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void button_GoToRegister_Click(object sender, EventArgs e)
        {
            // panel2.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Ignore. //
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Ignore. //
        }

        private void FormU_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT CustomerID, Username, Password FROM CustAccs";
            strCommandText += " WHERE Username=@Username AND Password=@Password";
            SqlCommand cmd = new SqlCommand(strCommandText, myConnect);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);

    
            try
            {
                myConnect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Successfully Logged In!");
                    //Form_CustUI form_show = new Form_CustUI();
                    //form_show.Show();
                    //this.Hide();

                    // Store login customer ID
                    string customerID = reader["CustomerID"].ToString();
                    Global.CurrentUser = Int32.Parse(customerID);

                    var newForm = new SmartCarpark.Home(Global.CurrentUser);
                    newForm.Show();
                    newForm.FormClosing += new FormClosingEventHandler(formClosing);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed.");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                reader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message.ToString());
            }

            finally
            {
                myConnect.Close();
            }
        }
        
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            var newForm = new FormAorU();
            newForm.Show();
            //this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ignore. (Register) //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAorU back = new FormAorU();
            back.Show();
        }
    }
}
