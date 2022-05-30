using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadListViewSP();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();

            sp.MaSP = int.Parse(txtMa.Text);
            sp.TenSP = txtTen.Text;
            sp.GiaSP = int.Parse(txtGia.Text);
            sp.MaDM = int.Parse(MaDM.Text);

            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            bool kq = sanPhamBLL.addSP_Object(sp);

            if (kq)
            {
                loadListViewSP();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                SanPham sp = lvi.Tag as SanPham;
                SanPhamBLL spbll = new SanPhamBLL();

                bool kq = spbll.deleteAt(sp.MaSP);

                if (kq)
                { 
                    loadListViewSP();
                }
            }
        }
        private void loadListViewSP()
        {
            SanPhamBLL sanPhamBLL = new SanPhamBLL();
            List<SanPham> DSSP = sanPhamBLL.getAllSP();

            lvSanPham.Items.Clear();

            foreach (SanPham sp in DSSP)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSP + "");

                lvi.SubItems.Add(sp.TenSP);
                lvi.SubItems.Add(sp.GiaSP + "");
                lvi.SubItems.Add(sp.MaDM + "");
                lvSanPham.Items.Add(lvi);

                lvi.Tag = sp;
            }
        }
    }
}
