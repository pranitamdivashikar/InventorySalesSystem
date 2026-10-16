using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Dapper;
using System.Threading.Tasks;
using InventorySalesApp.DataAccess;
using InventorySalesApp.Models;

namespace InventorySalesApp.Forms
{
    public partial class ProductForm : Form
    {
        ProductRepository repo = new ProductRepository();
        private int selectedProductID = 0;


        public ProductForm()
        {
            InitializeComponent();
            Load += ProductForm_Load_1;
            ApplyModernStyling();
         }
        private void ArrangeFormLayout()
        {
            int formWidth = this.ClientSize.Width;
            int margin = 30;

            // Header & Details Panel
            pnlHeader.Width = formWidth;
            pnlProductDetails.Location = new Point(margin, pnlHeader.Bottom + 15);
            pnlProductDetails.Width = formWidth - (margin * 2);
            pnlProductDetails.Height = 240;

            int panelInsideWidth = pnlProductDetails.ClientSize.Width;
            int horizontalPadding = 25;
            int gap = 20;
            int totalGaps = gap * 3;
            int inputWidth = (panelInsideWidth - (horizontalPadding * 2) - totalGaps) / 4;
            int inputHeight = 28;

            int col1 = horizontalPadding;
            int col2 = col1 + inputWidth + gap;
            int col3 = col2 + inputWidth + gap;
            int col4 = col3 + inputWidth + gap;

            // Row 1
            int r1LabelY = 50;
            int r1InputY = 75;

            lblProductName.Location = new Point(col1, r1LabelY);
            txtProductName.Location = new Point(col1, r1InputY);
            txtProductName.Size = new Size(inputWidth, inputHeight);

            lblCategory.Location = new Point(col2, r1LabelY);
            cmbCategory.Location = new Point(col2, r1InputY);
            cmbCategory.Size = new Size(inputWidth, inputHeight);

            lblSKU.Location = new Point(col3, r1LabelY);
            txtSKU.Location = new Point(col3, r1InputY);
            txtSKU.Size = new Size(inputWidth, inputHeight);

            lblSupplier.Location = new Point(col4, r1LabelY);
            cmbSupplier.Location = new Point(col4, r1InputY);
            cmbSupplier.Size = new Size(inputWidth, inputHeight);

            // Row 2
            int r2LabelY = 120;
            int r2InputY = 145;

            lblPurchasePrice.Location = new Point(col1, r2LabelY);
            txtPurchasePrice.Location = new Point(col1, r2InputY);
            txtPurchasePrice.Size = new Size(inputWidth, inputHeight);

            lblSellingPrice.Location = new Point(col2, r2LabelY);
            txtSellingPrice.Location = new Point(col2, r2InputY);
            txtSellingPrice.Size = new Size(inputWidth, inputHeight);

            lblStockQuantity.Location = new Point(col3, r2LabelY);
            txtStockQuantity.Location = new Point(col3, r2InputY);
            txtStockQuantity.Size = new Size(inputWidth, inputHeight);

            lblReorderLevel.Location = new Point(col4, r2LabelY);
            txtReorderLevel.Location = new Point(col4, r2InputY);
            txtReorderLevel.Size = new Size(inputWidth, inputHeight);

            // Save & Clear Buttons
            btnSaveProduct.Size = new Size(130, 34);
            btnClear.Size = new Size(90, 34);

            int buttonsY = pnlProductDetails.Top + 185;
            int panelRightEdge = pnlProductDetails.Right - horizontalPadding;

            btnClear.Location = new Point(panelRightEdge - btnClear.Width, buttonsY);
            btnSaveProduct.Location = new Point(btnClear.Left - btnSaveProduct.Width - 12, buttonsY);

            btnSaveProduct.BringToFront();
            btnClear.BringToFront();

            // Products List Title & Search
            int listSectionY = pnlProductDetails.Bottom + 15;
            lblProductList.Location = new Point(margin, listSectionY);

            txtSearch.Location = new Point(margin + 160, listSectionY - 2);
            txtSearch.Size = new Size(220, 28);
            btnSearch.Location = new Point(txtSearch.Right + 8, listSectionY - 4);
            btnSearch.Size = new Size(85, 30);

            int gridTop = listSectionY + 40;
            dgvProducts.Location = new Point(margin, gridTop);
            dgvProducts.Width = formWidth - (margin * 2);
            dgvProducts.Height = this.ClientSize.Height - gridTop - 135;

            // Bottom Action Buttons
            btnUpdate.Size = new Size(115, 36);
            btnDeactivate.Size = new Size(115, 36);
            int bottomButtonsY = dgvProducts.Bottom + 12;

            btnDeactivate.Location = new Point(dgvProducts.Right - btnDeactivate.Width, bottomButtonsY);
            btnUpdate.Location = new Point(btnDeactivate.Left - btnUpdate.Width - 12, bottomButtonsY);

            btnUpdate.BringToFront();
            btnDeactivate.BringToFront();
        }
        private void ApplyModernStyling()
        {
            // DataGridView layout and border
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.GridColor = Color.FromArgb(235, 237, 240);
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.RowTemplate.Height = 36;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Header styling - height 38 theva jyane text dabla janar nahi
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProducts.ColumnHeadersHeight = 38;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            // Padding dya jyane text aani numbers chikatnar nahit
            dgvProducts.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            dgvProducts.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);

