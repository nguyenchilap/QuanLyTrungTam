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
    public partial class ManageAccount : Form
    {
        public ManageAccount()
        {
            InitializeComponent();
        }

        static bool checkPass = false;
        private void CheckCurPass()
        {
            if (string.IsNullOrEmpty(CurPass.Text))
                MessageBox.Show("Enter your Current Password!!!");
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Check_Cur_Pass", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@input", CurPass.Text);
                    cmd.Parameters.AddWithValue("@id", Int32.Parse(Signin.ID.ToString()));
                    cmd.Parameters.AddWithValue("@type", Int32.Parse(Signin.Type_Person.ToString()));
                    SqlParameter res = new SqlParameter("@returnvalue", SqlDbType.Int);
                    res.Direction = ParameterDirection.ReturnValue;
                    cmd.Parameters.Add(res);

                    cmd.ExecuteNonQuery();

                    Object check = cmd.Parameters["@returnvalue"].Value;

                    if (Int32.Parse(check.ToString()) == 0)
                    {
                        noti.Text = "Incorrect Password !!!";
                        noti.ForeColor = System.Drawing.Color.Red;
                        checkPass = false;
                    }
                    if (Int32.Parse(check.ToString()) == 1)
                    {
                        noti.Text = "Correct Password !!!";
                        noti.ForeColor = System.Drawing.Color.Green;
                        checkPass = true;
                    }

                    conn.Close();
                }
                CurPass.Text = "";
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            CheckCurPass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCurPass();
        }

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            Id.Text += Signin.ID.ToString();
            NamePerson.Text += Signin.Name_person.ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (string.IsNullOrEmpty(NewPass.Text)) MessageBox.Show("Enter your new Password !!!");
            else if (string.IsNullOrEmpty(ConfirmPass.Text)) MessageBox.Show("Confirm your new Password !!!");
            else if (checkPass == false) MessageBox.Show("Please Confirm your Current Password !!!");
            else if (NewPass.Text != ConfirmPass.Text) MessageBox.Show("Please Confirm your Password again !!!");
            else
            {
                string qry = "";
                if (Signin.Type_Person == 1)
                    qry = "Update Taikhoan_Nhanvienn Set Matkhau = '" + NewPass.Text + "' Where ID_NV = " + Signin.ID.ToString();
                if (Signin.Type_Person == 0)
                    qry = "Update Taikhoan_Hocvien Set Matkhau = '" + NewPass.Text + "' Where ID_Hocvien = " + Signin.ID.ToString();
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show("Error!!! : " + exc);
                        check = false;
                    }
                    conn.Close();
                }    
                if (check == true)
                {
                    Program.ChangePass = true;
                    MessageBox.Show("Change Password Successful !!!");
                    this.Hide();
                    Signin temp = new Signin();
                    temp.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Signin.Type_Person == 0)
            {
                Student_Menu temp = new Student_Menu();
                temp.ShowDialog();
            }
            else
            {
                if (Signin.check_Menu == 1)
                {
                    CourseManager_Menu temp = new CourseManager_Menu();
                    temp.ShowDialog();
                }
                if (Signin.check_Menu == 2)
                {
                    HRM_Employee temp = new HRM_Employee();
                    temp.ShowDialog();
                }
                if (Signin.check_Menu == 3)
                {
                    Teacher_Menu temp = new Teacher_Menu();
                    temp.ShowDialog();
                }
                if (Signin.check_Menu == 4)
                {
                    StudentManager_Menu temp = new StudentManager_Menu();
                    temp.ShowDialog();
                }
            }
            this.Close();
        }
    }
}
