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
    public partial class ComputerForm : Form
    {

        public int id;

        public ComputerForm()
        {
            InitializeComponent();
        }
        private void loadListViewComputer()
        {
            ComputerBLL computerBLL = new ComputerBLL();
            List<Computer> ListComputer = computerBLL.getAllComp_InRoom(id);

            lvComputer.Items.Clear();

            foreach (Computer computer in ListComputer)
            {
                ListViewItem lvi = new ListViewItem(computer.id_comp + "");

                lvi.SubItems.Add(computer.id_room + "");
                lvi.SubItems.Add(computer.comp_name + "");
                lvi.SubItems.Add(computer.present_status + "");

                lvComputer.Items.Add(lvi);

                lvi.Tag = computer;
            }
        }
        private void ComputerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPTHDataSet1.Computer' table. You can move, or remove it, as needed.
            this.ComputerTableAdapter.Fill(this.qLPTHDataSet1.room);
            loadListViewComputer();
            cb_id_room.SelectedValue = this.id.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();

            computer.id_room = int.Parse(cb_id_room.SelectedValue.ToString());
            computer.comp_name = txt_comp_name.Text;
            computer.present_status = bool.Parse(cb_status.Text);

            ComputerBLL computerBLL = new ComputerBLL();
            bool kq = computerBLL.addComputer_Object(computer);

            if (kq)
            {
                loadListViewComputer();
            }
            else
            {
                noti("Thêm");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();

            computer.id_comp = int.Parse(txt_id_comp.Text);
            computer.id_room = int.Parse(cb_id_room.SelectedValue.ToString());
            computer.comp_name = txt_comp_name.Text;
            computer.present_status = bool.Parse(cb_status.Text);

            ComputerBLL computerBLL = new ComputerBLL();
            bool kq = computerBLL.changeComputer_At_Object(computer.id_comp, computer);

            if (kq)
            {
                loadListViewComputer();
            }
            else
            {
                noti("Sửa");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvComputer.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvComputer.SelectedItems[0];
                Computer computer = lvi.Tag as Computer;
                ComputerBLL computerBLL = new ComputerBLL();

                bool kq = computerBLL.deleteAt(computer.id_comp);

                if (kq)
                {
                    loadListViewComputer();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            ComputerBLL computerBLL = new ComputerBLL();
            List<Computer> ListComputer = computerBLL.searchComputer_Name_In_Room(this.id, txt_search.Text);

            lvComputer.Items.Clear();

            foreach (Computer computer in ListComputer)
            {
                ListViewItem lvi = new ListViewItem(computer.id_comp + "");

                lvi.SubItems.Add(computer.id_room + "");
                lvi.SubItems.Add(computer.comp_name + "");
                lvi.SubItems.Add(computer.present_status + "");

                lvComputer.Items.Add(lvi);

                lvi.Tag = computer;
            }
        }
        private void lvComputer_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvComputer.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvComputer.SelectedItems[0];
                Computer computer = lvi.Tag as Computer;

                txt_id_comp.Text = computer.id_comp.ToString();
                cb_id_room.SelectedValue = computer.id_room.ToString();
                txt_comp_name.Text = computer.comp_name.ToString();
                cb_status.Text = computer.present_status.ToString();
            }
        }

        private void lvComputer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            StatusForm statusForm = new StatusForm();
            statusForm.id = int.Parse(txt_id_comp.Text);
            statusForm.ShowDialog();
            this.Show();   
        }
        private void noti(string s)
        {
            MessageBox.Show(s + " không thành công", "Thông báo");
        }
    }
}
