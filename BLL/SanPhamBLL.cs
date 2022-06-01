using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL sanPhamDAL = new SanPhamDAL();
        public List<SanPham> getAllSP()
        {
            return sanPhamDAL.getAllSP();
        }
        public bool deleteAt(int maSP)
        {
            ChiTietHDDAL chiTietHDDAL = new ChiTietHDDAL();
            chiTietHDDAL.deleteAtSP(maSP);

            return sanPhamDAL.deleteAt(maSP);
        }        
        public bool addSP_Object(SanPham sp)
        {
            if (sp.TenSP.Length == 0)
            {
                return false;
            }            
            return sanPhamDAL.addSP_Object(sp);
        }
        public bool changeSP_At_Object(SanPham sp, int id)
        {
            if (sp.TenSP.Length == 0)
            { 
                return false; 
            }
            return sanPhamDAL.changeSP_At_Object(sp, id);
        }
    }
}