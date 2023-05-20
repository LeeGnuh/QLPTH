using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity
{
    public class ScheduceDAL
    {
        QLPTHEntities db = new QLPTHEntities();
        List<schedule_detail> ListSch = new List<schedule_detail>();
        public List<schedule_detail> getAllSch()
        {
            var result = from sch in db.schedule_detail select sch;
            ListSch = result.ToList();
            return ListSch;
        }
        public List<schedule_detail> select_id(int id)
        {
            var result = from sch in db.schedule_detail where sch.id == id select sch;
            ListSch = result.ToList();
            return (ListSch.Count > 0) ? ListSch : null;
        }
        public bool deleteAt(int id)
        {
            schedule_detail sch = db.schedule_detail.Find(id);
            if (sch != null) { db.schedule_detail.Remove(sch); db.SaveChanges(); }
            return sch != null;
        }
        public bool addSch_Object(schedule_detail sch)
        {
            db.schedule_detail.Add(sch);
            db.SaveChanges();
            return sch != null;
        }
        public bool changeSch_At_Object(int id, schedule_detail scheduce)
        {
            schedule_detail sch = db.schedule_detail.Find(id);
            if (sch != null)
            {
                sch.id = scheduce.id;
                sch.id_tea = scheduce.id_tea;
                sch.id_room = scheduce.id_room;
                sch.time = scheduce.time;
                sch.lesson = scheduce.lesson;
                sch.num_of_less = scheduce.num_of_less;
                db.SaveChanges();
            }
            return sch != null;
        }
    }
}
