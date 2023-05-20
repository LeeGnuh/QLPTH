using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity
{
    public class RoomDAL
    {
        QLPTHEntities db = new QLPTHEntities();
        List<room> ListRoom = new List<room>();
        public List<room> getAllRoom()
        {
            var result = from r in db.rooms select r;
            ListRoom = result.ToList();
            return ListRoom;
        }
        public List<room> select_name(string name)
        {
            var result = from r in db.rooms where r.room_name == name   select r;
            ListRoom = result.ToList();
            return (ListRoom.Count > 0) ? ListRoom : null;
        }
        public bool deleteAt(int id)
        {
            room r = db.rooms.Find(id);
            if (r != null) { db.rooms.Remove(r); db.SaveChanges(); }
            return r != null;
        }
        public bool addRoom_Object(room room)
        {
            db.rooms.Add(room);
            db.SaveChanges();
            return room != null;
        }
        public bool changeRoom_At_Object(int id, room room)
        {
            room r = db.rooms.Find(id);
            if (r != null) 
            { 
                r.room_name = room.room_name;
                r.floor = room.floor;
                r.building = room.building;
                db.SaveChanges(); 
            }
            return r != null;
        }
    }
}