            // Row styling
            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dgvProducts.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(225, 240, 255);
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvProducts.ScrollBars = ScrollBars.Both;
           
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;

            btnUpdate.BringToFront();
            btnDeactivate.BringToFront();

            // Clear button border styling
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 128);
            btnClear.FlatAppearance.BorderSize = 1;
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.FromArgb(0, 128, 128);
            btnClear.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        private void FormatGridColumns()
        {
            if (dgvProducts.Columns.Count == 0) return;

            if (dgvProducts.Columns.Contains("CategoryID"))
                dgvProducts.Columns["CategoryID"]!.Visible = false;

            if (dgvProducts.Columns.Contains("SupplierID"))
                dgvProducts.Columns["SupplierID"]!.Visible = false;

            // ID
            if (dgvProducts.Columns.Contains("ProductID"))
            {
                dgvProducts.Columns["ProductID"]!.HeaderText = "ID";
                dgvProducts.Columns["ProductID"]!.FillWeight = 25;
                dgvProducts.Columns["ProductID"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvProducts.Columns["ProductID"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            // Product Name
            if (dgvProducts.Columns.Contains("ProductName"))
            {
                dgvProducts.Columns["ProductName"]!.HeaderText = "Product Name";
                dgvProducts.Columns["ProductName"]!.FillWeight = 110;
                dgvProducts.Columns["ProductName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvProducts.Columns["ProductName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            // SKU / Code
            if (dgvProducts.Columns.Contains("SKU"))
            {
                dgvProducts.Columns["SKU"]!.HeaderText = "Product Code";
                dgvProducts.Columns["SKU"]!.FillWeight = 55;
                dgvProducts.Columns["SKU"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvProducts.Columns["SKU"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            // Buy Price (Header aani Data donhi Right Align)
            if (dgvProducts.Columns.Contains("PurchasePrice"))
            {
                dgvProducts.Columns["PurchasePrice"]!.HeaderText = "Buy Price";
                dgvProducts.Columns["PurchasePrice"]!.FillWeight = 55;
                dgvProducts.Columns["PurchasePrice"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProducts.Columns["PurchasePrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Sell Price (Header aani Data donhi Right Align)
            if (dgvProducts.Columns.Contains("SellingPrice"))
            {
                dgvProducts.Columns["SellingPrice"]!.HeaderText = "Sell Price";
                dgvProducts.Columns["SellingPrice"]!.FillWeight = 55;
                dgvProducts.Columns["SellingPrice"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProducts.Columns["SellingPrice"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Stock
            if (dgvProducts.Columns.Contains("StockQuantity"))
            {
                dgvProducts.Columns["StockQuantity"]!.HeaderText = "Stock";
                dgvProducts.Columns["StockQuantity"]!.FillWeight = 40;
                dgvProducts.Columns["StockQuantity"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProducts.Columns["StockQuantity"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Reorder
            if (dgvProducts.Columns.Contains("ReorderLevel"))
            {
                dgvProducts.Columns["ReorderLevel"]!.HeaderText = "Reorder";
                dgvProducts.Columns["ReorderLevel"]!.FillWeight = 45;
                dgvProducts.Columns["ReorderLevel"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProducts.Columns["ReorderLevel"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Category (Left Align)
            if (dgvProducts.Columns.Contains("CategoryName"))
            {
                dgvProducts.Columns["CategoryName"]!.HeaderText = "Category";
                dgvProducts.Columns["CategoryName"]!.FillWeight = 75;
                dgvProducts.Columns["CategoryName"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvProducts.Columns["CategoryName"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            // Status (Center Align)
            if (dgvProducts.Columns.Contains("StockStatus"))
            {
                dgvProducts.Columns["StockStatus"]!.HeaderText = "Status";
                dgvProducts.Columns["StockStatus"]!.FillWeight = 65;
                dgvProducts.Columns["StockStatus"]!.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProducts.Columns["StockStatus"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private class CategoryItem
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; } = string.Empty;
        }

        private void LoadCategories()
        {
            using (IDbConnection db = DbConnectionFactory.CreateConnection())
            {
                var categories = db.Query<CategoryItem>(
                    "SELECT CategoryID, CategoryName FROM dbo.Categories WHERE IsActive = 1"
                ).AsList();

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                cmbCategory.SelectedIndex = -1;
            }
        }
        private class SupplierItem
        {
            public int SupplierID { get; set; }
            public string SupplierName { get; set; } = string.Empty;
        }
        private async Task LoadProductsAsync()
        {
            dgvProducts.DataSource = await repo.GetAllAsync();
            FormatGridColumns();
        }

               private void LoadSuppliers()
        {
            using (IDbConnection db = DbConnectionFactory.CreateConnection())
            {
                var suppliers = db.Query<SupplierItem>(
                    @"SELECT SupplierID, SupplierName
              FROM dbo.Suppliers
              WHERE IsActive = 1"
                ).AsList();

                cmbSupplier.DataSource = suppliers;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierID";
                cmbSupplier.SelectedIndex = -1;
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    cmbCategory.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtSKU.Text) ||
                    string.IsNullOrWhiteSpace(txtPurchasePrice.Text) ||
                    string.IsNullOrWhiteSpace(txtSellingPrice.Text))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                decimal purchasePrice, sellingPrice;
                int stockQuantity = 0, reorderLevel = 10;

                if (!decimal.TryParse(txtPurchasePrice.Text, out purchasePrice) ||
                    !decimal.TryParse(txtSellingPrice.Text, out sellingPrice) ||
                    (!string.IsNullOrWhiteSpace(txtStockQuantity.Text) &&
                     !int.TryParse(txtStockQuantity.Text, out stockQuantity)) ||
                    (!string.IsNullOrWhiteSpace(txtReorderLevel.Text) &&
                     !int.TryParse(txtReorderLevel.Text, out reorderLevel)))
                {
                    MessageBox.Show("Enter valid prices and whole numbers for stock.");
                    return;
                }

                if (purchasePrice < 0 || sellingPrice < 0 ||
                    stockQuantity < 0 || reorderLevel < 0)
                {
                    MessageBox.Show("Values cannot be negative.");
                    return;
                }

                Products product = new Products
                {
                    ProductName = txtProductName.Text.Trim(),
                    CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                    SupplierID = cmbSupplier.SelectedIndex >= 0 ? Convert.ToInt32(cmbSupplier.SelectedValue) : (int?)null,
                    SKU = txtSKU.Text.Trim(),
                    PurchasePrice = purchasePrice,
                    SellingPrice = sellingPrice,
                    StockQuantity = stockQuantity,
                    ReorderLevel = reorderLevel
                };
                await repo.AddAsync(product);

                MessageBox.Show("Product saved successfully!");

                await LoadProductsAsync();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            txtSKU.Clear();
            txtPurchasePrice.Clear();
            txtSellingPrice.Clear();
            txtStockQuantity.Clear();
            txtReorderLevel.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            selectedProductID = 0;
            txtProductName.Focus();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private async void ProductForm_Load_1(object? sender, EventArgs e)
        {

            try
            {
                ArrangeFormLayout();
                LoadCategories();
                LoadSuppliers();
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Data load failed: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    await LoadProductsAsync();
                }
                else
                {
                    dgvProducts.DataSource =
                        await repo.SearchAsync(searchText);
                }
                txtSearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvProducts.Rows[e.RowIndex].DataBoundItem
                is not Products p)
                return;

            selectedProductID = p.ProductID;

            txtProductName.Text = p.ProductName;
            txtSKU.Text = p.SKU;
            txtPurchasePrice.Text = p.PurchasePrice.ToString();
            txtSellingPrice.Text = p.SellingPrice.ToString();
            txtStockQuantity.Text = p.StockQuantity.ToString();
            txtReorderLevel.Text = p.ReorderLevel.ToString();

            cmbCategory.SelectedValue = p.CategoryID;

            if (p.SupplierID.HasValue)
                cmbSupplier.SelectedValue = p.SupplierID.Value;
            else
                cmbSupplier.SelectedIndex = -1;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductID <= 0)
                {
                    MessageBox.Show("Select a product from the grid first.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    cmbCategory.SelectedIndex < 0 ||
                    string.IsNullOrWhiteSpace(txtSKU.Text))
                {
                    MessageBox.Show("Please fill all required fields.");
                    return;
                }

                if (!decimal.TryParse(txtPurchasePrice.Text, out decimal purchase) ||
                    !decimal.TryParse(txtSellingPrice.Text, out decimal selling) ||
                    !int.TryParse(txtStockQuantity.Text, out int stock) ||
                    !int.TryParse(txtReorderLevel.Text, out int reorder) ||
                    purchase < 0 || selling < 0 || stock < 0 || reorder < 0)
                {
                    MessageBox.Show("Enter valid non-negative values.");
                    return;
                }

                Products p = new Products
                {
                    ProductID = selectedProductID,
                    ProductName = txtProductName.Text.Trim(),
                    CategoryID = Convert.ToInt32(cmbCategory.SelectedValue),
                    SupplierID = cmbSupplier.SelectedIndex >= 0
                        ? Convert.ToInt32(cmbSupplier.SelectedValue)
                        : (int?)null,
                    SKU = txtSKU.Text.Trim(),
                    PurchasePrice = purchase,
                    SellingPrice = selling,
                    StockQuantity = stock,
                    ReorderLevel = reorder
                };

                await repo.UpdateAsync(p);

                MessageBox.Show("Product updated successfully!");

                await LoadProductsAsync();
                ClearFields();
                selectedProductID = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private async void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProductID <= 0)
                {
                    MessageBox.Show("Select a product from the grid first.");
                    return;
                }

                var result = MessageBox.Show(
                    "Are you sure you want to deactivate this product?",
                    "Confirm Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes) return;

                await repo.DeactivateAsync(selectedProductID);

                MessageBox.Show("Product deactivated successfully!");

                await LoadProductsAsync();
                ClearFields();
                selectedProductID = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deactivate failed: " + ex.Message);
            }
        }

        private void dgvProducts_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var column = dgvProducts.Columns[e.ColumnIndex];
            if (column == null) return;

            // Stock status highlight
            if (column.Name.Equals("StockStatus", StringComparison.OrdinalIgnoreCase) && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";
                if (status.Equals("In Stock", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(46, 125, 50); // Green
                    e.CellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                }
                else if (status.Equals("Low Stock", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.ForeColor = Color.FromArgb(211, 47, 47); // Red
                    e.CellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                }
            }

            // Currency columns right-alignment and formatting
            if (column.Name.Equals("PurchasePrice", StringComparison.OrdinalIgnoreCase) ||
                column.Name.Equals("SellingPrice", StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (decimal.TryParse(e.Value?.ToString(), out decimal price))
                {
                    e.Value = price.ToString("N2");
                    e.FormattingApplied = true;
                }
            }
            else if (column.Name.Equals("StockQuantity", StringComparison.OrdinalIgnoreCase) ||
                     column.Name.Equals("ReorderLevel", StringComparison.OrdinalIgnoreCase))
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

    }
}







