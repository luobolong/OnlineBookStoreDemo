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
    public partial class SupplyForm : Form
    {
        public delegate void SendOrderInfo(string isbn, int amount);
        public event SendOrderInfo SendOrderInfoEvent;

        public SupplyForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
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

        private void iconButtonSupply_Click(object sender, EventArgs e)
        {
            if(textBoxISBN.Text.Length == 0)
            {
                MessageBox.Show("ISBN不能为空");
                return;
            }
            if (BookDataAccess.IsBookExisted(textBoxISBN.Text))
            {
                SupplierOrderDataAccess.InsertSupplierOrderOfExistentBook(SupplierInfo.supplier.Id, DateTime.Now, (int)numericUpDownAmount.Value, textBoxISBN.Text);
                MessageBox.Show("发货成功");
            }
            else
            {
                MessageBox.Show("您供应的图书ISBN在书库中未被检索到，\r\n您需要录入关于新书的信息");
                NewBookForm newBookForm = new NewBookForm();
                SendOrderInfoEvent += newBookForm.GetInfo;
                SendOrderInfoEvent.Invoke(textBoxISBN.Text, (int)numericUpDownAmount.Value);
                newBookForm.ShowDialog();
            }
        }
    }
}
