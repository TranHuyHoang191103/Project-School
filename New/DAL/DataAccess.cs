using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace DAL
{
    public class SqlConnectionData
    {
        // tao chuoi ket noi co so du lieu

        public static SqlConnection connect()
        {

            string str = @"Data Source=DESKTOP-6GG2D7G\DATASSMS;Initial Catalog=ScheduleManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(str); // khoi tao connect
            return con;
        }
    }

    public class DataAccess
    {
        // ham do du lieu vao datable
        public static DataTable getData(string query)
        {
            SqlConnection conn = SqlConnectionData.connect();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(tb);
            conn.Close();
            return tb;
        }

        public static void execQuery(string sql)
        {
            SqlConnection conn = SqlConnectionData.connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }

        public static ArrayList getList(string sql)
        {
            DataTable tb = getData(sql);
            ArrayList list = new ArrayList();
            for(int i = 0; i<tb.Rows.Count; i++)
            {
                string key = tb.Rows[i][0].ToString().Trim();
                if(list.IndexOf(key) < 0)
                list.Add(key);
            }
            return list;
        }
    }
}
