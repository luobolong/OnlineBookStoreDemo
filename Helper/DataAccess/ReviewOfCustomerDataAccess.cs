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
    public static class ReviewOfCustomerDataAccess
    {
        public static List<ReviewOfCustomerModel> GetReviews(string customer_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT re.book_isbn, bo.title, re.review_rate, re.review_content, re.review_date
                                FROM [dbo].[Reviews] re
                                LEFT JOIN [dbo].[Books] bo
                                ON re.book_isbn = bo.ISBN
                                WHERE customer_id = @CustomerId";
                List<ReviewOfCustomerModel> reviews = connection.Query<ReviewOfCustomerModel>(sql, new { CustomerID = customer_id }).ToList();
                return reviews;
            }
        }
        public static List<ReviewOfCustomerModel> GetReviews(int customer_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT re.book_isbn, bo.title, re.review_rate, re.review_content, re.review_date
                                FROM [dbo].[Reviews] re
                                LEFT JOIN [dbo].[Books] bo
                                ON re.book_isbn = bo.ISBN
                                WHERE customer_id = @CustomerId";
                List<ReviewOfCustomerModel> reviews = connection.Query<ReviewOfCustomerModel>(sql, new { CustomerID = customer_id }).ToList();
                return reviews;
            }
        }

        public static ReviewOfCustomerModel GetReviewByISBN(int customer_id, string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT re.book_isbn, bo.title, re.review_rate, re.review_content, re.review_date
                                FROM [dbo].[Reviews] re
                                LEFT JOIN [dbo].[Books] bo
                                ON re.book_isbn = bo.ISBN
                                WHERE customer_id = @CustomerId and book_isbn = @BookISBN";
                ReviewOfCustomerModel review = connection.QueryFirst<ReviewOfCustomerModel>(sql, new { CustomerID = customer_id, BookISBN = book_isbn });
                return review;
            }
        }
    }
}
