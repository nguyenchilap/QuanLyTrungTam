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

namespace QuanlyTrungtam
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signin temp = new Signin();
            temp.ShowDialog();
            this.Close();
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            if(noti.ForeColor != Color.Green)
            {
                MessageBox.Show("Confirm your Account first!!!");
            }
            else
            {
                if (string.IsNullOrEmpty(Name_Text.Text))
                    MessageBox.Show("Enter your Name!!");
                else if (string.IsNullOrEmpty(email.Text))
                    MessageBox.Show("Enter your Email Address!!");
                else if (DOB.Value == DateTime.Now)
                    MessageBox.Show("Enter your Date of Birth!!!");
                else if (string.IsNullOrEmpty(Phonenum_text.Text))
                    MessageBox.Show("Enter your Phone Number !!!");
                else
                {
                    int ID_Hocvien = 0;
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry = "Select Max(ID_Hocvien) as ID_Hocvien from HocVien";
                        SqlCommand cmd = new SqlCommand(qry,conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            //MessageBox.Show(reader["ID_Hocvien"].ToString());
                            ID_Hocvien = Int32.Parse(reader["ID_Hocvien"].ToString()) + 1;
                        }
                        conn.Close();
                    }

                    bool check = false;
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    { 
                        conn.Open();
                        string insert_qry = "Insert into HocVien values (" + ID_Hocvien.ToString() + ", N'" +
                           Name_Text.Text + "', '" + email.Text + "@gmail.com', '" + Phonenum_text.Text +
                           "', '" + DOB.Value.ToString("MM/dd/yyyy") + "')";
                        insert_qry += "\n Insert into Taikhoan_HocVien values ('"
                                + Username_text.Text + "','" + Pass_Text.Text + "'," + ID_Hocvien.ToString() + ")";
                        //MessageBox.Show(insert_qry);
                   
                        SqlCommand cmd = new SqlCommand(insert_qry,conn);
                        try
                        {
                            cmd.ExecuteNonQuery();
                            check = true;
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Error!!!" + exc);
                        }
                        conn.Close();
                        if (check == true)
                        {
                            MessageBox.Show("Sign up success !!");
                            this.Hide();
                            Signin temp = new Signin();
                            temp.ShowDialog();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void Check_Avail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username_text.Text))
                MessageBox.Show("Enter Username!!!");
            else if (string.IsNullOrEmpty(Pass_Text.Text))
                MessageBox.Show("Enter Password!!!");
            else if (string.IsNullOrEmpty(Confirmpass_text.Text))
                MessageBox.Show("Confirm Password!!!");
            else if (Pass_Text.Text != Confirmpass_text.Text)
                MessageBox.Show("Re-Confirm Password !!");
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    string qry = "Select * from Taikhoan_HocVien where Ten_TK = N'" + Username_text.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Username_text.Text = "";
                        noti.Text = "Username already exists!!!";
                        noti.ForeColor = Color.Maroon;
                    }
                    else
                    {
                        noti.Text = "Available Username !!";
                        noti.ForeColor = Color.Green;
                    }
                    conn.Close();
                }
             
            }
        }
    }
}
