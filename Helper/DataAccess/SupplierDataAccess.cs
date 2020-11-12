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
    public static class SupplierDataAccess
    {
        public static SupplierModel LoginSupplier(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                return connection.QueryFirst<SupplierModel>(SPStrings.Supplier_Login, new { Username = username, PasswordHash = Tools.ComputeSha256Hash(password) });
            }
        }

        public static bool IsUsernameExisted(string username)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT 1 FROM [dbo].[Suppliers] WHERE username = @Username";
                return connection.ExecuteScalar<bool>(sql, new { Username = username });
            }
        }

        public static void InsertSupplier(string username, string real_name, string password, string phoner_number, string email_address)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                connection.Execute(SPStrings.Supplier_Insert, new { Username = username, RealName = real_name, PasswordHash = Tools.ComputeSha256Hash(password), PhoneNumber = phoner_number, EmailAddress = email_address });
            }
        }

        public static void UpdateSupplier(int id, string real_name, string phone_number, string email_address)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"UPDATE [dbo].[Suppliers]
                                SET real_name = @RealName, phone_number = @PhoneNumber, email_address = @EmailAddress
                                WHERE id = @Id";
                connection.Execute(sql, new
                {
                    RealName = real_name,
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
                string sql = @"UPDATE [dbo].[Suppliers]
                                SET password_hash = @PasswordHash
                                WHERE id = @Id";
                connection.Execute(sql, new
                {
                    PasswordHash = Tools.ComputeSha256Hash(password),
                    Id = id
                });
            }
        }

        public static List<SupplierModel> GetAllSuppliers()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql).ToList();
                return suppliers;
            }
        }

        public static SupplierModel GetSupplierById(string supplier_id)
        {
            return SelectSupplierById(supplier_id)?[0];
        }

        #region 搜索
        public static List<SupplierModel> SelectSupplierById(string keyword)
        {
            if (!StringChecker.IsNumber(keyword))
            {
                throw new MyException("请输入一个数字");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE id = @Keyword";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByExactUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE username = @Keyword";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByVagueUsername(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("用户名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE username LIKE '%' + @Keyword + '%'";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByExactRealName(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("真实姓名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE real_name = @Keyword";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByVagueRealName(string keyword)
        {
            if (keyword.Length > 20)
            {
                throw new MyException("真实姓名搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE real_name LIKE '%' + @Keyword + '%'";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByExactPhoneNumber(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("地址搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE phone_number = @Keyword";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByVaguePhoneNumber(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("地址搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE phone_number LIKE '%' + @Keyword + '%'";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByExactEmailAddress(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("电子邮箱搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE email_address = @Keyword";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }

        public static List<SupplierModel> SelectSupplierByVagueEmailAddress(string keyword)
        {
            if (keyword.Length > 100)
            {
                throw new MyException("电子邮箱搜索字段过长");
            }
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Suppliers]
                                WHERE email_address LIKE '%' + @Keyword + '%'";
                List<SupplierModel> suppliers = connection.Query<SupplierModel>(sql, new { Keyword = keyword }).ToList();
                return suppliers;
            }
        }
        #endregion
    }
}
