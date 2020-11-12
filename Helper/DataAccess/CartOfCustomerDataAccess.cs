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
    public static class CartOfCustomerDataAccess
    {
        public static List<CartOfCustomerModel> GetCart(string customer_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ca.book_isbn, bo.title, ca.amount from [dbo].[Carts] ca
                                LEFT JOIN [dbo].[Books] bo
                                ON ca.book_isbn = bo.ISBN
                                WHERE customer_id = @CustomerId";
                List<CartOfCustomerModel> cart = connection.Query<CartOfCustomerModel>(sql, new { CustomerId = customer_id }).ToList();
                return cart;
            }
        }
    }
}
