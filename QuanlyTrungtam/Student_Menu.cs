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
    public partial class Student_Menu : Form
    {
        public Student_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Courses temp = new Register_Courses();
            temp.ShowDialog();
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_ManageClass temp = new Student_ManageClass();
            temp.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAccount temp = new ManageAccount();
            temp.ShowDialog();
            this.Close();
        }
    }
}
