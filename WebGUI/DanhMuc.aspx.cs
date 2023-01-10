using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;

namespace WebGUI
{
    public partial class Danhmuc : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DanhMuc> list = new List<DanhMuc>();
            DanhMucBLL sp = new DanhMucBLL();
            list = sp.getAllDM();
            Grdanhmuc.DataSource = list;
            Grdanhmuc.DataBind();
        }
        protected void btnAdd_Click1(object sender, EventArgs e)
        {

        }

        
    }
}