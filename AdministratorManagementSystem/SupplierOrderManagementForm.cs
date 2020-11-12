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
    public partial class SupplierOrderManagementForm : Form
    {
        public delegate void SendSupplierInfo(SupplierModel supplier);
        public event SendSupplierInfo SendSupplierInfoEvent;

        public delegate void SendBookInfo(FullBookModel book);
        public event SendBookInfo SendBookInfoEvent;

        public delegate void SendNewBookInfo(SupplyNewBookInfoModel book);
        public event SendNewBookInfo SendNewBookInfoEvent;
        public SupplierOrderManagementForm()
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

        private void ShowAllSupplierOrderData()
        {
            try
            {
                dataGridViewOrders.Rows.Clear();
                var orders = SupplierOrderDataAccess.GetAllSupplierOrders();
                foreach (var order in orders)
                {
                    int rowId = dataGridViewOrders.Rows.Add();
                    DataGridViewRow row = dataGridViewOrders.Rows[rowId];
                    row.Cells["OrderId"].Value = order.Id;
                    row.Cells["SupplierId"].Value = order.Supplier.Id;
                    row.Cells["Username"].Value = order.Supplier.Username;
                    row.Cells["OrderDate"].Value = order.Order_Date.ToString("yyyy-MM-dd hh:mm:ss");
                    row.Cells["Amount"].Value = order.Amount;
                    row.Cells["Status"].Value = order.Status;
                    row.Cells["IsNew"].Value = order.Is_New ? "是" : "否";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("刷新失败\n" + ex.Message);
            }
        }

        private void ShowSupplierOrdersData(List<SupplierOrderModel> orders)
        {
            dataGridViewOrders.Rows.Clear();
            foreach (var order in orders)
            {
                int rowId = dataGridViewOrders.Rows.Add();
                DataGridViewRow row = dataGridViewOrders.Rows[rowId];
                row.Cells["OrderId"].Value = order.Id;
                row.Cells["SupplierId"].Value = order.Supplier.Id;
                row.Cells["Username"].Value = order.Supplier.Username;
                row.Cells["OrderDate"].Value = order.Order_Date.ToString("yyyy-MM-dd hh:mm:ss");
                row.Cells["Amount"].Value = order.Amount.ToString();
                row.Cells["Status"].Value = order.Status;
                row.Cells["IsNew"].Value = order.Is_New ? "是" : "否";
            }
        }

        private void SupplierOrderManagementForm_Load(object sender, EventArgs e)
        {
            ShowAllSupplierOrderData();
            comboBoxOption.SelectedIndex = 0;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowAllSupplierOrderData();
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
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByOrderId(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderBySupplierId(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByExactUsername(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByOrderDate(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByAmount(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByStatusId(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByExactStatusName(textBoxSearch.Text));
                        break;
                    case 7:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByIsNewBook(textBoxSearch.Text));
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
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByOrderId(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderBySupplierId(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByVagueUsername(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByOrderDate(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByAmount(textBoxSearch.Text));
                        break;
                    case 5:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByStatusId(textBoxSearch.Text));
                        break;
                    case 6:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByVagueStatusName(textBoxSearch.Text));
                        break;
                    case 7:
                        ShowSupplierOrdersData(SupplierOrderDataAccess.SelectOrderByIsNewBook(textBoxSearch.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "SupplierDetail" && e.RowIndex >= 0)
            {
                string Username_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["SupplierId"].Value.ToString();
                var supplier = SupplierDataAccess.GetSupplierById(Username_Value);
                SupplierDetailForm supplierDetailForm = new SupplierDetailForm();
                SendSupplierInfoEvent += supplierDetailForm.ShowDetail;
                SendSupplierInfoEvent.Invoke(supplier);
                supplierDetailForm.ShowDialog();
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "BookDetail" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value?.ToString();
                bool IsNewBook;
                try
                {
                    IsNewBook = SupplierOrderDataAccess.GetIsNewBook(OrderId_Value);
                }
                catch (MyException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (!IsNewBook)
                {
                    var book = BookDataAccess.GetFullBookBySupplierExistentBookOrderId(OrderId_Value);
                    if (book == null)
                    {
                        MessageBox.Show("图书不存在");
                        return;
                    }
                    BookDetailForm detailForm = new BookDetailForm();
                    SendBookInfoEvent += detailForm.ShowDetail;
                    SendBookInfoEvent.Invoke(book);
                    detailForm.ShowDialog();
                }
                else
                {
                    var new_book = NewBookInfoOfSupplierOrderDataAccess.GetNewBookInfoBySupplierOrderId(OrderId_Value);
                    int status_id = new_book.Supplier_Order.Status.Id;
                    if (status_id == 1) // 未入库
                    {
                        BookUnstockedDetailForm detailForm = new BookUnstockedDetailForm();
                        SendNewBookInfoEvent += detailForm.ShowNewBookDetail;
                        SendNewBookInfoEvent.Invoke(new_book);
                        detailForm.ShowDialog();
                    }
                    else // 已入库
                    {
                        var book = BookDataAccess.GetFullBookByISBN(new_book.Book_ISBN);
                        if (book == null)
                        {
                            MessageBox.Show("图书不存在");
                            return;
                        }
                        BookDetailForm detailForm = new BookDetailForm();
                        SendBookInfoEvent += detailForm.ShowDetail;
                        SendBookInfoEvent.Invoke(book);
                        detailForm.ShowDialog();
                    }
                }
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Warehouse" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                int StatusId_Value = SupplierOrderDataAccess.GetStatusIdValue(OrderId_Value);
                if (StatusId_Value == 1)
                {
                    bool IsNewBook;
                    try
                    {
                        IsNewBook = SupplierOrderDataAccess.GetIsNewBook(OrderId_Value);
                    }
                    catch (MyException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    if (IsNewBook)
                    {
                        bool is_on_sale = MessageBox.Show("是否立即上架该图书？", "上架", MessageBoxButtons.OKCancel) == DialogResult.OK;
                        try
                        {
                            SupplierOrderDataAccess.WarehouseNewBook(OrderId_Value, is_on_sale);
                        }
                        catch (MyException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            SupplierOrderDataAccess.WarehouseExistentBook(OrderId_Value);
                        }
                        catch(MyException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                ShowAllSupplierOrderData();
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Cancel" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                try
                {
                    SupplierOrderDataAccess.CancelOrder(OrderId_Value);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("取消订单失败\n" + ex.Message);
                }
                ShowAllSupplierOrderData();
            } else if (dataGridViewOrders.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                string OrderId_Value = dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
                try
                {
                    SupplierOrderDataAccess.DeleteOrder(OrderId_Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除订单失败\n" + ex.Message);
                }
                ShowAllSupplierOrderData();
            }
        }

        private void dataGridViewOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex <= 6)
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
