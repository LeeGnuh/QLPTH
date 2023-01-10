using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StatusBLL
    {
        StatusDAL statusDAL = new StatusDAL();
        public List<Status> getAllStt_Of_Comp(int id)
        {
            return statusDAL.getAllStt_Of_Comp(id);
        }
        public bool deleteAt(int id)
        {
            return statusDAL.deleteAt(id);
        }
        public bool addStt_Object(Status Stt)
        {
            return statusDAL.addStt_Object(Stt);
        }
        public bool changeStt_At_Object(int id, Status Stt)
        {
            return statusDAL.changeStt_At_Object(id, Stt);
        }
    }
}
