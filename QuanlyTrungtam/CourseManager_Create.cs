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
    public partial class CourseManager_Create : Form
    {
        int type_sub = 0; //trạng thái : 0 - môn học, 1 - chuyên đề
        int type_gr = 0;
        int ID_Current_Detail = 0;
        public CourseManager_Create()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            SubjectName_text.Text = "";
            Fee_text.Value = 0;
            Description_text.Text = "";
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
                    //Hien thi trang thai 
                    using (SqlConnection con = new SqlConnection(ConnectionString.connect))
                    {
                        con.Open();
                        SqlCommand Trangthai = new SqlCommand("KhoaHoc_Trangthai", con);
                        Trangthai.CommandType = CommandType.StoredProcedure;
                        SqlParameter res1 = new SqlParameter("@returnvalue", SqlDbType.Int);
                        res1.Direction = ParameterDirection.ReturnValue;

                        Trangthai.Parameters.AddWithValue("@current", DateTime.Now.ToString("yyyy/MM/dd"));
                        Trangthai.Parameters.AddWithValue("@begin", startDayInput);
                        Trangthai.Parameters.AddWithValue("@idKhoahoc", Int32.Parse(idkhoahoc));
                        Trangthai.Parameters.Add(res1);
                        Trangthai.ExecuteNonQuery();
                        object status = Trangthai.Parameters["@returnvalue"].Value;

                        item.SubItems.Add(status.ToString());
                        con.Close();
                    }
                    Courses_View.Items.Add(item);
                }
                watch.Stop();
                conn.Close();
            }
        }

        private void LoadGroup() //0 la Hoc phan, 1 la Nhanh hoc, 2 la chuyen de
        {

            Group_list.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                string qry = "";
                conn.Open();
                //Load Group script
                if (type_gr == 0)
                    qry = "Select * from dbo.DS_HocPhan where ID_Hocphan > 0";
                else if (type_gr == 1)
                    qry = "Select * from dbo.DS_NhanhHoc where ID_Nhanh > 0";
                else if (type_gr == 2)
                    qry = "Select * from dbo.Nhom_Chuyende where ID_Nhom > 0";

                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (type_gr == 0)
                    {
                        ListViewItem item = new ListViewItem(reader["ID_Hocphan"].ToString());
                        item.SubItems.Add(reader["Ten_Hocphan"].ToString());
                        item.SubItems.Add(reader["Hocphi"].ToString() + " VND");
                        Group_list.Items.Add(item);
                    }
                    else if (type_gr == 1)
                    {
                        ListViewItem item = new ListViewItem(reader["ID_Nhanh"].ToString());
                        item.SubItems.Add(reader["Ten_Nhanh"].ToString());
                        item.SubItems.Add(reader["Hocphi"].ToString() + " VND");
                        Group_list.Items.Add(item);
                    }
                    else if (type_gr == 2)
                    {
                        ListViewItem item = new ListViewItem(reader["ID_Nhom"].ToString());
                        item.SubItems.Add(reader["Ten_Nhom"].ToString());
                        item.SubItems.Add(reader["Hocphi"].ToString() + " VND");
                        Group_list.Items.Add(item);
                    }
                }
                watch.Stop();
                conn.Close();
            }
        }
        private void LoadSubject() //0 la mon hoc, 1 la chuyen de
        {
            Subject_list.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                string qry = "Select * from dbo.DS_MonHoc where ID_Monhoc > 0 and";
                conn.Open();
                //Load Subject
                if (type_sub == 0) //0 la monhoc
                    qry += " Loai = 0";
                else if (type_sub == 1) //1 la chuyende
                    qry += " Loai = 1";

                SqlCommand cmd = new SqlCommand(qry,conn);
                //cmd1.CommandType = CommandType.StoredProcedure;

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                        ListViewItem item = new ListViewItem(reader["ID_Monhoc"].ToString());
                        item.SubItems.Add(reader["Ten_Monhoc"].ToString());
                        item.SubItems.Add(reader["Mota"].ToString());
                        item.SubItems.Add(reader["Hocphi"].ToString() + " VND");
                        Subject_list.Items.Add(item);
                }
                watch.Stop();
                conn.Close();
            }
        }
        private bool checkBlank()
        {

            if (string.IsNullOrEmpty(SubjectName_text.Text))
            {
                MessageBox.Show("Please Enter Subject's Name !!!");
                return false;
            }
            if (Fee_text.Value == 0)
            {
                MessageBox.Show("Please Enter Tuition Fee !!!");
                return false;
            }
            if (string.IsNullOrEmpty(Type_text.Text))
            {
                MessageBox.Show("Which type of this subject ?!");
                return false;
            }
            return true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (checkBlank())
            {
                string qry = "Insert into dbo.DS_MonHoc values (" +
                        "(Select Max(ID_Monhoc) from DS_MonHoc) + 1, N'" +
                        SubjectName_text.Text + "',N'" + Description_text.Text + "'," + Fee_text.Text;
                    if (Type_text.Text == "Môn học")
                    {
                        qry +=  ", 0)";
                        Program.ExecCmd(qry);
                    }
                    else if (Type_text.Text == "Chuyên đề")
                    {
                        qry += ", 1)";
                        Program.ExecCmd(qry);
                    }
                LoadSubject();
                Reset();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManager_Menu menu = new CourseManager_Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Details.Items.Clear();
            Name_Cur.Text = "";
            ID_Cur.Text = "";
            ListView.CheckedListViewItemCollection Items = Group_list.CheckedItems;
            if (Items.Count <= 0)
                MessageBox.Show("Select Group you wanna see details !!");
            else if (Items.Count > 1)
                MessageBox.Show("Please Select 1 Group you wanna see !!!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    string qry = "";
                    if (type_gr == 0) qry = "Select cthp.ID_Monhoc, dsmh.Ten_Monhoc, cthp.Batbuoc, hp.Ten_Hocphan " +
                                            "from Chitiet_Hocphan cthp inner join DS_MonHoc dsmh ON cthp.ID_Monhoc = dsmh.ID_Monhoc " +
                                            "join DS_HocPhan hp ON hp.ID_Hocphan = cthp.ID_Hocphan " +
                                            "Where hp.ID_Hocphan = " + item.SubItems[0].Text;

                    if (type_gr == 1) qry = "Select ctnh.ID_Monhoc, dsmh.Ten_Monhoc, nh.Ten_Nhanh " +
                                            "from Chitiet_NhanhHoc ctnh inner join DS_MonHoc dsmh ON ctnh.ID_Monhoc = dsmh.ID_Monhoc " +
                                            "join DS_NhanhHoc nh ON nh.ID_Nhanh = ctnh.ID_Nhanh " +
                                            "Where nh.ID_Nhanh = " + item.SubItems[0].Text;

                    if (type_gr == 2) qry = "Select ctncd.ID_Chuyende, dscd.Ten_Monhoc, ncd.Ten_Nhom " +
                                            "from Chitiet_NhomCD ctncd inner join DS_MonHoc dscd ON ctncd.ID_Chuyende = dscd.ID_Monhoc " +
                                            "join Nhom_Chuyende ncd ON ncd.ID_Nhom = ctncd.ID_Nhom " +
                                            "Where ncd.ID_Nhom = " + item.SubItems[0].Text;

                    ID_Current_Detail = Int32.Parse(item.SubItems[0].Text);
                    ID_Cur.Text = ID_Current_Detail.ToString();
                    Name_Cur.Text = item.SubItems[1].Text;
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(qry, conn);

                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader = cmd.ExecuteReader();
                        try
                        {
                            while (reader.Read())
                            {
                                if (type_gr == 0)
                                {
                                    ListViewItem temp = new ListViewItem(reader["ID_Monhoc"].ToString());
                                    temp.SubItems.Add(reader["Ten_Monhoc"].ToString());
                                    temp.SubItems.Add(reader["Batbuoc"].ToString());
                                    Name_Cur.Text = reader["Ten_Hocphan"].ToString();
                                    Details.Items.Add(temp);
                                }
                                else if (type_gr == 1)
                                {
                                    ListViewItem temp = new ListViewItem(reader["ID_Monhoc"].ToString());
                                    temp.SubItems.Add(reader["Ten_Monhoc"].ToString());
                                    Name_Cur.Text = reader["Ten_Nhanh"].ToString();
                                    Details.Items.Add(temp);
                                }
                                else if (type_gr == 2)
                                {
                                    ListViewItem temp = new ListViewItem(reader["ID_Chuyende"].ToString());
                                    Name_Cur.Text = reader["Ten_Nhom"].ToString();
                                    temp.SubItems.Add(reader["Ten_Monhoc"].ToString());
                                    Details.Items.Add(temp);
                                }
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Error !!!" + exc);
                        }
                        watch.Stop();

                        conn.Close();
                    }
                }      
            }
            LoadGroup();    
        }

        private void Drop_button_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = Subject_list.CheckedItems;
            if (Items.Count <= 0)
            {
                MessageBox.Show("Select at least 1 subject you wanna fix !!!");
            }
            else if (Items.Count > 1)
            {
                MessageBox.Show("Please Select only 1 subject !!");
            }
            else if (string.IsNullOrEmpty(Type_text.Text))
                MessageBox.Show("Enter Type of Subject !!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult res = MessageBox.Show("Confirm to drop this Subject ?", "Delete Subject", buttons);
                    if (res == DialogResult.No)
                    {
                        Reset();
                        return;
                    }
                    else
                    {
                        string qry = "";
                        if (true)
                            qry = "DELETE FROM dbo.DS_MonHoc WHERE ID_Monhoc = " + item.SubItems[0].Text;
                        Program.ExecCmd(qry);
                        LoadSubject();
                        Reset();
                    }
                }
            }
        }

        private void Admin_Create_Load(object sender, EventArgs e)
        {
            force.Hide();
            title.Text = "Danh sach mon hoc";
            Edu_Form.Text = "Loại hình đào tạo";

            Group.Items.Add("Danh sách học phần");
            Group.Items.Add("Các nhánh học");
            Group.SelectedIndex = 0;

            type_gr = 0;
            type_sub = 0;
            Type_text.SelectedIndex = 0;
            LoadSubject();
            LoadGroup();
            LoadCoursesListView(0,0);
            Edu_Form_LoadIndex();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSubject();
        }

        private void Fix_button_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = Subject_list.CheckedItems;
            if (Items.Count <= 0)
            {
                MessageBox.Show("Select at least 1 subject you wanna fix !!!");
            }
            else if (Items.Count > 1)
            {
                MessageBox.Show("Please Select only 1 subject !!");
            }
            else if (string.IsNullOrEmpty(Type_text.Text))
                MessageBox.Show("Which type of subject you wanna FIX ?!");
            else if (string.IsNullOrEmpty(SubjectName_text.Text) && Fee_text.Value == 0 && string.IsNullOrEmpty(Description_text.Text))
                MessageBox.Show("Enter new value of the attribute(s) you wanna FIX !!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    string qry = "";
                    if (true)
                    {
                        if (!string.IsNullOrEmpty(SubjectName_text.Text))
                        {
                            qry = "UPDATE DS_MonHoc" +
                                " SET Ten_Monhoc = N'" + SubjectName_text.Text.ToString() +
                                "' WHERE ID_Monhoc = " + item.SubItems[0].Text;

                        }
                        if (!string.IsNullOrEmpty(Description_text.Text))
                        {
                            qry += "\n UPDATE DS_MonHoc" +
                                " SET Mota = N'" + Description_text.Text +
                                "' WHERE ID_Monhoc = " + item.SubItems[0].Text;

                        }
                        if (Fee_text.Value != 0)
                        {
                            qry += "\n UPDATE DS_MonHoc" +
                                " SET Hocphi = " + Int32.Parse(Fee_text.Value.ToString()) +
                                " WHERE ID_Monhoc = " + item.SubItems[0].Text;

                        }
                    }

                    Program.ExecCmd(qry);
                    LoadSubject();
                    Reset();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Item_Sbj = Subject_list.CheckedItems;
            ListView.CheckedListViewItemCollection Item_Gr = Group_list.CheckedItems;
            if (Item_Sbj.Count <= 0)
            {
                MessageBox.Show("Select at least 1 Subject !!!");
            }
            else if (Item_Gr.Count <= 0)
            {
                MessageBox.Show("Select at least 1 Group to add subject !!!");
            }
            else
            {
                string qry = "";
                foreach (ListViewItem item_gr in Item_Gr)
                {
                    foreach (ListViewItem item_sbj in Item_Sbj)
                    {
                        if (type_gr == 0)
                        {
                            qry = "Insert into dbo.Chitiet_Hocphan values (" + item_gr.SubItems[0].Text
                                  + "," + item_sbj.SubItems[0].Text + ",";
                            if (force.Checked == true)
                                qry += "N'Bắt buộc')";
                            else
                                qry += "N'Không bắt buộc')";
                        }
                        else if (type_gr == 1)
                        {
                            qry = "Insert into dbo.Chitiet_NhanhHoc values (" + item_gr.SubItems[0].Text
                                + "," + item_sbj.SubItems[0].Text + ")";
                        }
                        else if (type_gr == 2)
                        {
                            qry = "Insert into dbo.Chitiet_NhomCD values (" + item_gr.SubItems[0].Text
                                + "," + item_sbj.SubItems[0].Text + ")";
                        }
                        Program.ExecCmd(qry);
                    }
                }
            }
            LoadSubject();
            LoadGroup();
        }

        private void Type_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_text.Text == "Môn học")
            {
                Group.Items.Clear();
                Group.Items.Add("Danh sách học phần");
                Group.Items.Add("Các nhánh học");
                Group.SelectedIndex = 0;
                title.Text = "Danh sach mon hoc";
                type_sub = 0;
                LoadSubject();
            }    
            else if (Type_text.Text == "Chuyên đề")
            {
                Group.Items.Clear();
                Group.Items.Add("Các nhóm chuyên đề");
                Group.SelectedIndex = 0;
                title.Text = "danh sach chuyen de";
                type_sub = 1;
                LoadSubject();
            }    
        }

        private void Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Group.Text == "Danh sách học phần")
            {
                Details.Items.Clear();
                force.Show();
                type_gr = 0;
                LoadGroup();
            }
            if (Group.Text == "Các nhánh học")
            {
                Details.Items.Clear();
                force.Hide();
                type_gr = 1;
                LoadGroup();
            }
            if (Group.Text == "Các nhóm chuyên đề")
            {
                Details.Items.Clear();
                force.Hide();
                type_gr = 2;
                LoadGroup();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private bool checkBlank_Gr()
        {
            if (string.IsNullOrEmpty(Group_Name.Text))
            {
                MessageBox.Show("Please Enter Group's Name !!!");
                return false;
            }
            if (string.IsNullOrEmpty(Type_text.Text))
            {
                MessageBox.Show("Which type of this subject ?!");
                return false;
            }
            return true;
        }

        private void ResetGr()
        {
            Group_Name.Text = "";
        }
        private void add_Gr_Click(object sender, EventArgs e)
        {
            if (checkBlank_Gr())
            {
                if (Group_Type.Text == "Học phần")
                {
                    string qry = "Insert into dbo.DS_HocPhan values (" +
                        "(Select Max(ID_Hocphan) from DS_HocPhan) + 1, N'" +
                        Group_Name.Text + "',0)";
                    Program.ExecCmd(qry);
                }
                else if (Group_Type.Text == "Nhánh học")
                {
                    string qry = "Insert into dbo.DS_NhanhHoc values (" +
                        "(Select Max(ID_Nhanh) from DS_NhanhHoc) + 1, N'" +
                        Group_Name.Text + "',0)";
                    Program.ExecCmd(qry);
                }
                else if (Group_Type.Text == "Nhóm chuyên đề")
                {
                    string qry = "Insert into dbo.Nhom_Chuyende values (" +
                        "(Select Max(ID_Nhom) from Nhom_Chuyende) + 1, N'" +
                        Group_Name.Text + "',0)";
                    Program.ExecCmd(qry);
                }
                LoadGroup();
                ResetGr();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadSubject();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadGroup();
        }

        private void Load_Details_List( string qry)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        if (type_gr == 0)
                        {
                            ListViewItem temp = new ListViewItem(reader["ID_Monhoc"].ToString());
                            temp.SubItems.Add(reader["Ten_Monhoc"].ToString());
                            temp.SubItems.Add(reader["Batbuoc"].ToString());

                            Details.Items.Add(temp);
                        }
                        else if (type_gr == 1)
                        {
                            ListViewItem temp = new ListViewItem(reader["ID_Monhoc"].ToString());
                            temp.SubItems.Add(reader["Ten_Monhoc"].ToString());
                            Details.Items.Add(temp);
                        }
                        else if (type_gr == 2)
                        {
                            ListViewItem temp = new ListViewItem(reader["ID_Chuyende"].ToString());
                            temp.SubItems.Add(reader["Ten_Chuyende"].ToString());
                            Details.Items.Add(temp);
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error !!!" + exc);
                }
                watch.Stop();

                conn.Close();
            }
        }

        private void Del_Detail_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Item = Details.CheckedItems;
            if (Item.Count <= 0)
                MessageBox.Show("Select component(s) you wanna drop !!");
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Confirm to drop these components ?", "Delete Components", buttons);
                if (res == DialogResult.Yes)
                {
                    string qry = "";
                    foreach (ListViewItem item in Item)
                    {
                        if (type_gr == 0) qry = "DELETE FROM dbo.Chitiet_Hocphan" +
                                                " WHERE ID_Hocphan = " + ID_Current_Detail.ToString() +
                                                " AND ID_Monhoc = " + item.SubItems[0].Text;
                        if (type_gr == 1) qry = "DELETE FROM dbo.Chitiet_Nhanhhoc" +
                                                " WHERE ID_Nhanh = " + ID_Current_Detail.ToString() +
                                                " AND ID_Monhoc = " + item.SubItems[0].Text;
                        if (type_gr == 2) qry = "DELETE FROM dbo.Chitiet_NhomCD" +
                                               " WHERE ID_Nhom = " + ID_Current_Detail.ToString() +
                                               " AND ID_Chuyende = " + item.SubItems[0].Text;
                        Program.ExecCmd(qry);
                        
                    }

                    Details.Items.Clear();
                    string qry1 = "";
                    if (type_gr == 0) qry1 = "Select cthp.ID_Monhoc, dsmh.Ten_Monhoc, cthp.Batbuoc " +
                                            "from Chitiet_Hocphan cthp inner join DS_MonHoc dsmh ON cthp.ID_Monhoc = dsmh.ID_Monhoc " +
                                            "Where cthp.ID_Hocphan = " + ID_Cur.Text;

                    if (type_gr == 1) qry1= "Select ctnh.ID_Monhoc, dsmh.Ten_Monhoc " +
                                            "from Chitiet_NhanhHoc ctnh inner join DS_MonHoc dsmh ON ctnh.ID_Monhoc = dsmh.ID_Monhoc " +
                                            "Where ctnh.ID_Nhanh = " + ID_Cur.Text;

                    if (type_gr == 2) qry1 = "Select ctncd.ID_Chuyende, dscd.Ten_Chuyende " +
                                            "from Chitiet_NhomCD ctncd inner join DS_Chuyende dscd ON ctncd.ID_Chuyende = dscd.ID_Chuyende " +
                                            "Where ctncd.ID_Nhom = " + ID_Cur.Text;
                    Load_Details_List(qry1);
                }
            }
        }

        private void Drop_Gr_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = Group_list.CheckedItems;
            if (Items.Count <= 0)
            {
                MessageBox.Show("Select at least 1 item you wanna DROP !!!");
            }
            else
            {
                string qry = "";
                foreach (ListViewItem item in Items)
                {
                    if (type_gr == 0)
                        qry = "DELETE FROM dbo.DS_HocPhan WHERE ID_Hocphan = " + item.SubItems[0].Text;
                    if (type_gr == 1)
                        qry = "DELETE FROM dbo.DS_Nhanhhoc WHERE ID_Nhanh = " + item.SubItems[0].Text;
                    if (type_gr == 2)
                        qry = "DELETE FROM dbo.Nhom_Chuyende WHERE ID_Nhom = " + item.SubItems[0].Text;
                    Program.ExecCmd(qry);
                }
                LoadGroup();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Backtomenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManager_Menu mn = new CourseManager_Menu();
            mn.ShowDialog();
            this.Close();
        }


        //------------------------ tab COURSES--------------------------------//

        private void LoadCourses()
        {
            Courses_View.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                string qry = "";
                conn.Open();
                //Load Courses script
                if (type_gr == 0)
                    qry = "Select * from dbo.DS_HocPhan where ID_Hocphan > 0";
                else if (type_gr == 1)
                    qry = "Select * from dbo.DS_NhanhHoc where ID_Nhanh > 0";
                else if (type_gr == 2)
                    qry = "Select * from dbo.Nhom_Chuyende where ID_Nhom > 0";

                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (type_gr == 0)
                    {
                        ListViewItem item = new ListViewItem(reader["ID_Hocphan"].ToString());
                        item.SubItems.Add(reader["Ten_Hocphan"].ToString());
                        item.SubItems.Add(reader["Hocphi"].ToString() + " VND");
                        Group_list.Items.Add(item);
                    }
                    else if (type_gr == 1)
                    {
                        ListViewItem item = new ListViewItem(reader["ID_Nhanh"].ToString());
                        item.SubItems.Add(reader["Ten_Nhanh"].ToString());
                        item.SubItems.Add(reader["Hocphi"].ToString() + " VND");
                        Group_list.Items.Add(item);
                    }
                    else if (type_gr == 2)
                    {
                        ListViewItem item = new ListViewItem(reader["ID_Nhom"].ToString());
                        item.SubItems.Add(reader["Ten_Nhom"].ToString());
                        item.SubItems.Add(reader["Hocphi"].ToString() + " VND");
                        Group_list.Items.Add(item);
                    }
                }
                watch.Stop();
                conn.Close();
            }
        }

        private void Manage_Form_button_Click(object sender, EventArgs e)
        {
            CourseManager_Edu_Form temp = new CourseManager_Edu_Form();
            temp.ShowDialog();
        }

        int EduForm_State = 0; // 1 - KTV , 4 - Chuyende , 2 - A, 3 -B
        private void Course_Drop_Click(object sender, EventArgs e)
        {
           
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                ListView.CheckedListViewItemCollection Items = Courses_View.CheckedItems;
                if (Items.Count <= 0)
                    MessageBox.Show("Please select 1 course you wanna drop!!!");
                else if (Items.Count > 1)
                    MessageBox.Show("Please select just 1 course you wanna drop !!!");
                else
                {
                    foreach (ListViewItem item in Items)
                    {
                        string check = "Select * from DangKi where ID_Khoa = " + item.SubItems[0].Text;
                        SqlCommand cmd = new SqlCommand(check, conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Cannot Drop this Course!!!");
                        }
                        else
                        {
                            MessageBoxButtons button = MessageBoxButtons.YesNo;
                            DialogResult res = MessageBox.Show("Are you sure to drop this Course?", "Delete Course", button);
                            if (res == DialogResult.Yes)
                            {

                                string qry = "Delete From LopHoc where ID_Khoa = " + item.SubItems[0].Text +
                                    "\n Delete From KhoaDaoTao where ID_Khoa = " + item.SubItems[0].Text;
                                Program.ExecCmd(qry);
                                LoadCoursesListView(0,0);
                            }
                        }
                    }
                }
                conn.Close();
            }
            
        }

        private void Course_View_button_Click(object sender, EventArgs e)
        {
            Course_Details_View.Items.Clear();
            ListView.CheckedListViewItemCollection Items = Courses_View.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Please choose 1 Course you wanna VIEW !!");
            else if (Items.Count > 1) MessageBox.Show("Please choose just 1 Course!!!");
            else
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    foreach (ListViewItem item in Items)
                    {
                        
                        string qry = "Select * from DangKi Where ID_Khoa = " + item.SubItems[0].Text;
                        SqlCommand cmd = new SqlCommand(qry, conn);

                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem temp = new ListViewItem(reader["ID_Hocvien"].ToString()); 
                            temp.SubItems.Add(reader["ID_Khoa"].ToString());
                            temp.SubItems.Add(reader["Totnghiep"].ToString());
                            Course_Details_View.Items.Add(temp);
                        }
                        watch.Stop();
                        ID_Course_Detail.Text = item.SubItems[0].Text;
                    }
                    conn.Close();
                }
                
                LoadCoursesListView(0,0);
            }
        }

        private void Course_Fix_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = Courses_View.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Select Course you wanna DROP !!!");
            else if (Items.Count > 1) MessageBox.Show("Please Select just 1 Course !!!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    string qry = "";
                    if (!string.IsNullOrEmpty(Course_Name_text.Text))
                        qry += "\n UPDATE dbo.KhoaDaoTao" +
                            " SET Ten_Khoa = N'" + Course_Name_text.Text +
                            "' WHERE ID_Khoa = " + item.SubItems[0].Text;
                    if (Course_MaxMem_text.Value > 0)
                        qry += "\n UPDATE dbo.KhoaDaoTao" +
                            " SET Soluong = " + Course_MaxMem_text.Value.ToString() +
                            " WHERE ID_Khoa = " + item.SubItems[0].Text;
                    if (item.SubItems[3].Text != Course_BeginDate_text.Value.ToString("MM/dd/yyyy"))
                        qry += "\n UPDATE dbo.KhoaDaoTao" +
                            " SET NgayBatdau = '" + Course_BeginDate_text.Value.ToString("MM/dd/yyyy") +
                            "' WHERE ID_Khoa = " + item.SubItems[0].Text;
                    Program.ExecCmd(qry);
                    LoadCoursesListView(0,0);
                }
            }
        }

        private void Course_Create_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (string.IsNullOrEmpty(Course_Name_text.Text))
                MessageBox.Show("Please Enter Course's Name !!");
            else if (string.IsNullOrEmpty(Course_BeginDate_text.Text))
                MessageBox.Show("Please Enter Course's Begin Date !!!");
            else if (Course_MaxMem_text.Value < 5)
                MessageBox.Show("More than 5 students each Course !!!");
            else if (Edu_Form.Text == "Loại hình đào tạo" || Edu_Form.Text == "Tất cả")
                MessageBox.Show("Please Enter Education Form of Course !!");
            else
            {
                qry = "Insert into KhoaDaoTao values ((Select Max(ID_Khoa) from KhoaDaoTao)+1, N'" + Course_Name_text.Text +
                    "', " + Course_MaxMem_text.Value.ToString() + ", '" + Course_BeginDate_text.Value.ToString("MM/dd/yyyy") + "', " 
                    + "(Select ID_Loai from LoaiHinhDaoTao where Ten_Loai = N'" + Edu_Form.Text +  "')," + Signin.ID.ToString() +")";
                Program.ExecCmd(qry);
                LoadCoursesListView(0,0);
            }
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

        private void Edu_Form_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Edu_Form.Text == "Tất cả" || Edu_Form.Text == "Loại hình đào tạo") EduForm_State = 0;
            LoadCoursesListView(0,0);
        }

        private void YearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterMonth.Text == "")
                LoadCoursesListView(Int32.Parse(YearFilter.Text),0);
            else
                LoadCoursesListView(Int32.Parse(YearFilter.Text), Int32.Parse(FilterMonth.Text));
        }

        private void Courses_Reload_Click(object sender, EventArgs e)
        {
            YearFilter.Text = "";
            FilterMonth.Text = "";
            Edu_Form_LoadIndex();
            LoadCoursesListView(0,0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Group_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearFilter.Text == "")
                LoadCoursesListView(0, Int32.Parse(FilterMonth.Text));
            else
                LoadCoursesListView(Int32.Parse(YearFilter.Text), Int32.Parse(FilterMonth.Text));
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}