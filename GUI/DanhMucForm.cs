using System;
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
    public partial class DanhMucForm : Form
    {
        public DanhMucForm()
        {
            InitializeComponent();
        }

        private void loadListViewDM()
        {
            DanhMucBLL danhMucBLL = new DanhMucBLL();
            List<DanhMuc> DSDM = danhMucBLL.getAllDM();

            lvDanhMuc.Items.Clear();

            foreach (DanhMuc dm in DSDM)
            {
                ListViewItem lvi = new ListViewItem(dm.MaDM + "");

                lvi.SubItems.Add(dm.TenDM + "");
                lvDanhMuc.Items.Add(lvi);

                lvi.Tag = dm;
            }
        }

        private void DanhMucForm_Load(object sender, EventArgs e)
        {
            loadListViewDM();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();

            dm.MaDM = int.Parse(txtMaDM.Text);
            dm.TenDM = txtTenDM.Text;

            DanhMucBLL danhMucBLL = new DanhMucBLL();
            bool kq = danhMucBLL.addDM_Object(dm);

            if (kq)
            {
                loadListViewDM();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvDanhMuc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhMuc.SelectedItems[0];
                DanhMuc dm = lvi.Tag as DanhMuc;
                DanhMucBLL dmbll = new DanhMucBLL();

                bool kq = dmbll.deleteAt(dm.MaDM);

                if (kq)
                {
                    loadListViewDM();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();

            dm.MaDM = int.Parse(txtMaDM.Text);
            dm.TenDM = txtTenDM.Text;

            DanhMucBLL danhMucBLL = new DanhMucBLL();
            bool kq = danhMucBLL.changeDM_At_Object(dm, dm.MaDM);

            if (kq)
            {
                loadListViewDM();
            }
        }

        private void lvDanhMuc_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvDanhMuc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvDanhMuc.SelectedItems[0];
                DanhMuc dm = lvi.Tag as DanhMuc;

                txtMaDM.Text = dm.MaDM.ToString();
                txtTenDM.Text = dm.TenDM.ToString();
            }
        }
    }
}
