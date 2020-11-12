using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class BasicBookModel
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public bool Is_On_Sale { get; set; }
    }
}
