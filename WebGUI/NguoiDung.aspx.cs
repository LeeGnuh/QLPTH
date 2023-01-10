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
    public partial class Nguoidung : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<NguoiDung> list = new List<NguoiDung>();
            NguoiDungBLL sp = new NguoiDungBLL();
            list = sp.getAllND();
            Grnguoidung.DataSource = list;
            Grnguoidung.DataBind();
        }
    }
}