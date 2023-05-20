using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StatusDAL : DataAccessDAL
    {        
        List<Status> ListStatus = new List<Status>();
        public List<Status> getAllStt_Of_Comp(int id)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Status where id_comp = @id order by time, lesson";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Status stt = new Status();

                stt.id_status = reader.GetInt32(0);
                stt.time = reader.GetDateTime(1);
                stt.lesson = reader.GetInt32(2);
                stt.id_comp = reader.GetInt32(3);
                stt.detail = reader.GetString(4);

                ListStatus.Add(stt);
            }
            reader.Close();
            return ListStatus;
        }
        public List<Status> select_id(int id)
        {
            List<Status> list = new List<Status>();

            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Status Where id_status = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Status stt = new Status();

                stt.id_status = reader.GetInt32(0);
                stt.time = reader.GetDateTime(1);
                stt.lesson = reader.GetInt32(2);
                stt.id_comp = reader.GetInt32(3);
                stt.detail = reader.GetString(4);

                list.Add(stt);
            }
            reader.Close();
            return list;
        }

        public bool deleteAt(int id)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from Status where id_status = @id";
            commnand.Connection = conn;

            commnand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addStt_Object(Status stt)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Status Values(@time,@lesson,@id_comp,@detail)";
            command.Connection = conn;

            command.Parameters.Add("@time", SqlDbType.Date).Value = stt.time;
            command.Parameters.Add("@lesson", SqlDbType.Int).Value = stt.lesson;
            command.Parameters.Add("@id_comp", SqlDbType.Int).Value = stt.id_comp;
            command.Parameters.Add("@detail", SqlDbType.NVarChar).Value = stt.detail;

            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeStt_At_Object(int id, Status stt)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE Status SET time = @time, lesson = @lesson, id_comp = @id_comp, detail = @detail WHERE id_status = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@time", SqlDbType.Date).Value = stt.time;
            command.Parameters.Add("@lesson", SqlDbType.Int).Value = stt.lesson;
            command.Parameters.Add("@id_comp", SqlDbType.Int).Value = stt.id_comp;
            command.Parameters.Add("@detail", SqlDbType.NVarChar).Value = stt.detail;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}