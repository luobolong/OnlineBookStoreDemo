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
    public static class ReviewOfBookDataAccess
    {
        public static List<ReviewOfBookModel> GetReviews(string book_isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT cu.username, re.review_rate, re.review_content, re.review_date
                                FROM [dbo].[Reviews] re
                                LEFT JOIN [dbo].[Customers] cu
                                ON re.customer_id = cu.id
                                WHERE book_isbn = @BookISBN";
                List<ReviewOfBookModel> reviews = connection.Query<ReviewOfBookModel>(sql, new { BookISBN = book_isbn }).ToList();
                return reviews;
            }
        }
    }
}
