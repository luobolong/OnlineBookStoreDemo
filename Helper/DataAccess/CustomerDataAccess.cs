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
    public static class CustomerDataAccess
    {
        public static CustomerModel LoginCustomer(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                return connection.QueryFirst<CustomerModel>(SPStrings.Customer_Login, new { Username = username, PasswordHash = Tools.ComputeSha256Hash(password) });
            }
        }

        public static void InsertCustomer(string username, string real_name, string password, string address, string phone_number, string email_address)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                connection.Execute(SPStrings.Customer_Insert, new { Username = username, RealName = real_name, PasswordHash = Tools.ComputeSha256Hash(password), Address = address, PhoneNumber = phone_number, EmailAddress = email_address });
            }
        }

        public static bool IsUsernameExisted(string username)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT 1 FROM [dbo].[Customers] WHERE username = @Username";
                return connection.ExecuteScalar<bool>(sql, new { Username = username });
            }
        }

        public static void UpdateCustomer(int id, string real_name, string address, string phone_number, string email_address)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Customers]
                                SET real_name = @RealName, address = @Address, phone_number = @PhoneNumber, email_address = @EmailAddress
                                WHERE id = @Id";
                connection.Execute(sql, new
                {
                    RealName = real_name,
                    Address = address,
                    PhoneNumber = phone_number,
                    EmailAddress = email_address,
                    Id = id
                });
            }
        }

        public static void ResetPassword(int id, string password)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Customers]
                                SET password_hash = @PasswordHash
                                WHERE id = @Id";
                connection.Execute(sql, new
                {
                    PasswordHash = Tools.ComputeSha256Hash(password),
                    Id = id
                });
            }
        }

        public static void TopUp(int id, decimal money)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Customers] SET wallet_balance = wallet_balance + @Money WHERE id = @Id";
                connection.Open();
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        connection.Execute(sql, new { Money = money, Id = id }, transaction: transaction);
                        transaction.Commit();
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                }
            }
        }

        public static void DeductBalance(int id, decimal total_price)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Customers] SET wallet_balance = wallet_balance - @TotalPrice WHERE id = @Id";
                connection.Open();
                decimal balance = GetWalletBalanceById(id);
                if (balance < total_price)
                {
                    throw new MyException("余额不足");
                }
                else
                {
                    using (IDbTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, new { TotalPrice = total_price, Id = id }, transaction: transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
        }

        public static List<CustomerModel> GetAllCustomers()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql).ToList();
                return customers;
            }
        }

        public static CustomerModel GetCustomerById(string id)
        {
            return SelectCustomerById(id)?[0];
        }

        public static CustomerModel GetCustomerByUsername(string username)
        {
            return SelectCustomerByExactUsername(username)?[0];
        }

        public static decimal GetWalletBalanceById(int id)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT wallet_balance FROM [dbo].[Customers] WHERE id = @Id";
                decimal wallet_balance = connection.QueryFirst<decimal>(sql, new { Id = id });
                return wallet_balance;
            }
        }

        #region 搜索
        public static List<CustomerModel> SelectCustomerById(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE id = @Keyword";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByExactUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE username = @Keyword";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByVagueUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE username LIKE '%' + @Keyword + '%'";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByExactRealName(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("真实姓名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE real_name = @Keyword";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByVagueRealName(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("真实姓名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE real_name LIKE '%' + @Keyword + '%'";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByExactAddress(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("地址搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE address = @Keyword";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByVagueAddress(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("地址搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE address LIKE '%' + @Keyword + '%'";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByExactPhoneNumber(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("地址搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE phone_number = @Keyword";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByVaguePhoneNumber(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("地址搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE phone_number LIKE '%' + @Keyword + '%'";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByExactEmailAddress(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("电子邮箱搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE email_address = @Keyword";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByVagueEmailAddress(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("电子邮箱搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE email_address LIKE '%' + @Keyword + '%'";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }

        public static List<CustomerModel> SelectCustomerByWalletBalance(string keyword)
        {
            if (!StringChecker.IsNumberic(keyword))
            {
                throw new MyException("钱包余额搜索字段无效");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Customers]
                                WHERE wallet_balance = @Keyword";
                List<CustomerModel> customers = connection.Query<CustomerModel>(sql, new { Keyword = keyword }).ToList();
                return customers;
            }
        }
        #endregion
    }
}
