using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            DanhMucForm danhMucForm = new DanhMucForm();
            danhMucForm.ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            SanPhamForm sanPhamForm = new SanPhamForm();
            sanPhamForm.ShowDialog();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            NguoiDungForm nguoiDungForm = new NguoiDungForm();
            nguoiDungForm.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonForm hoaDonForm = new HoaDonForm();
            hoaDonForm.ShowDialog();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            ChiTietHDForm chiTietHDForm = new ChiTietHDForm();
            chiTietHDForm.ShowDialog();
        }
    }
}
