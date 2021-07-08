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
    public partial class Teacher_Students : Form
    {
        public Teacher_Students()
        {
            InitializeComponent();
        }

        private void Load_LichThi(string month, string year)
        {
            LichThiView.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from LichThi a Join KhoaDaoTao b ON a.ID_Khoa = b.ID_Khoa " +
                                                    " Join DS_Monhoc c ON a.ID_Monhoc = c.ID_Monhoc " +
                                    "where a.GiaoVienCoiThi = " + Signin.ID.ToString();
                if (!string.IsNullOrEmpty(month)) qry += " and MONTH(a.Thoigian) = " + month;
                if (!string.IsNullOrEmpty(year)) qry += " and YEAR(a.Thoigian) = " + year;

                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Ten_Khoa"].ToString());
                    item.SubItems.Add(reader["Ten_Monhoc"].ToString());
                    item.SubItems.Add(reader["Thoigian"].ToString());
                    LichThiView.Items.Add(item);
                }
                
                conn.Close();
            }
        }

        private void Load_StudentList(string coursename, string classname)
        {
            StudentView.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from DSLopHoc a JOIN Hocvien b ON a.ID_Hocvien = b.ID_Hocvien " +
                                                    " JOIN KhoaDaoTao c ON c.ID_Khoa = a.ID_Khoa " +
                                                    " JOIN DS_MonHoc d ON d.ID_Monhoc = a.ID_Monhoc " +
                                      " where c.Ten_Khoa = N'" + coursename + "' and d.Ten_Monhoc = N'" + classname + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Hocvien"].ToString());
                    item.SubItems.Add(reader["Ten_Hocvien"].ToString());
                    item.SubItems.Add(reader["Email"].ToString());
                    item.SubItems.Add(reader["SDT"].ToString());
                    item.SubItems.Add(reader["Sobuoivang"].ToString());
                    item.SubItems.Add(reader["DiemThi"].ToString());
                    StudentView.Items.Add(item);
                }
                conn.Close();
            }    
        }
        private void Load_ClassList(string month, string year)
        {
            FilterCourses.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select distinct(Ten_Khoa) from LopHoc a join KhoaDaoTao b on a.ID_Khoa = b.ID_Khoa" +
                    //" join DS_MonHoc c ON c.ID_Monhoc = a.ID_Monhoc " +
                    " where ID_GV = " + Signin.ID.ToString();
                if (!string.IsNullOrEmpty(month)) qry += " and MONTH(b.NgayBatdau) =" + month;
                if (!string.IsNullOrEmpty(year)) qry += " and YEAR(b.NgayBatdau) =" + year;

                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FilterCourses.Items.Add(reader["Ten_Khoa"].ToString());
                }
                conn.Close();
            }
        }
        private void FilterClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FilterCourses.Text) && !string.IsNullOrEmpty(FilterClass.Text))
            Load_StudentList(FilterCourses.Text, FilterClass.Text);
        }

        private void FilterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterYear.Text))
            {
                Load_ClassList(FilterMonth.Text, null);
                Load_LichThi(FilterMonth.Text, null);
            }
            else
            {
                Load_ClassList(FilterMonth.Text, FilterYear.Text);
                Load_LichThi(FilterMonth.Text, FilterYear.Text);
            }
        }

        private void FilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterMonth.Text))
            {
                Load_ClassList(null, FilterYear.Text);
                Load_LichThi(null, FilterYear.Text);
            }
            else
            {
                Load_ClassList(FilterMonth.Text, FilterYear.Text);
                Load_LichThi(FilterMonth.Text, FilterYear.Text);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Menu temp = new Teacher_Menu();
            temp.ShowDialog();
            this.Close();
        }

        private void FilterCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentView.Items.Clear();
            FilterClass.Text = "";
            FilterClass.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from LopHoc a join KhoaDaoTao b on a.ID_Khoa = b.ID_Khoa" +
                    " join DS_MonHoc c ON c.ID_Monhoc = a.ID_Monhoc " +
                    " where a.ID_GV = " + Signin.ID.ToString() + " and b.Ten_Khoa = N'" + FilterCourses.Text +"'";
                if (!string.IsNullOrEmpty(FilterMonth.Text)) qry += " and MONTH(b.NgayBatdau) =" + FilterMonth.Text;
                if (!string.IsNullOrEmpty(FilterYear.Text)) qry += " and YEAR(b.NgayBatdau) =" + FilterYear.Text;

                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FilterClass.Items.Add(reader["Ten_Monhoc"].ToString());
                }
                conn.Close();
            }
        }

        private void UpdateHocvien(int sobuoivang, float diemthi)
        {
            ListView.CheckedListViewItemCollection Items = StudentView.CheckedItems;
            if (Items.Count <= 0 || Items.Count >1) MessageBox.Show("Select just 1 students!!");
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    string qry = "Update DSLopHoc ";
                    if (sobuoivang != -1) qry += " Set Sobuoivang = " + sobuoivang.ToString();
                    if (diemthi != -1) qry += " Set DiemThi = " + diemthi.ToString();

                    qry += " Where ID_Khoa = (Select ID_Khoa from KhoaDaoTao Where Ten_Khoa = N'" + FilterCourses.Text + "')" +
                        " and ID_Monhoc = (Select ID_Monhoc from DS_MonHoc where Ten_Monhoc = N'" + FilterClass.Text + "')" +
                        " and ID_Hocvien = " + Items[0].SubItems[0].Text;
                    Program.ExecCmd(qry);
                    conn.Close();
                }
            }
        }

        private void Sobuoivang_button_Click(object sender, EventArgs e)
        {
            UpdateHocvien(Int32.Parse(Sobuoivang_input.Value.ToString()), -1);
            Load_StudentList(FilterCourses.Text,FilterClass.Text);
        }

        private void Diemthi_button_Click(object sender, EventArgs e)
        {
            UpdateHocvien(-1, float.Parse(Diemthi_input.Text));
            Load_StudentList(FilterCourses.Text, FilterClass.Text);
        }

        private void Teacher_Students_Load(object sender, EventArgs e)
        {

        }
    }
}
