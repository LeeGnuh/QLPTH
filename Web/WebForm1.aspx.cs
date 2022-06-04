using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<SanPham> list = new List<SanPham>();
            SanPhamDAL sp = new SanPhamDAL();
            list = sp.getAllSP();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}