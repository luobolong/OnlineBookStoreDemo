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
    public static class OrderOfBookDataAccess
    {
        public static List<OrderOfBookModel> GetOrders(string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.[id], cu.[username], co.[amount], co.[total_price], co.[order_date], cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN[dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN[dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE book_isbn = @BookISBN";
                List<OrderOfBookModel> orders = connection.Query<OrderOfBookModel, CustomerOrderStatusModel, OrderOfBookModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { BookISBN = book_isbn }, splitOn: "id").ToList();
                return orders;
            }
        }
    }
}
