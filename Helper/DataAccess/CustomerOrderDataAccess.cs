using Dapper;
using Helper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.DataAccess
{
    public static class CustomerOrderDataAccess
    {
        public static List<CustomerOrderModel> GetAllCustomerOrders()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, splitOn:"id").ToList();
                return customerOrders;
            }
        }

        public static string GetBookISBNById(string id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT book_isbn FROM [dbo].[CustomerOrders] WHERE id = @Id";
                return connection.QueryFirst<string>(sql, new { @Id = id });
            }
        }

        public static int GetAmountById(string id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT amount FROM [dbo].[CustomerOrders] WHERE id = @Id";
                return connection.QueryFirst<int>(sql, new { @Id = id });
            }
        }

        public static void SubmitOrder(int customer_id, string book_isbn, int amount, decimal total_price, DateTime order_date)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"INSERT INTO [dbo].[CustomerOrders] (customer_id, book_isbn, amount, total_price, order_date, status_id)
                                VALUES (@CustomerId, @BookISBN, @Amount, @TotalPrice, @OrderDate, 1)";
                connection.Execute(sql, new { CustomerId = customer_id, BookISBN = book_isbn, Amount = amount, TotalPrice = total_price, OrderDate = order_date });
            }
        }

        public static void PayOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[CustomerOrders] SET status_id = 2 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }


        public static void ShipOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[CustomerOrders] SET status_id = 3 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }

        public static void ReceiveOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[CustomerOrders] SET status_id = 4 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }

        public static void FinishOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[CustomerOrders] SET status_id = 5 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }

        public static void CancelOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[CustomerOrders] SET status_id = 6 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }

        public static void DeleteOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"DELETE FROM [dbo].[CustomerOrders] WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }


        #region 搜索
        public static List<CustomerOrderModel> SelectOrderById(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE co.id = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByCustomerId(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE co.customer_id = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByExactUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE cu.username = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByVagueUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE cu.username LIKE '%' + @Keyword + '%'";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByExactISBN(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("ISBN搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE co.book_isbn = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByVagueISBN(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("ISBN搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE co.book_isbn LIKE '%' + @Keyword + '%'";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByExactTitle(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("题名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE bo.title = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByVagueTitle(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("题名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE bo.title LIKE '%' + @Keyword + '%'";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByAmount(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE co.amount = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByTotalPrice(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE co.total_price = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByOrderDate(string keyword)
        {
            DateTime date = new DateTime();
            if (!StringChecker.IsDate(keyword))
            {
                throw new MyException("请输入一个日期");
            }
            else
            {
                date = Convert.ToDateTime(keyword);
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE DATEPART(YEAR, co.order_date) = @Year and DATEPART(MONTH, co.order_date) = @Month and DATEPART(DAY, co.order_date) = @Day";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, 
                    new { Year = date.Year, Month = date.Month, Day = date.Day }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByStatusId(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE co.status_id = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByExactStatusName(string keyword)
        {
            if (keyword.Length > 10)
            {
                throw new MyException("状态名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE cs.status_name = @Keyword";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        public static List<CustomerOrderModel> SelectOrderByVagueStatusName(string keyword)
        {
            if (keyword.Length > 10)
            {
                throw new MyException("状态名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT co.*, cu.username, bo.title, cs.*
                                FROM [dbo].[CustomerOrders] co
                                LEFT JOIN [dbo].[Customers] cu ON co.customer_id = cu.id
                                LEFT JOIN [dbo].[Books] bo ON co.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[CustomerOrderStatus] cs ON co.status_id = cs.id
                                WHERE cs.status_name LIKE '%' + @Keyword + '%'";
                List<CustomerOrderModel> customerOrders = connection.Query<CustomerOrderModel, CustomerOrderStatusModel, CustomerOrderModel>(sql,
                    (order, status) => { order.Status = status; return order; }, new { Keyword = keyword }, splitOn: "id").ToList();
                return customerOrders;
            }
        }

        #endregion
    }
}
