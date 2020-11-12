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
    public partial class RegisterForm : Form
    {
        private string _username { get; set; }
        private string _realName { get; set; }
        private string _password { get; set; }
        private string _address { get; set; }
        private string _phoneNumber { get; set; }
        private string _emailAddress { get; set; }
        private bool _isUsernameValid { get; set; } = false;
        private bool _isRealNameValid { get; set; } = false;
        private bool _isPasswordValid { get; set; } = false;
        private bool _isAddressValid { get; set; } = false;
        private bool _isPhoneNumberValid { get; set; } = false;
        private bool _isEmailAddressValid { get; set; } = false;
        public RegisterForm()
        {
            InitializeComponent();
            
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (_isUsernameValid && _isRealNameValid && _isPasswordValid && _isAddressValid && _isPhoneNumberValid && _isEmailAddressValid)
            {
                try
                {
                    if (CustomerDataAccess.IsUsernameExisted(_username))
                    {
                        MessageBox.Show("用户名已存在");
                        return;
                    }
                    CustomerDataAccess.InsertCustomer(_username, _realName, _password, _address, _phoneNumber, _emailAddress);
                    MessageBox.Show("注册成功！");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                Close();
            }
            else
            {
                MessageBox.Show("请检查字符串是否匹配");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region 鼠标左键移动窗口
        Point mouseOff;
        bool leftFlag = false;
        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                this.Location = mouseSet;
            }
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
        #endregion

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Length == 0)
            {
                labelTipForUsername.Text = "*用户名不得为空";
                _isUsernameValid = false;
            }
            else if (textBoxUsername.Text.Length > 20 || textBoxUsername.Text.Length < 6)
            {
                labelTipForUsername.Text = "*用户名不能超过20个字符或少于6个字符";
                _isUsernameValid = false;
            }
            else if (!StringChecker.IsUsername(textBoxUsername.Text))
            {
                labelTipForUsername.Text = "*用户名只能由数字和大小写字母组成";
                _isUsernameValid = false;
            }
            else
            {
                labelTipForUsername.Text = "";
                _isUsernameValid = true;
                _username = textBoxUsername.Text;
            }
        }

        private void textBoxRealName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRealName.Text.Length == 0)
            {
                labelTipForRealName.Text = "*真实姓名不得为空";
                _isRealNameValid = false;
            }
            else if (textBoxRealName.Text.Length > 50)
            {
                labelTipForRealName.Text = "*真实姓名不得超过50个字符";
                _isRealNameValid = false;
            }
            else
            {
                labelTipForRealName.Text = "";
                _isRealNameValid = true;
                _realName = textBoxRealName.Text;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (!StringChecker.IsPassword(textBoxPassword.Text))
            {
                labelTipForPassword.Text = "*密码由6-16个字符组成\n*区分大小写\n*至少包含一个字母、一个数字\n和一个特殊字符";
                _isPasswordValid = false;
            }
            else
            {
                labelTipForPassword.Text = "";
                _isPasswordValid = true;
                _password = textBoxPassword.Text;
            }
        }

        private void textBoxEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmailAddress.Text.Length == 0)
            {
                labelTipForEmailAddress.Text = "*电子邮箱地址不能为空";
                _isEmailAddressValid = false;
            }
            else if (!StringChecker.IsEmailAddress(textBoxEmailAddress.Text))
            {
                labelTipForEmailAddress.Text = "*电子邮箱地址格式不正确";
                _isEmailAddressValid = false;
            }
            else
            {
                labelTipForEmailAddress.Text = "";
                _isEmailAddressValid = true;
                _emailAddress = textBoxEmailAddress.Text;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            panelBackgroud.BackColor = Color.FromArgb(170, Color.White);
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAddress.Text.Length == 0)
            {
                labelTipForAddress.Text = "*住址不能为空";
            }
            else if (textBoxAddress.Text.Length > 100)
            {
                labelTipForPhoneNumber.Text = "*住址不得超过100个字符";
            }
            else
            {
                labelTipForAddress.Text = "";
                _isAddressValid = true;
                _address = textBoxAddress.Text;
            }
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text.Length == 0)
            {
                labelTipForPhoneNumber.Text = "*手机号不能为空";
            }
            else if (!StringChecker.IsPhoneNumber(textBoxPhoneNumber.Text))
            {
                labelTipForPhoneNumber.Text = "*请输入11位有效手机号";
            }
            else
            {
                labelTipForPhoneNumber.Text = "";
                _isPhoneNumberValid = true;
                _phoneNumber = textBoxPhoneNumber.Text;
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
    }
}
