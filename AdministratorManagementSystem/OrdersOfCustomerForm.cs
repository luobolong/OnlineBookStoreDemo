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
    public partial class OrdersOfCustomerForm : Form
    {
        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;
        public OrdersOfCustomerForm()
        {
            InitializeComponent();
        }

        public void ShowOrders(List<OrderOfCustomerModel> orders)
        {
            dataGridViewOrders.Rows.Clear();
            foreach (var order in orders)
            {
                int rowId = dataGridViewOrders.Rows.Add();
                DataGridViewRow row = dataGridViewOrders.Rows[rowId];
                row.Cells["OrderId"].Value = order.Id;
                row.Cells["BookISBN"].Value = order.Book_ISBN;
                row.Cells["Title"].Value = order.Title;
                row.Cells["Amount"].Value = order.Amount;
                row.Cells["TotalPrice"].Value = order.Total_Price;
                row.Cells["OrderDate"].Value = order.Order_Date;
                row.Cells["OrderStatus"].Value = order.Status;
            }
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["BookISBN"].Value?.ToString();
                if (ISBN_Value == null)
                {
                    MessageBox.Show("图书不存在");
                    return;
                }
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                BookDetailForm detailForm = new BookDetailForm();
                SendBookInfoEvent += detailForm.ShowDetail;
                SendBookInfoEvent.Invoke(book);
                detailForm.ShowDialog();
            }
        }
    }
}
