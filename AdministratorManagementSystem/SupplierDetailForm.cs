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
    public partial class SupplierDetailForm : Form
    {
        public SupplierDetailForm()
        {
            InitializeComponent();
        }

        public void ShowDetail(SupplierModel supplier)
        {
            textBoxId.Text = supplier.Id.ToString();
            textBoxUsername.Text = supplier.Username;
            textBoxRealName.Text = supplier.Real_Name;
            textBoxPasswordHash.Text = supplier.Password_Hash;
            textBoxPhoneNumber.Text = supplier.Phone_Number;
            textBoxEmailAddress.Text = supplier.Email_Address;
        }
    }
}
