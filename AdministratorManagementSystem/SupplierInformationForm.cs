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
    public partial class SupplierInformationForm : Form
    {
        public delegate void SendOrdersInfo(List<OrderOfSupplierModel> orders);
        public event SendOrdersInfo SendOrdersInfoEvent;
        public SupplierInformationForm()
        {
            //设置窗体的双缓冲
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            InitializeComponent();

            //利用反射设置DataGridView的双缓冲
            Type dgvType = this.dataGridViewSuppliers.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridViewSuppliers, true, null);
        }

        private void ShowAllSupplierData()
        {
            try
            {
                dataGridViewSuppliers.Rows.Clear();
                var suppliers = SupplierDataAccess.GetAllSuppliers();
                foreach (var supplier in suppliers)
                {
                    int rowId = dataGridViewSuppliers.Rows.Add();
                    DataGridViewRow row = dataGridViewSuppliers.Rows[rowId];
                    row.Cells["Id"].Value = supplier.Id;
                    row.Cells["Username"].Value = supplier.Username;
                    row.Cells["RealName"].Value = supplier.Real_Name;
                    row.Cells["PasswordHash"].Value = supplier.Password_Hash;
                    row.Cells["PhoneNumber"].Value = supplier.Phone_Number;
                    row.Cells["EmailAddress"].Value = supplier.Email_Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowSupplierData(List<SupplierModel> suppliers)
        {
            dataGridViewSuppliers.Rows.Clear();
            foreach (var supplier in suppliers)
            {
                int rowId = dataGridViewSuppliers.Rows.Add();
                DataGridViewRow row = dataGridViewSuppliers.Rows[rowId];
                row.Cells["Id"].Value = supplier.Id;
                row.Cells["Username"].Value = supplier.Username;
                row.Cells["RealName"].Value = supplier.Real_Name;
                row.Cells["PasswordHash"].Value = supplier.Password_Hash;
                row.Cells["PhoneNumber"].Value = supplier.Phone_Number;
                row.Cells["EmailAddress"].Value = supplier.Email_Address;
            }
        }

        private void SupplierInformationForm_Load(object sender, EventArgs e)
        {
            ShowAllSupplierData();
            comboBoxOption.SelectedIndex = 0;
        }

        private void dataGridViewSuppliers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex <= 5)
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

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSuppliers.Columns[e.ColumnIndex].Name == "Order" && e.RowIndex >= 0)
            {
                string SupplierId_Value = dataGridViewSuppliers.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var orders = OrderOfSupplierDataAccess.GetOrders(SupplierId_Value);
                OrdersOfSupplierForm ordersOfCustomerForm = new OrdersOfSupplierForm();
                SendOrdersInfoEvent += ordersOfCustomerForm.ShowOrders;
                SendOrdersInfoEvent.Invoke(orders);
                ordersOfCustomerForm.ShowDialog();
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
                        ShowSupplierData(SupplierDataAccess.SelectSupplierById(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByExactUsername(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByExactRealName(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByExactPhoneNumber(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByExactEmailAddress(textBoxSearch.Text));
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
                        ShowSupplierData(SupplierDataAccess.SelectSupplierById(textBoxSearch.Text));
                        break;
                    case 1:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByVagueUsername(textBoxSearch.Text));
                        break;
                    case 2:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByVagueRealName(textBoxSearch.Text));
                        break;
                    case 3:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByVaguePhoneNumber(textBoxSearch.Text));
                        break;
                    case 4:
                        ShowSupplierData(SupplierDataAccess.SelectSupplierByVagueEmailAddress(textBoxSearch.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
