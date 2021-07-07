using gymManagement.common;
using gymManagement.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymManagement.ui
{
    partial class LoginMenu : Form
    {
        private LoginAdapter la;
        private Adapter ad;
        Login login;
        public LoginMenu()
        {
            InitializeComponent();
        }
        public LoginMenu(LoginAdapter la, Adapter ad)
        {
            InitializeComponent();
            this.la = la;
            this.ad = ad;
            this.ActiveControl = loginId;
        }
        public void checkLogin(Login login)
        {
            try
            {
                string id = loginId.Text;
                string pw = loginPw.Text;
                if (login.Id.Equals(id) && login.Password.Equals(pw))
                {
                    new AdminMenu(ad).ShowDialog();
                    Close();
                    Console.WriteLine("접속성공");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("아이디 또는 패스워드가 일치하지 않습니다.");
            }
        }
        private void exitLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string id = loginId.Text;
            string pw = loginPw.Text;
            login = la.getLoginVo(id, pw);
            checkLogin(login);
        }
    }
}
