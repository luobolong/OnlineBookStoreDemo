using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class FullBookModel : BasicBookModel
    {
        public decimal Price { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public GenreModel Genre { get; set; }
        public decimal Book_Rate { get; set; }
        public DateTime? Publication_Date { get; set; }
        public string Introduction { get; set; }
    }
}
