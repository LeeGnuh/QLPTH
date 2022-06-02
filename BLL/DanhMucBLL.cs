using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DanhMucBLL
    {
        DanhMucDAL danhMucDAL = new DanhMucDAL();
        public List<DanhMuc> getAllDM()
        {
            return danhMucDAL.getAllDM();
        }
        public bool deleteAt(int maDM)
        {
            ChiTietHDDAL chiTietHDDAL = new ChiTietHDDAL();
            SanPhamDAL sanPhamDAL = new SanPhamDAL();

            chiTietHDDAL.deleteAtSP(sanPhamDAL.select_MaDM(maDM));
            sanPhamDAL.deleteAtDM(maDM);

            return danhMucDAL.deleteAt(maDM);
        }
        public bool addDM_Object(DanhMuc dm)
        {
            if (dm.TenDM.Length == 0)
            {
                return false;
            }
            return danhMucDAL.addDM_Object(dm);
        }
        public bool changeDM_At_Object(DanhMuc dm, int id)
        {
            if (dm.TenDM.Length == 0)
            {
                return false;
            }
            return danhMucDAL.changeDM_At_Object(dm, id);
        }
    }
}
