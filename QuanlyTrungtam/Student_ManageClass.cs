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

        private void Init_ListSubGr()
        {
            List_SubGr.BeginUpdate();
            List_SubGr.Nodes.Add("HocPhan", "Học phần");
            List_SubGr.Nodes.Add("NhanhHoc", "Nhánh học");
            List_SubGr.Nodes.Add("NhomChuyende", "Nhóm Chuyên đề");
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
                    IDCur_Course.Text = Int32.Parse(item.SubItems[0].Text);
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
    }
}
