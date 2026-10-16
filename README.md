# 📦 Inventory & Sales Management System

A robust desktop-based Inventory and Sales Management System built with **C#**, **.NET**, **Dapper ORM**, and **SQL Server**. Designed to streamline product tracking, monitor stock reorder thresholds, and manage supplier transactions with an intuitive desktop UI.

---

## 📸 Application Preview

![Product Management Dashboard](C:\Users\ADMIN\Pictures\Screenshots\Dashboard.png)

---

## 🚀 Key Features

- **Product Management:** Complete CRUD operations for products with category and supplier mapping.
- **Real-Time Stock Alerts:** Dynamic status calculation (`In Stock` vs `Low Stock`) based on user-defined reorder levels.
- **Search & Filtering:** Fast multi-field search across product names, categories, and SKU codes.
- **High-Performance Data Access:** Backed by **Dapper ORM** and optimized **SQL Server Stored Procedures**.
- **Responsive UI:** Clean, custom-styled Windows Forms layout with automated proportional scaling.

---

## 🛠️ Tech Stack & Architecture

- **Language:** C# (.NET 8.0 Windows Desktop)
- **UI Framework:** Windows Forms (WinForms)
- **ORM / Micro-ORM:** Dapper
- **Database:** Microsoft SQL Server (Stored Procedures, Relational Queries)
- **Data Architecture:** Repository Pattern with Asynchronous Operations (`async/await`)

---

## 🗄️ Database Setup

1. Open SQL Server Management Studio (SSMS).
2. Execute the database initialization scripts located in the `/Database` folder:
   - `Schema.sql` (Tables: Products, Categories, Suppliers)
   - `StoredProcedures.sql` (`usp_Product_GetAll`, `usp_Product_Search`, etc.)
3. Update the database connection string in `DbConnectionFactory.cs`:
   ```csharp
Server=DESKTOP-8Q9G3RR\SQLEXPRESS10;Database=InventorySalesDB;Trusted_Connection=True;TrustServerCertificate=True;
   Server=YOUR_SERVER_NAME;Database=InventorySalesDB;Trusted_Connection=True;TrustServerCertificate=True;
