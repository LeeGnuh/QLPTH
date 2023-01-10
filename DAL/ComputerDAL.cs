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
    public class ComputerDAL : DataAccessDAL
    {
        List<Computer> ListComputer = new List<Computer>();
        public List<Computer> getAllComp_InRoom(int id_room)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Computer where id_room = @id order by comp_name";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id_room;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Computer computer = new Computer();

                computer.id_comp = reader.GetInt32(0);
                computer.id_room = reader.GetInt32(1);
                computer.comp_name = reader.GetString(2);
                computer.present_status = reader.GetBoolean(3);

                ListComputer.Add(computer);
            }
            reader.Close();
            return ListComputer;
        }
        public List<Computer> select_name(int id, string name)
        {
            List<Computer> list = new List<Computer>();

            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Computer Where comp_name like @name and id_room = @id";
            command.Connection = conn;

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = id;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Computer computer = new Computer();

                computer.id_comp = reader.GetInt32(0);
                computer.id_room = reader.GetInt32(1);
                computer.comp_name = reader.GetString(2);
                computer.present_status = reader.GetBoolean(3);

                list.Add(computer);
            }
            reader.Close();
            return list;
        }

        public bool deleteAt(int id)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "delete from Computer where id_comp = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addComputer_Object(Computer computer)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into computer Values(@idR,@Cname,@status)";
            command.Connection = conn;

            command.Parameters.Add("@idR", SqlDbType.Int).Value = computer.id_room;
            command.Parameters.Add("@Cname", SqlDbType.VarChar).Value = computer.comp_name;
            command.Parameters.Add("@status", SqlDbType.Bit).Value = computer.present_status;

            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeComputer_At_Object(int id, Computer computer)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE Computer SET id_room = @idR, comp_name = @Cname, present_status = @status WHERE id_comp = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idR", SqlDbType.Int).Value = computer.id_room;
            command.Parameters.Add("@Cname", SqlDbType.VarChar).Value = computer.comp_name;
            command.Parameters.Add("@status", SqlDbType.Bit).Value = computer.present_status;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}