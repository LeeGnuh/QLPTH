using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALEntity;
using BLL;


namespace GUI
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void loadListViewAcc()
        {
            AccountBLL accountBLL = new AccountBLL();
            List<account> ListAcc = accountBLL.getAllAcc();

            lvAcc.Items.Clear();

            foreach (account acc in ListAcc)
            {
                ListViewItem lvi = new ListViewItem(acc.id_acc + "");

                lvi.SubItems.Add(acc.username + "");
                lvi.SubItems.Add(acc.password + "");
                lvi.SubItems.Add(acc.id_per == 1 ? "Quản trị viên" : "Quản lý phòng máy");
                lvi.SubItems.Add(acc.full_name + "");
                lvi.SubItems.Add(acc.acc_ban + "");

                lvAcc.Items.Add(lvi);

                lvi.Tag = acc;
            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPTHDataSet.permision' table. You can move, or remove it, as needed.
            this.permisionTableAdapter.Fill(this.qLPTHDataSet.permision);
            loadListViewAcc();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            account acc = new account();

            acc.username = txt_username.Text;
            acc.password = txt_password.Text;
            acc.id_per = int.Parse(cb_per.SelectedValue.ToString());
            acc.full_name = txt_full_name.Text;
            acc.acc_ban = bool.Parse(cb_ban.Text);

            AccountBLL accountBLL = new AccountBLL();
            bool kq = accountBLL.addAcc_Object(acc);

            if (kq)
            {
                loadListViewAcc();
            }         
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvAcc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvAcc.SelectedItems[0];
                account acc = lvi.Tag as account;
                AccountBLL accountBLL = new AccountBLL();

                bool kq = accountBLL.deleteAt(acc.id_acc);

                if (kq)
                {
                    loadListViewAcc();
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            account acc = new account();

            acc.id_acc = int.Parse(txt_id_acc.Text);
            acc.username = txt_username.Text;
            acc.password = txt_password.Text;
            acc.id_per = int.Parse(cb_per.SelectedValue.ToString());
            acc.full_name = txt_full_name.Text;
            acc.acc_ban = bool.Parse(cb_ban.Text);

            AccountBLL accountBLL = new AccountBLL();
            bool kq = accountBLL.changeAcc_At_Object(acc.id_acc, acc);

            if (kq)
            {
                loadListViewAcc();
            }
        }

        private void lvAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvAcc.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvAcc.SelectedItems[0];
                account acc = lvi.Tag as account;

                txt_id_acc.Text = acc.id_acc.ToString();
                txt_username.Text = acc.username.ToString();
                txt_password.Text = acc.password.ToString();
                txt_full_name.Text = acc.full_name.ToString();
                cb_ban.Text = acc.acc_ban.ToString();
            }
        }
    }
}
