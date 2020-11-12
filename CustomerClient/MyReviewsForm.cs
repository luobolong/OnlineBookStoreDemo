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
    public partial class MyReviewsForm : Form
    {
        private List<ReviewOfCustomerModel> _reviews { get; set; }
        public delegate void SendOrderInfo(string order_id, FullBookModel book, bool is_reviewed);
        public event SendOrderInfo SendOrderInfoEvent;

        public MyReviewsForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewMyReviews.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridViewMyReviews, true, null);

            ShowMyReviews();
        }

        private void ShowMyReviews()
        {
            try
            {
                _reviews = ReviewOfCustomerDataAccess.GetReviews(CustomerInfo.customer.Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show("错误：获取评论失败\r\n" + ex.Message);
            }

            dataGridViewMyReviews.Rows.Clear();
            foreach (var review in _reviews)
            {
                int rowId = dataGridViewMyReviews.Rows.Add();
                DataGridViewRow row = dataGridViewMyReviews.Rows[rowId];
                row.Cells["BookISBN"].Value = review.Book_ISBN;
                row.Cells["Title"].Value = review.Title;
                row.Cells["ReviewDate"].Value = review.Review_Date;
                row.Cells["ReviewRate"].Value = review.Review_Rate;
                row.Cells["ReviewContent"].Value = review.Review_Content;
            }
        }

        private void dataGridViewMyReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMyReviews.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewMyReviews.Rows[e.RowIndex].Cells["BookISBN"].Value.ToString();
                if (!BookDataAccess.IsBookExisted(ISBN_Value))
                {
                    MessageBox.Show("图书不存在");
                    return;
                }

                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                WriteReviewForm writeReviewForm = new WriteReviewForm();
                SendOrderInfoEvent += writeReviewForm.ShowDetail;
                SendOrderInfoEvent.Invoke(ISBN_Value, book, true);
                writeReviewForm.ShowDialog();
                ShowMyReviews();
            } else if(dataGridViewMyReviews.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                string ISBN_Value = dataGridViewMyReviews.Rows[e.RowIndex].Cells["BookISBN"].Value.ToString();
                try
                {
                    ReviewDataAccess.DeleteReview(CustomerInfo.customer.Id, ISBN_Value);
                    MessageBox.Show("删除成功");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("删除失败\r\n" + ex.Message);
                }
                ShowMyReviews();
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
