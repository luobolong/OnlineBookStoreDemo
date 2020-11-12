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
    public static class ReviewDataAccess
    {
        
        public static void InsertReview(int customer_id, string book_isbn, decimal review_rate, string review_content, DateTime review_date, bool is_review_content_null)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"INSERT INTO [dbo].[Reviews](customer_id, book_isbn, review_rate, review_content, review_date)
                                VALUES (@CustomerId, @BookISBN, @ReviewRate, @ReviewContent, @ReviewDate)";
                connection.Execute(sql, new 
                { 
                    CustomerId = customer_id, 
                    BookISBN = book_isbn, 
                    ReviewRate = review_rate, 
                    ReviewContent = is_review_content_null ? null : review_content, 
                    ReviewDate = review_date 
                });
            }
        }

        public static bool IsReviewed(int customer_id, string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT 1 FROM [dbo].[Reviews] WHERE customer_id = @CustomerId and book_isbn = @BookISBN";
                return connection.ExecuteScalar<bool>(sql, new { CustomerId = customer_id, BookISBN = book_isbn });
            }
        }

        public static void UpdateReview(int customer_id, string book_isbn, decimal review_rate, string review_content, DateTime review_date, bool is_review_content_null)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Reviews]
                                SET review_rate = @ReviewRate, review_content = @ReviewContent, review_date = @ReviewDate
                                WHERE customer_id = @CustomerId and book_isbn = @BookISBN";
                connection.Execute(sql, new 
                { 
                    CustomerId = customer_id, 
                    BookISBN = book_isbn, 
                    ReviewRate = review_rate, 
                    ReviewContent = is_review_content_null? null : review_content, 
                    ReviewDate = review_date 
                });
            }
        }

        public static void DeleteReview(int customer_id, string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"DELETE FROM [dbo].[Reviews] WHERE customer_id = @CustomerId and book_isbn = @BookISBN";
                connection.Execute(sql, new { CustomerId = customer_id, BookISBN = book_isbn });
            }
        }
    }
}
