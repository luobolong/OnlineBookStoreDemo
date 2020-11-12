using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class CartOfCustomerModel
    {
        public string Book_ISBN { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
    }
}
