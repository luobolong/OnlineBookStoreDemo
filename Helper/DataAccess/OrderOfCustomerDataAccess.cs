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
    public static class OrderOfCustomerDataAccess
    {
        public static List<OrderOfCustomerModel> GetAllOrders(string customer_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT cu.[id], cu.[book_isbn], bo.[title], cu.[amount], cu.[total_price], cu.[order_date], co.*
                                FROM [dbo].[CustomerOrders] cu
                                LEFT JOIN [dbo].[Books] bo ON cu.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] co ON cu.status_id = co.id
                                WHERE customer_id = @CustomerId";
                List<OrderOfCustomerModel> orders = connection.Query<OrderOfCustomerModel, CustomerOrderStatusModel, OrderOfCustomerModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { CustomerID = customer_id }, splitOn: "id").ToList();
                return orders;
            }
        }

        public static List<OrderOfCustomerModel> GetAllOrders(int customer_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT cu.[id], cu.[book_isbn], bo.[title], cu.[amount], cu.[total_price], cu.[order_date], co.*
                                FROM [dbo].[CustomerOrders] cu
                                LEFT JOIN [dbo].[Books] bo ON cu.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] co ON cu.status_id = co.id
                                WHERE customer_id = @CustomerId";
                List<OrderOfCustomerModel> orders = connection.Query<OrderOfCustomerModel, CustomerOrderStatusModel, OrderOfCustomerModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { CustomerID = customer_id }, splitOn: "id").ToList();
                return orders;
            }
        }

        public static List<OrderOfCustomerModel> GetOrdersByStatusId(int customer_id, int status_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT cu.[id], cu.[book_isbn], bo.[title], cu.[amount], cu.[total_price], cu.[order_date]
                                FROM [dbo].[CustomerOrders] cu
                                LEFT JOIN [dbo].[Books] bo ON cu.book_isbn = bo.ISBN
                                WHERE customer_id = @CustomerId and status_id = @StatusId";
                List<OrderOfCustomerModel> orders = connection.Query<OrderOfCustomerModel>(sql, new { CustomerID = customer_id, StatusId = status_id }).ToList();
                return orders;
            }
        }
    }
}
