using Helper;
using Helper.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DataAccess
{
    public static class OrderOfSupplierDataAccess
    {
        public static List<OrderOfSupplierModel> GetOrders(string supplier_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT su.id, su.order_date, su.amount, su.is_new, sos.*
                                FROM [dbo].[SupplierOrders] su
                                LEFT JOIN [dbo].[SupplierOrderStatus] sos ON su.status_id = sos.id
                                WHERE supplier_id = @SupplierId";
                List<OrderOfSupplierModel> orders = connection.Query<OrderOfSupplierModel, SupplierOrderStatusModel, OrderOfSupplierModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { SupplierId = supplier_id }, splitOn: "id").ToList();
                return orders;
            }
        }

        public static List<OrderOfSupplierModel> GetOrders(int supplier_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT su.id, su.order_date, su.amount, su.is_new, sos.*
                                FROM [dbo].[SupplierOrders] su
                                LEFT JOIN [dbo].[SupplierOrderStatus] sos ON su.status_id = sos.id
                                WHERE supplier_id = @SupplierId";
                List<OrderOfSupplierModel> orders = connection.Query<OrderOfSupplierModel, SupplierOrderStatusModel, OrderOfSupplierModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { SupplierId = supplier_id }, splitOn: "id").ToList();
                return orders;
            }
        }
    }
}
