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
    public partial class Signin : Form
    {
        public static int ID = 0, Type_Person = 0;
        public static string Name_person, Email;
        public static bool IsManager = false;
        
        public Signin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signin_Load(object sender, EventArgs e)
        {
            ID = 0;
            Program.ChangePass = false;
            IsManager = false;
        }

        private void CheckisManager()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = " Select * from PhongBan Where Truongphong = " + ID;
                SqlCommand cmd = new SqlCommand(qry,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsManager = true;
                }

                conn.Close();
            }
        }

        private void Type_text_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Courses temp = new Register_Courses();
            temp.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Type_text.Text == "Học viên")
                Type_Person = 0;
            if (Type_text.Text == "Nhân viên")
                Type_Person = 1;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                SqlCommand check = new SqlCommand("DangNhap", conn);
                check.CommandType = CommandType.StoredProcedure;
                check.Parameters.AddWithValue("@tenDN", Username_text.Text);
                check.Parameters.AddWithValue("@mk", Pass_Text.Text);
                check.Parameters.AddWithValue("@loaiTK", Type_Person);
                SqlParameter res = new SqlParameter("@returnvalue", SqlDbType.Int);

                res.Direction = ParameterDirection.ReturnValue;
                check.Parameters.Add(res);
                check.ExecuteNonQuery();

                Object checkDN = check.Parameters["@returnvalue"].Value;

                //MessageBox.Show(checkDN.ToString());

                if (string.IsNullOrEmpty(Username_text.Text) || string.IsNullOrEmpty(Pass_Text.Text))
                {
                    MessageBox.Show("Please Enter your Username and Password !!");
                }
                else if (string.IsNullOrEmpty(Type_text.Text))
                {
                    MessageBox.Show("You are a Student or an Employee ?");
                }
                else
                {
                    if (Int32.Parse(checkDN.ToString()) == 0)
                    {
                        MessageBox.Show(" Username doesn't exist !!");
                    }
                    else if (Int32.Parse(checkDN.ToString()) == -1)
                    {
                        MessageBox.Show(" Uncorrect Password !!");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("ThongtinTK", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tenDN", Username_text.Text);
                        cmd.Parameters.AddWithValue("@loaiTK", Type_Person);
                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Ten_TK"].ToString());
                            if (reader["Ten_TK"].ToString() == Username_text.Text.Trim())
                            {
                                if (Type_Person == 0)
                                {
                                    ID = Int32.Parse(reader["ID_Hocvien"].ToString());
                                    Name_person = reader["Ten_Hocvien"].ToString();
                                    Email = reader["Email"].ToString();

                                }
                                if (Type_Person == 1)
                                {
                                    ID = Int32.Parse(reader["ID_NV"].ToString());
                                    Name_person = reader["Ten_NV"].ToString();
                                    Email = reader["Email"].ToString();

                                }

                            }
                        }
                        watch.Stop();
                        this.Hide();

                        CheckisManager();
                        //MessageBox.Show(IsManager.ToString());
                        if (Type_Person == 1)
                        {
                            if (Int32.Parse(checkDN.ToString()) == 1)
                            {
                                CourseManager_Menu temp = new CourseManager_Menu();
                                temp.ShowDialog();
                            }
                            if (Int32.Parse(checkDN.ToString()) == 2)
                            {
                                HRM_Employee temp = new HRM_Employee();
                                temp.ShowDialog();
                            }
                            if (Int32.Parse(checkDN.ToString()) == 4)
                            {
                                StudentManager_Classes temp = new StudentManager_Classes();
                                temp.ShowDialog();
                            }

                        }
                        else
                        {
                            if (Int32.Parse(checkDN.ToString()) == 1)
                            {
                                Student_Menu temp = new Student_Menu();
                                temp.ShowDialog();
                            }
                        }
                        this.Close();

                    }
                }
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup temp = new Signup();
            temp.ShowDialog();
            this.Close();
        }
    }
}
