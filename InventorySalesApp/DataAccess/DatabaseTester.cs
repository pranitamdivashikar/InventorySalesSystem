using System;
using System.Threading.Tasks;
using Dapper;

namespace InventorySalesApp.DataAccess
{
    public static class DatabaseTester
    {
        public static async Task<bool> TestConnectionAsync()
        {
            using var connection =
                (Microsoft.Data.SqlClient.SqlConnection)
                DbConnectionFactory.CreateConnection();

            await connection.OpenAsync();

            int result = await connection.ExecuteScalarAsync<int>(
                "SELECT 1");

            return result == 1;
        }
    }

}
