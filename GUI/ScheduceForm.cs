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
    public partial class ScheduceForm : Form
    {
        private void loadListViewScheduce()
        {
            ScheduceBLL ScheduceBLL = new ScheduceBLL();
            List<schedule_detail> ListScheduce = ScheduceBLL.getAllSch();

            lvScheduce.Items.Clear();

            foreach (schedule_detail sch in ListScheduce)
            {
                ListViewItem lvi = new ListViewItem(sch.id + "");

                lvi.SubItems.Add(sch.id_tea + "");
                lvi.SubItems.Add(sch.id_subj + "");
                lvi.SubItems.Add(sch.id_room + "");
                lvi.SubItems.Add(sch.time + "");
                lvi.SubItems.Add(sch.lesson + "");
                lvi.SubItems.Add(sch.num_of_less + "");

                lvScheduce.Items.Add(lvi);

                lvi.Tag = sch;
            }
        }
        public ScheduceForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            schedule_detail sch = new schedule_detail();

            sch.id_tea =  cb_id_tea.SelectedValue.ToString();
            sch.id_subj = int.Parse(cb_id_subj.SelectedValue.ToString());
            sch.id_room = int.Parse(cb_id_room.SelectedValue.ToString());
            sch.time = DateTime.Parse(dtp_time.Value.ToString());
            sch.lesson = int.Parse(txt_lesson.Text);
            sch.num_of_less = int.Parse(txt_num_of_less.Text);

            ScheduceBLL ScheduceBLL = new ScheduceBLL();
            bool kq = ScheduceBLL.addSch_Object(sch);

            if (kq)
            {
                loadListViewScheduce();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            schedule_detail sch = new schedule_detail();

            sch.id = int.Parse(txt_id.Text);
            sch.id_tea = cb_id_tea.SelectedValue.ToString();
            sch.id_subj = int.Parse(cb_id_subj.SelectedValue.ToString());
            sch.id_room = int.Parse(cb_id_room.SelectedValue.ToString());
            sch.time = DateTime.Parse(dtp_time.Value.ToString());
            sch.lesson = int.Parse(txt_lesson.Text);
            sch.num_of_less = int.Parse(txt_num_of_less.Text);

            ScheduceBLL ScheduceBLL = new ScheduceBLL();
            bool kq = ScheduceBLL.changeSch_At_Object(sch.id, sch);

            if (kq)
            {
                loadListViewScheduce();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvScheduce.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvScheduce.SelectedItems[0];
                schedule_detail sch = lvi.Tag as schedule_detail;
                ScheduceBLL ScheduceBLL = new ScheduceBLL();

                bool kq = ScheduceBLL.deleteAt(sch.id);

                if (kq)
                {
                    loadListViewScheduce();
                }
            }
        }

        private void lvScheduce_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvScheduce.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvScheduce.SelectedItems[0];
                schedule_detail sch = lvi.Tag as schedule_detail;

                txt_id.Text = sch.id.ToString();
                cb_id_tea.SelectedValue = sch.id_tea.ToString();
                cb_id_subj.SelectedValue = sch.id_subj.ToString();
                cb_id_room.SelectedValue = sch.id_room.ToString();
                dtp_time.Value = (DateTime)sch.time;
                txt_lesson.Text = sch.lesson.ToString();
                txt_num_of_less.Text = sch.num_of_less.ToString();                
            }
        }

        private void ScheduceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPTHDataSet5.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.qLPTHDataSet5.room);
            // TODO: This line of code loads data into the 'qLPTHDataSet4.subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.qLPTHDataSet4.subject);
            // TODO: This line of code loads data into the 'qLPTHDataSet3.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.qLPTHDataSet3.teacher);
            loadListViewScheduce();
        }
    }
}
