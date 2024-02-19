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
    public partial class EditForm : Form
    {
        public int Customer = 1;
        string strConnectionString = ConfigurationManager.ConnectionStrings["CarPark"].ConnectionString;
        DataTable UserTable = new DataTable();
        DataGridView currentRow = null;
        SqlDataAdapter UserAdapter;
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carParkDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.carParkDataSet.Customer);
            gridbind();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillBy(this.carParkDataSet.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridbind()
        {
            SqlConnection myConnect = new SqlConnection(strConnectionString);
            myConnect.Open();
            string str = "SELECT CustomerID, Username, Password, Phone, Email FROM Customer WHERE CustomerID = " + Customer;
            UserAdapter = new SqlDataAdapter(str, strConnectionString);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(UserAdapter);
            UserTable.Clear();
            UserAdapter.Fill(UserTable);

            if (UserTable.Rows.Count > 0)
                customerBindingSource1.DataSource = UserTable;
            
            myConnect.Close();
        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int modifiedRows = 0;
            DataTable UpdatedTable = UserTable.GetChanges();
            if (UpdatedTable != null)
            {
                modifiedRows = UserAdapter.Update(UpdatedTable);
                UserTable.AcceptChanges();
            }
            else
                MessageBox.Show("There are no changes to be made");

            if (modifiedRows > 0)
                MessageBox.Show("There are " + modifiedRows + " records updated...");
            gridbind();
            profile myForm = new profile();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
