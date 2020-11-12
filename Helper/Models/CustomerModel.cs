using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class CustomerModel
    {
        public int Id { get; private set; }
        public string Real_Name { get; private set; }
        public string Username { get; private set; }
        public string Password_Hash { get; private set; }
        public string Address { get; private set; }
        public string Phone_Number { get; private set; }
        public decimal Wallet_Balance { get; private set; }
        public string Email_Address { get; private set; }
    }
}
