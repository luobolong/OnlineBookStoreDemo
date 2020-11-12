using Helper.DataAccess;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerClient
{
    public static class CustomerInfo
    {
        public static CustomerModel customer { get; set; }
        public static void UpdateInfo()
        {
            if(customer != null)
            {
                customer = CustomerDataAccess.GetCustomerById(customer.Id.ToString());
            }
        }
    }
}
