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
    public partial class MyCartForm : Form
    {
        public delegate void SendCartInfo(FullBookModel book, bool add_or_update);
        public event SendCartInfo SendCartInfoEvent;

        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;

        public delegate void SendOrderInfo(FullBookModel book, int amount);
        public event SendOrderInfo SendOrderInfoEvent;

        public MyCartForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();
            
            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewMyCart.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridViewMyCart, true, null);

            ShowAllCartData();
        }

        private void ShowAllCartData()
        {
            try
            {
                dataGridViewMyCart.Rows.Clear();
                var items = CartDataAccess.GetCartItems(CustomerInfo.customer.Id);
                foreach (var item in items)
                {
                    int rowId = dataGridViewMyCart.Rows.Add();
                    DataGridViewRow row = dataGridViewMyCart.Rows[rowId];
                    row.Cells["ISBN"].Value = item.Book.ISBN;
                    row.Cells["Title"].Value = item.Book.Title;
                    row.Cells["Amount"].Value = item.Amount;
                    row.Cells["Price"].Value = item.Book.Price;
                    row.Cells["TotalPrice"].Value = item.Book.Price * item.Amount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void dataGridViewMyCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMyCart.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewMyCart.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                if (!BookDataAccess.IsBookExisted(ISBN_Value))
                {
                    MessageBox.Show("错误：图书不存在");
                    return;
                }
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                BookDetailForm bookDetailForm = new BookDetailForm();
                SendBookInfoEvent += bookDetailForm.ShowBookDetail;
                SendBookInfoEvent.Invoke(book);
                bookDetailForm.ShowDialog();
            } else if (dataGridViewMyCart.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewMyCart.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                if (!BookDataAccess.IsBookExisted(ISBN_Value))
                {
                    MessageBox.Show("错误：图书不存在");
                    return;
                }
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                CartItemAmountForm cartItemAmountForm = new CartItemAmountForm();
                SendCartInfoEvent += cartItemAmountForm.GetInfo;
                SendCartInfoEvent.Invoke(book, false);
                cartItemAmountForm.ShowDialog();
                ShowAllCartData();
            } else if (dataGridViewMyCart.Columns[e.ColumnIndex].Name == "CheckOut" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewMyCart.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                int amount = CartDataAccess.SelectAmount(CustomerInfo.customer.Id, ISBN_Value);
                SubmitOrderForm submitOrderForm = new SubmitOrderForm();
                SendOrderInfoEvent += submitOrderForm.GetOrderInfo;
                SendOrderInfoEvent.Invoke(book, amount);
                submitOrderForm.ShowDialog();
                ShowAllCartData();
            } else if(dataGridViewMyCart.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewMyCart.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                try
                {
                    CartDataAccess.DeleteCartItem(CustomerInfo.customer.Id, ISBN_Value);
                    MessageBox.Show("删除成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("删除失败\r\n" + ex.Message);
                }
                ShowAllCartData();
            }
        }
    }
}
