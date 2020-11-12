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
    public static class BookDataAccess
    {
        public static List<BasicBookModel> GetAllBasicBooks()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql).ToList();
                return books;
            }
        }

        public static List<FullBookModel> GetAllOnsaleBooks()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Books] WHERE is_on_sale = 1";
                List<FullBookModel> books = connection.Query<FullBookModel>(sql).ToList();
                return books;
            }
        }

        public static FullBookModel GetFullBookByISBN(string isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT bo.*, ge.*
                                FROM [dbo].[Books] bo
                                LEFT JOIN [dbo].[Genres] ge ON bo.genre_clc = ge.clc
                                WHERE ISBN = @ISBN";
                var books = connection.Query<FullBookModel, GenreModel, FullBookModel>(sql,
                    (book, genre) => { book.Genre = genre; return book; }, new { ISBN = isbn }, splitOn : "clc").ToList();
                if (books.Count == 0)
                {
                    return null;
                }
                else
                {
                    return books[0];
                }
            }
        }

        public static int GetBookQuantityByISBN(string isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT quantity FROM [dbo].[Books] WHERE ISBN = @ISBN";
                return connection.QueryFirst<int>(sql, new { ISBN = isbn });
            }
        }

        public static bool IsBookExisted(string isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT 1 FROM [dbo].[Books] WHERE ISBN = @ISBN";
                return connection.ExecuteScalar<bool>(sql, new { ISBN = isbn});
            }
        }

        public static void InsertBook(string isbn, string title, decimal price, string author, string publisher, GenreModel genre, decimal quantity, DateTime? publication_date, string introduction, bool is_on_sale, bool isAuthorNull, bool isPublisherNull, bool isPublicationDateNull, bool isIntroductionNull)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"INSERT INTO [dbo].[Books] (ISBN, title, price, author, publisher, genre_clc, quantity, publication_date, introduction, is_on_sale)
                                VALUES(@ISBN, @Title, @Price, @Author, @Publisher, @GenreClc, @Quantity, @PublicationDate, @Introduction, @IsOnSale)";
                connection.Execute(sql, new
                {
                    ISBN = isbn,
                    Title = title,
                    Price = price,
                    Author = isAuthorNull ? null : author,
                    Publisher = isPublisherNull ? null : publisher,
                    GenreClc = genre.Clc,
                    Quantity = quantity,
                    PublicationDate = isPublicationDateNull ? null : publication_date,
                    Introduction = isIntroductionNull ? null : introduction,
                    IsOnSale = is_on_sale
                });
            }
        }

        public static void UpdateBook(string isbn, string title, decimal price, string author, string publisher, GenreModel genre, decimal quantity, DateTime? publication_date, string introduction, bool is_on_sale, bool isAuthorNull, bool isPublisherNull, bool isPublicationDateNull, bool isIntroductionNull)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Books]
                                SET title = @Title, price = @Price, author = @Author,
                                publisher = @Publisher, genre_clc = @GenreClc, quantity = @Quantity,
                                publication_date = @PublicationDate, introduction = @Introduction, is_on_sale = @IsOnSale
                                WHERE ISBN = @ISBN";
                connection.Execute(sql, new
                {
                    Title = title,
                    Price = price,
                    Author = isAuthorNull ? null : author,
                    Publisher = isPublisherNull ? null : publisher,
                    GenreClc = genre.Clc,
                    Quantity = quantity,
                    PublicationDate = isPublicationDateNull ? null : ((DateTime)publication_date).ToString("yyyy-MM-dd"),
                    Introduction = isIntroductionNull ? null : introduction,
                    ISBN = isbn,
                    IsOnSale = is_on_sale
                });
            }
        }

        public static void UpdateBookQuantity(string isbn, int quantity)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Books]
                                SET quantity = @Quantity
                                WHERE ISBN = @ISBN";
                connection.Execute(sql, new { ISBN = isbn, Quantity = quantity });
            }
        }
        public static void DeleteBook(string isbn)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"DELETE FROM [dbo].[Books] WHERE ISBN = @ISBN";
                connection.Execute(sql, new { ISBN = isbn });
            }
        }
        #region 搜索
        public static List<BasicBookModel> SelectBookByExactISBN(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("ISBN搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE ISBN = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByVagueISBN(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("ISBN搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE ISBN LIKE '%' + @Keyword + '%'";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByExactTitle(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("题名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books] 
                                WHERE title = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByVagueTitle(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("题名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books] 
                                WHERE title LIKE '%' + @Keyword + '%'";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByExactAuthor(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("作者搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE author = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }


        public static List<BasicBookModel> SelectBookByVagueAuthor(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("作者搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE author LIKE '%' + @Keyword + '%'";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByExactPublisher(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("出版社搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE publisher = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByVaguePublisher(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("出版社搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE publisher LIKE '%' + @Keyword + '%'";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByGenreClc(string keyword)
        {
            if (keyword.Length > 1)
            {
                throw new MyException("中图检索号搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE genre_clc = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByPublicationYear(string keyword)
        {
            if (!StringChecker.IsYear(keyword))
            {
                throw new MyException("请输入正确的年份");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE DATEPART(YEAR, publication_date) = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByQuantity(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE Quantity = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByPrice(string keyword)
        {
            if (!StringChecker.IsNumberic(keyword))
            {
                throw new MyException("价格搜索字段无效");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE price = @Keyword";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }

        public static List<BasicBookModel> SelectBookByIsOnSale(string keyword)
        {
            bool is_on_sale = false;
            if (!keyword.Equals("是") && !keyword.Equals("否"))
            {
                throw new MyException("请输入“是”或“否”");
            }
            else
            {
                is_on_sale = keyword.Equals("是");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT ISBN, title, quantity, is_on_sale FROM [dbo].[Books]
                                WHERE is_on_sale = @IsOnSale";
                List<BasicBookModel> books = connection.Query<BasicBookModel>(sql, new { IsOnSale = is_on_sale ? "true" : "false" }).ToList();
                return books;
            }
        }

        public static List<FullBookModel> SelectBookInCustomer(string keyword)
        {
            if (keyword.Length > 200)
            {
                throw new MyException("搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Books]
                                WHERE is_on_sale = 1 and (ISBN = @Keyword or title LIKE '%' + @Keyword + '%' or author LIKE '%' + @Keyword + '%')";
                List<FullBookModel> books = connection.Query<FullBookModel>(sql, new { Keyword = keyword }).ToList();
                return books;
            }
        }
        #endregion

        public static FullBookModel GetFullBookBySupplierExistentBookOrderId(string order_id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT bo.*, ge.*
                                FROM SupplierOrders so
                                LEFT JOIN SupplierOrderStatus sos ON so.status_id = sos.id
                                INNER JOIN SupplyExistentBookInfo sebi ON so.id = sebi.order_id
								LEFT JOIN Books bo ON sebi.book_isbn = bo.ISBN
                                LEFT JOIN [dbo].[Genres] ge ON bo.genre_clc = ge.clc
								WHERE sebi.order_id = @OrderId";
                var books = connection.Query<FullBookModel, GenreModel, FullBookModel>(sql,
                    (book, genre) => { book.Genre = genre; return book; }, new { OrderId = order_id }, splitOn: "clc").ToList();
                return books?[0];
            }
        }
    }
}
