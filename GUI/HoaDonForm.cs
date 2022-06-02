using BLL;
using DTO;
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
    public partial class HoaDonForm : Form
    {
        public HoaDonForm()
        {
            InitializeComponent();
        }

        private void loadListViewHD()
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            List<HoaDon> DSHD = hoaDonBLL.getAllHD();

            lvHoaDon.Items.Clear();

            foreach (HoaDon hd in DSHD)
            {
                ListViewItem lvi = new ListViewItem(hd.MaHD + "");

                lvi.SubItems.Add(hd.MaND + "");
                lvi.SubItems.Add(hd.NgayTao + "");
                lvHoaDon.Items.Add(lvi);

                lvi.Tag = hd;
            }
        }
        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            loadListViewHD();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();

            hd.MaHD = int.Parse(txtMaHD.Text);
            hd.MaND = int.Parse(txtMaND.Text);
            hd.NgayTao = txtNgayTao.Text;

            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            bool kq = hoaDonBLL.addHD_Object(hd);

            if (kq)
            {
                loadListViewHD();
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvHoaDon.SelectedItems[0];
                HoaDon hd = lvi.Tag as HoaDon;
                HoaDonBLL hdbll = new HoaDonBLL();

                bool kq = hdbll.deleteAt(hd.MaHD);

                if (kq)
                {
                    loadListViewHD();
                }
            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();

            hd.MaHD = int.Parse(txtMaHD.Text);
            hd.MaND = int.Parse(txtMaND.Text);
            hd.NgayTao = txtNgayTao.Text;

            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            bool kq = hoaDonBLL.changeHD_At_Object(hd, hd.MaHD);

            if (kq)
            {
                loadListViewHD();
            }
        }
        private void lvHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvHoaDon.SelectedItems[0];
                HoaDon hd = lvi.Tag as HoaDon;

                txtMaHD.Text = hd.MaHD.ToString();
                txtMaND.Text = hd.MaND.ToString();
                txtNgayTao.Text = hd.NgayTao.ToString();
            }
        }        
    }
}
