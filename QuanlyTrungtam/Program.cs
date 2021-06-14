using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanlyTrungtam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void ExecCmd(string qry)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString.connect))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(qry, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful !!!");
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error!! : " + exc);
                }
                conn.Close();
            }
        }
        public static bool ChangePass = false;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Register_Courses());
        }
    }
}
