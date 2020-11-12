using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class CartModel
    {
        public CustomerModel Customer { get; set; }
        public FullBookModel Book { get; set; }
        public int Amount { get; set; }
    }
}
