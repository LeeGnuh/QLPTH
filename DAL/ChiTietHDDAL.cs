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
    public class ChiTietHDDAL : DataAccessDAL
    {
        List<ChiTietHD> DSCT = new List<ChiTietHD>();
        public List<ChiTietHD> getAllCT()
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from ChiTietHD";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ChiTietHD ct = new ChiTietHD();

                ct.MaHD = reader.GetInt32(0);               
                ct.MaSP = reader.GetInt32(1);
                ct.SoLuong = reader.GetInt32(2);

                DSCT.Add(ct);
            }
            reader.Close();
            return DSCT;
        }

        public bool deleteAt(int maHD, int maSP)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from ChiTietHD where MaHD = @maHD, MaSP = @maSP";
            commnand.Connection = conn;

            commnand.Parameters.Add("@maHD", SqlDbType.Int).Value = maHD;
            commnand.Parameters.Add("@maSP", SqlDbType.Int).Value = maSP;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool deleteAtHD(int maHD)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from ChiTietHD where MaHD = @maHD";
            commnand.Connection = conn;

            commnand.Parameters.Add("@maHD", SqlDbType.Int).Value = maHD;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool deleteAtSP(int maSP)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from ChiTietHD where MaSP = @maSP";
            commnand.Connection = conn;

            commnand.Parameters.Add("@maSP", SqlDbType.Int).Value = maSP;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }


        public bool addCT_Object(ChiTietHD ct)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = " insert into ChiTietHD Values(@maHD, @maSP, @sl)";
            command.Connection = conn;

            command.Parameters.Add("@maHD", SqlDbType.Int).Value = ct.MaHD;
            command.Parameters.Add("@maSP", SqlDbType.Int).Value = ct.MaSP;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = ct.SoLuong;

            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeCT_At_Object(ChiTietHD ct, int maHD, int maSP)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE SanPham SET SoLuong = @sl WHERE MaHD = @maHD, MaSP = @maSP";
            command.Connection = conn;
          
            command.Parameters.Add("@sl", SqlDbType.Int).Value = ct.SoLuong;
            command.Parameters.Add("@maHD", SqlDbType.Int).Value = maHD;
            command.Parameters.Add("@maSP", SqlDbType.Int).Value = maSP;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}
