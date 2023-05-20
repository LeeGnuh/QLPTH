using BLL;
using DALEntity;
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
    public partial class StatusForm : Form
    {

        public int id;

        public StatusForm()
        {
            InitializeComponent();
        }
        private void loadListViewStatus()
        {
            StatusBLL statusBLL = new StatusBLL();
            List<status> ListStatus = statusBLL.getAllStt_Of_Comp(id);

            lvStatus.Items.Clear();

            foreach (status stt in ListStatus)
            {
                ListViewItem lvi = new ListViewItem(stt.id_status + "");

                lvi.SubItems.Add(stt.time + "");
                lvi.SubItems.Add(stt.lesson + "");
                lvi.SubItems.Add(stt.id_comp + "");
                lvi.SubItems.Add(stt.detail + "");

                lvStatus.Items.Add(lvi);

                lvi.Tag = stt;
            }
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPTHDataSet2.computer' table. You can move, or remove it, as needed.
            this.computerTableAdapter.Fill(this.qLPTHDataSet2.computer);
            loadListViewStatus();
            cb_id_comp.SelectedValue = id.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            status stt = new status();

            stt.time = DateTime.Parse(dtp_time.Value.ToString());
            stt.lesson = int.Parse(txt_lession.Text);
            stt.id_comp = int.Parse(cb_id_comp.SelectedValue.ToString());
            stt.detail = txt_detail.Text;

            StatusBLL statusBLL = new StatusBLL();
            bool kq = statusBLL.addStt_Object(stt);

            if (kq)
            {
                loadListViewStatus();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            status stt = new status();

            stt.id_status = int.Parse(txt_id_status.Text);
            stt.time = DateTime.Parse(dtp_time.Value.ToString());
            stt.lesson = int.Parse(txt_lession.Text);
            stt.id_comp = int.Parse(cb_id_comp.SelectedValue.ToString());
            stt.detail = txt_detail.Text;

            StatusBLL statusBLL = new StatusBLL();
            bool kq = statusBLL.changeStt_At_Object(stt.id_status, stt);

            if (kq)
            {
                loadListViewStatus();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvStatus.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvStatus.SelectedItems[0];
                status status = lvi.Tag as status;
                StatusBLL statusBLL = new StatusBLL();

                bool kq = statusBLL.deleteAt(status.id_status);

                if (kq)
                {
                    loadListViewStatus();
                }
            }
        }

        private void lvStatus_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvStatus.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvStatus.SelectedItems[0];
                status status = lvi.Tag as status;

                txt_id_status.Text = status.id_status.ToString();
                dtp_time.Value = (DateTime)status.time;
                txt_lession.Text = status.lesson.ToString();
                cb_id_comp.SelectedValue = status.id_comp.ToString();
                txt_detail.Text = status.detail;
            }
        }
    }
}
