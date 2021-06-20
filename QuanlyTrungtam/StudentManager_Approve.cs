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
    public partial class StudentManager_Approve : Form
    {
        public StudentManager_Approve()
        {
            InitializeComponent();
        }

        private void Filter_Load()
        {
            Year_Filter.Items.Clear();
            Month_Filter.Items.Clear();
            for (int i = 1; i<=12; i++)
            {
                Month_Filter.Items.Add(i.ToString());
            }
            for (int i = 2018; i<=2050; i++)
            {
                Year_Filter.Items.Add(i.ToString());
            }
        }
        private void StudentManager_StudentRegister_Load(object sender, EventArgs e)
        {
            Edu_Form_LoadIndex();
            Filter_Load();

            //Edu_Form.Text = "Tất cả";
            Month_Filter.Text = DateTime.Now.Month.ToString();
            Year_Filter.Text = DateTime.Now.Year.ToString();
            CheckPaid.Text = "Tất cả";

            Load_DonDangki();
            Load_Khoahoc();
        }

        private int ID_KhoaHoc(string Ten_Khoa)
        {
            int res = 0;
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select ID_Khoa from KhoaDaoTao Where Ten_Khoa = N'" + Ten_Khoa + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    res = Int32.Parse(reader["ID_Khoa"].ToString());
                }
                conn.Close();
            }
            return res;
        }
        private string HocPhi_KhoaHoc(string Ten_Khoa, string Ten_HV)
        {
            string res = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Dangky_Hocphi", conn);
                cmd.Parameters.AddWithValue("@idKhoa", ID_KhoaHoc(Ten_Khoa));
                cmd.Parameters.AddWithValue("@tenHV", Ten_HV);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    res = reader["Hocphi"].ToString();
                }
                conn.Close();
            }
            return res;
        }

        private void Edu_Form_LoadIndex()
        {
            Edu_Form.Items.Clear();
            Edu_Form.Items.Add("Tất cả");
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select Ten_Loai from LoaiHinhDaoTao where ID_Loai > 0";
                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Edu_Form.Items.Add(reader["Ten_Loai"].ToString());
                }
                watch.Stop();
                conn.Close();
            }
        }

        private void Load_DonDangki()
        {
            DonDK_View.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();

                string qry = " Select *, A.Hocphi as DHP from DonDangKi A join HocVien B ON A.ID_Hocvien = B.ID_Hocvien " +
                                                                         "join KhoaDaoTao C ON A.ID_Khoa = C.ID_Khoa " +
                                                                         "join LoaiHinhDaoTao D ON D.ID_Loai = C.LoaiHinhDaoTao ";
                qry += " where Year(C.NgayBatdau) = " + Year_Filter.Text + " and Month(C.NgayBatdau) = " + Month_Filter.Text;
                qry += " and NOT EXISTS (Select * from DangKi DK where DK.ID_Hocvien = A.ID_Hocvien and DK.ID_Khoa = A.ID_Khoa)";
                if (Edu_Form.Text != "Tất cả" && !string.IsNullOrEmpty(Edu_Form.Text))
                    qry += " and D.Ten_Loai = N'" + Edu_Form.Text + "'";
                if (CheckPaid.Text != "Tất cả")
                {
                    if (CheckPaid.Text == "Đã đóng") qry += " and A.Hocphi = 1";
                    if (CheckPaid.Text == "Chưa đóng") qry += " and A.Hocphi = 0";
                }
                //MessageBox.Show(qry);

                SqlCommand cmd = new SqlCommand(qry, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Hocvien"].ToString());
                    item.SubItems.Add(reader["Ten_Hocvien"].ToString());
                    item.SubItems.Add(reader["Ten_Khoa"].ToString());
                    item.SubItems.Add(HocPhi_KhoaHoc(reader["Ten_Khoa"].ToString(),reader["Ten_Hocvien"].ToString()));
                    if (reader["DHP"].ToString() == "0")
                        item.SubItems.Add("Chưa đóng");
                    else
                        item.SubItems.Add("Đã đóng");
                    DonDK_View.Items.Add(item);
                }

                conn.Close();
            }
        }

        private void Load_Khoahoc()
        {
            KhoaHoc_View.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from KhoaDaoTao where ID_Khoa > 0";
                qry += " and Year(NgayBatdau) = " + Year_Filter.Text + " and Month(NgayBatdau) = " + Month_Filter.Text;
                if (Edu_Form.Text != "Tất cả" && !string.IsNullOrEmpty(Edu_Form.Text))
                    qry += " and LoaiHinhDaoTao = (Select ID_Loai from LoaiHinhDaoTao where Ten_Loai = N'" + Edu_Form.Text + "')";
                //MessageBox.Show(qry);
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Khoa"].ToString());
                    item.SubItems.Add(reader["Ten_Khoa"].ToString());
                    KhoaHoc_View.Items.Add(item);
                }
                conn.Close();
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManager_Menu temp = new StudentManager_Menu();
            temp.ShowDialog();
            this.Close();
        }

        private void Edu_Form_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DonDangki();
            Load_Khoahoc();
        }

        private void Courses_Reload_Click(object sender, EventArgs e)
        {
            Load_Khoahoc();
            Load_DonDangki();
            Edu_Form_LoadIndex();
            Student_Email.Text = "________________";
            Student_ID.Text = "000";
            Student_Name.Text = "_________________";
            Student_SDT.Text = "________________";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HocVien_view.Items.Clear();
            ListView.CheckedListViewItemCollection Items = KhoaHoc_View.CheckedItems;
            if (Items.Count > 1) MessageBox.Show("Select just 1 Course!!");
            else if (Items.Count <= 0) MessageBox.Show("Select Course you wanna View!!");
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    string qry = "Select * from DangKi A Join HocVien B ON A.ID_Hocvien = B.ID_Hocvien" +
                        " where ID_Khoa = " + Items[0].SubItems[0].Text;
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["ID_Hocvien"].ToString());
                        item.SubItems.Add(reader["Ten_Hocvien"].ToString());
                        HocVien_view.Items.Add(item);
                    }
                    conn.Close();
                }
            }
        }

        private void Month_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Year_Filter.Text))
            {
                Load_DonDangki();
                Load_Khoahoc();
            }
        }

        private void Year_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
                Load_DonDangki();
                Load_Khoahoc();
        }

        private void ViewClassList_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = DonDK_View.CheckedItems;
            if (Items.Count > 1) MessageBox.Show("Select just 1 Student!!");
            else if (Items.Count <= 0) MessageBox.Show("Select Student you wanna View!!");
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    string qry = "Select * from HocVien where ID_Hocvien = " + Items[0].SubItems[0].Text;
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Student_ID.Text = reader["ID_Hocvien"].ToString();
                        Student_Name.Text = reader["Ten_Hocvien"].ToString();
                        Student_SDT.Text = reader["SDT"].ToString();
                        Student_Email.Text = reader["Email"].ToString();
                    }
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = DonDK_View.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Select Student you wanna Approve!!");
            else
            {
                DialogResult res = MessageBox.Show("Are you sure to approve these students ?", "Approve", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    foreach(ListViewItem item in Items)
                    {
                        if (item.SubItems[4].Text == "Chưa đóng")
                        {
                            MessageBox.Show("Student haven't paid tuition fee yet !!!!");
                        }
                        else
                        {
                            string qry = "Insert into DangKi values(" + ID_KhoaHoc(item.SubItems[2].Text) + ", "
                                + item.SubItems[0].Text + ", N'Chưa tốt nghiệp', " + Signin.ID.ToString() + ")";
                            Program.ExecCmd(qry);
                        }
                    }
                }
                Load_DonDangki();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = DonDK_View.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Select Student you wanna View!!");
            else
            {
                foreach(ListViewItem item in Items)
                {
                    using(SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry = "Update DonDangKi Set Hocphi = 1 where ID_Hocvien = " + item.SubItems[0].Text
                            + " and ID_Khoa = " + ID_KhoaHoc(item.SubItems[2].Text);
                        Program.ExecCmd(qry);
                        conn.Close();
                    }
                }
                Load_DonDangki();
            }
        }

        private void CheckPaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_DonDangki();
        }
    }
}
