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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            BookMangementForm bookMangementForm = new BookMangementForm();
            bookMangementForm.ShowDialog();
        }

        #region 鼠标左键移动窗口
        Point mouseOff;
        bool leftFlag = false;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                this.Location = mouseSet;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCustomerInformation_Click(object sender, EventArgs e)
        {
            CustomerInformationForm customerInformationForm = new CustomerInformationForm();
            customerInformationForm.ShowDialog();
        }

        private void buttonSupplierInformation_Click(object sender, EventArgs e)
        {
            SupplierInformationForm supplierInformationForm = new SupplierInformationForm();
            supplierInformationForm.ShowDialog();
        }

        private void buttonCustomerOrderManagement_Click(object sender, EventArgs e)
        {
            CustomerOrderManagementForm customerOrderManagementForm = new CustomerOrderManagementForm();
            customerOrderManagementForm.ShowDialog();
        }

        private void buttonSupplierOrderManagement_Click(object sender, EventArgs e)
        {
            SupplierOrderManagementForm supplierOrderManagementForm = new SupplierOrderManagementForm();
            supplierOrderManagementForm.ShowDialog();
        }
    }
}
