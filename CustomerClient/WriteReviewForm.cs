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
    public partial class WriteReviewForm : Form
    {
        private string _orderId { get; set; }
        private FullBookModel _book { get; set; }
        private bool _isReviewed { get; set; }
        private decimal _reviewRate { get; set; }
        
        public WriteReviewForm()
        {
            InitializeComponent();
        }

        public void ShowDetail(string order_id, FullBookModel book, bool is_reviewed)
        {
            _orderId = order_id;
            _book = book;
            _isReviewed = is_reviewed;
            if (_isReviewed)
            {
                ReviewOfCustomerModel review = ReviewOfCustomerDataAccess.GetReviewByISBN(CustomerInfo.customer.Id, _book.ISBN);
                _reviewRate = review.Review_Rate;
                SetReviewRate();
                textBoxReviewContent.Text = review.Review_Content;
            }
            textBoxISBN.Text = _book.ISBN;
            textBoxTitle.Text = _book.Title;
        }

        private void GetReviewRate()
        {
            if (radioButton1.Checked)
            {
                _reviewRate = 1;
            } else if (radioButton2.Checked)
            {
                _reviewRate = 2;
            } else if (radioButton3.Checked)
            {
                _reviewRate = 3;
            } else if (radioButton4.Checked)
            {
                _reviewRate = 4;
            } else if (radioButton5.Checked)
            {
                _reviewRate = 5;
            }
            else
            {
                _reviewRate = 5;
            }
        }

        private void SetReviewRate()
        {
            switch (_reviewRate)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
                case 4:
                    radioButton4.Checked = true;
                    break;
                case 5:
                    radioButton5.Checked = true;
                    break;
                default:
                    radioButton5.Checked = true;
                    break;
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


        private void ReviewsOfBookForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButtonOK_Click(object sender, EventArgs e)
        {
            if (textBoxReviewContent.Text.Length > 1000)
            {
                MessageBox.Show("评论内容请不要超过1000字");
                return;
            }

            bool is_review_content_null = false;
            if(textBoxReviewContent.Text.Length == 0)
            {
                is_review_content_null = true;
            }

            GetReviewRate();
            try
            {
                if (_isReviewed)
                {
                    ReviewDataAccess.UpdateReview(CustomerInfo.customer.Id, _book.ISBN, _reviewRate, textBoxReviewContent.Text, DateTime.Now, is_review_content_null);
                    CustomerOrderDataAccess.FinishOrder(_orderId);
                    MessageBox.Show("评论更新成功");
                }
                else
                {
                    ReviewDataAccess.InsertReview(CustomerInfo.customer.Id, _book.ISBN, _reviewRate, textBoxReviewContent.Text, DateTime.Now, is_review_content_null);
                    CustomerOrderDataAccess.FinishOrder(_orderId);
                    MessageBox.Show("评论成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
