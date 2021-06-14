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
    public partial class CourseManager_Edu_Form : Form
    {
        public CourseManager_Edu_Form()
        {
            InitializeComponent();
        }

        private void ResetInput()
        {
            Rule_text.Text = "";
            Name_text.Text = "";
        }
        private void LoadLHDT()
        {
            LHDT_View.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from dbo.LoaiHinhDaoTao where ID_Loai > 0";
                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Loai"].ToString());
                    item.SubItems.Add(reader["Ten_Loai"].ToString());
                    LHDT_View.Items.Add(item);
                }
                watch.Stop();
                conn.Close();
            }
        }

        int state = 0; // 0 - View Details, 1 - Danh sach hoc phan , 2 - Danh sach Nhom chuyen de
                        // 3 - Danh sach Mon hoc , 4 - Danh sach Nhanh hoc
        private void LoadGroupSub()
        {
            details_view.Items.Clear();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                string qry = "";
                conn.Open();
                switch (state)
                {
                    case 1: qry = "Select ID_Hocphan as ID, Ten_Hocphan as Ten, Hocphi from DS_HocPhan where ID_Hocphan > 0"; break;
                    case 2: qry = "Select ID_Nhom as ID, Ten_Nhom as Ten, Hocphi from Nhom_Chuyende where ID_Nhom > 0"; break;
                    case 3: qry = "Select ID_Monhoc as ID, Ten_Monhoc as Ten, Hocphi from DS_MonHoc where ID_Monhoc > 0"; break;
                    case 4: qry = "Select ID_Nhanh as ID, Ten_Nhanh as Ten, Hocphi from DS_NhanhHoc where ID_Nhanh > 0"; break;
                }
                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["Ten"].ToString());
                    item.SubItems.Add(reader["Hocphi"].ToString());
                    details_view.Items.Add(item);
                }
                watch.Stop();
                conn.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
        }

        private void Students_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_text.Text))
                MessageBox.Show("Please Enter Education Form's Name !!!");
            else if (string.IsNullOrEmpty(Rule_text.Text))
                MessageBox.Show("Please Enter the Rules !!!");
            else {
                string qry = "Insert into dbo.LoaiHinhDaoTao values " +
                    "((Select Max(ID_Loai) From LoaiHinhDaoTao)+1," +
                    "N'" + Name_text.Text + "', N'" + Rule_text.Text + "')";
                Program.ExecCmd(qry);
            }
            LoadLHDT();
            ResetInput();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadLHDT();
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = LHDT_View.CheckedItems;
            if (Items.Count == 0)
                MessageBox.Show("Please Enter at least 1 Item you wanna DROP !!!");
            else
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Are you sure you want to Delete these item ?!","Delete Item",button);
                if (res == DialogResult.Yes)
                {
                    string qry = "";
                    foreach (ListViewItem item in Items)
                    {
                        qry = "Delete From dbo.LoaiHinhDaoTao Where ID_Loai = " + item.SubItems[0].Text;
                        Program.ExecCmd(qry);
                    }
                }
                LoadLHDT();
                ResetInput();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = LHDT_View.CheckedItems;
            if (Items.Count == 0)
                MessageBox.Show("Please Select 1 Item you wanna FIX !!!");
            else if (Items.Count > 1)
                MessageBox.Show("Please Select just 1 Item !!!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    string qry = "";
                    if (!string.IsNullOrEmpty(Name_text.Text))
                        qry += " Update dbo.LoaiHinhDaoTao" +
                            " Set Ten_Loai = N'" + Name_text.Text + "' Where ID_Loai = " + item.SubItems[0].Text;
                    if (!string.IsNullOrEmpty(Rule_text.Text))
                        qry += "\n" +
                            "Update dbo.LoaiHinhDaoTao" +
                            " Set Quytac = N'" + Rule_text.Text + "' Where ID_Loai = " + item.SubItems[0].Text;
                    Program.ExecCmd(qry);
                }
            }
            LoadLHDT();
            ResetInput();
        }

        private void Admin_Courses_Load(object sender, EventArgs e)
        {
            Drop_Component.BackColor = Color.Gray;
            LoadLHDT();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            ResetInput();
            ListView.CheckedListViewItemCollection Items = LHDT_View.CheckedItems;
            if (Items.Count == 0)
                MessageBox.Show("Please Select item you wanna SHOW RULES!!!!");
            else if (Items.Count > 1)
                MessageBox.Show("Please Select just 1 item you wanna SHOW RULES!!!!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        string qry = "Select Quytac from dbo.LoaiHinhDaoTao Where ID_Loai = " + item.SubItems[0].Text;
                        SqlCommand cmd = new SqlCommand(qry, conn);

                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader = cmd.ExecuteReader();
                        try
                        {
                            while (reader.Read())
                            {
                                Rule_text.Text = reader["Quytac"].ToString();
                                ID_Selected.Text = item.SubItems[0].Text;
                            }
                        }
                        catch(Exception exc)
                        {
                            MessageBox.Show("Error!!" + exc);
                        }
                        conn.Close();
                    }
                }
            }
            LoadLHDT();
        }

        private void View_Details_Click(object sender, EventArgs e)
        {
            details_view.Items.Clear();
            ListView.CheckedListViewItemCollection Items = LHDT_View.CheckedItems;
            if (Items.Count <= 0)
                MessageBox.Show("Please select the item you wanna view details !!!");
            else if (Items.Count > 1)
                MessageBox.Show("Please select just 1 item you wanna view details !!!");
            else
            {
                foreach(ListViewItem item in Items)
                {
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Chitiet_LHDT", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idloai", Int32.Parse(item.SubItems[0].Text));

                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem temp = new ListViewItem(reader["ID"].ToString());
                            temp.SubItems.Add(reader["Ten"].ToString());
                            temp.SubItems.Add(reader["Hocphi"].ToString());
                            details_view.Items.Add(temp);
                        }
                        watch.Stop();
                        conn.Close();
                    }
                    ID_Selected.Text = item.SubItems[0].Text;
                }
                LoadLHDT();

                Drop_Component.BackColor = Color.Brown;
            }
            List_GroupSub.Text = "Loại hình đào tạo gồm các thành phần :";
        }

        private void List_GroupSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List_GroupSub.Text == "Loại hình đào tạo gồm các thành phần :") return;
            state = List_GroupSub.SelectedIndex + 1;
            LoadGroupSub();
            Drop_Component.BackColor = Color.Gray;
        }

        // 0 - View Details, 1 - Danh sach hoc phan , 2 - Danh sach Nhom chuyen de
        // 3 - Danh sach Mon hoc , 4 - Danh sach Nhanh hoc
        private void Add_Component_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Form_Item = LHDT_View.CheckedItems;
            ListView.CheckedListViewItemCollection Component_Item = details_view.CheckedItems;
            if (Form_Item.Count <= 0)
                MessageBox.Show("Select 1 item you wanna ADD !!!");
            else if (Form_Item.Count > 1)
                MessageBox.Show("Select just 1 item !!!");
            else if (Component_Item.Count <= 0)
                MessageBox.Show("Select at least 1 component you wanna ADD!!!");
            else if (List_GroupSub.Text == "Danh sách Nhóm chuyên đề" && Component_Item.Count > 1)
                MessageBox.Show("Each Major belongs to just 1 Major Group!!!"); 
            else
            {
                string qry = ""; string table = "";
                switch (state)
                {
                    case 1: table = "Chungchi_Hocphan"; break;
                    case 2: table = "LopChuyende"; break;
                    case 3: table = "Chungchi_Monhoc"; break;
                    case 4: table = "Chungchi_Nhanhhoc"; break;
                }
                foreach (ListViewItem Form_item in Form_Item)
                {
                    foreach (ListViewItem Compo_item in Component_Item)
                    {
                        qry = "Insert Into " + table + " values (" + Compo_item.SubItems[0].Text + ", " +
                             Form_item.SubItems[0].Text + ")";
                        Program.ExecCmd(qry);
                    }
                }
                LoadLHDT();
                LoadGroupSub();
            }
        }

        private void Drop_Component_Click(object sender, EventArgs e)
        {
            if (Drop_Component.BackColor != Color.Gray)
            {
                ListView.CheckedListViewItemCollection Component_Item = details_view.CheckedItems;
                if (Component_Item.Count <= 0)
                    MessageBox.Show("Select at least 1 component you wanna DROP!!!");
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    DialogResult res = MessageBox.Show("Are you sure to delete these items ?!", "Delete Components", button);
                    if (res == DialogResult.Yes)
                    {
                        string qry = ""; string table = ""; string id_select = "";
                        switch (Int32.Parse(ID_Selected.Text))
                        {
                            case 0: return;
                            case 1: table = "Chungchi_Hocphan"; id_select = "ID_Hocphan = "; break;
                            case 4: table = "LopChuyende"; id_select = "ID_Nhom = "; break;
                            case 2: table = "Chungchi_Monhoc"; id_select = "ID_Monhoc = "; break;
                            case 3: table = "Chungchi_Nhanhhoc"; id_select = "ID_Nhanh = "; break;
                        }
                        foreach (ListViewItem Compo_item in Component_Item)
                        {
                            qry = "Delete From " + table + " Where " + id_select + Compo_item.SubItems[0].Text + "and ID_Loai = " +
                                     ID_Selected.Text;
                            Program.ExecCmd(qry);
                        }
                    }
                    LoadLHDT();
                    details_view.Items.Clear();
                    using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Chitiet_LHDT", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idloai", Int32.Parse(ID_Selected.Text));

                        var watch = System.Diagnostics.Stopwatch.StartNew();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ListViewItem temp = new ListViewItem(reader["ID"].ToString());
                            temp.SubItems.Add(reader["Ten"].ToString());
                            temp.SubItems.Add(reader["Hocphi"].ToString());
                            details_view.Items.Add(temp);
                        }
                        watch.Stop();
                        conn.Close();
                    }
                }
            }
        }
    }
}
