using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    internal class HoaDonBLL
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();
        public List<HoaDon> getAllHD()
        {
            return hoaDonDAL.getAllHD();
        }
        public bool deleteAt(int maHD)
        {
            ChiTietHDDAL chiTietHDDAL = new ChiTietHDDAL();
            chiTietHDDAL.deleteAtHD(maHD);

            return hoaDonDAL.deleteAt(maHD);
        }
        public bool addHD_Object(HoaDon hd)
        {
            if (hd.NgayTao.Length == 0)
            {
                return false;
            }
            return hoaDonDAL.addHD_Object(hd);
        }
        public bool changeHD_At_Object(HoaDon hd, int maHD)
        {
            if (hd.NgayTao.Length == 0)
            {
                return false;
            }
            return hoaDonDAL.changeHD_At_Object(hd, maHD);
        }
    }
}
