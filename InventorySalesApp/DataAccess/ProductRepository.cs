using Dapper;
using InventorySalesApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace InventorySalesApp.DataAccess
{
    public class ProductRepository
    {
        public async Task<List<Products>> GetAllAsync()
        {
            using IDbConnection db =
                DbConnectionFactory.CreateConnection();

            var products = await db.QueryAsync<Products>(
                "dbo.usp_Product_GetAll",
                commandType: CommandType.StoredProcedure);

            return products.AsList();
        }

        public async Task<int> AddAsync(Products product)
        {
            using IDbConnection db =
                DbConnectionFactory.CreateConnection();

            return await db.ExecuteScalarAsync<int>(
                "dbo.usp_Product_Add",
                new
                {
                    product.ProductName,
                    product.CategoryID,
                    product.SupplierID,
                    product.SKU,
                    product.PurchasePrice,
                    product.SellingPrice,
                    product.StockQuantity,
                    product.ReorderLevel
                },
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<Products>> SearchAsync(string searchText)
        {
            using IDbConnection db =
                DbConnectionFactory.CreateConnection();

            var products = await db.QueryAsync<Products>(
                "dbo.usp_Product_Search",
                new { SearchText = searchText },
                commandType: CommandType.StoredProcedure);

            return products.AsList();
        }

        public async Task UpdateAsync(Products product)
        {
            using IDbConnection db =
                DbConnectionFactory.CreateConnection();

            await db.ExecuteAsync(
                "dbo.usp_Product_Update",
                new
                {
                    product.ProductID,
                    product.ProductName,
                    product.CategoryID,
                    product.SupplierID,
                    product.SKU,
                    product.PurchasePrice,
                    product.SellingPrice,
                    product.StockQuantity,
                    product.ReorderLevel
                },
                commandType: CommandType.StoredProcedure);
        }

        public async Task DeactivateAsync(int productID)
        {
            using IDbConnection db =
                DbConnectionFactory.CreateConnection();

            await db.ExecuteAsync(
                "dbo.usp_Product_Deactivate",
                new { ProductID = productID },
                commandType: CommandType.StoredProcedure);
        }
    }
}
