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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerClient
{
    public partial class PurchaseBooksForm : Form
    {
        private List<FullBookModel> _books { get; set; }

        public delegate void SendCartInfo(FullBookModel book, bool add_or_update);
        public event SendCartInfo SendCartInfoEvent;

        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;

        public delegate void SendReviewsInfo(List<ReviewOfBookModel> reviews);
        public event SendReviewsInfo SendReviewsInfoEvent;
        public PurchaseBooksForm()
        {
            //设置窗体的双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewBooks.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridViewBooks, true, null);

            SendMessage(textBoxSearch.Handle, 0x1501, 1, "书名、作者、ISBN");
            ShowAllBookData();
        }
        // 提示文字
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void ShowAllBookData()
        {
            try
            {
                dataGridViewBooks.Rows.Clear();
                _books = BookDataAccess.GetAllOnsaleBooks();
                foreach (var book in _books)
                {
                    int rowId = dataGridViewBooks.Rows.Add();
                    DataGridViewRow row = dataGridViewBooks.Rows[rowId];
                    row.Cells["ISBN"].Value = book.ISBN;
                    row.Cells["Title"].Value = book.Title;
                    row.Cells["Author"].Value = book.Author;
                    row.Cells["Rate"].Value = book.Book_Rate.ToString();
                    row.Cells["Price"].Value = book.Price.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowBookData(List<FullBookModel> books)
        {
            dataGridViewBooks.Rows.Clear();
            foreach (var book in books)
            {
                int rowId = dataGridViewBooks.Rows.Add();
                DataGridViewRow row = dataGridViewBooks.Rows[rowId];
                row.Cells["ISBN"].Value = book.ISBN;
                row.Cells["Title"].Value = book.Title;
                row.Cells["Author"].Value = book.Author;
                row.Cells["Rate"].Value = book.Book_Rate.ToString();
                row.Cells["Price"].Value = book.Price.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
            {
                MessageBox.Show("检索关键词为空");
                return;
            }
            try
            {
                ShowBookData(BookDataAccess.SelectBookInCustomer(textBoxSearch.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewBooks.Columns[e.ColumnIndex].Name == "AddToCart" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                CartItemAmountForm addToCartForm = new CartItemAmountForm();
                SendCartInfoEvent += addToCartForm.GetInfo;
                SendCartInfoEvent.Invoke(book, true);
                addToCartForm.ShowDialog();
            } else if(dataGridViewBooks.Columns[e.ColumnIndex].Name == "Review" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var reviews = ReviewOfBookDataAccess.GetReviews(ISBN_Value);
                ReviewsOfBookForm reviewsOfBookForm = new ReviewsOfBookForm();
                SendReviewsInfoEvent += reviewsOfBookForm.ShowReviews;
                SendReviewsInfoEvent.Invoke(reviews);
                reviewsOfBookForm.ShowDialog();
            } else if(dataGridViewBooks.Columns[e.ColumnIndex].Name == "More" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                BookDetailForm bookDetailForm = new BookDetailForm();
                SendBookInfoEvent += bookDetailForm.ShowBookDetail;
                SendBookInfoEvent.Invoke(book);
                bookDetailForm.ShowDialog();
            }
        }
    }
}
