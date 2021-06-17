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
                label4.Hide();
                Cur_UserID.Hide();
                Back.Text = "Exit";
                AssignCourse.BackColor = Color.Gray;
                AssignCourse.FlatAppearance.BorderColor = Color.DimGray;
            }
            else
            {
                BUTTON.Text = "Your Registering>";
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
            Rule_Text.Text = "";
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
                this.Hide();
                Student_ManageClass temp = new Student_ManageClass();
                temp.ShowDialog();
                this.Close();
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
                        string qry1 = "";
                        if (check == 0) //Hoc phan
                            qry1 = "Select C.Ten_Hocphan as Ten from Chungchi_Hocphan A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_HocPhan C ON C.ID_Hocphan = A.ID_Hocphan" +
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
                        if (check == 1) //Nhanh hoc
                            qry1 = "Select C.Ten_Nhanh as Ten from Chungchi_Nhanhhoc A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_Nhanhhoc C ON C.ID_Nhanh = A.ID_Nhanh" +
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
                        if (check == 2) //Nhom chuyen de
                            qry1 = "Select D.Ten_Monhoc as Ten from LopChuyende A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join Chitiet_NhomCD C ON C.ID_Nhom = A.ID_Nhom " +
                                                                        "join DS_MonHoc D ON D.ID_Monhoc = C.ID_Chuyende " +
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
                        if (check == 3) //Monhoc
                            qry1 = "Select C.Ten_Monhoc as Ten from Chungchi_Monhoc A join LoaiHinhDaoTao B ON A.ID_Loai = B.ID_Loai " +
                                                                        "join DS_MonHoc C ON C.ID_Monhoc = A.ID_Monhoc" +
                                " where B.Ten_Loai = N'" + item.SubItems[2].Text + "'";
                        SqlCommand cmd1 = new SqlCommand(qry1, conn);

                        //MessageBox.Show(check.ToString());
                        //MessageBox.Show(qry1);
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
        
        private int NodeLevel(TreeNode node)
        {
            int level = 0;
            while ((node = node.Parent) != null) level++;
            return level;
        }
        private void AssignCourse_Click(object sender, EventArgs e)
        {
            if (AssignCourse.BackColor == Color.Gray)
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Sign in first !! Redirect to Sign in screen ?", "Register", button);
                if (res == DialogResult.Yes)
                {
                    this.Hide();
                    Signin temp = new Signin();
                    temp.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                ListView.CheckedListViewItemCollection Items = Courses_View.CheckedItems;
                if (Items.Count <= 0) MessageBox.Show("Select Course you wanna Register!!!");
                else if (Items.Count > 1) MessageBox.Show("Select just 1 Course !!");
                else
                {
                    int check_Nhanhhoc = 0;
                    foreach (ListViewItem item in Items)
                    {
                        using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                        {
                            conn.Open();
                            string qry1 = "Select A.LoaiHinhDaoTao from KhoaDaoTao A join Chungchi_Nhanhhoc B ON A.LoaiHinhDaoTao = B.ID_Loai where " +
                                                                                " A.ID_Khoa = " + item.SubItems[0].Text;
                            SqlCommand cmd1 = new SqlCommand(qry1, conn);
                            SqlDataReader reader = cmd1.ExecuteReader();

                            if (reader.Read())
                            {
                                check_Nhanhhoc = 1;
                            }
                            conn.Close();
                        }
                        string qry = "Insert into DonDangKi values (" + Signin.ID.ToString() + ", " + item.SubItems[0].Text
                            + ", 0 , N'')";
                        if (check_Nhanhhoc == 1)
                        {
                            if (List_SubGr.SelectedNode == null)
                                MessageBox.Show(" Please Select 1 item !!");
                            else if (List_SubGr.SelectedNode.Level != 1)
                            {
                                MessageBox.Show(" Please Select Branch of Learning !!!");
                            }
                            else
                            {
                                qry += "\n Insert into Dangky_Nhanhhoc values ("
                                    + "(Select ID_Loai from LoaiHinhDaoTao where Ten_Loai = N'" + item.SubItems[2].Text + "')"
                                    + ", (Select ID_Nhanh from DS_NhanhHoc where Ten_Nhanh = N'" + List_SubGr.SelectedNode.Text + "')"
                                    + ", " + Signin.ID.ToString() + ", " + item.SubItems[0].Text + ")";
                                MessageBox.Show(qry);
                                Program.ExecCmd(qry);
                            }
                        }
                        else
                        {
                            Program.ExecCmd(qry);
                        }
                    }
                }
            }
        }

        private void View_Details_Class_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(List_SubGr.SelectedNode.Level.ToString());
            using(SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from LopHoc A join NhanVien B ON ID_GV = ID_NV where A.ID_Khoa = " + CurCourse_ID.ToString();
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                string nametext = "";
                string contacttext = "";
                if (reader.Read())
                {
                    nametext = " Giáo viên : " + reader["ID_GV"].ToString() + "   -      " + reader["Ten_NV"].ToString();
                    contacttext += " SĐT : " + reader["SDT"].ToString() + " -    Email : " + reader["Email"].ToString();
                }
                Name_teacher.Text = nametext;
                Contact_teacher.Text = contacttext;
                conn.Close();
            }
        }

        private void IDCur_Course_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
