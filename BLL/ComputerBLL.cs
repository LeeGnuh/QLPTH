using DALEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ComputerBLL
    {
        public int id; 
        ComputerDAL computerDAL = new ComputerDAL();
        public List<computer> getAllComp_InRoom(int id)
        {
            return computerDAL.getAllComp_InRoom(id);
        }
        public bool deleteAt(int id)
        {
            return computerDAL.deleteAt(id);
        }
        public bool addComputer_Object(computer computer)
        {
            if (computerDAL.select_name(id, computer.comp_name).Count == 0)
            return computerDAL.addComputer_Object(computer);
            return false;
        }
        public bool changeComputer_At_Object(int id, computer computer)
        {
            if (computerDAL.select_name(this.id, computer.comp_name).Count == 0)
            return computerDAL.changeComputer_At_Object(id, computer);
            return false;
        }
        public List<computer> searchComputer_Name_In_Room(int id, string name)
        {
            return computerDAL.select_name(id, name);
        }
    }
}
