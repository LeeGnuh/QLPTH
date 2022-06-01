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
    public class HoaDonDAL : DataAccessDAL
    {
        List<HoaDon> DSHD = new List<HoaDon>();
        public List<HoaDon> getAllHD()
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from HoaDon";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                HoaDon hd = new HoaDon();

                hd.MaHD = reader.GetInt32(0);
                hd.MaND = reader.GetInt32(1);
                hd.NgayTao = reader.GetString(2);

                DSHD.Add(hd);
            }
            reader.Close();
            return DSHD;
        }

        public bool deleteAt(int maHD)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from HoaDon where MaHD = @maHD";
            commnand.Connection = conn;

            commnand.Parameters.Add("@maHD", SqlDbType.Int).Value = maHD;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }
        public bool deleteAtND(int maND)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from HoaDon where MaND = @maND";
            commnand.Connection = conn;

            commnand.Parameters.Add("@maND", SqlDbType.Int).Value = maND;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addHD_Object(HoaDon hd)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = " insert into HoaDon Values(@maHD, @maND, @ngay)";
            command.Connection = conn;

            command.Parameters.Add("@maHD", SqlDbType.Int).Value = hd.MaHD;
            command.Parameters.Add("@ten", SqlDbType.Int).Value = hd.MaND;
            command.Parameters.Add("@ngay", SqlDbType.VarChar).Value = hd.NgayTao;

            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeHD_At_Object(HoaDon hd, int maHD)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE HoaDon SET MaND = @maND, NgayTao = @ngay WHERE MaHD = @maHD;";
            command.Connection = conn;

            command.Parameters.Add("@maND", SqlDbType.Int).Value = hd.MaND;
            command.Parameters.Add("@ngay", SqlDbType.VarChar).Value = hd.NgayTao;
            command.Parameters.Add("@maHD", SqlDbType.Int).Value = maHD;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}
