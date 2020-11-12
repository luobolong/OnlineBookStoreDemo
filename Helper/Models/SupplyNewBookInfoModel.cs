using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class SupplyNewBookInfoModel
    {
        public SupplierOrderModel Supplier_Order { get; set; }
        public string Book_ISBN { get; set; }
        public string Book_Title { get; set; }
        public decimal Book_Price { get; set; }
        public string Book_Author { get; set; }
        public string Book_Publisher { get; set; }
        public GenreModel Genre { get; set; }
        public DateTime? Publication_Date { get; set; }
        public string Introduction { get; set; }
    }
}
