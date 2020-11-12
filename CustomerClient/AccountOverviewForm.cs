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
    public partial class AccountOverviewForm : Form
    {
        public AccountOverviewForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            ShowAccountOverview();
        }

        private void ShowAccountOverview()
        {
            textBoxUsername.Text = CustomerInfo.customer.Username;
            textBoxRealName.Text = CustomerInfo.customer.Real_Name;
            textBoxAddress.Text = CustomerInfo.customer.Address;
            textBoxPhoneNumber.Text = CustomerInfo.customer.Phone_Number;
            textBoxEmailAddress.Text = CustomerInfo.customer.Email_Address;
            textBoxWalletBalance.Text = CustomerInfo.customer.Wallet_Balance.ToString();
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
