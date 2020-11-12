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
    public partial class CustomerDetailForm : Form
    {
        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        public void ShowDetail(CustomerModel customer)
        {
            textBoxId.Text = customer.Id.ToString();
            textBoxUsername.Text = customer.Username;
            textBoxRealName.Text = customer.Real_Name;
            textBoxPasswordHash.Text = customer.Password_Hash;
            textBoxAddress.Text = customer.Address;
            textBoxPhoneNumber.Text = customer.Phone_Number;
            textBoxEmailAddress.Text = customer.Email_Address;
            textBoxWalletBalance.Text = customer.Wallet_Balance.ToString();
        }
    }
}
