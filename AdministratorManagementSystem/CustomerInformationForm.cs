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

namespace AdministratorManagementSystem
{
    public partial class CustomerInformationForm : Form
    {
        public delegate void SendCartInfo(List<CartOfCustomerModel> cart);
        public event SendCartInfo SendCartInfoEvent;

        public delegate void SendOrdersInfo(List<OrderOfCustomerModel> orders);
        public event SendOrdersInfo SendOrdersInfoEvent;

        public delegate void SendReviewsInfo(List<ReviewOfCustomerModel> reviews);
        public event SendReviewsInfo SendReviewsInfoEvent;

        public CustomerInformationForm()
        {
            //设置窗体的双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewCustomers.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridViewCustomers, true, null);
        }

        private void CustomerInformationForm_Load(object sender, EventArgs e)
        {
            ShowAllCustomerData();
            comboBoxOption.SelectedItem = comboBoxOption.Items[0];
        }

        private void ShowAllCustomerData()
        {
            try
            {
                dataGridViewCustomers.Rows.Clear();
                var customers = CustomerDataAccess.GetAllCustomers();
                foreach (var customer in customers)
                {
                    int rowId = dataGridViewCustomers.Rows.Add();
                    DataGridViewRow row = dataGridViewCustomers.Rows[rowId];
                    row.Cells["Id"].Value = customer.Id;
                    row.Cells["Username"].Value = customer.Username;
                    row.Cells["RealName"].Value = customer.Real_Name;
                    row.Cells["PasswordHash"].Value = customer.Password_Hash;
                    row.Cells["Address"].Value = customer.Address;
                    row.Cells["PhoneNumber"].Value = customer.Phone_Number;
                    row.Cells["EmailAddress"].Value = customer.Email_Address;
                    row.Cells["WalletBalance"].Value = customer.Wallet_Balance;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowCustomerData(List<CustomerModel> customers)
        {
            dataGridViewCustomers.Rows.Clear();
            foreach (var customer in customers)
            {
                int rowId = dataGridViewCustomers.Rows.Add();
                DataGridViewRow row = dataGridViewCustomers.Rows[rowId];
                row.Cells["Id"].Value = customer.Id;
                row.Cells["Username"].Value = customer.Username;
                row.Cells["RealName"].Value = customer.Real_Name;
                row.Cells["PasswordHash"].Value = customer.Password_Hash;
                row.Cells["Address"].Value = customer.Address;
                row.Cells["PhoneNumber"].Value = customer.Phone_Number;
                row.Cells["EmailAddress"].Value = customer.Email_Address;
                row.Cells["WalletBalance"].Value = customer.Wallet_Balance;
            }
        }

        private void buttonPresiseSearch_Click(object sender, EventArgs e)
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
                        ShowCustomerData(CustomerDataAccess.SelectCustomerById(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByExactUsername(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByExactRealName(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByExactAddress(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByExactPhoneNumber(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByExactEmailAddress(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByWalletBalance(textBoxSearch.Text));
                        break;
                }
            }
            catch (Exception ex)
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
                        ShowCustomerData(CustomerDataAccess.SelectCustomerById(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByVagueUsername(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByVagueRealName(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByVagueAddress(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByVaguePhoneNumber(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByVagueEmailAddress(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowCustomerData(CustomerDataAccess.SelectCustomerByWalletBalance(textBoxSearch.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowAllCustomerData();
        }

        private void dataGridViewCustomers_CellMouthClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex <= 7)
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

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCustomers.Columns[e.ColumnIndex].Name == "Cart" && e.RowIndex >= 0)
            {
                string CustomerId_Value = dataGridViewCustomers.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var cart = CartOfCustomerDataAccess.GetCart(CustomerId_Value);
                CartOfCustomerForm customerCartForm = new CartOfCustomerForm();
                SendCartInfoEvent += customerCartForm.ShowCart;
                SendCartInfoEvent.Invoke(cart);
                customerCartForm.ShowDialog();
            } else if (dataGridViewCustomers.Columns[e.ColumnIndex].Name == "Order" && e.RowIndex >= 0)
            {
                string CustomerId_Value = dataGridViewCustomers.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var orders = OrderOfCustomerDataAccess.GetAllOrders(CustomerId_Value);
                OrdersOfCustomerForm ordersOfCustomerForm = new OrdersOfCustomerForm();
                SendOrdersInfoEvent += ordersOfCustomerForm.ShowOrders;
                SendOrdersInfoEvent.Invoke(orders);
                ordersOfCustomerForm.ShowDialog();
            } else if (dataGridViewCustomers.Columns[e.ColumnIndex].Name == "Review" && e.RowIndex >= 0)
            {
                string CustomerId_Value = dataGridViewCustomers.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var reviews = ReviewOfCustomerDataAccess.GetReviews(CustomerId_Value);
                ReviewsOfCustomerForm ordersOfCustomerForm = new ReviewsOfCustomerForm();
                SendReviewsInfoEvent += ordersOfCustomerForm.ShowReviews;
                SendReviewsInfoEvent.Invoke(reviews);
                ordersOfCustomerForm.ShowDialog();
            }
        }
    }
}
