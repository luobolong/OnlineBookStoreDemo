using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class CustomerOrderStatusModel
    {
        public int Id { get; set; }
        public string Status_Name { get; set; }
        public override string ToString()
        {
            return Status_Name;
        }
    }
}
