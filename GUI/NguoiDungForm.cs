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
    public partial class NguoiDungForm : Form
    {
        public NguoiDungForm()
        {
            InitializeComponent();
        }
        private void loadListViewND()
        {
            NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
            List<NguoiDung> DSND = nguoiDungBLL.getAllND();

            lvNguoiDung.Items.Clear();

            foreach (NguoiDung nd in DSND)
            {
                ListViewItem lvi = new ListViewItem(nd.MaND + "");

                lvi.SubItems.Add(nd.TenND);
                lvi.SubItems.Add(nd.Uname + "");
                lvi.SubItems.Add(nd.UPass + "");
                lvNguoiDung.Items.Add(lvi);

                lvi.Tag = nd;
            }
        }   
        private void NguoiDungForm_Load(object sender, EventArgs e)
        {
            loadListViewND();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();

            nd.MaND = int.Parse(txtMaND.Text);
            nd.TenND = txtTenND.Text;
            nd.Uname = txtUname.Text;
            nd.UPass = txtUpass.Text;

            NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
            bool kq = nguoiDungBLL.addND_Object(nd);

            if (kq)
            {
                loadListViewND();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvNguoiDung.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvNguoiDung.SelectedItems[0];
                NguoiDung nd = lvi.Tag as NguoiDung;
                NguoiDungBLL ndbll = new NguoiDungBLL();

                bool kq = ndbll.deleteAt(nd.MaND);

                if (kq)
                {
                    loadListViewND();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung();

            nd.MaND = int.Parse(txtMaND.Text);
            nd.TenND = txtTenND.Text;
            nd.Uname = txtUname.Text;
            nd.UPass = txtUpass.Text;

            NguoiDungBLL nguoiDungBLL = new NguoiDungBLL();
            bool kq = nguoiDungBLL.changeND_At_Object(nd, nd.MaND);

            if (kq)
            {
                loadListViewND();
            }
        }

        private void lvNguoiDung_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvNguoiDung.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvNguoiDung.SelectedItems[0];
                NguoiDung nd = lvi.Tag as NguoiDung;

                txtMaND.Text = nd.MaND.ToString();
                txtTenND.Text = nd.TenND.ToString();
                txtUname.Text = nd.Uname.ToString();
                txtUpass.Text = nd.UPass.ToString();
            }
        }
    }
}
