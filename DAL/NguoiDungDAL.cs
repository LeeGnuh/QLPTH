using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class NguoiDungDAL : DataAccessDAL
    {
        List<NguoiDung> DSND = new List<NguoiDung>();
        public List<NguoiDung> getAllND()
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from NguoiDung";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                NguoiDung nd = new NguoiDung();

                nd.MaND = reader.GetInt32(0);
                nd.TenND = reader.GetString(1);
                nd.Uname = reader.GetString(2);
                nd.UPass = reader.GetString(3);

                DSND.Add(nd);
            }
            reader.Close();
            return DSND;
        }

        public bool deleteAt(int ma)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from NguoiDung where MaND = @ma";
            commnand.Connection = conn;

            commnand.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addND_Object(NguoiDung nd)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = " insert into NguoiDung Values(@ma, @ten, @un, @pw)";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = nd.MaND;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nd.TenND;
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = nd.Uname;
            command.Parameters.Add("@pw", SqlDbType.NVarChar).Value = nd.UPass;

            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeND_At_Object(NguoiDung nd, int id)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE NguoiDung SET TenND = @ten, Uname = @un, Upass = @pw WHERE MaND = @id;";
            command.Connection = conn;

            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nd.TenND;
            command.Parameters.Add("@un", SqlDbType.NVarChar).Value = nd.Uname;
            command.Parameters.Add("@pw", SqlDbType.NVarChar).Value = nd.UPass;
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}
