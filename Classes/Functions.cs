using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace TikkTakk2013
{
    public class Functions
    {
        public static double Opacity()
        {
            double opacity = Convert.ToInt32(Common.GetRegistryKey("Opacity", "100"));
            if (opacity == 0)
                opacity = 100;
            return opacity/100;
        }

        public static string WindowsUser()
        {
            string userName = Environment.UserName;
            return userName;
        }

        public static DataTable GetTable(string sqlString)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlString, Common.Conn);
            adapter.Fill(tbl);
            return tbl;
        }

        public static bool RunCmd(SqlCommand cmd)
        {
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                    cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing command: " + ex.Message, "Database Error");
                return false;
            }
        }
    }
}
