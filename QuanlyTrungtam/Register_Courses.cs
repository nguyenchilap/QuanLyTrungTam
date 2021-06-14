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
    public partial class Register_Courses : Form
    {
        public Register_Courses()
        {
            InitializeComponent();
        }

        int CurCourse_ID = 0;
        string CurCourse_Name = "";
        private void Guess_Load(object sender, EventArgs e)
        {
            if (Signin.ID == 0)
            {
                Back.Text = "Exit";
                AssignCourse.BackColor = Color.Gray;
                AssignCourse.FlatAppearance.BorderColor = Color.DimGray;
            }
            else
            {
                BUTTON.Text = "Your Assignment";
                Cur_UserID.Text = Signin.ID.ToString();
            }

            Edu_Form.Text = "Loại hình đào tạo";
            LoadCoursesListView();
            Edu_Form_LoadIndex();
            Init_ListSubGr();
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
                string qry = "Select kdt.ID_Khoa, kdt.Ten_Khoa, lhdt.Ten_Loai as LoaiHinhDaoTao, kdt.NgayBatdau, kdt.Soluong" +
                    " from KhoaDaoTao kdt join LoaiHinhDaoTao lhdt ON kdt.LoaiHinhDaoTao = lhdt.ID_Loai ";
                if (Edu_Form.Text == "Loại hình đào tạo" || Edu_Form.Text == "Tất cả")
                    qry += "where kdt.ID_Khoa > 0";
                else qry += "where lhdt.Ten_Loai = N'" + Edu_Form.Text + "'";

                qry += " and YEAR(kdt.NgayBatdau) = " + DateTime.Now.Year.ToString();

                SqlCommand cmd = new SqlCommand(qry, conn);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Khoa"].ToString());
                    item.SubItems.Add(reader["Ten_Khoa"].ToString());
                    item.SubItems.Add(reader["LoaiHinhDaoTao"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NgayBatdau"]).ToString("MM/dd/yyyy"));

                    string startDayInput = Convert.ToDateTime(reader["NgayBatdau"]).ToString("yyyy/MM/dd");
                    string idkhoahoc = reader["ID_Khoa"].ToString();

                    //Tinh so luong da dang ki hien tai
                    using (SqlConnection con = new SqlConnection(ConnectionString.connect))
                    {
                        con.Open();
                        SqlCommand Soluong = new SqlCommand("KhoaHoc_Dangki", con);
                        Soluong.Parameters.AddWithValue("@idKhoahoc", Int32.Parse(idkhoahoc));
                        Soluong.CommandType = CommandType.StoredProcedure;
                        SqlParameter res = new SqlParameter("@returnvalue", SqlDbType.Int);
                        res.Direction = ParameterDirection.ReturnValue;
                        Soluong.Parameters.Add(res);
                        Soluong.ExecuteNonQuery();
                        object Currentnum = Soluong.Parameters["@returnvalue"].Value;

                        item.SubItems.Add(Currentnum.ToString() + "/" + reader["Soluong"].ToString());
                        con.Close();
                    } 
                    
                    Courses_View.Items.Add(item);
                }
                watch.Stop();
                conn.Close();
            }
        }
        private void Init_ListSubGr()
        {
            List_SubGr.BeginUpdate();
            List_SubGr.Nodes.Add("HocPhan", "Học phần");
            List_SubGr.Nodes.Add("NhanhHoc", "Nhánh học");
            List_SubGr.Nodes.Add("NhomChuyende", "Nhóm Chuyên đề");
            List_SubGr.Nodes.Add("MonHoc", "Môn học");
            List_SubGr.EndUpdate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (BUTTON.Text == "Sign in")
            {
                this.Hide();
                Signin temp = new Signin();
                temp.ShowDialog();
                this.Close();
            }
            else
            {

            }
        }

        private void Courses_Reload_Click(object sender, EventArgs e)
        {
            LoadCoursesListView();
            Edu_Form_LoadIndex();
            Rule_Text.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
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
                        string qry1 = "Select mh.Ten_Monhoc from KhoaDaoTao kh join LopHoc lh ON kh.ID_Khoa = lh.ID_Khoa" +
                                                                    " join DS_Monhoc mh ON mh.ID_Monhoc = lh.ID_Monhoc " +
                                                                    " where kh.ID_Khoa = " + item.SubItems[0].Text;
                        SqlCommand cmd1 = new SqlCommand(qry1, conn);

                        var watch1 = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader1 = cmd1.ExecuteReader();

                        while (reader1.Read())
                        {
                            List_SubGr.Nodes[check].Nodes.Add(reader1["Ten_Monhoc"].ToString());
                        }

                        List_SubGr.Nodes[check].ExpandAll();
                        watch1.Stop();
                        conn.Close();
                    }
                    CurCourse_ID = Int32.Parse(item.SubItems[0].Text);
                    CurCourse_Name = item.SubItems[1].Text;
                    IDCur_Course.Text = CurCourse_ID.ToString();
                    NameCur_Course.Text = CurCourse_Name;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (Back.Text == "Exit")
            {
                this.Hide();
                this.Close();
            }
            else
            {
                this.Hide();
                Student_Menu temp = new Student_Menu();
                temp.ShowDialog();
                this.Close();
            }
        }

        private void Edu_Form_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCoursesListView();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = Courses_View.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Select Course you wanna see!!");
            else if (Items.Count > 1) MessageBox.Show("Select just 1 Course!!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry = "Select A.Quytac from LoaiHinhDaoTao A join KhoaDaoTao B on A.ID_Loai = B.LoaiHinhDaoTao " +
                            "where B.ID_Khoa = " + item.SubItems[0].Text;
                        SqlCommand cmd = new SqlCommand(qry, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Rule_Text.Text = reader["Quytac"].ToString();
                        }
                        
                        conn.Close();
                    }
                }
            }
        }

        private void AssignCourse_Click(object sender, EventArgs e)
        {

        }

        private void View_Details_Class_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from LopHoc A join NhanVien B ON ID_GV = ID_NV where A.ID_Khoa = " + CurCourse_ID.ToString();
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string text = " Giáo viên : " + reader["ID_GV"].ToString() + " - " + reader["Ten_NV"].ToString();
                    text += "\n SĐT : " + reader["SDT"].ToString() + "\n Email : " + reader["Email"].ToString();
                }
                conn.Close();
            }
        }

        private void IDCur_Course_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
