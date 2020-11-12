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
    public class CartDataAccess
    {
        public static void InsertItem(CustomerModel customer, FullBookModel book, int amount)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                connection.Execute(SPStrings.Carts_Add, new { CustomerId = customer.Id, BookISBN = book.ISBN, Amount = amount });
            }
        }

        public static List<CartModel> GetCartItems(int customer_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Cart_View] WHERE id = @CustomerId";
                List<CartModel> items = connection.Query<CartModel, CustomerModel, FullBookModel, CartModel>(sql,
                    (cart, customer, book) =>
                    {
                        cart.Customer = customer;
                        cart.Book = book;
                        return cart;
                    }, new { CustomerId = customer_id }, splitOn:"id,ISBN").ToList();
                return items;
            }
        }

        public static int SelectAmount(int customer_id, string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT amount FROM [dbo].[Carts] WHERE customer_id = @CustomerId and book_isbn = @BookISBN";
                int amount = connection.QueryFirst<int>(sql, new { CustomerId = customer_id, BookISBN = book_isbn });
                return amount;
            }
        }

        public static void DeleteCartItem(int customer_id, string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"DELETE FROM [dbo].[Carts] WHERE customer_id = @CustomerId and book_isbn = @BookISBN";
                connection.Execute(sql, new { CustomerId = customer_id, BookISBN = book_isbn });
            }
        }

        public static void UpdateCartItem(int customer_id, string book_isbn, int amount)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Carts] SET amount = @Amount WHERE customer_id = @CustomerId and book_isbn = @BookISBN";
                connection.Execute(sql, new { CustomerId = customer_id, BookISBN = book_isbn, Amount = amount });
            }
        }
    }
}
