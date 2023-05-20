using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity
{
    public class ComputerDAL
    {
        QLPTHEntities db = new QLPTHEntities();
        List <computer> ListComputer = new List<computer>();
        public List<computer> getAllComp_InRoom(int id_room)
        {
            var result = from c in db.computers where c.id_room == id_room select c;
            ListComputer = result.ToList();
            return ListComputer;
        }
        public List<computer> select_name(int id, string name)
        {
            var result = from c in db.computers where c.id_room == id && c.comp_name == name select c;
            ListComputer = result.ToList();
            return ListComputer;
        }
        public bool deleteAt(int id)
        {
            computer c = db.computers.Find(id);
            if (c != null) { db.computers.Remove(c); db.SaveChanges(); }
            return c != null;
        }
        public bool addComputer_Object(computer computer)
        {
            db.computers.Add(computer);
            db.SaveChanges();
            return computer != null;
        }
        public bool changeComputer_At_Object(int id, computer computer)
        {
            computer c = db.computers.Find(id);
            if (c != null)
            {
                c.id_comp = computer.id_comp;
                c.id_room = computer.id_room;
                c.comp_name = computer.comp_name;
                c.present_status = computer.present_status;
                db.SaveChanges();
            }
            return c != null;
        }
    }
}
