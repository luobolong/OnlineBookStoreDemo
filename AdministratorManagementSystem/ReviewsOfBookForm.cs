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
    public partial class ReviewsOfBookForm : Form
    {
        public delegate void SendCustomerInfo(CustomerModel customer);
        public event SendCustomerInfo SendCustomerInfoEvent;
        public ReviewsOfBookForm()
        {
            InitializeComponent();
        }

        public void ShowReviews(List<ReviewOfBookModel> reviews)
        {
            dataGridViewReviews.Rows.Clear();
            foreach (var review in reviews)
            {
                int rowId = dataGridViewReviews.Rows.Add();
                DataGridViewRow row = dataGridViewReviews.Rows[rowId];
                row.Cells["Username"].Value = review.Username;
                row.Cells["ReviewDate"].Value = review.Review_Date;
                row.Cells["ReviewRate"].Value = review.Review_Rate;
                row.Cells["ReviewContent"].Value = review.Review_Content;
            }
        }

        private void dataGridViewReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewReviews.Columns[e.ColumnIndex].Name == "Detail" && e.RowIndex >= 0)
            {
                string Username_Value = dataGridViewReviews.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                var customer = CustomerDataAccess.GetCustomerByUsername(Username_Value);
                CustomerDetailForm customerDetailForm = new CustomerDetailForm();
                SendCustomerInfoEvent += customerDetailForm.ShowDetail;
                SendCustomerInfoEvent.Invoke(customer);
                customerDetailForm.ShowDialog();
            }
        }
    }
}
