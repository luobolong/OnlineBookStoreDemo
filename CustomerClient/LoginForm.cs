using Helper;
using Helper.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Equals("") || textBoxPassword.Text.Equals(""))
            {
                MessageBox.Show("用户名或密码为空");
                return;
            }
            try
            {
                CustomerInfo.customer = CustomerDataAccess.LoginCustomer(textBoxUsername.Text, textBoxPassword.Text);
                MainForm mainForm = MainForm.CreateForm();
                Hide();
                mainForm.ShowDialog();
                Show();
            }
            catch
            {
                MessageBox.Show("登录失败");
            }
        }
        #region 鼠标左键移动窗口
        Point mouseOff;
        bool leftFlag = false;
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                this.Location = mouseSet;
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
        #endregion

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}

