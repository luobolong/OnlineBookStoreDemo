﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class SupplyExistentBookInfoModel
    {
        public SupplierOrderModel Supplier_Order { get; set; }
        public string Book_ISBN { get; set; }
    }
}
