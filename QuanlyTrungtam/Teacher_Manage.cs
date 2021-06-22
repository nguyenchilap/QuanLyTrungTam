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

        private void Load_GV(string chuyenmon)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select * from NhanVien A join GiaoVien B ON A.ID_NV = B.ID_NV where A.ID_NV > 0 ";
                if (!string.IsNullOrEmpty(chuyenmon))
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
                    Courses_View.Items.Add(item);
                }
                conn.Close();
            }
        }

        private void Init_Major()
        {
            MajorText.Items.Clear();
            using(SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                string qry = "Select distinct Chuyenmon from GiaoVien where ID_NV > 0";
                SqlCommand cmd = new SqlCommand(qry, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MajorText.Items.Add(reader["Chuyenmon"].ToString());
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

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            Init_Major();
            Load_GV(null);
        }

        private void MajorText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MajorText.Text == "Tất cả")
                Load_GV(null);
            else Load_GV(MajorText.Text);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Menu temp = new Teacher_Menu();
            temp.ShowDialog();
            this.Close();
        }
    }
}
