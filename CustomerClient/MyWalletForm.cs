using Helper;
using Helper.DataAccess;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerClient
{
    public partial class MyWalletForm : Form
    {
        private decimal _walletBalance { get; set; }
        public MyWalletForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            ShowWalletBalance();
        }

        private void ShowWalletBalance()
        {
            _walletBalance = CustomerDataAccess.GetWalletBalanceById(CustomerInfo.customer.Id);
            textBoxWalletBalance.Text = _walletBalance.ToString();
        }

        private void iconButtonTopUp_Click(object sender, EventArgs e)
        {
            TopUpForm topUpForm = new TopUpForm();
            topUpForm.ShowDialog();
            ShowWalletBalance();
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
