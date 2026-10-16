using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySalesApp.Models
{
    public class Products
    
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public int? SupplierID { get; set; }
        public string SKU { get; set; } = string.Empty;
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public string? CategoryName { get; set; }
        public string? StockStatus { get; set; }
    }
}
