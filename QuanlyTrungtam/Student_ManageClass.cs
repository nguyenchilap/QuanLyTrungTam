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
    public partial class Student_ManageClass : Form
    {
        public Student_ManageClass()
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
        private void LoadCoursesListView()
        {

            Courses_View.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select kdt.ID_Khoa, kdt.Ten_Khoa, lhdt.Ten_Loai as LoaiHinhDaoTao, kdt.NgayBatdau, dk.Totnghiep" +
                    " from KhoaDaoTao kdt join LoaiHinhDaoTao lhdt ON kdt.LoaiHinhDaoTao = lhdt.ID_Loai " +
                                         "join DangKi dk ON dk.ID_Khoa = kdt.ID_Khoa ";
                if (Edu_Form.Text == "Loại hình đào tạo" || Edu_Form.Text == "Tất cả")
                    qry += "where dk.ID_Hocvien = " + Signin.ID.ToString();
                else qry += "where lhdt.Ten_Loai = N'" + Edu_Form.Text + "' and dk.ID_Hocvien = " + Signin.ID.ToString();

                SqlCommand cmd = new SqlCommand(qry, conn);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Khoa"].ToString());
                    item.SubItems.Add(reader["Ten_Khoa"].ToString());
                    item.SubItems.Add(reader["LoaiHinhDaoTao"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NgayBatdau"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(reader["Totnghiep"].ToString());
                    Courses_View.Items.Add(item);
                }
                watch.Stop();
                conn.Close();
            }
        }
        private void Init_ListSubGr()
        {
            List_SubGr.Nodes.Clear();
            List_SubGr.BeginUpdate();
            List_SubGr.Nodes.Add("HocPhan", "Học phần");
            List_SubGr.Nodes.Add("NhanhHoc", "Nhánh học");
            List_SubGr.Nodes.Add("Chuyende", "Chuyên đề");
            List_SubGr.Nodes.Add("MonHoc", "Môn học");
            List_SubGr.EndUpdate();
        }
        private void ViewDetail_button_Click(object sender, EventArgs e)
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
                        " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'");
                    qry.Add("Select * from Chungchi_Nhanhhoc A join LoaiHinhDaoTao B on A.ID_Loai = B.ID_Loai" +
                        " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'");
                    qry.Add("Select * from LopChuyende A join LoaiHinhDaoTao B on A.ID_Loai = B.ID_Loai" +
                        " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'");
                    qry.Add("Select * from Chungchi_Monhoc A join LoaiHinhDaoTao B on A.ID_Loai = B.ID_Loai" +
                        " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'");
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
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
                        if (check == 1) //Nhanh hoc
                            qry1 = "Select C.Ten_Nhanh as Ten from Chungchi_Nhanhhoc A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_Nhanhhoc C ON C.ID_Nhanh = A.ID_Nhanh" +
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
                        if (check == 2) //chuyen de
                            qry1 = "Select D.Ten_Monhoc as Ten from LopChuyende A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join Chitiet_NhomCD C ON C.ID_Nhom = A.ID_Nhom " +
                                                                        "join DS_MonHoc D ON D.ID_Monhoc = C.ID_Chuyende " +
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
                        if (check == 3) //Monhoc
                            qry1 = "Select C.Ten_Monhoc as Ten from Chungchi_Monhoc A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_MonHoc C ON C.ID_Monhoc = A.ID_Monhoc" +
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
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
                    IDCur_Course.Text = item.SubItems[0].Text;
                    NameCur_Course.Text = item.SubItems[1].Text;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Menu temp = new Student_Menu();
            temp.ShowDialog();
            this.Close();
        }

        private void List_SubGr_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Student_ManageClass_Load(object sender, EventArgs e)
        {
            Edu_Form.Text = "Loại hình đào tạo";

            Thilai.Hide();
            Thilai_title.Hide();
            comp.Hide();

            Edu_Form_LoadIndex();
            LoadCoursesListView();
            Init_ListSubGr();
        }

        private void Edu_Form_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCoursesListView();
        }

        private void ResetInfo()
        {
            Name_CurClass.Text = "_____________________";
            Name_CurTeacher.Text = "__________________";
            text.Text = "00";
            Contact_CurTeacher.Text = "___________________";
            DiemThi_Title.Text = "Điểm thi :";
            DiemThi.Text = "000";
            Thilai.Hide();
            Thilai_title.Hide();
            comp.Hide();
        }
        private void Detail_button_Click(object sender, EventArgs e)
        {
            ResetInfo();
            if (string.IsNullOrEmpty(List_SubGr.SelectedNode.Text)) MessageBox.Show("Select Class you wanna see!!!");
            else
            {
                if (List_SubGr.SelectedNode.Level == 2 || List_SubGr.SelectedNode.Parent.Name == "MonHoc" || List_SubGr.SelectedNode.Parent.Name == "Chuyende")
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry = " Select * from LopHoc A join DSLopHoc B ON A.ID_Khoa = B.ID_Khoa and A.ID_Monhoc = B.ID_Monhoc "
                                                            + "join NhanVien C ON C.ID_NV = A.ID_GV join DS_Monhoc D ON D.ID_Monhoc = A.ID_Monhoc "
                                             + " where A.ID_Khoa = " + IDCur_Course.Text + " and D.Ten_Monhoc = N'" + List_SubGr.SelectedNode.Text + "' "
                                             + " and B.ID_Hocvien = " + Signin.ID;
                        //MessageBox.Show(qry);
                        SqlCommand cmd = new SqlCommand(qry, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Name_CurClass.Text = reader["Ten_Monhoc"].ToString();
                            text.Text = reader["Sobuoivang"].ToString();
                            Name_CurTeacher.Text = reader["Ten_NV"].ToString();
                            Contact_CurTeacher.Text = reader["SDT"].ToString() + " / " + reader["Email"].ToString();
                            DiemThi.Text = reader["Diemthi"].ToString();
                        }

                        conn.Close();
                    }
                }
                else if (List_SubGr.SelectedNode.Parent.Name == "HocPhan")
                {
                    DiemThi_Title.Text = "Điểm trung bình :";
                    Thilai.Show();
                    Thilai_title.Show();
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry = "Select Sum(C.DiemThi) as Tongdiem, Count(B.ID_Monhoc) as Soluong" +
                                             " from DS_HocPhan A join Chitiet_Hocphan B ON A.ID_Hocphan = B.ID_Hocphan "
                                                            + " join DSLopHoc C ON C.ID_Monhoc = B.ID_Monhoc "
                                                            + " where C.ID_Hocvien = " + Signin.ID.ToString() + " and A.Ten_Hocphan = N'" + List_SubGr.SelectedNode.Text +"'";
                        //MessageBox.Show(qry);
                        SqlCommand cmd = new SqlCommand(qry, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while(reader.Read())
                        {
                            DiemThi.Text = (float.Parse(reader["Tongdiem"].ToString()) / Int32.Parse(reader["Soluong"].ToString())).ToString();
                            //Thilai.Text = reader["Solanthilai"].ToString();
                        }
                        conn.Close();
                    }
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry = "Select * from KetquaHocphan A join DS_HocPhan B ON A.ID_Hocphan = B.ID_Hocphan and " +
                            "ID_Hocvien = " + Signin.ID.ToString() + " and ID_Khoa = " + IDCur_Course.Text;
                        SqlCommand cmd = new SqlCommand(qry, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Thilai.Text = reader["Solanthilai"].ToString();
                            if (reader["Hoanthanh"].ToString() == "1")
                                comp.Show();
                        }
                        conn.Close();
                    }
                }
            }
        }

        private void Courses_Reload_Click(object sender, EventArgs e)
        {
            ResetInfo();
            LoadCoursesListView();
            Init_ListSubGr();
        }
    }
}
