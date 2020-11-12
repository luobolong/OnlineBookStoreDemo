using Helper.DataAccess;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplierClient
{
    public static class SupplierInfo
    {
        public static SupplierModel supplier { get; set; }
        public static void UpdateInfo()
        {
            if (supplier != null)
            {
                supplier = SupplierDataAccess.GetSupplierById(supplier.Id.ToString());
            }
        }
    }
}
