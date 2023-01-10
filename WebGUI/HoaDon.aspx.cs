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
    public partial class Hoadon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<DTO.HoaDon> list = new List<DTO.HoaDon>();
            HoaDonBLL sp = new HoaDonBLL();
            list = sp.getAllHD();
            Grhoadon.DataSource = list;
            Grhoadon.DataBind();
        }
    }
}