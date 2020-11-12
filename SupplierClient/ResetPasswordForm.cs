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

namespace SupplierClient
{
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private bool checkPassword()
        {
            if (!textBoxNewPassword.Text.Equals(textBoxRepeatPassword.Text))
            {
                MessageBox.Show("两次密码输入的不一致");
                return false;
            }
            else if (!StringChecker.IsPassword(textBoxNewPassword.Text))
            {
                MessageBox.Show("重置的密码不符合要求");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void iconButtonOK_Click(object sender, EventArgs e)
        {
            if (checkPassword())
            {
                SupplierDataAccess.ResetPassword(SupplierInfo.supplier.Id, textBoxNewPassword.Text);
                MessageBox.Show("重置密码成功");
            }
        }

        // 解决闪屏问题
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                textBoxNewPassword.PasswordChar = new char();
                textBoxRepeatPassword.PasswordChar = new char();
            }
            else
            {
                textBoxNewPassword.PasswordChar = '●';
                textBoxRepeatPassword.PasswordChar = '●';
            }
        }
    }
}
