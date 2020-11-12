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
    public static class CustomerOrderStatusDataAccess
    {
        public static List<CustomerOrderStatusModel> GetAllStatus()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[CustomerOrderStatus]";
                List<CustomerOrderStatusModel> status = connection.Query<CustomerOrderStatusModel>(sql).ToList();
                return status;
            }
        }
    }
}
