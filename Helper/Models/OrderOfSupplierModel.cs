using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class OrderOfSupplierModel
    {
        public int Id { get; set; }
        public DateTime Order_Date { get; set; }
        public int Amount { get; set; }
        public bool Is_New { get; set; }
        public SupplierOrderStatusModel Status { get; set; }
    }
}
