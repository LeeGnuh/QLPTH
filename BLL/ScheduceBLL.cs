using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ScheduceBLL
    {
        ScheduceDAL ScheduceDAL = new ScheduceDAL();
        public List<Scheduce> getAllSch()
        {
            return ScheduceDAL.getAllSch();
        }
        public bool deleteAt(int id)
        {
            return ScheduceDAL.deleteAt(id);
        }
        public bool addSch_Object(Scheduce Sch)
        {
            return ScheduceDAL.addSch_Object(Sch);
        }
        public bool changeSch_At_Object(int id, Scheduce Sch)
        {
            return ScheduceDAL.changeSch_At_Object(id, Sch);
        }
    }
}
