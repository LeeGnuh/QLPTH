using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietHDBLL
    {
        ChiTietHDDAL chiTietHDDAL = new ChiTietHDDAL();
        public List<ChiTietHD> getAllCT()
        {
            return chiTietHDDAL.getAllCT();
        }
        public bool deleteAt(int maHD, int maSP)
        {
            return chiTietHDDAL.deleteAt(maHD, maSP);
        }
        public bool addCT_Object(ChiTietHD ct)
        {
            if (ct.SoLuong <= 0)
            {
                return false;
            }
            return chiTietHDDAL.addCT_Object(ct);
        }
        public bool changeCT_At_Object(ChiTietHD ct, int maHD, int maSP)
        {
            if (ct.SoLuong <= 0)
            {
                return false;
            }
            return chiTietHDDAL.changeCT_At_Object(ct, maHD, maSP);
        }
    }
}
