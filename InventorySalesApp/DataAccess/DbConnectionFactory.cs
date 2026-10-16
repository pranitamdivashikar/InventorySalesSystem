using Microsoft.Data.SqlClient;
using System.Data;

namespace InventorySalesApp.DataAccess
{
    public static class DbConnectionFactory
   {
        private const string ConnectionString =
            @"Server=.\SQLEXPRESS10;Database=InventorySalesDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static IDbConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
