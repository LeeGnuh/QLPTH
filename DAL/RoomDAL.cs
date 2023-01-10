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
    public class RoomDAL:DataAccessDAL
    {
        List<Room> ListRoom = new List<Room>();
        public List<Room> getAllRoom()
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Room order by room_name";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Room room = new Room();

                room.id_room = reader.GetInt32(0);
                room.room_name = reader.GetString(1);
                room.building = reader.GetString(2);
                room.floor = reader.GetString(3);
                
                ListRoom.Add(room);
            }
            reader.Close();
            return ListRoom;
        }
        public List<Room> select_name(string name)
        {
            List<Room> list = new List<Room>();

            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "select * from Room Where room_name like @name order by room_name";
            command.Connection = conn;

            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Room room = new Room();

                room.id_room = reader.GetInt32(0);
                room.room_name = reader.GetString(1);
                room.building = reader.GetString(2);
                room.floor = reader.GetString(3);
             
                list.Add(room);
            }
            reader.Close();
            return list;
        }

        public bool deleteAt(int id)
        {
            openConn();

            SqlCommand commnand = new SqlCommand();
            commnand.CommandType = CommandType.Text;

            commnand.CommandText = "delete from Room where id_room = @id";
            commnand.Connection = conn;

            commnand.Parameters.Add("@id", SqlDbType.Int).Value = id;

            int kq = commnand.ExecuteNonQuery();

            return kq > 0;
        }

        public bool addRoom_Object(Room room)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Room Values(@Rname,@building,@floor)";
            command.Connection = conn;

            command.Parameters.Add("@Rname", SqlDbType.VarChar).Value = room.room_name;
            command.Parameters.Add("@building", SqlDbType.VarChar).Value = room.building;
            command.Parameters.Add("@floor", SqlDbType.Int).Value = room.floor;
            
            int kq = command.ExecuteNonQuery();

            return kq > 0;

        }
        public bool changeRoom_At_Object(int id, Room room)
        {
            openConn();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "UPDATE Room SET room_name = @Rname, building = @building, floor = @floor WHERE id_room = @id";
            command.Connection = conn;

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Rname", SqlDbType.VarChar).Value = room.room_name;
            command.Parameters.Add("@building", SqlDbType.VarChar).Value = room.building;
            command.Parameters.Add("@floor", SqlDbType.VarChar).Value = room.floor;

            int kq = command.ExecuteNonQuery();

            return kq > 0;
        }
    }
}
