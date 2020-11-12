using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class ReviewOfBookModel
    {
        public string Username { get; set; }
        public decimal Review_Rate { get; set; }
        public string Review_Content { get; set; }
        public DateTime Review_Date { get; set; }
    }
}
