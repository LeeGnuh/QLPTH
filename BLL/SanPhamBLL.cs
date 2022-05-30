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
        public bool deleteAt(int ma)
        {
            return sanPhamDAL.deleteAt(ma);
        }        
        public bool addSP_Object(SanPham sp)
        {
            if (sp.TenSP.Length == 0)
            {
                return false;
            }            
            return sanPhamDAL.addSP_Object(sp);
        }
    }
}