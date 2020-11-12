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
    public partial class CartItemAmountForm : Form
    {
        private FullBookModel _book { get; set; }
        private bool _addOrUpdate { get; set; } // add - true, update - false
        public CartItemAmountForm()
        {
            InitializeComponent();
        }

        public void GetInfo(FullBookModel book, bool add_or_update)
        {
            if (book != null)
            {
                _book = book;
                _addOrUpdate = add_or_update;
            }
            else
            {
                MessageBox.Show("错误：找不到该图书");
                Close();
            }
        }

        public void AddToCart()
        {
            try
            {
                CartDataAccess.InsertItem(CustomerInfo.customer, _book, (int)numericUpDownAmount.Value);
                MessageBox.Show("加入购物车成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCartItem()
        {
            try
            {
                CartDataAccess.UpdateCartItem(CustomerInfo.customer.Id, _book.ISBN, (int)numericUpDownAmount.Value);
                MessageBox.Show("修改成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButtonOK_Click(object sender, EventArgs e)
        {
            if (_addOrUpdate)
            {
                AddToCart();
            }
            else
            {
                UpdateCartItem();
            }
        }
    }
}
