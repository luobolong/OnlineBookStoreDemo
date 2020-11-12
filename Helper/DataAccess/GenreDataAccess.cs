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
    public static class GenreDataAccess
    {
        public static List<GenreModel> GetAllGenres()
        {
            using (IDbConnection connection = new SqlConnection(Tools.GetConnectionStringValue()))
            {
                string sql = @"SELECT * FROM [dbo].[Genres]";
                List<GenreModel> genres = connection.Query<GenreModel>(sql).ToList();
                return genres;
            }
        }
    }
}
