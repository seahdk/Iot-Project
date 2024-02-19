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
    public partial class FormA : Form
    {
        private string strConnectionString = ConfigurationManager.ConnectionStrings["SmartCarparkDatabaseConnection"].ConnectionString;
        public FormA()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - (this.Width / 2);
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - (this.Height / 2);
            this.Location = new Point(x, y);
        }

        // SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-D7UTGJ2S;Initial Catalog=Smart Carpark Database;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {
            // Ignore. //
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Ignore. //
        }

        private void FormA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* String username, password;

            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                String query = "SELECT * FROM Admin_Accounts WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;

                    Form2 form_show = new Form2();
                    form_show.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Credentials.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error.");
            }
            finally
            {
                conn.Close();
            } */

            SqlConnection myConnect = new SqlConnection(strConnectionString);
            string strCommandText = "SELECT Username, Password FROM AdmAccs";
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
                    Form_AdminUI form_show = new Form_AdminUI();
                    form_show.Show();
                    this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAorU back = new FormAorU();
            back.Show();
        }
    }
}
