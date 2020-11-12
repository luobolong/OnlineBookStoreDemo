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
    public partial class ReviewsOfCustomerForm : Form
    {
        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;
        public ReviewsOfCustomerForm()
        {
            InitializeComponent();
        }

        public void ShowReviews(List<ReviewOfCustomerModel> reviews)
        {
            dataGridViewReviews.Rows.Clear();
            foreach (var review in reviews)
            {
                int rowId = dataGridViewReviews.Rows.Add();
                DataGridViewRow row = dataGridViewReviews.Rows[rowId];
                row.Cells["BookISBN"].Value = review.Book_ISBN;
                row.Cells["Title"].Value = review.Title;
                row.Cells["ReviewDate"].Value = review.Review_Date;
                row.Cells["ReviewRate"].Value = review.Review_Rate;
                row.Cells["ReviewContent"].Value = review.Review_Content;
            }
        }

        private void dataGridViewReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewReviews.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewReviews.Rows[e.RowIndex].Cells["BookISBN"].Value.ToString();
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                BookDetailForm detailForm = new BookDetailForm();
                SendBookInfoEvent += detailForm.ShowDetail;
                SendBookInfoEvent.Invoke(book);
                detailForm.ShowDialog();
            }
        }
    }
}
