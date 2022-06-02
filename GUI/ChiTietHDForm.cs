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
    public partial class ChiTietHDForm : Form
    {
        public ChiTietHDForm()
        {
            InitializeComponent();
        }

        private void loadListViewCT()
        {
            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            List<ChiTietHD> DSCT = chiTietHDBLL.getAllCT();

            lvChiTiet.Items.Clear();

            foreach (ChiTietHD ct in DSCT)
            {
                ListViewItem lvi = new ListViewItem(ct.MaHD + "");

                lvi.SubItems.Add(ct.MaSP + "");
                lvi.SubItems.Add(ct.SoLuong + "");
                lvChiTiet.Items.Add(lvi);

                lvi.Tag = ct;
            }
        }
        private void ChiTietHDForm_Load(object sender, EventArgs e)
        {
            loadListViewCT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChiTietHD ct = new ChiTietHD();

            ct.MaHD = int.Parse(txtMaHD.Text);
            ct.MaSP = int.Parse(txtMaSP.Text);
            ct.SoLuong = int.Parse(txtSoLuong.Text);

            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            bool kq = chiTietHDBLL.addCT_Object(ct);

            if (kq)
            {
                loadListViewCT();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvChiTiet.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvChiTiet.SelectedItems[0];
                ChiTietHD ct = lvi.Tag as ChiTietHD;
                ChiTietHDBLL ctbll = new ChiTietHDBLL();

                bool kq = ctbll.deleteAt(ct.MaHD, ct.MaSP);

                if (kq)
                {
                    loadListViewCT();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChiTietHD ct = new ChiTietHD();

            ct.MaHD = int.Parse(txtMaHD.Text);
            ct.MaSP = int.Parse(txtMaSP.Text);
            ct.SoLuong = int.Parse(txtSoLuong.Text);

            ChiTietHDBLL chiTietHDBLL = new ChiTietHDBLL();
            bool kq = chiTietHDBLL.changeCT_At_Object(ct, ct.MaHD, ct.MaSP);

            if (kq)
            {
                loadListViewCT();
            }
        }

        private void lvChiTiet_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvChiTiet.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvChiTiet.SelectedItems[0];
                ChiTietHD ct = lvi.Tag as ChiTietHD;

                txtMaHD.Text = ct.MaHD.ToString();
                txtMaSP.Text = ct.MaSP.ToString();
                txtSoLuong.Text = ct.SoLuong.ToString();
            }
        }
    }
}
