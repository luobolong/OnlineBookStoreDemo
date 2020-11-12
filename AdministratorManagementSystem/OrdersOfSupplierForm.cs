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

namespace AdministratorManagementSystem
{
    public partial class OrdersOfSupplierForm : Form
    {
        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;

        public delegate void SendNewBookInfo(SupplyNewBookInfoModel book);
        public event SendNewBookInfo SendNewBookInfoEvent;
        public OrdersOfSupplierForm()
        {
            InitializeComponent();
        }

        public void ShowOrders(List<OrderOfSupplierModel> orders)
        {
            dataGridViewOrders.Rows.Clear();
            foreach (var order in orders)
            {
                int rowId = dataGridViewOrders.Rows.Add();
                DataGridViewRow row = dataGridViewOrders.Rows[rowId];
                row.Cells["OrderId"].Value = order.Id;
                row.Cells["Amount"].Value = order.Amount;
                row.Cells["OrderDate"].Value = order.Order_Date;
                row.Cells["OrderStatus"].Value = order.Status;
                row.Cells["IsNew"].Value = order.Is_New ? "是" : "否";
                row.Cells["Detail"].Value = order.Is_New ? "查看新书详情" : "查看旧书详情";
            }
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value?.ToString();
                bool IsNewBook;
                try
                {
                    IsNewBook = SupplierOrderDataAccess.GetIsNewBook(OrderId_Value);
                }
                catch(MyException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (!IsNewBook)
                {
                    var book = BookDataAccess.GetFullBookBySupplierExistentBookOrderId(OrderId_Value);
                    if(book == null)
                    {
                        MessageBox.Show("图书不存在");
                        return;
                    }
                    BookDetailForm detailForm = new BookDetailForm();
                    SendBookInfoEvent += detailForm.ShowDetail;
                    SendBookInfoEvent.Invoke(book);
                    detailForm.ShowDialog();
                } else
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
                        SendBookInfoEvent += detailForm.ShowDetail;
                        SendBookInfoEvent.Invoke(book);
                        detailForm.ShowDialog();
                    }
                }
            }
        }
    }
}
