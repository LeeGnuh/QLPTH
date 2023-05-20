using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity
{
    public class StatusDAL
    {
        QLPTHEntities db = new QLPTHEntities();
        List<status> ListStatus = new List<status>();
        public List<status> getAllStt_Of_Comp(int id_comp)
        {
            var result = from s in db.status where s.id_comp == id_comp select s;
            ListStatus = result.ToList();
            return ListStatus;
        }
        public List<status> select_id(int id)
        {
            var result = from s in db.status where s.id_status == id select s;
            ListStatus = result.ToList();
            return ListStatus;
        }
        public bool deleteAt(int id)
        {
            status s = db.status.Find(id);
            if (s != null) { db.status.Remove(s); db.SaveChanges(); }
            return s != null;
        }
        public bool addStt_Object(status stt)
        {
            db.status.Add(stt);
            db.SaveChanges();
            return stt != null;
        }
        public bool changeStt_At_Object(int id, status stt)
        {
            status s = db.status.Find(id);
            if (s != null)
            {
                s.id_status = stt.id_status;
                s.time = stt.time;
                s.lesson = stt.lesson;
                s.id_comp = stt.id_comp;
                s.detail = stt.detail;
                db.SaveChanges();
            }
            return s != null;
        }
    }
}
