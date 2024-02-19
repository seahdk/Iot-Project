using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormAorU : Form
    {
        public FormAorU()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - (this.Width / 2);
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - (this.Height / 2);
            this.Location = new Point(x, y);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Ignore. //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new FormA();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new FormU();
            newForm.Show();
            this.Hide();
        }

        private void FormAorU_Load(object sender, EventArgs e)
        {

        }
    }
}
