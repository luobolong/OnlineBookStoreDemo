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
    public static class SupplierOrderDataAccess
    {
        public static void InsertSupplierOrderOfExistentBook(int supplier_id, DateTime order_date, int amount, string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                connection.Execute(SPStrings.SupplierOrder_Insert_Existent_Book, new { SupplierId = supplier_id, OrderDate = order_date, Amount = amount, BookISBN = book_isbn });
            }
        }
        
        
        public static List<SupplierOrderModel> GetAllSupplierOrders()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }
        
        public static List<SupplyExistentBookInfoModel> GetOrdersOfExistentBook()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT so.*, sos.*, sebi.*
                                FROM SupplierOrders so
                                LEFT JOIN SupplierOrderStatus sos ON so.status_id = sos.id
                                INNER JOIN SupplyExistentBookInfo sebi ON so.id = sebi.order_id";
                List<SupplyExistentBookInfoModel> orders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplyExistentBookInfoModel, SupplyExistentBookInfoModel>(sql,
                    (supplier_order, status, info) => 
                    {
                        info.Supplier_Order = supplier_order;
                        info.Supplier_Order.Status = status;
                        return info; 
                    }, splitOn:"id,order_id").ToList();
                return orders;
            }
        }

        public static List<SupplyNewBookInfoModel> GetOrdersOfNewBook()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT so.*, sos.*, snbi.*, g.*
                                FROM SupplierOrders so
                                LEFT JOIN SupplierOrderStatus sos ON so.status_id = sos.id
                                INNER JOIN SupplyNewBookInfo snbi ON so.id = snbi.order_id
                                LEFT JOIN Genres g ON g.clc = snbi.genre_clc";
                List<SupplyNewBookInfoModel> orders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplyNewBookInfoModel, GenreModel, SupplyNewBookInfoModel>(sql,
                    (supplier_order, status, info, genre) =>
                    {
                        info.Supplier_Order = supplier_order;
                        info.Supplier_Order.Status = status;
                        info.Genre = genre;
                        return info;
                    }, splitOn: "id,order_id,clc").ToList();
                return orders;
            }
        }

        public static bool GetIsNewBook(string order_id)
        {
            var orders = SelectOrderByOrderId(order_id);
            if(orders.Count == 0)
            {
                throw new MyException("图书不存在");
            }
            else
            {
                return orders[0].Is_New;
            }
        }

        public static SupplyNewBookInfoModel GetOrderOfNewBookByOrderId(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT so.*, sos.*, snbi.*, g.*
                                FROM SupplierOrders so
                                LEFT JOIN SupplierOrderStatus sos ON so.status_id = sos.id
                                INNER JOIN SupplyNewBookInfo snbi ON so.id = snbi.order_id
                                LEFT JOIN Genres g ON g.clc = snbi.genre_clc
                                WHERE so.id = @OrderId";
                List<SupplyNewBookInfoModel> orders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplyNewBookInfoModel, GenreModel, SupplyNewBookInfoModel>(sql,
                    (supplier_order, status, info, genre) =>
                    {
                        info.Supplier_Order = supplier_order;
                        info.Supplier_Order.Status = status;
                        info.Genre = genre;
                        return info;
                    }, new { OrderId = order_id }, splitOn: "id,order_id,clc").ToList();
                if (orders.Count == 0)
                {
                    return null;
                }
                else
                {
                    return orders[0];
                }
            }
        }

        public static SupplyExistentBookInfoModel GetOrderOfExistentBookByOrderId(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT so.*, sos.*, sebi.*
                                FROM SupplierOrders so
                                LEFT JOIN SupplierOrderStatus sos ON so.status_id = sos.id
                                INNER JOIN SupplyExistentBookInfo sebi ON so.id = sebi.order_id
                                WHERE so.id = @OrderId";
                List<SupplyExistentBookInfoModel> orders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplyExistentBookInfoModel, SupplyExistentBookInfoModel>(sql,
                    (supplier_order, status, info) =>
                    {
                        info.Supplier_Order = supplier_order;
                        info.Supplier_Order.Status = status;
                        return info;
                    }, new { OrderId = order_id }, splitOn: "id,order_id").ToList();
                if (orders.Count == 0)
                {
                    return null;
                }
                else
                {
                    return orders[0];
                }
            }
        }

        public static int GetStatusIdValue(string order_id)
        {
            var orders = SelectOrderByOrderId(order_id);
            return orders[0].Status.Id;
        }

        public static void WarehouseNewBook(string order_id, bool is_on_sale)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE dbo.SupplierOrders SET status_id = 2 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
            var order = GetOrderOfNewBookByOrderId(order_id);
            bool isAuthorNull = order.Book_Author.Equals(null);
            bool isPublisherNull = order.Book_Publisher.Equals(null);
            bool isPublicationDateNull = !order.Publication_Date.HasValue;
            bool isIntroductonNull = order.Introduction.Equals(null);
            if (BookDataAccess.IsBookExisted(order.Book_ISBN))
            {
                int quantity = BookDataAccess.GetBookQuantityByISBN(order.Book_ISBN);
                int nQuantity = quantity + order.Supplier_Order.Amount;
                try
                {
                    BookDataAccess.UpdateBookQuantity(order.Book_ISBN, nQuantity);
                }
                catch (Exception ex)
                {
                    throw new MyException("添加图书失败\n" + ex.Message);
                }
            }
            else
            {
                try
                {
                    BookDataAccess.InsertBook(order.Book_ISBN, order.Book_Title, order.Book_Price, order.Book_Author, order.Book_Publisher, order.Genre, order.Supplier_Order.Amount, order.Publication_Date, order.Introduction, is_on_sale, isAuthorNull, isPublisherNull, isPublicationDateNull, isIntroductonNull);
                }
                catch (Exception ex)
                {
                    throw new MyException("添加图书失败\n" + ex.Message);
                }
            }
        }

        public static void WarehouseExistentBook(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE dbo.SupplierOrders SET status_id = 2 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
            var order = GetOrderOfExistentBookByOrderId(order_id);
            string book_isbn = order.Book_ISBN;
            int amount = order.Supplier_Order.Amount;
            if (BookDataAccess.IsBookExisted(book_isbn))
            {
                throw new MyException("入库失败 图书不存在");
            }
            int quantity = BookDataAccess.GetBookQuantityByISBN(book_isbn);
            int nQuantity = quantity + amount;
            try
            {
                BookDataAccess.UpdateBookQuantity(book_isbn, nQuantity);
            }
            catch(Exception ex)
            {
                throw new MyException("更新图书数量失败\n" + ex.Message);
            }
        }

        public static void CancelOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE dbo.SupplierOrders SET status_id = 3 WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }

        public static void DeleteOrder(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"DELETE FROM dbo.SupplierOrders WHERE id = @OrderId";
                connection.Execute(sql, new { OrderId = order_id });
            }
        }
        #region 搜索
        public static List<SupplierOrderModel> SelectOrderByOrderId(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.SupplierOrders.id = @Keyword";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword}, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }


        public static List<SupplierOrderModel> SelectOrderBySupplierId(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.SupplierOrders.supplier_id = @Keyword";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByExactUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.Suppliers.username = @Keyword";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByVagueUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.Suppliers.username LIKE '%' + @Keyword + '%'";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByOrderDate(string keyword)
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
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE DATEPART(YEAR, dbo.SupplierOrders.order_date) = @Year and DATEPART(MONTH, dbo.SupplierOrders.order_date) = @Month and DATEPART(DAY, dbo.SupplierOrders.order_date)";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Year = date.Year, Month = date.Month, Day = date.Day }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByAmount(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.SupplierOrders.amount = @Keyword";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByStatusId(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.SupplierOrders.status_id = @Keyword";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByExactStatusName(string keyword)
        {
            if (keyword.Length > 10)
            {
                throw new MyException("状态名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.SupplierOrderStatus.status_name = @Keyword";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByVagueStatusName(string keyword)
        {
            if (keyword.Length > 10)
            {
                throw new MyException("状态名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.SupplierOrderStatus.status_name LIKE '%' + @Keyword + '%'";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }

        public static List<SupplierOrderModel> SelectOrderByIsNewBook(string keyword)
        {
            if (!StringChecker.IsBit(keyword))
            {
                throw new MyException("请输入0或1");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT   dbo.SupplierOrders.*, dbo.SupplierOrderStatus.*, dbo.Suppliers.*
                                FROM      dbo.SupplierOrders INNER JOIN
                                dbo.SupplierOrderStatus ON dbo.SupplierOrders.status_id = dbo.SupplierOrderStatus.id INNER JOIN
                                dbo.Suppliers ON dbo.SupplierOrders.supplier_id = dbo.Suppliers.id
                                WHERE dbo.SupplierOrders.is_new = @Keyword";
                List<SupplierOrderModel> supplierOrders = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplierModel, SupplierOrderModel>(sql,
                    (order, status, supplier) =>
                    {
                        order.Status = status;
                        order.Supplier = supplier;
                        return order;
                    }, new { Keyword = keyword }, splitOn: "id,id").ToList();
                return supplierOrders;
            }
        }
        #endregion
    }
}
