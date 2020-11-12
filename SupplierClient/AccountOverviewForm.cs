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
            textBoxUsername.Text = SupplierInfo.supplier.Username;
            textBoxRealName.Text = SupplierInfo.supplier.Real_Name;
            textBoxPhoneNumber.Text = SupplierInfo.supplier.Phone_Number;
            textBoxEmailAddress.Text = SupplierInfo.supplier.Email_Address;
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
