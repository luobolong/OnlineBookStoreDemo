using Helper.DataAccess;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerClient
{
    public partial class SubmitOrderForm : Form
    {
        private FullBookModel _book { get; set; }
        private int _amount { get; set; }
        private decimal _totalPrice { get; set; }

        public SubmitOrderForm()
        {
            InitializeComponent();
        }

        public void GetOrderInfo(FullBookModel book, int amount)
        {
            _book = book;
            _amount = amount;
            _totalPrice = _book.Price * _amount;

            textBoxISBN.Text = _book.ISBN;
            textBoxTitle.Text = _book.Title;
            textBoxPirce.Text = _book.Price.ToString();
            textBoxAmount.Text = _amount.ToString();
            textBoxTotalPrice.Text = _totalPrice.ToString();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Form_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButtonSubmit_Click(object sender, EventArgs e)
        {
            if (_book == null)
            {
                MessageBox.Show("错误：找不到图书");
                return;
            }
            try
            {
                CustomerOrderDataAccess.SubmitOrder(CustomerInfo.customer.Id, _book.ISBN, _amount, _totalPrice, DateTime.Now);
                CartDataAccess.DeleteCartItem(CustomerInfo.customer.Id, _book.ISBN);
                MessageBox.Show("提交订单成功");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("提交订单失败\r\n" + ex.Message);
            }
        }
    }
}
