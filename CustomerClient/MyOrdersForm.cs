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
    public partial class MyOrdersForm : Form
    {
        public delegate void SendBookInfo(string order_id, FullBookModel book, bool is_reviewed);
        public event SendBookInfo SendBookInfoEvent;

        private List<OrderOfCustomerModel> _allOrders { get; set; }
        private List<OrderOfCustomerModel> _pendingPaymentOrders { get; set; }
        private List<OrderOfCustomerModel> _waitingForDeliveryOrders { get; set; }
        private List<OrderOfCustomerModel> _onDeliveryOrders { get; set; }
        private List<OrderOfCustomerModel> _waitingForReviewOrders { get; set; }
        private List<OrderOfCustomerModel> _finishedOrders { get; set; }
        private List<OrderOfCustomerModel> _canceledOrders { get; set; }

        public MyOrdersForm()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewAllOrders.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dataGridViewAllOrders, true, null);
            pi.SetValue(dataGridViewPendingPaymentOrders, true, null);
            pi.SetValue(dataGridViewWaitingForDeliveryOrders, true, null);
            pi.SetValue(dataGridViewOnDeliveryOrders, true, null);
            pi.SetValue(dataGridViewWaitingForReviewOrders, true, null);
            pi.SetValue(dataGridViewFinishedOrders, true, null);
            pi.SetValue(dataGridViewCanceledOrders, true, null);
            ShowAll();
        }

        private void ShowAll()
        {
            ShowAllOrders();
            ShowPendingPaymentOrders();
            ShowWaitingForDeliveryOrders();
            ShowOnDeliveryOrders();
            ShowWaitingForReviewOrders();
            ShowFinishedOrders();
            ShowCanceledOrders();
        }

        private void ShowAllOrders()
        {
            try
            {
                _allOrders = OrderOfCustomerDataAccess.GetAllOrders(CustomerInfo.customer.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewAllOrders.Rows.Clear();
            foreach (var order in _allOrders)
            {
                int rowId = dataGridViewAllOrders.Rows.Add();
                DataGridViewRow row = dataGridViewAllOrders.Rows[rowId];
                row.Cells["OrderId1"].Value = order.Id;
                row.Cells["BookISBN1"].Value = order.Book_ISBN;
                row.Cells["Title1"].Value = order.Title;
                row.Cells["Amount1"].Value = order.Amount;
                row.Cells["TotalPrice1"].Value = order.Total_Price;
                row.Cells["OrderDate1"].Value = order.Order_Date;
                row.Cells["OrderStatus1"].Value = order.Status;
            }
        }

        private void ShowPendingPaymentOrders()
        {
            try
            {
                _pendingPaymentOrders = OrderOfCustomerDataAccess.GetOrdersByStatusId(CustomerInfo.customer.Id, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewPendingPaymentOrders.Rows.Clear();
            foreach (var order in _pendingPaymentOrders)
            {
                int rowId = dataGridViewPendingPaymentOrders.Rows.Add();
                DataGridViewRow row = dataGridViewPendingPaymentOrders.Rows[rowId];
                row.Cells["OrderId2"].Value = order.Id;
                row.Cells["BookISBN2"].Value = order.Book_ISBN;
                row.Cells["Title2"].Value = order.Title;
                row.Cells["Amount2"].Value = order.Amount;
                row.Cells["TotalPrice2"].Value = order.Total_Price;
                row.Cells["OrderDate2"].Value = order.Order_Date;
            }
        }

        private void ShowWaitingForDeliveryOrders()
        {
            try
            {
                _waitingForDeliveryOrders = OrderOfCustomerDataAccess.GetOrdersByStatusId(CustomerInfo.customer.Id, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewWaitingForDeliveryOrders.Rows.Clear();
            foreach (var order in _waitingForDeliveryOrders)
            {
                int rowId = dataGridViewWaitingForDeliveryOrders.Rows.Add();
                DataGridViewRow row = dataGridViewWaitingForDeliveryOrders.Rows[rowId];
                row.Cells["OrderId3"].Value = order.Id;
                row.Cells["BookISBN3"].Value = order.Book_ISBN;
                row.Cells["Title3"].Value = order.Title;
                row.Cells["Amount3"].Value = order.Amount;
                row.Cells["TotalPrice3"].Value = order.Total_Price;
                row.Cells["OrderDate3"].Value = order.Order_Date;
            }
        }

        private void ShowOnDeliveryOrders()
        {
            try
            {
                _onDeliveryOrders = OrderOfCustomerDataAccess.GetOrdersByStatusId(CustomerInfo.customer.Id, 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewOnDeliveryOrders.Rows.Clear();
            foreach (var order in _onDeliveryOrders)
            {
                int rowId = dataGridViewOnDeliveryOrders.Rows.Add();
                DataGridViewRow row = dataGridViewOnDeliveryOrders.Rows[rowId];
                row.Cells["OrderId4"].Value = order.Id;
                row.Cells["BookISBN4"].Value = order.Book_ISBN;
                row.Cells["Title4"].Value = order.Title;
                row.Cells["Amount4"].Value = order.Amount;
                row.Cells["TotalPrice4"].Value = order.Total_Price;
                row.Cells["OrderDate4"].Value = order.Order_Date;
            }
        }

        private void ShowWaitingForReviewOrders()
        {
            try
            {
                _waitingForReviewOrders = OrderOfCustomerDataAccess.GetOrdersByStatusId(CustomerInfo.customer.Id, 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewWaitingForReviewOrders.Rows.Clear();
            foreach (var order in _waitingForReviewOrders)
            {
                int rowId = dataGridViewWaitingForReviewOrders.Rows.Add();
                DataGridViewRow row = dataGridViewWaitingForReviewOrders.Rows[rowId];
                row.Cells["OrderId5"].Value = order.Id;
                row.Cells["BookISBN5"].Value = order.Book_ISBN;
                row.Cells["Title5"].Value = order.Title;
                row.Cells["Amount5"].Value = order.Amount;
                row.Cells["TotalPrice5"].Value = order.Total_Price;
                row.Cells["OrderDate5"].Value = order.Order_Date;
            }
        }

        private void ShowFinishedOrders()
        {
            try
            {
                _finishedOrders = OrderOfCustomerDataAccess.GetOrdersByStatusId(CustomerInfo.customer.Id, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewFinishedOrders.Rows.Clear();
            foreach (var order in _finishedOrders)
            {
                int rowId = dataGridViewFinishedOrders.Rows.Add();
                DataGridViewRow row = dataGridViewFinishedOrders.Rows[rowId];
                row.Cells["OrderId6"].Value = order.Id;
                row.Cells["BookISBN6"].Value = order.Book_ISBN;
                row.Cells["Title6"].Value = order.Title;
                row.Cells["Amount6"].Value = order.Amount;
                row.Cells["TotalPrice6"].Value = order.Total_Price;
                row.Cells["OrderDate6"].Value = order.Order_Date;
            }
        }

        private void ShowCanceledOrders()
        {
            try
            {
                _canceledOrders = OrderOfCustomerDataAccess.GetOrdersByStatusId(CustomerInfo.customer.Id, 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewCanceledOrders.Rows.Clear();
            foreach (var order in _canceledOrders)
            {
                int rowId = dataGridViewCanceledOrders.Rows.Add();
                DataGridViewRow row = dataGridViewCanceledOrders.Rows[rowId];
                row.Cells["OrderId7"].Value = order.Id;
                row.Cells["BookISBN7"].Value = order.Book_ISBN;
                row.Cells["Title7"].Value = order.Title;
                row.Cells["Amount7"].Value = order.Amount;
                row.Cells["TotalPrice7"].Value = order.Total_Price;
                row.Cells["OrderDate7"].Value = order.Order_Date;
            }
        }

        private void dataGridViewPendingPaymentOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPendingPaymentOrders.Columns[e.ColumnIndex].Name == "Pay" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewPendingPaymentOrders.Rows[e.RowIndex].Cells["OrderId2"].Value.ToString();
                OrderOfCustomerModel order = _pendingPaymentOrders.FindLast(o => o.Id.ToString().Equals(OrderId_Value));
                if (order == null)
                {
                    MessageBox.Show("错误：找不到订单");
                    return;
                }
                if (!BookDataAccess.IsBookExisted(order.Book_ISBN))
                {
                    MessageBox.Show("错误：图书不存在");
                    return;
                }
                try
                {
                    CustomerDataAccess.DeductBalance(CustomerInfo.customer.Id, order.Total_Price);
                    CustomerOrderDataAccess.PayOrder(order.Id.ToString());
                    MessageBox.Show("付款成功");
                    ShowAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            } else if (dataGridViewPendingPaymentOrders.Columns[e.ColumnIndex].Name == "Cancel1" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewPendingPaymentOrders.Rows[e.RowIndex].Cells["OrderId2"].Value.ToString();
                try
                {
                    CustomerOrderDataAccess.CancelOrder(OrderId_Value);
                    MessageBox.Show("取消成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("取消失败\r\n" + ex.Message);
                }
                ShowAll();
            }
        }

        private void dataGridViewWaitingForDeliveryOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewWaitingForDeliveryOrders.Columns[e.ColumnIndex].Name == "Refund" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewWaitingForDeliveryOrders.Rows[e.RowIndex].Cells["OrderId3"].Value.ToString();
                OrderOfCustomerModel order = _waitingForDeliveryOrders.FindLast(o => o.Id.ToString().Equals(OrderId_Value));
                try
                {
                    CustomerDataAccess.TopUp(CustomerInfo.customer.Id, order.Total_Price);
                    CustomerInfo.UpdateInfo();
                    CustomerOrderDataAccess.CancelOrder(OrderId_Value);
                    MessageBox.Show("退款成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("退款失败\r\n" + ex.Message);
                }
                ShowAll();
            }
        }

        private void dataGridViewOnDeliveryOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOnDeliveryOrders.Columns[e.ColumnIndex].Name == "Receive" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOnDeliveryOrders.Rows[e.RowIndex].Cells["OrderId4"].Value.ToString();
                OrderOfCustomerModel order = _onDeliveryOrders.FindLast(o => o.Id.ToString().Equals(OrderId_Value));
                try
                {
                    CustomerOrderDataAccess.ReceiveOrder(OrderId_Value);
                    MessageBox.Show("确认收货成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("确认收货失败\r\n" + ex.Message);
                }
                ShowAll();
            }
        }

        private void dataGridViewWaitingForReviewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewWaitingForReviewOrders.Columns[e.ColumnIndex].Name == "Review" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewWaitingForReviewOrders.Rows[e.RowIndex].Cells["OrderId5"].Value.ToString();
                OrderOfCustomerModel order = _waitingForReviewOrders.FindLast(o => o.Id.ToString().Equals(OrderId_Value));
                string ISBN_Value = order.Book_ISBN;
                bool is_reviewed = ReviewDataAccess.IsReviewed(CustomerInfo.customer.Id, ISBN_Value);
                if (!BookDataAccess.IsBookExisted(ISBN_Value))
                {
                    MessageBox.Show("图书不存在");
                    return;
                }
                if (is_reviewed)
                {
                    DialogResult result = MessageBox.Show("您已对该书做出评价，是否更新评论内容？", "消息", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        CustomerOrderDataAccess.FinishOrder(OrderId_Value);
                        ShowAll();
                        return;
                    }
                }
                var book = BookDataAccess.GetFullBookByISBN(ISBN_Value);
                WriteReviewForm writeReviewForm = new WriteReviewForm();
                SendBookInfoEvent += writeReviewForm.ShowDetail;
                SendBookInfoEvent.Invoke(OrderId_Value, book, is_reviewed);
                writeReviewForm.ShowDialog();

                ShowAll();
            }
        }

        private void dataGridViewFinishedOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFinishedOrders.Columns[e.ColumnIndex].Name == "Delete1" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewFinishedOrders.Rows[e.RowIndex].Cells["OrderId6"].Value.ToString();
                OrderOfCustomerModel order = _finishedOrders.FindLast(o => o.Id.ToString().Equals(OrderId_Value));
                try
                {
                    CustomerOrderDataAccess.DeleteOrder(OrderId_Value);
                    MessageBox.Show("删除订单成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除订单失败\r\n" + ex.Message);
                }
                ShowAll();
            }
        }

        private void dataGridViewCanceledOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCanceledOrders.Columns[e.ColumnIndex].Name == "Delete2" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewCanceledOrders.Rows[e.RowIndex].Cells["OrderId7"].Value.ToString();
                OrderOfCustomerModel order = _canceledOrders.FindLast(o => o.Id.ToString().Equals(OrderId_Value));
                try
                {
                    CustomerOrderDataAccess.DeleteOrder(OrderId_Value);
                    MessageBox.Show("删除订单成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除订单失败\r\n" + ex.Message);
                }
                ShowAll();
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
