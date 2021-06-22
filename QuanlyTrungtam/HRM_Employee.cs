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
    public partial class HRM_Employee : Form
    {
        public HRM_Employee()
        {
            InitializeComponent();
        }
        private void ResetInput()
        {
            Name_input.Text = "";
            email_input.Text = "";
            phonenum_input.Text = "";
            Salary_input.Value = 0;
            Username.Text = "";
            Pass.Text = "";
            DOB_input.Value = DateTime.Now;
            DOB_input.Value = DOB_input.Value.AddYears(-20);
            dateBegin_input.Value = DateTime.Now;
        }

        private void Load_Truongphong()
        {
            if (Department_State.Text != "Tất cả")
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
                {
                    conn.Open();
                    string qry = "Select nv.Ten_NV From PhongBan pb join NhanVien nv ON pb.Truongphong = nv.ID_NV" +
                    " where pb.Ten_Phongban = N'" + Department_State.Text + "'";
                    SqlCommand cmd = new SqlCommand(qry, conn);

                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        TruongPhongban.Text = reader["Ten_NV"].ToString();
                    }

                    watch.Stop();
                    conn.Close();
                }
            }
        }

        private void Load_DepartmentList()
        {
            Department_State.Items.Add("Tất cả");
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select nv.Ten_NV, pb.Ten_Phongban From PhongBan pb join NhanVien nv ON pb.Truongphong = nv.ID_NV" +
                    " where pb.ID_Phongban > 0";
                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Department_State.Items.Add(reader["Ten_Phongban"].ToString());
                }

                watch.Stop();
                conn.Close();
            }
        }
        private void Load_EmployeeList(int departID)
        {
            EmployeeView.Items.Clear();
            string qry = "Select *" +
                "From NhanVien nv JOIN PhongBan pb ON nv.ID_Phongban = pb.ID_Phongban Where nv.ID_NV > 0";
            if (departID != 0) qry += " and pb.ID_Phongban = " + departID.ToString();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(qry, conn);

                var watch = System.Diagnostics.Stopwatch.StartNew();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_NV"].ToString());
                    item.SubItems.Add(reader["Ten_NV"].ToString());
                    item.SubItems.Add(reader["Luong"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["Ngaysinh"]).ToString("MM/dd/yyyy"));
                    item.SubItems.Add(reader["SDT"].ToString());
                    item.SubItems.Add(reader["Email"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["NgayBatdau"]).ToString("MM/dd/yyyy"));
                    if (string.IsNullOrEmpty(reader["Ngayketthuc"].ToString())) 
                        item.SubItems.Add("Đang công tác");
                    else
                        item.SubItems.Add(Convert.ToDateTime(reader["NgayKetthuc"]).ToString("MM/dd/yyyy"));
                    EmployeeView.Items.Add(item);
                }

                watch.Stop();
                conn.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HRM_Employee_Load(object sender, EventArgs e)
        {
            Department_State.Text = "Tất cả";
            Load_DepartmentList();
            Load_EmployeeList(0);
            DOB_input.Value = DateTime.Now;
            DOB_input.Value = DOB_input.Value.AddYears(-20);
            if (Signin.IsManager == false)
            {
                GrantManage.BackColor = Color.Gray;
                GrantManage.FlatAppearance.BorderColor = Color.DarkGray;

                LeaveWork.BackColor = Color.Gray;
                LeaveWork.FlatAppearance.BorderColor = Color.DarkGray;
            }
        }

        private void Department_State_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Truongphong();
            Load_EmployeeList(Department_State.SelectedIndex);
            if (Signin.IsManager)
            {
                if (Department_State.Text == "Phòng Nhân sự")
                {
                    GrantManage.BackColor = Color.Gray;
                    GrantManage.FlatAppearance.BorderColor = Color.DarkGray;
                }
                else
                {
                    GrantManage.BackColor = Color.MediumSpringGreen;
                    GrantManage.FlatAppearance.BorderColor = Color.DarkGreen;
                }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Name_input.Text)) MessageBox.Show("Enter Employee's Name !!");
            else if (string.IsNullOrEmpty(email_input.Text)) MessageBox.Show("Enter Employee's Email !!");
            else if (string.IsNullOrEmpty(phonenum_input.Text)) MessageBox.Show("Enter Employee's Phone number !!");
            else if (Salary_input.Text == "0") MessageBox.Show("Enter Employee's Salary !!");
            else if (string.IsNullOrEmpty(Username.Text)) MessageBox.Show("Enter Employee's User account !!");
            else if (DOB_input.Value.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy"))
                MessageBox.Show("Date of Birth invalid !!!");
            else if (string.IsNullOrEmpty(Pass.Text)) MessageBox.Show("Enter Employee's default Password !!");
            else if (string.IsNullOrEmpty(Department_State.Text) || Department_State.Text == "Tất cả")
                MessageBox.Show("Which Depatment this Employee belong to ??!!");
            else
            {
                //Them vao bang nhan vien
                string qry_NV = "Insert into NhanVien values (" +
                    "(Select Max(ID_NV) from NhanVien) + 1, N'" +
                    Name_input.Text + "'," + Salary_input.Value.ToString() + ", '" +
                    DOB_input.Value.ToString("MM/dd/yyyy") + "' , '" + phonenum_input.Text + "', '" +
                    email_input.Text + "@gmail.com' , '" + dateBegin_input.Value.ToString("MM/dd/yyyy") + "', " +
                    "(Select ID_Phongban from PhongBan where Ten_Phongban = N'" + Department_State.Text + "'),NULL)";

                //MessageBox.Show(qry_NV);
                Program.ExecCmd(qry_NV);

                //Them vao bang giao vien
                if (Department_State.Text == "Phòng Chuyên môn")
                {
                    string qry_teach = "Insert into GiaoVien values ((Select Max(ID_NV) from NhanVien),'')" ;
                    Program.ExecCmd(qry_teach);
                }

                string qry_TKNV = "Insert into Taikhoan_Nhanvienn values ('" + Username.Text + "','" + Pass.Text + "',"
                    + "(Select Max(ID_NV) from NhanVien))";
                //MessageBox.Show(qry_TKNV);
                Program.ExecCmd(qry_TKNV);
                Load_EmployeeList(Department_State.SelectedIndex);
                ResetInput();
            }
        }

        private void Fix_button_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = EmployeeView.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Enter Employee you wanna Fix!!!");
            else if (Items.Count > 1) MessageBox.Show("Please Select just 1 Employee !!!");
            else
            {
                foreach (ListViewItem item in Items)
                {
                    string qry = "";
                    if (!string.IsNullOrEmpty(Name_input.Text))
                        qry += "\n Update NhanVien Set Ten_NV = N'" + Name_input.Text + "' Where ID_NV = " + item.SubItems[0].Text;
                    if (!string.IsNullOrEmpty(email_input.Text))
                        qry += "\n Update NhanVien Set Email = '" + email_input.Text + "@gmail.com' Where ID_NV = " + item.SubItems[0].Text;
                    if (!string.IsNullOrEmpty(phonenum_input.Text))
                        qry += "\n Update NhanVien Set SDT = '" + phonenum_input.Text + "' Where ID_NV = " + item.SubItems[0].Text;
                    if (dateBegin_input.Value != DateTime.Now)
                        qry += "\n Update NhanVien Set NgayBatdau = '" + dateBegin_input.Value.ToString("MM/dd/yyyy") + "' Where ID_NV = " + item.SubItems[0].Text;
                    if (DOB_input.Value != DateTime.Now)
                        qry += "\n Update NhanVien Set Ngaysinh = '" + DOB_input.Value.ToString("MM/dd/yyyy") + "' Where ID_NV = " + item.SubItems[0].Text;
                    if (Salary_input.Value != 0)
                        qry += "\n Update NhanVien Set Luong = " + Salary_input.Value.ToString() + " Where ID_NV = " + item.SubItems[0].Text;
                    Program.ExecCmd(qry);
                }
                if (Department_State.Text == "Tất cả") Load_EmployeeList(0);
                else
                    Load_EmployeeList(Department_State.SelectedIndex);
                ResetInput();
            }
        }

        private void Drop_button_Click(object sender, EventArgs e)
        {
            ListView.CheckedListViewItemCollection Items = EmployeeView.CheckedItems;
            if (Items.Count <= 0) MessageBox.Show("Enter Employee you wanna DROP!!!");
            else if (Items.Count > 1) MessageBox.Show("Please Select just 1 Employee !!!");
            else
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult res = MessageBox.Show("Are you sure to DROP this Employee ?!!", "Delete Employee", button);
                if (res == DialogResult.Yes)
                {
                    foreach (ListViewItem item in Items)
                    {
                        string qry = "Delete from NhanVien Where ID_NV = " + item.SubItems[0].Text;
                        Program.ExecCmd(qry);
                    }
                }
                if (Department_State.Text == "Tất cả") Load_EmployeeList(0);
                else
                    Load_EmployeeList(Department_State.SelectedIndex);
            }
        }

        private void View_Detail_Click(object sender, EventArgs e)
        {
            ManageAccount temp = new ManageAccount();
            temp.ShowDialog();
            if (Program.ChangePass == true)
            {
                this.Hide();
                this.Close();
            }
        }

        private void Signout_Click(object sender, EventArgs e)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult res = MessageBox.Show("You will be logged out. Continue ?","Log out", button);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                Signin temp = new Signin();
                temp.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Signin.IsManager)
            {
                if (Department_State.Text != "Phòng Nhân sự")
                {
                    ListView.CheckedListViewItemCollection Items = EmployeeView.CheckedItems;
                    if (Items.Count <= 0) MessageBox.Show("Select employee you wanna grant !!!");
                    else if (Items.Count > 1) MessageBox.Show("Please Select just 1 Employee !!!");
                    else if (Department_State.Text == "Tất cả") MessageBox.Show("Select Department !!!");
                    else
                    {
                        MessageBoxButtons button = MessageBoxButtons.YesNo;
                        DialogResult res = MessageBox.Show("Are you sure to grant this employee Manage Privilege on this Department?", "Grant Manage", button);
                        if (res == DialogResult.Yes)
                        {
                            string qry = "";
                            foreach (ListViewItem item in Items)
                            {
                                qry = "Update PhongBan Set Truongphong = " + item.SubItems[0].Text + " Where Ten_Phongban = N'" + Department_State.Text + "'";
                                Program.ExecCmd(qry);
                            }
                        }
                    }
                    Load_EmployeeList(Department_State.SelectedIndex);
                    Load_Truongphong();
                }
            }
        }

        private void LeaveWork_Click(object sender, EventArgs e)
        {
            if (Signin.IsManager)
            {
                ListView.CheckedListViewItemCollection Items = EmployeeView.CheckedItems;
                if (Items.Count <= 0) MessageBox.Show("Select employee !!!");
                else if (Items.Count > 1) MessageBox.Show("Please Select just 1 Employee !!!");
                else
                {
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    DialogResult res = MessageBox.Show("Please check carefully which Employee gonna leaving work !!!", "Leave Work", button);
                    if (res == DialogResult.Yes)
                    {
                        string qry = "";
                        foreach (ListViewItem item in Items)
                        {
                            qry = "Update NhanVien Set NgayKetthuc = '" + DateTime.Now.ToString("MM/dd/yyyy")
                                + "' Where ID_NV = " + item.SubItems[0].Text;
                            qry += "\n Delete from Taikhoan_Nhanvienn Where ID_NV = " + item.SubItems[0].Text;
                            Program.ExecCmd(qry);
                        }
                    }
                }
                if (Department_State.Text == "Tất cả") Load_EmployeeList(0);
                else
                    Load_EmployeeList(Department_State.SelectedIndex);
            }
        }
    }
}
