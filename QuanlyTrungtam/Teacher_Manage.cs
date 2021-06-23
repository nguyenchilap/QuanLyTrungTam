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
    public partial class Teacher_Manage : Form
    {
        public Teacher_Manage()
        {
            InitializeComponent();
        }

        private void Load_Class(string tenKhoa)
        {
            ClassView.Items.Clear();
            using(SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from LopHoc A JOIN KhoaDaoTao B ON A.ID_Khoa = B.ID_Khoa " +
                                                   " JOIN DS_MonHoc C ON C.ID_Monhoc = A.ID_Monhoc " +
                                                   " JOIN NhanVien D ON D.ID_NV = A.ID_GV " +
                              "Where B.Ten_Khoa = N'" + tenKhoa + "'" ;
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Ten_Khoa"].ToString());
                    item.SubItems.Add(reader["Ten_Monhoc"].ToString());
                    if (Int32.Parse(reader["ID_NV"].ToString()) == 0)
                        item.SubItems.Add("Chưa phân");
                    else 
                        item.SubItems.Add(reader["ID_NV"].ToString());
                    ClassView.Items.Add(item);
                }
                conn.Close();
            }
        }
        private void Load_GV(string chuyenmon)
        {
            EmployeeView.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from NhanVien A join GiaoVien B ON A.ID_NV = B.ID_NV where A.ID_NV > 0 ";
                if (!string.IsNullOrEmpty(chuyenmon) && chuyenmon != "Tất cả")
                {
                    qry += " and B.Chuyenmon = N'" + chuyenmon + "'";
                }
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_NV"].ToString());
                    item.SubItems.Add(reader["Ten_NV"].ToString());
                    item.SubItems.Add(reader["Email"].ToString());
                    item.SubItems.Add(reader["SDT"].ToString());
                    item.SubItems.Add(reader["Chuyenmon"].ToString());
                    EmployeeView.Items.Add(item);
                }
                conn.Close();
            }
        }

        private void Init_Course(int Month, int Year)
        {
            FilterCourse.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select Ten_Khoa From KhoaDaoTao Where ID_Khoa > 0 ";

                if (Month != 0) qry += " and Month(NgayBatdau) = " + Month.ToString();
                if (Year != 0) qry += " and Year(NgayBatdau) = " + Year.ToString();

                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    FilterCourse.Items.Add(reader["Ten_Khoa"].ToString());
                }
                conn.Close();
            }
        }
        private void Init_Major()
        {
            MajorText.Items.Clear();
            MajorText.Items.Add("Tất cả");
            using(SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select distinct Chuyenmon from GiaoVien where ID_NV > 0";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["Chuyenmon"].ToString()))
                    {
                        MajorText.Items.Add(reader["Chuyenmon"].ToString());
                    }
                }
                conn.Close();
            }
        }
        private void Teacher_Manage_Load(object sender, EventArgs e)
        {
            Init_Major();
            Load_GV(null);
        }

        private void Detail_button_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = EmployeeView.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Select Employee!!");
            else if (string.IsNullOrEmpty(MajorText.Text)) MessageBox.Show("Select or type new Major!!!");
            else if (MajorText.Text == "Tất cả") MessageBox.Show("invalid Major!!!");
            else
            {
                DialogResult res = MessageBox.Show("Are you sure to add this Major to these Employees ?!?", "Add Major", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    foreach (ListViewItem item in Items)
                    {
                        string qry = "UPDATE GiaoVien Set Chuyenmon = N'" + MajorText.Text + "' Where ID_NV = " + item.SubItems[0].Text;
                        Program.ExecCmd(qry);
                    }
                }
                Load_GV(null);
                Init_Major();
            }
        }

        private void GrantButton_Click(object sender, EventArgs e)
        {

        }
        private void Filter_button_Click(object sender, EventArgs e)
        {
            if (MajorText.Text == "Tất cả")
                Load_GV(null);
            else Load_GV(MajorText.Text);
        }
        private void Reload_Click(object sender, EventArgs e)
        {
            Init_Major();
            Load_GV(null);
        }

        private void MajorText_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Menu temp = new Teacher_Menu();
            temp.ShowDialog();
            this.Close();
        }

        private void GrantButton_Click_1(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection GV = EmployeeView.CheckedItems;
            ListView.CheckedListViewItemCollection Class = ClassView.CheckedItems;
            if (GV.Count > 1) MessageBox.Show("Select just 1 Teacher !!!");
            else if (GV.Count > 0 && Class.Count > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure to continue ??!", "Grant Teacher to Class(es)", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    foreach (ListViewItem item in Class)
                    {
                        string qry = "Update LopHoc Set ID_GV = " + GV[0].SubItems[0].Text 
                                + "Where ID_Khoa = (Select ID_Khoa from KhoaDaoTao where Ten_Khoa = N'" + item.SubItems[0].Text +"')"
                                + " and ID_Monhoc = (Select ID_Monhoc from DS_MonHoc where Ten_Monhoc = N'" + item.SubItems[1].Text + "')";
                        Program.ExecCmd(qry);
                    }
                    Load_Class(FilterCourse.Text);
                    Load_GV(MajorText.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MajorText.Text != "Tất cả")
            {
                Load_GV(MajorText.Text);
            }
            else Load_GV(null);
        }

        private void FilterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterYear.Text))
                Init_Course(Int32.Parse(FilterMonth.Text), 0);
            else
                Init_Course(Int32.Parse(FilterMonth.Text), Int32.Parse(FilterYear.Text));
            FilterCourse.Text = "";
        }

        private void FilterYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterMonth.Text))
                Init_Course(0, Int32.Parse(FilterYear.Text));
            else
                Init_Course(Int32.Parse(FilterMonth.Text), Int32.Parse(FilterYear.Text));
            FilterCourse.Text = "";
        }

        private void FilterCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Class(FilterCourse.SelectedItem.ToString());
        }
    }
}
