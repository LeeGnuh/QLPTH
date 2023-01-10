using BLL;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            string permision = accountBLL.user_login(txtUname.Text, txtPass.Text);
            if (permision == "admin")
            {
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.ShowDialog();
                txtUname.Text = "";
                txtPass.Text = "";
                this.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác", "Thông báo");
            }    
        }
    }
}
