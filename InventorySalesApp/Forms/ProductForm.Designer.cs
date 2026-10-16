namespace InventorySalesApp.Forms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlProductDetails = new Panel();
            txtReorderLevel = new TextBox();
            txtStockQuantity = new TextBox();
            txtSellingPrice = new TextBox();
            txtPurchasePrice = new TextBox();
            lblReorderLevel = new Label();
            lblStockQuantity = new Label();
            lblSellingPrice = new Label();
            lblPurchasePrice = new Label();
            cmbSupplier = new ComboBox();
            lblSupplier = new Label();
            txtSKU = new TextBox();
            cmbCategory = new ComboBox();
            txtProductName = new TextBox();
            lblSKU = new Label();
            lblCategory = new Label();
            lblProductName = new Label();
            lblFormTitle = new Label();
            btnClear = new Button();
            btnSaveProduct = new Button();
            lblProductList = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvProducts = new DataGridView();
            btnUpdate = new Button();
            btnDeactivate = new Button();
            pnlHeader.SuspendLayout();
            pnlProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.MidnightBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(984, 75);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Variable Display", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(433, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INVENTORY & SALES MANAGEMENT";
            lblTitle.UseMnemonic = false;
            lblTitle.Click += label1_Click;
            // 
            // pnlProductDetails
            // 
            pnlProductDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProductDetails.BackColor = Color.White;
            pnlProductDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlProductDetails.Controls.Add(txtReorderLevel);
            pnlProductDetails.Controls.Add(txtStockQuantity);
            pnlProductDetails.Controls.Add(txtSellingPrice);
            pnlProductDetails.Controls.Add(txtPurchasePrice);
            pnlProductDetails.Controls.Add(lblReorderLevel);
            pnlProductDetails.Controls.Add(lblStockQuantity);
            pnlProductDetails.Controls.Add(lblSellingPrice);
            pnlProductDetails.Controls.Add(lblPurchasePrice);
            pnlProductDetails.Controls.Add(cmbSupplier);
            pnlProductDetails.Controls.Add(lblSupplier);
            pnlProductDetails.Controls.Add(txtSKU);
            pnlProductDetails.Controls.Add(cmbCategory);
            pnlProductDetails.Controls.Add(txtProductName);
            pnlProductDetails.Controls.Add(lblSKU);
            pnlProductDetails.Controls.Add(lblCategory);
            pnlProductDetails.Controls.Add(lblProductName);
            pnlProductDetails.Controls.Add(lblFormTitle);
            pnlProductDetails.Location = new Point(12, 81);
            pnlProductDetails.Name = "pnlProductDetails";
            pnlProductDetails.Size = new Size(960, 220);
            pnlProductDetails.TabIndex = 1;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(694, 174);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(200, 25);
            txtReorderLevel.TabIndex = 16;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(473, 174);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(200, 25);
            txtStockQuantity.TabIndex = 15;
            // 
            // txtSellingPrice
            // 
            txtSellingPrice.Location = new Point(246, 174);
            txtSellingPrice.Name = "txtSellingPrice";
            txtSellingPrice.Size = new Size(200, 25);
            txtSellingPrice.TabIndex = 14;
            // 
            // txtPurchasePrice
            // 
            txtPurchasePrice.Location = new Point(20, 174);
            txtPurchasePrice.Name = "txtPurchasePrice";
            txtPurchasePrice.Size = new Size(200, 25);
            txtPurchasePrice.TabIndex = 13;
            // 
            // lblReorderLevel
            // 
            lblReorderLevel.AutoSize = true;
            lblReorderLevel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReorderLevel.Location = new Point(694, 151);
            lblReorderLevel.Name = "lblReorderLevel";
            lblReorderLevel.Size = new Size(100, 20);
            lblReorderLevel.TabIndex = 12;
            lblReorderLevel.Text = "Reorder Level";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockQuantity.Location = new Point(473, 151);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(105, 20);
            lblStockQuantity.TabIndex = 11;
            lblStockQuantity.Text = "Stock Quantity";
            // 
            // lblSellingPrice
            // 
            lblSellingPrice.AutoSize = true;
            lblSellingPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSellingPrice.Location = new Point(250, 151);
            lblSellingPrice.Name = "lblSellingPrice";
            lblSellingPrice.Size = new Size(104, 20);
            lblSellingPrice.TabIndex = 10;
            lblSellingPrice.Text = "Selling Price  *";
            // 
            // lblPurchasePrice
            // 
            lblPurchasePrice.AutoSize = true;
            lblPurchasePrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPurchasePrice.Location = new Point(20, 151);
            lblPurchasePrice.Name = "lblPurchasePrice";
            lblPurchasePrice.Size = new Size(117, 20);
            lblPurchasePrice.TabIndex = 9;
            lblPurchasePrice.Text = "Purchase Price  *";
            // 
            // cmbSupplier
            // 
            cmbSupplier.BackColor = SystemColors.ControlDark;
            cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSupplier.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(694, 83);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(200, 25);
            cmbSupplier.TabIndex = 8;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(694, 60);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(64, 20);
            lblSupplier.TabIndex = 7;
            lblSupplier.Text = "Supplier";
            // 
            // txtSKU
            // 
            txtSKU.Location = new Point(473, 83);
            txtSKU.Name = "txtSKU";
            txtSKU.Size = new Size(200, 25);
            txtSKU.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.ControlDark;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(246, 85);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 25);
            cmbCategory.TabIndex = 5;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(20, 85);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 25);
            txtProductName.TabIndex = 4;
            // 
            // lblSKU
            // 
            lblSKU.AutoSize = true;
            lblSKU.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSKU.Location = new Point(473, 60);
            lblSKU.Name = "lblSKU";
            lblSKU.Size = new Size(109, 20);
            lblSKU.TabIndex = 3;
            lblSKU.Text = "Product Code *";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(250, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category *";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(20, 60);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(118, 20);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name  *";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.Location = new Point(20, 15);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(148, 25);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Product Details";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(872, 307);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.Teal;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.Location = new Point(726, 307);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(140, 40);
            btnSaveProduct.TabIndex = 3;
            btnSaveProduct.Text = "Save Product";
            btnSaveProduct.UseVisualStyleBackColor = false;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // lblProductList
            // 
            lblProductList.AutoSize = true;
            lblProductList.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductList.Location = new Point(33, 369);
            lblProductList.Name = "lblProductList";
            lblProductList.Size = new Size(140, 30);
            lblProductList.TabIndex = 4;
            lblProductList.Text = "Products List";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(259, 376);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 25);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MidnightBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(495, 371);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 32);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.LightGray;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 50, 100);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(12, 421);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowTemplate.Height = 32;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(960, 177);
            dgvProducts.TabIndex = 16;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(726, 604);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 40);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update ";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(183, 28, 28);
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivate.ForeColor = Color.White;
            btnDeactivate.Location = new Point(842, 604);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(130, 40);
            btnDeactivate.TabIndex = 18;
            btnDeactivate.Text = "Deactivate ";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(984, 695);
            Controls.Add(btnDeactivate);
            Controls.Add(btnUpdate);
            Controls.Add(dgvProducts);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblProductList);
            Controls.Add(btnSaveProduct);
            Controls.Add(btnClear);
            Controls.Add(pnlProductDetails);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PeopleHub - Product Management";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlProductDetails.ResumeLayout(false);
            pnlProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlProductDetails;
        private Label lblFormTitle;
        private Label lblSKU;
        private Label lblCategory;
        private Label lblProductName;
        private TextBox txtProductName;
        private ComboBox cmbCategory;
        private Label lblSupplier;
        private TextBox txtSKU;
      
        private Label lblStockQuantity;
        private Label lblReorderLevel;
        private TextBox txtPurchasePrice;
        private Label lblSellingPrice;
        private Label lblPurchasePrice;
        private ComboBox cmbSupplier;
      
        private TextBox txtSellingPrice;
        private TextBox txtStockQuantity;
        private Button btnClear;
        private Button btnSaveProduct;
        private Label lblProductList;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvProducts;
        private Button btnUpdate;
        private Button btnDeactivate;
        private TextBox txtReorderLevel;
    }
}