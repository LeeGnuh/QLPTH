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
    public class DanhMucDAL : DataAccessDAL
    {
        List<DanhMuc> DSDM = new List<DanhMuc>();
        public List<DanhMuc> getAllDM()
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from DanhMuc";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DanhMuc dm = new DanhMuc();

                dm.MaDM = reader.GetInt32(0);
                dm.TenDM = reader.GetString(1);
                
                DSDM.Add(dm);
            }
            reader.Close();
            return DSDM;
        }

        public bool deleteAt(int ma)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from DanhMuc where MaDM = @ma";
            commnand.Connection = conn;

            commnand.Parameters.Add("@ma", SqlDbType.Int).Value = ma;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addDM_Object(DanhMuc dm)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = " insert into DanhMuc Values(@ma, @ten)";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = dm.MaDM;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = dm.TenDM;
            
            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeDM_At_Object(DanhMuc dm, int id)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE DanhMuc SET TenDM = @ten WHERE MaDM = @id;";
            command.Connection = conn;

            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = dm.TenDM;          
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}