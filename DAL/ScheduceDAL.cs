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
    public class ScheduceDAL : DataAccessDAL
    {
        List<Scheduce> ListSch = new List<Scheduce>();
        public List<Scheduce> getAllSch()
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from schedule_detail";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Scheduce sch = new Scheduce();

                sch.id = reader.GetInt32(0);
                sch.id_tea = reader.GetString(1);
                sch.id_subj = reader.GetInt32(2);
                sch.id_room = reader.GetInt32(3);
                sch.time = reader.GetDateTime(4);
                sch.lesson = reader.GetInt32(5);
                sch.num_of_less = reader.GetInt32(6);

                ListSch.Add(sch);
            }
            reader.Close();
            return ListSch;
        }
        public List<Scheduce> select_id(int id)
        {
            List<Scheduce> list = new List<Scheduce>();

            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from schedule_detail Where id = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Scheduce sch = new Scheduce();

                sch.id = reader.GetInt32(0);
                sch.id_tea = reader.GetString(1);
                sch.id_subj = reader.GetInt32(2);
                sch.id_room = reader.GetInt32(3);
                sch.time = reader.GetDateTime(4);
                sch.lesson = reader.GetInt32(5);
                sch.num_of_less = reader.GetInt32(6);

                list.Add(sch);
            }
            reader.Close();
            return list;
        }

        public bool deleteAt(int id)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from schedule_detail where id = @id";
            commnand.Connection = conn;

            commnand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addSch_Object(Scheduce sch)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into schedule_detail Values(@id_tea,@id_subj,@id_room,@time,@lesson,@num_of_less)";
            command.Connection = conn;

            command.Parameters.Add("@id_tea", SqlDbType.VarChar).Value = sch.id_tea;
            command.Parameters.Add("@id_subj", SqlDbType.Int).Value = sch.id_subj;
            command.Parameters.Add("@id_room", SqlDbType.Int).Value = sch.id_room;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = sch.time;
            command.Parameters.Add("@lesson", SqlDbType.Int).Value = sch.lesson;
            command.Parameters.Add("@num_of_less", SqlDbType.Int).Value = sch.num_of_less;

            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeSch_At_Object(int id, Scheduce sch)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE schedule_detail SET id_tea = @id_tea, id_subj = @id_subj, id_room = @id_room, time = @time, lesson = @lesson, num_of_less = @num_of_less WHERE id = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@id_tea", SqlDbType.VarChar).Value = sch.id_tea;
            command.Parameters.Add("@id_subj", SqlDbType.Int).Value = sch.id_subj;
            command.Parameters.Add("@id_room", SqlDbType.Int).Value = sch.id_room;
            command.Parameters.Add("@time", SqlDbType.DateTime).Value = sch.time;
            command.Parameters.Add("@lesson", SqlDbType.Int).Value = sch.lesson;
            command.Parameters.Add("@num_of_less", SqlDbType.Int).Value = sch.num_of_less;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}
