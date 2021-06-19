using SorguNet.Business.Abstract;
using SorguNet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorguNet
{
    public partial class LoginForm : Form
    {
        IUserManager _userManager;
        public LoginForm(IUserManager userManager)
        {
            _userManager = userManager;
            InitializeComponent();
        }
         
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != null && tbPassword.Text != null) { 
                User user=_userManager.UserLogin(tbUserName.Text, tbPassword.Text);
                if (user == null)
                {
                    MessageBox.Show("Kullanıcı adı şifre hatalı!");
                }
                else
                {
                    LoginInfo.user = user;
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı şifre giriniz!");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
