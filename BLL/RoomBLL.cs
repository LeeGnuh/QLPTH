using DTO;
using DALEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoomBLL
    {
        RoomDAL roomDAL = new RoomDAL();
        public List<room> getAllRoom()
        {
            return roomDAL.getAllRoom();
        }

        public bool deleteAt(int id)
        {
            return roomDAL.deleteAt(id);
        }
        public bool addRoom_Object(room room)
        {
            if (roomDAL.select_name(room.room_name) == null)
            return roomDAL.addRoom_Object(room);
            return false;
        }
        public bool changeRoom_At_Object(int id, room room)
        {
            if (roomDAL.select_name(room.room_name) == null)
            return roomDAL.changeRoom_At_Object(id, room);
            return false;
        }
        public List<room> searchRoom_Name(string name)
        {
            return roomDAL.select_name(name);
        }
    }
}
