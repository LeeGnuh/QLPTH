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
    public partial class Sanpham : Page
    {
        List<SanPham> list = new List<SanPham>();
        SanPhamBLL sp = new SanPhamBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrv();
            
        }

        protected void Grsanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = Grsanpham.SelectedRow.Cells[1].Text;  
            TextBox1.Text=maSP;
            TextBox2.Text = Grsanpham.SelectedRow.Cells[2].Text;
            TextBox3.Text = Grsanpham.SelectedRow.Cells[3].Text;
            TextBox4.Text = Grsanpham.SelectedRow.Cells[4].Text;
        }
        public void LoadGrv()
        {
            list.Clear();
            list = sp.getAllSP();
            Grsanpham.DataSource = list;
            Grsanpham.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.MaSP = int.Parse(TextBox1.Text);
            sanPham.TenSP = TextBox2.Text;
            sanPham.GiaSP = int.Parse(TextBox3.Text);
            sanPham.MaDM = int.Parse(TextBox4.Text);
            sp.addSP_Object(sanPham);
            LoadGrv();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.MaSP = int.Parse(TextBox1.Text);
            sanPham.TenSP = TextBox2.Text;
            sanPham.GiaSP = int.Parse(TextBox3.Text);
            sanPham.MaDM = int.Parse(TextBox4.Text);
            sp.changeSP_At_Object(sanPham, sanPham.MaSP);
            LoadGrv() ;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            sp.deleteAt(int.Parse(TextBox1.Text));
            LoadGrv();
        }
    }

}