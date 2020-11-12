using Helper.DataAccess;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorManagementSystem
{
    public partial class BookMangementForm : Form
    {
        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;

        public delegate void SendReviewsInfo(List<ReviewOfBookModel> reviews);
        public event SendReviewsInfo SendReviewsInfoEvent;

        public delegate void SendOrdersInfo(List<OrderOfBookModel> reviews);
        public event SendOrdersInfo SendOrdersInfoEvent;
        public BookMangementForm()
        {
            //设置窗体的双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewBooks.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridViewBooks, true, null);
        }

        private void ShowAllBasicBookData()
        {
            try
            {
                dataGridViewBooks.Rows.Clear();
                var basicBooks = BookDataAccess.GetAllBasicBooks();
                foreach (var basicBook in basicBooks)
                {
                    int rowId = dataGridViewBooks.Rows.Add();
                    DataGridViewRow row = dataGridViewBooks.Rows[rowId];
                    row.Cells["ISBN"].Value = basicBook.ISBN;
                    row.Cells["Title"].Value = basicBook.Title;
                    row.Cells["Quantity"].Value = basicBook.Quantity;
                    row.Cells["IsOnSale"].Value = basicBook.Is_On_Sale ? "是" : "否";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowBasicBookData(List<BasicBookModel> basicBooks)
        {
            dataGridViewBooks.Rows.Clear();
            foreach (var basicBook in basicBooks)
            {
                int rowId = dataGridViewBooks.Rows.Add();
                DataGridViewRow row = dataGridViewBooks.Rows[rowId];
                row.Cells["ISBN"].Value = basicBook.ISBN;
                row.Cells["Title"].Value = basicBook.Title;
                row.Cells["Quantity"].Value = basicBook.Quantity;
                row.Cells["IsOnSale"].Value = basicBook.Is_On_Sale ? "是" : "否";
            }
        }

        private void BookMangementForm_Load(object sender, EventArgs e)
        {
            ShowAllBasicBookData();
            comboBoxOption.SelectedItem = comboBoxOption.Items[0];
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                BookDetailForm detailForm = new BookDetailForm();
                SendBookInfoEvent += detailForm.ShowDetail;
                SendBookInfoEvent.Invoke(book);
                detailForm.ShowDialog();
            } else if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                BookEditorForm editBookForm = new BookEditorForm();
                SendBookInfoEvent += editBookForm.GetValues;
                SendBookInfoEvent.Invoke(book);
                editBookForm.ShowDialog();
                ShowAllBasicBookData();
            } else if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                if (MessageBox.Show("删除图书后可能会导致部分订单、购物车和评论数据失效\n确定删除图书？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                    try
                    {
                        BookDataAccess.DeleteBook(ISBN_Value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ShowAllBasicBookData();
                }
            } else if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Review" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var reviews = ReviewOfBookDataAccess.GetReviews(ISBN_Value);
                ReviewsOfBookForm reviewsOfBookForm = new ReviewsOfBookForm();
                SendReviewsInfoEvent += reviewsOfBookForm.ShowReviews;
                SendReviewsInfoEvent.Invoke(reviews);
                reviewsOfBookForm.ShowDialog();
            } else if (dataGridViewBooks.Columns[e.ColumnIndex].Name == "Order" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                var orders = OrderOfBookDataAccess.GetOrders(ISBN_Value);
                OrdersOfBookForm reviewsOfBookForm = new OrdersOfBookForm();
                SendOrdersInfoEvent += reviewsOfBookForm.ShowOrders;
                SendOrdersInfoEvent.Invoke(orders);
                reviewsOfBookForm.ShowDialog();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowAllBasicBookData();
        }

        private void buttonPreciseSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
            {
                MessageBox.Show("检索关键词为空");
                return;
            }
            try
            {
                switch (comboBoxOption.SelectedIndex)
                {
                    case 0:
                        ShowBasicBookData(BookDataAccess.SelectBookByExactISBN(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowBasicBookData(BookDataAccess.SelectBookByExactTitle(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowBasicBookData(BookDataAccess.SelectBookByExactAuthor(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowBasicBookData(BookDataAccess.SelectBookByExactPublisher(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowBasicBookData(BookDataAccess.SelectBookByGenreClc(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowBasicBookData(BookDataAccess.SelectBookByPublicationYear(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowBasicBookData(BookDataAccess.SelectBookByQuantity(textBoxSearch.Text));
                        break;
                    case 7:
                        ShowBasicBookData(BookDataAccess.SelectBookByPrice(textBoxSearch.Text));
                        break;
                    case 8:
                        ShowBasicBookData(BookDataAccess.SelectBookByIsOnSale(textBoxSearch.Text));
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFuzzySearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals(""))
            {
                MessageBox.Show("检索关键词为空");
                return;
            }
            try
            {
                switch (comboBoxOption.SelectedIndex)
                {
                    case 0:
                        ShowBasicBookData(BookDataAccess.SelectBookByVagueISBN(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowBasicBookData(BookDataAccess.SelectBookByVagueTitle(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowBasicBookData(BookDataAccess.SelectBookByVagueAuthor(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowBasicBookData(BookDataAccess.SelectBookByVaguePublisher(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowBasicBookData(BookDataAccess.SelectBookByGenreClc(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowBasicBookData(BookDataAccess.SelectBookByPublicationYear(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowBasicBookData(BookDataAccess.SelectBookByQuantity(textBoxSearch.Text));
                        break;
                    case 7:
                        ShowBasicBookData(BookDataAccess.SelectBookByPrice(textBoxSearch.Text));
                        break;
                    case 8:
                        ShowBasicBookData(BookDataAccess.SelectBookByIsOnSale(textBoxSearch.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex <= 3)
            {
                DataGridView dgv = sender as DataGridView;
                dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //dgv.Rows[e1.RowIndex].Cells[e1.ColumnIndex].Selected = true;   
                ContextMenuStrip context = new ContextMenuStrip();
                //context.SuspendLayout();   
                //context.Tag = (dgv.Rows[e1.RowIndex].Cells[e1.ColumnIndex].Value ?? "").ToString();   
                context.Size = new System.Drawing.Size(153, 22);

                ToolStripMenuItem contextItem = new ToolStripMenuItem();
                contextItem.Tag = (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? "").ToString();
                contextItem.Size = new System.Drawing.Size(152, 22);
                contextItem.Text = "复制";
                contextItem.Click += new System.EventHandler(
                    (sender2, e2) =>
                    {
                        ToolStripMenuItem tsmi = sender2 as ToolStripMenuItem;
                        Clipboard.Clear();
                        Clipboard.SetData(DataFormats.Text, tsmi.Tag);
                    }
                );
                context.Items.Add(contextItem);
                context.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void linkLabelAddNewBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BookAdderForm addBookForm = new BookAdderForm();
            addBookForm.ShowDialog();
            ShowAllBasicBookData();
        }
    }
}
