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
    public partial class StudentManager_Approve : Form
    {
        public StudentManager_Approve()
        {
            InitializeComponent();
        }

        private void StudentManager_StudentRegister_Load(object sender, EventArgs e)
        {

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

        private void Load_DonDangki()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();

                string qry = " Select * from DonDangKi A join HocVien ON A.ID_Hocvien = B.ID_Hocvien " +
                                                        "join KhoaDaoTao C ON A.ID_Khoa = C.ID_Khoa " +
                                                        "join LoaiHinhDaoTao D ON D.ID_Loai = C.LoaiHinhDaoTao ";
                if (Edu_Form.Text != "Tất cả")
                    qry += " where D.Ten_Loai = N'" + Edu_Form.Text + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID_Hocvien"].ToString());
                    item.SubItems.Add(reader["Ten_Hocvien"].ToString());
                    item.SubItems.Add(reader["Ten_Khoa"].ToString());
                    item.SubItems.Add(reader["Hocphi"].ToString());
                    if (reader[""])
                }

                conn.Close();
            }
        }
    }
}
