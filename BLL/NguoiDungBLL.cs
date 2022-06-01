using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class NguoiDungBLL
    {
        NguoiDungDAL nguoiDungDAL = new NguoiDungDAL();
        public List<NguoiDung> getAllND()
        {
            return nguoiDungDAL.getAllND();
        }
        public bool deleteAt(int maND)
        {
            HoaDonDAL hoaDonDAL = new HoaDonDAL();
            hoaDonDAL.deleteAtND(maND);

            return nguoiDungDAL.deleteAt(maND);
        }
        public bool addND_Object(NguoiDung nd)
        {
            if (nd.TenND.Length == 0)
            {
                return false;
            }
            return nguoiDungDAL.addND_Object(nd);
        }
        public bool changeND_At_Object(NguoiDung nd, int id)
        {
            if (nd.TenND.Length == 0)
            {
                return false;
            }
            return nguoiDungDAL.changeND_At_Object(nd, id);
        }
    }
}
