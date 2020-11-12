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
    public static class AdministratorDataAccess
    {
        public static AdministratorModel LoginAdministrator(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                return connection.QueryFirst<AdministratorModel>(SPStrings.Administrator_Login, new { Username = username, PasswordHash = Tools.ComputeSha256Hash(password)});
            }
        }

        public static void InsertAdministrator(string username, string real_name, string password, string email_address)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                connection.Execute(SPStrings.Administrator_Insert, new { Username = username, RealName = real_name, PasswordHash = Tools.ComputeSha256Hash(password), EmailAddress = email_address });
            }
        }

        public static bool IsUsernameExisted(string username)
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT 1 FROM [dbo].[Administrators] WHERE username = @Username";
                return connection.ExecuteScalar<bool>(sql, new { Username = username });
            }
        }
    }
}
