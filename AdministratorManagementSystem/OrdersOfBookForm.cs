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
    public partial class OrdersOfBookForm : Form
    {
        public delegate void SendCustomerInfo(CustomerModel customer);
        public event SendCustomerInfo SendCustomerInfoEvent;
        public OrdersOfBookForm()
        {
            InitializeComponent();
        }

        public void ShowOrders(List<OrderOfBookModel> orders)
        {
            dataGridViewOrders.Rows.Clear();
            foreach (var order in orders)
            {
                int rowId = dataGridViewOrders.Rows.Add();
                DataGridViewRow row = dataGridViewOrders.Rows[rowId];
                row.Cells["OrderId"].Value = order.Id;
                row.Cells["Username"].Value = order.Username;
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
                string Username_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                var customer = CustomerDataAccess.GetCustomerByUsername(Username_Value);
                CustomerDetailForm customerDetailForm = new CustomerDetailForm();
                SendCustomerInfoEvent += customerDetailForm.ShowDetail;
                SendCustomerInfoEvent.Invoke(customer);
                customerDetailForm.ShowDialog();
            }
        }
    }
}
