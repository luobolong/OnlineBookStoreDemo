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

namespace SupplierClient
{
    public partial class MyOrdersForm : Form
    {
        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;

        public delegate void SendNewBookInfo(SupplyNewBookInfoModel book);
        public event SendNewBookInfo SendNewBookInfoEvent;

        private List<OrderOfSupplierModel> _orders { get; set; }

        public MyOrdersForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewMyOrders.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridViewMyOrders, true, null);

            ShowMyOrders();
        }

        private void ShowMyOrders()
        {
            try
            {
                _orders = OrderOfSupplierDataAccess.GetOrders(SupplierInfo.supplier.Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show("错误：获取发货单数据失败\r\n" + ex.Message);
            }

            dataGridViewMyOrders.Rows.Clear();
            foreach (var order in _orders)
            {
                int rowId = dataGridViewMyOrders.Rows.Add();
                DataGridViewRow row = dataGridViewMyOrders.Rows[rowId];
                row.Cells["OrderId"].Value = order.Id;
                row.Cells["Amount"].Value = order.Amount;
                row.Cells["OrderDate"].Value = order.Order_Date;
                row.Cells["OrderStatus"].Value = order.Status;
                row.Cells["IsNew"].Value = order.Is_New ? "是" : "否";
            }
        }

        private void dataGridViewMyOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMyOrders.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewMyOrders.Rows[e.RowIndex].Cells["OrderId"].Value?.ToString();
                bool IsNewBook;
                try
                {
                    IsNewBook = SupplierOrderDataAccess.GetIsNewBook(OrderId_Value);
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (!IsNewBook)
                {
                    var book = BookDataAccess.GetFullBookBySupplierExistentBookOrderId(OrderId_Value);
                    if (book == null)
                    {
                        MessageBox.Show("图书不存在");
                        return;
                    }
                    BookDetailForm detailForm = new BookDetailForm();
                    SendBookInfoEvent += detailForm.ShowBookDetail;
                    SendBookInfoEvent.Invoke(book);
                    detailForm.ShowDialog();
                }
                else
                {
                    var new_book = NewBookInfoOfSupplierOrderDataAccess.GetNewBookInfoBySupplierOrderId(OrderId_Value);
                    int status_id = new_book.Supplier_Order.Status.Id;
                    if (status_id == 1) // 未入库
                    {
                        BookUnstockedDetailForm detailForm = new BookUnstockedDetailForm();
                        SendNewBookInfoEvent += detailForm.ShowNewBookDetail;
                        SendNewBookInfoEvent.Invoke(new_book);
                        detailForm.ShowDialog();
                    }
                    else // 已入库
                    {
                        var book = BookDataAccess.GetFullBookByISBN(new_book.Book_ISBN);
                        if (book == null)
                        {
                            MessageBox.Show("图书不存在");
                            return;
                        }
                        BookDetailForm detailForm = new BookDetailForm();
                        SendBookInfoEvent += detailForm.ShowBookDetail;
                        SendBookInfoEvent.Invoke(book);
                        detailForm.ShowDialog();
                    }
                }
            } else if (dataGridViewMyOrders.Columns[e.ColumnIndex].Name == "Cancel" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewMyOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                int StatusId_Value = SupplierOrderDataAccess.GetStatusIdValue(OrderId_Value);
                if (StatusId_Value == 1)
                {
                    try
                    {
                        SupplierOrderDataAccess.CancelOrder(OrderId_Value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("取消订单失败\n" + ex.Message);
                    }
                }
                ShowMyOrders();
            } else if (dataGridViewMyOrders.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewMyOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                try
                {
                    SupplierOrderDataAccess.DeleteOrder(OrderId_Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除订单失败\n" + ex.Message);
                }
                ShowMyOrders();
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
