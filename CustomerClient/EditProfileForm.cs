using Helper;
using Helper.DataAccess;
using Helper.Models;
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
    public partial class EditProfileForm : Form
    {
        public EditProfileForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            ShowAccountOverview();
        }

        private void ShowAccountOverview()
        {
            textBoxRealName.Text = CustomerInfo.customer.Real_Name;
            textBoxAddress.Text = CustomerInfo.customer.Address;
            textBoxPhoneNumber.Text = CustomerInfo.customer.Phone_Number;
            textBoxEmailAddress.Text = CustomerInfo.customer.Email_Address;
        }

        private bool CheckInfo()
        {
            StringBuilder tip = new StringBuilder();
            if (textBoxRealName.Text.Length == 0) tip.Append("真实姓名不得为空\r\n");
            if (textBoxAddress.Text.Length == 0) tip.Append("住址不得为空\r\n");
            if (textBoxPhoneNumber.Text.Length == 0) tip.Append("手机号码不得为空\r\n");
            if (textBoxRealName.Text.Length == 0) tip.Append("电子邮箱不得为空\r\n");
            if(textBoxRealName.Text.Length > 50) tip.Append("真实姓名不得超过50个字符\r\n");
            if (textBoxAddress.Text.Length > 100) tip.Append("住址不得超过100个字符\r\n");
            if (textBoxEmailAddress.Text.Length > 100) tip.Append("电子邮箱不得超过100个字符\r\n");
            if (!StringChecker.IsEmailAddress(textBoxEmailAddress.Text)) tip.Append("电子邮箱格式不正确\r\n");
            if (!StringChecker.IsPhoneNumber(textBoxPhoneNumber.Text)) tip.Append("手机号码格式不正确\r\n");
            
            if (tip.Length == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(tip.ToString());
                return false;
            }
        }

        private void iconButtonOK_Click(object sender, EventArgs e)
        {
            if (CheckInfo())
            {
                try
                {
                    CustomerDataAccess.UpdateCustomer(CustomerInfo.customer.Id, textBoxRealName.Text, textBoxAddress.Text, textBoxPhoneNumber.Text, textBoxEmailAddress.Text);
                    CustomerInfo.UpdateInfo();
                    MessageBox.Show("修改成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
