using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QuanLyQuanCafe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            
            //frmCoffeeShop f = new frmCoffeeShop();
            //this.Hide();
            //f.ShowDialog();
            //this.Show();

            string user = txtUserName.Text;
            string pass = txtPassword.Text;

            UserBUS u = new UserBUS();

            if (u.Login(user, pass) == true)
            {
                //MessageBox.Show("Dang nhap thanh cong");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Đăng nhập thất bại");
        }
    }
}


