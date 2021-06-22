using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyTrungtam
{
    public partial class Teacher_Menu : Form
    {
        public Teacher_Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAccount temp = new ManageAccount();
            temp.ShowDialog();
            this.Close();
        }

        private void Teacher_Menu_Load(object sender, EventArgs e)
        {
            if(!Signin.IsManager)
            {
                button1.BackColor = Color.LightGray;
                button1.ForeColor = Color.Black;
                button1.FlatAppearance.BorderColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor != Color.LightGray)
            {
                this.Hide();
                Teacher_Manage temp = new Teacher_Manage();
                temp.ShowDialog();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show("You will be logged out. Continue ?", "Log out", button);
            if (res == DialogResult.Yes)
            {
                Signin.ID = 0;
                this.Hide();
                Signin temp = new Signin();
                temp.ShowDialog();
                this.Close();
            }
        }
    }
}
