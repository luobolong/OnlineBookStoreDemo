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
    public class NewBookInfoOfSupplierOrderDataAccess
    {
        public static SupplyNewBookInfoModel GetNewBookInfoBySupplierOrderId(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT so.*, sos.*, snbi.*, ge.*
                                FROM SupplierOrders so
                                LEFT JOIN SupplierOrderStatus sos ON so.status_id = sos.id
                                INNER JOIN SupplyNewBookInfo snbi ON so.id = snbi.order_id
								LEFT JOIN [dbo].[Genres] ge ON snbi.genre_clc = ge.clc
								WHERE snbi.order_id = @OrderId";
                var new_books = connection.Query<SupplierOrderModel, SupplierOrderStatusModel, SupplyNewBookInfoModel, GenreModel, SupplyNewBookInfoModel>(sql,
                    (supplier_order, order_status, new_book, genre) => 
                    {
                        new_book.Supplier_Order = supplier_order;
                        new_book.Supplier_Order.Status = order_status;
                        new_book.Genre = genre;
                        return new_book; 
                    }, new { OrderId = order_id }, splitOn: "id,order_id,clc").ToList();
                return new_books?[0];
            }
        }

        public static void InsertNewBook(int supplier_id, DateTime order_date, int amount,string book_isbn, string book_title, decimal book_price, string book_author, string book_publisher, string genre_clc, DateTime? publication_date, string introduction, bool isAuthorNull, bool isPublisherNull, bool isPublicationDateNull, bool isIntroductionNull)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                connection.Execute(SPStrings.SupplierOrder_Insert_New_Book, new
                {
                    SupplierId = supplier_id,
                    OrderDate = order_date,
                    Amount = amount,
                    BookISBN = book_isbn,
                    BookTitle = book_title,
                    BookPrice = book_price,
                    BookAuthor = isAuthorNull ? null : book_author,
                    BookPublisher = isPublisherNull ? null : book_publisher,
                    GenreClc = genre_clc,
                    PublicationDate = isPublicationDateNull ? null : publication_date,
                    Introduction = isIntroductionNull ? null : introduction,
                });
            }
        }
    }
}
