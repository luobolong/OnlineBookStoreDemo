using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class OrderOfCustomerModel
    {
        public int Id { get; set; }
        public string Book_ISBN { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public decimal Total_Price { get; set; }
        public DateTime Order_Date { get; set; }
        public CustomerOrderStatusModel Status { get; set; }
    }
}
