using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataAccessDAL
    {
        public SqlConnection conn = null;
        string strConn = @"Data Source=9H1ENY893ZBJDQQ\LEEGNUH;Initial Catalog=QLPTH;Integrated Security=True";
        public void openConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void cloeConn()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}