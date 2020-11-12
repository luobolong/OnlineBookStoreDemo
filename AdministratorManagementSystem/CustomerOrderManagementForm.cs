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
    public partial class CustomerOrderManagementForm : Form
    {
        public delegate void SendCustomerInfo(CustomerModel customer);
        public event SendCustomerInfo SendCustomerInfoEvent;

        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;
        public CustomerOrderManagementForm()
        {
            //设置窗体的双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewOrders.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridViewOrders, true, null);
        }

        private void ShowAllCustomerOrderData()
        {
            try
            {
                dataGridViewOrders.Rows.Clear();
                var orders = CustomerOrderDataAccess.GetAllCustomerOrders();
                foreach (var order in orders)
                {
                    int rowId = dataGridViewOrders.Rows.Add();
                    DataGridViewRow row = dataGridViewOrders.Rows[rowId];
                    row.Cells["OrderId"].Value = order.Id.ToString();
                    row.Cells["CustomerId"].Value = order.Customer_Id.ToString();
                    row.Cells["Username"].Value = order.Username;
                    row.Cells["BookISBN"].Value = order.Book_ISBN;
                    row.Cells["Title"].Value = order.Title;
                    row.Cells["OrderDate"].Value = order.Order_Date.ToString();
                    row.Cells["Amount"].Value = order.Amount.ToString();
                    row.Cells["TotalPrice"].Value = order.Total_Price.ToString();
                    row.Cells["Status"].Value = order.Status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowCustomerOrderData(List<CustomerOrderModel> orders)
        {
            dataGridViewOrders.Rows.Clear();
            foreach (var order in orders)
            {
                int rowId = dataGridViewOrders.Rows.Add();
                DataGridViewRow row = dataGridViewOrders.Rows[rowId];
                row.Cells["OrderId"].Value = order.Id.ToString();
                row.Cells["CustomerId"].Value = order.Customer_Id.ToString();
                row.Cells["Username"].Value = order.Username;
                row.Cells["BookISBN"].Value = order.Book_ISBN;
                row.Cells["Title"].Value = order.Title;
                row.Cells["OrderDate"].Value = order.Order_Date.ToString();
                row.Cells["Amount"].Value = order.Amount.ToString();
                row.Cells["TotalPrice"].Value = order.Total_Price.ToString();
                row.Cells["Status"].Value = order.Status;
            }
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "CustomerDetail" && e.RowIndex >= 0)
            {
                string Username_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["CustomerId"].Value.ToString();
                var customer = CustomerDataAccess.GetCustomerById(Username_Value);
                CustomerDetailForm customerDetailForm = new CustomerDetailForm();
                SendCustomerInfoEvent += customerDetailForm.ShowDetail;
                SendCustomerInfoEvent.Invoke(customer);
                customerDetailForm.ShowDialog();
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "BookDetail" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                string BookISBN_Value = CustomerOrderDataAccess.GetBookISBNById(OrderId_Value);
                //string BookISBN_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["BookISBN"].Value?.ToString();
                if (BookISBN_Value == null)
                {
                    MessageBox.Show("图书不存在");
                    return;
                }
                var book = BookDataAccess.GetFullBookByISBN(BookISBN_Value);
                BookDetailForm bookDetailForm = new BookDetailForm();
                SendBookInfoEvent += bookDetailForm.ShowDetail;
                SendBookInfoEvent.Invoke(book);
                bookDetailForm.ShowDialog();
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Ship" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                string BookISBN_Value = CustomerOrderDataAccess.GetBookISBNById(OrderId_Value);
                if (BookISBN_Value == null)
                {
                    MessageBox.Show("图书不存在");
                    return;
                }
                CustomerOrderStatusModel Status_Value = (CustomerOrderStatusModel)dataGridViewOrders.Rows[e.RowIndex].Cells["Status"].Value;
                if (Status_Value.Id == 2)
                {
                    int quantity = BookDataAccess.GetBookQuantityByISBN(BookISBN_Value);
                    int amount = CustomerOrderDataAccess.GetAmountById(OrderId_Value);
                    if (quantity >= amount)
                    {
                        CustomerOrderDataAccess.ShipOrder(OrderId_Value);
                        BookDataAccess.UpdateBookQuantity(BookISBN_Value, quantity - amount);
                    }
                    else
                    {
                        MessageBox.Show("库存不足");
                        return;
                    }
                }
                ShowAllCustomerOrderData();
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Cancel" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                CustomerOrderDataAccess.CancelOrder(OrderId_Value);
                ShowAllCustomerOrderData();
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                CustomerOrderDataAccess.DeleteOrder(OrderId_Value);
                ShowAllCustomerOrderData();
            }
        }

        private void CustomerOrderManagementForm_Load(object sender, EventArgs e)
        {
            ShowAllCustomerOrderData();
            comboBoxOption.SelectedIndex = 0;
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
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderById(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByCustomerId(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByExactISBN(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByExactTitle(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByOrderDate(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByAmount(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByTotalPrice(textBoxSearch.Text));
                        break;
                    case 7:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByStatusId(textBoxSearch.Text));
                        break;
                    case 8:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByExactStatusName(textBoxSearch.Text));
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
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderById(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByCustomerId(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByVagueISBN(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByVagueTitle(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByOrderDate(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByAmount(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByTotalPrice(textBoxSearch.Text));
                        break;
                    case 7:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByStatusId(textBoxSearch.Text));
                        break;
                    case 8:
                        ShowCustomerOrderData(CustomerOrderDataAccess.SelectOrderByVagueStatusName(textBoxSearch.Text));
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
            ShowAllCustomerOrderData();
        }

        private void dataGridViewOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex <= 8)
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
    }
}
