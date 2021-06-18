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
    public partial class StudentManager_Classes : Form
    {
        public StudentManager_Classes()
        {
            InitializeComponent();
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
        private string HocPhi_KhoaHoc(string Ten_Khoa)
        {
            string res = "";
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                
                conn.Close();
            }
            return res;
        }

        private void LoadCoursesListView(int Year, int Month)
        {
            Courses_View.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select kdt.ID_Khoa, kdt.Ten_Khoa, lhdt.Ten_Loai as LoaiHinhDaoTao, kdt.NgayBatdau, kdt.Soluong" +
                    " from KhoaDaoTao kdt join LoaiHinhDaoTao lhdt ON kdt.LoaiHinhDaoTao = lhdt.ID_Loai ";
                if (Edu_Form.Text == "Loại hình đào tạo" || Edu_Form.Text == "Tất cả")
                    qry += "where kdt.ID_Khoa > 0";
                else qry += "where lhdt.Ten_Loai = N'" + Edu_Form.Text + "'";
                
                if (Year > 0) qry += " and Year(NgayBatdau) = " + Year.ToString();
                if (Month > 0) qry += " and Month(NgayBatdau) = " + Month.ToString();

                SqlCommand cmd = new SqlCommand(qry, conn);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Khoa"].ToString());
                    item.SubItems.Add(reader["Ten_Khoa"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NgayBatdau"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(reader["LoaiHinhDaoTao"].ToString());

                    Courses_View.Items.Add(item);
                }
                watch.Stop();
                conn.Close();
            }
        }

        private void Init_ListSubGr()
        {
            List_SubGr.BeginUpdate();
            List_SubGr.Nodes.Add("HocPhan","Học phần");
            List_SubGr.Nodes.Add("NhanhHoc","Nhánh học");
            List_SubGr.Nodes.Add("NhomChuyende","Nhóm Chuyên đề");
            List_SubGr.Nodes.Add("MonHoc", "Môn học");
            List_SubGr.EndUpdate();
        }

        private void AddChild_ListSubGr()
        {

        }
        private void Manager_Classes_Load(object sender, EventArgs e)
        {
            Edu_Form.Text = "Loại hình đào tạo";
            LoadCoursesListView(0,0);
            Edu_Form_LoadIndex();
            Init_ListSubGr();
        }

        private void ViewClassList_Click(object sender, EventArgs e)
        {
            List_SubGr.Nodes.Clear();
            Init_ListSubGr();
            ListView.CheckedListViewItemCollection Items = Courses_View.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Select Course !!");
            else if (Items.Count > 1) MessageBox.Show("Select just 1 Course !!!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    var qry = new List<string>();
                    int check = -1;


                    qry.Add("Select * from Chungchi_Hocphan A join LoaiHinhDaoTao B on A.ID_Loai = B.ID_Loai" +
                        " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'");
                    qry.Add("Select * from Chungchi_Nhanhhoc A join LoaiHinhDaoTao B on A.ID_Loai = B.ID_Loai" +
                        " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'");
                    qry.Add("Select * from LopChuyende A join LoaiHinhDaoTao B on A.ID_Loai = B.ID_Loai" +
                        " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'");
                    qry.Add("Select * from Chungchi_Monhoc A join LoaiHinhDaoTao B on A.ID_Loai = B.ID_Loai" +
                        " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'");
                    for (int i = 0; i < qry.Count; i++)
                    {
                        using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(qry[i], conn);

                            //var watch = System.Diagnostics.Stopwatch.StartNew();
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                check = i;
                                break;
                            }
                            conn.Close();
                        }

                    }
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry1 = "";
                        if (check == 0) //Hoc phan
                            qry1 = "Select C.Ten_Hocphan as Ten from Chungchi_Hocphan A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_HocPhan C ON C.ID_Hocphan = A.ID_Hocphan" +
                                " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'";
                        if (check == 1) //Nhanh hoc
                            qry1 = "Select C.Ten_Nhanh as Ten from Chungchi_Nhanhhoc A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_Nhanhhoc C ON C.ID_Nhanh = A.ID_Nhanh" +
                                " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'";
                        if (check == 2) //Nhom chuyen de
                            qry1 = "Select D.Ten_Monhoc as Ten from LopChuyende A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join Chitiet_NhomCD C ON C.ID_Nhom = A.ID_Nhom " +
                                                                        "join DS_MonHoc D ON D.ID_Monhoc = C.ID_Chuyende " +
                                " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'";
                        if (check == 3) //Monhoc
                            qry1 = "Select C.Ten_Monhoc as Ten from Chungchi_Monhoc A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_MonHoc C ON C.ID_Monhoc = A.ID_Monhoc" +
                                " where B.Ten_Loai = N'" + item.SubItems[3].Text + "'";
                        SqlCommand cmd1 = new SqlCommand(qry1, conn);

                        var watch1 = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        while (reader1.Read())
                        {
                            List_SubGr.Nodes[check].Nodes.Add(reader1["Ten"].ToString());
                        }

                        List_SubGr.Nodes[check].ExpandAll();
                        watch1.Stop();
                        conn.Close();
                    }
                    int count = 0;
                    if (check == 0 || check == 1)
                    {
                        while (count <= (List_SubGr.Nodes[check].GetNodeCount(false) - 1))
                        {
                            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                            {
                                conn.Open();
                                string qry1 = "";
                                if (check == 0)
                                    qry1 = "Select C.Ten_Monhoc as Ten from Chitiet_Hocphan A join DS_HocPhan B on A.ID_Hocphan = B.ID_Hocphan " +
                                                                             "join DS_MonHoc C on C.ID_Monhoc = A.ID_Monhoc " +
                                                                             "where B.Ten_Hocphan = N'" + List_SubGr.Nodes[check].Nodes[count].Text + "'";
                                if (check == 1)
                                    qry1 = "Select C.Ten_Monhoc as Ten from Chitiet_Nhanhhoc A join DS_NhanhHoc B on A.ID_Nhanh = B.ID_Nhanh " +
                                                                             "join DS_MonHoc C on C.ID_Monhoc = A.ID_Monhoc " +
                                                                             "where B.Ten_Nhanh = N'" + List_SubGr.Nodes[check].Nodes[count].Text + "'";
                                SqlCommand cmd1 = new SqlCommand(qry1, conn);
                                SqlDataReader reader1 = cmd1.ExecuteReader();

                                while (reader1.Read())
                                {
                                    List_SubGr.Nodes[check].Nodes[count].Nodes.Add(reader1["Ten"].ToString());
                                }

                                List_SubGr.Nodes[check].Nodes[count].ExpandAll();

                                count++;
                                conn.Close();
                            }
                        }
                    }
                    CurCourse_ID.Text = item.SubItems[0].Text;
                    CurCourse_Name.Text = item.SubItems[1].Text;
                }
            }
        }

        private void Edu_Form_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCoursesListView(0, 0);
        }

        private void ViewStudentList_Click(object sender, EventArgs e)
        {
            //if (List_SubGr.SelectedNode.Level)
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select A.ID_Monhoc, C.ID_Hocvien, C.Ten_Hocvien, A.Diemthi " +
                                "from DSLopHoc A join DS_Monhoc B ON A.ID_Monhoc = B.ID_Monhoc " +
                                                "join HocVien C ON A.ID_Hocvien = C.ID_Hocvien " +
                                " where A.ID_Khoa = " + CurCourse_ID.Text 
                              + " and B.Ten_Monhoc = N'" + List_SubGr.SelectedNode.Text +"'";
                //MessageBox.Show(qry);
                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Hocvien"].ToString());
                    item.SubItems.Add(reader["Ten_Hocvien"].ToString());
                    item.SubItems.Add(reader["Diemthi"].ToString());
                    StudentView.Items.Add(item);

                    CurSub_ID.Text = reader["ID_Monhoc"].ToString();
                    CurSub_Name.Text = List_SubGr.SelectedNode.Text;
                }
                 
                watch.Stop();
                conn.Close();
            }
        }

        private void YearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterMonth.Text == "")
                LoadCoursesListView(Int32.Parse(YearFilter.Text), 0);
            else
                LoadCoursesListView(Int32.Parse(YearFilter.Text), Int32.Parse(FilterMonth.Text));
        }

        private void FilterMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearFilter.Text == "")
                LoadCoursesListView(0, Int32.Parse(FilterMonth.Text));
            else
                LoadCoursesListView(Int32.Parse(YearFilter.Text), Int32.Parse(FilterMonth.Text));
        }

        private void Courses_Reload_Click(object sender, EventArgs e)
        {
            YearFilter.Text = "";
            FilterMonth.Text = "";
            Edu_Form_LoadIndex();
            LoadCoursesListView(0, 0);
        }

        private void List_SubGr_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManager_Menu temp = new StudentManager_Menu();
            temp.ShowDialog();
            this.Close();
        }
    }
}
