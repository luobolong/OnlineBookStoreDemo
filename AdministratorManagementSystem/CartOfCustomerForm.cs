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
    public partial class CartOfCustomerForm : Form
    {
        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;
        public CartOfCustomerForm()
        {
            InitializeComponent();
        }

        public void ShowCart(List<CartOfCustomerModel> cart)
        {
            dataGridViewCart.Rows.Clear();
            foreach (var item in cart)
            {
                int rowId = dataGridViewCart.Rows.Add();
                DataGridViewRow row = dataGridViewCart.Rows[rowId];
                row.Cells["BookISBN"].Value = item.Book_ISBN;
                row.Cells["BookTitle"].Value = item.Title;
                row.Cells["Amount"].Value = item.Amount;
            }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCart.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewCart.Rows[e.RowIndex].Cells["BookISBN"].Value.ToString();
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                BookDetailForm detailForm = new BookDetailForm();
                SendBookInfoEvent += detailForm.ShowDetail;
                SendBookInfoEvent.Invoke(book);
                detailForm.ShowDialog();
            }
        }
    }
}
