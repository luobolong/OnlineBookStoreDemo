using Helper;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerClient
{
    public partial class TopUpForm : Form
    {
        private decimal _money { get; set; }
        public TopUpForm()
        {
            InitializeComponent();
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButtonOK_Click(object sender, EventArgs e)
        {
            if(textBoxMoney.Text.Equals(""))
            {
                MessageBox.Show("数额为空");
                return;
            }
            try
            {
                _money = decimal.Parse(textBoxMoney.Text);
            }
            catch
            {
                MessageBox.Show("输入的数额有误");
                return;
            }
            if (_money.Equals(0))
            {
                MessageBox.Show("数额不得为0");
                return;
            }
            try
            {
                CustomerDataAccess.TopUp(CustomerInfo.customer.Id, _money);
                CustomerInfo.UpdateInfo();
                MessageBox.Show("充值成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show("充值失败\r\n" + ex.Message);
            }
            
        }

        private void textBoxMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(textBoxMoney.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
