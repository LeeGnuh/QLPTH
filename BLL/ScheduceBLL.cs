using DALEntity;
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
        public List<schedule_detail> getAllSch()
        {
            return ScheduceDAL.getAllSch();
        }
        public bool deleteAt(int id)
        {
            return ScheduceDAL.deleteAt(id);
        }
        public bool addSch_Object(schedule_detail Sch)
        {
            return ScheduceDAL.addSch_Object(Sch);
        }
        public bool changeSch_At_Object(int id, schedule_detail Sch)
        {
            return ScheduceDAL.changeSch_At_Object(id, Sch);
        }
    }
}
