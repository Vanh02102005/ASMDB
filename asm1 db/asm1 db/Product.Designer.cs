namespace asm1_db
{
    partial class Product_Management
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProductManagement = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbProductImage = new System.Windows.Forms.Label();
            this.lbInventoryQuantity = new System.Windows.Forms.Label();
            this.lbSellingPrice = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.tbListofProducts = new System.Windows.Forms.TabPage();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.lbProductDescription = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbProductManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            this.tbListofProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbProductManagement);
            this.tabControl1.Controls.Add(this.tbListofProducts);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tbProductManagement
            // 
            this.tbProductManagement.Controls.Add(this.btnSearch);
            this.tbProductManagement.Controls.Add(this.txtProductDescription);
            this.tbProductManagement.Controls.Add(this.lbProductDescription);
            this.tbProductManagement.Controls.Add(this.btnDelete);
            this.tbProductManagement.Controls.Add(this.btnEdit);
            this.tbProductManagement.Controls.Add(this.btnAdd);
            this.tbProductManagement.Controls.Add(this.pbProduct);
            this.tbProductManagement.Controls.Add(this.txtProductQuantity);
            this.tbProductManagement.Controls.Add(this.txtProductPrice);
            this.tbProductManagement.Controls.Add(this.txtProductName);
            this.tbProductManagement.Controls.Add(this.txtProductID);
            this.tbProductManagement.Controls.Add(this.lbProductImage);
            this.tbProductManagement.Controls.Add(this.lbInventoryQuantity);
            this.tbProductManagement.Controls.Add(this.lbSellingPrice);
            this.tbProductManagement.Controls.Add(this.lbProductName);
            this.tbProductManagement.Controls.Add(this.lbProductID);
            this.tbProductManagement.Location = new System.Drawing.Point(4, 25);
            this.tbProductManagement.Name = "tbProductManagement";
            this.tbProductManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tbProductManagement.Size = new System.Drawing.Size(791, 421);
            this.tbProductManagement.TabIndex = 0;
            this.tbProductManagement.Text = "Product Management";
            this.tbProductManagement.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(450, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(284, 351);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 350);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbProduct
            // 
            this.pbProduct.Location = new System.Drawing.Point(518, 42);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(185, 217);
            this.pbProduct.TabIndex = 9;
            this.pbProduct.TabStop = false;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(161, 221);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(94, 22);
            this.txtProductQuantity.TabIndex = 8;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(159, 162);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(96, 22);
            this.txtProductPrice.TabIndex = 7;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(158, 97);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(97, 22);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(156, 42);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 5;
            // 
            // lbProductImage
            // 
            this.lbProductImage.AutoSize = true;
            this.lbProductImage.Location = new System.Drawing.Point(404, 45);
            this.lbProductImage.Name = "lbProductImage";
            this.lbProductImage.Size = new System.Drawing.Size(94, 16);
            this.lbProductImage.TabIndex = 4;
            this.lbProductImage.Text = "Product Image";
            // 
            // lbInventoryQuantity
            // 
            this.lbInventoryQuantity.AutoSize = true;
            this.lbInventoryQuantity.Location = new System.Drawing.Point(31, 227);
            this.lbInventoryQuantity.Name = "lbInventoryQuantity";
            this.lbInventoryQuantity.Size = new System.Drawing.Size(115, 16);
            this.lbInventoryQuantity.TabIndex = 3;
            this.lbInventoryQuantity.Text = "Inventory  Quantity";
            // 
            // lbSellingPrice
            // 
            this.lbSellingPrice.AutoSize = true;
            this.lbSellingPrice.Location = new System.Drawing.Point(31, 165);
            this.lbSellingPrice.Name = "lbSellingPrice";
            this.lbSellingPrice.Size = new System.Drawing.Size(82, 16);
            this.lbSellingPrice.TabIndex = 2;
            this.lbSellingPrice.Text = "Selling Price";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(31, 103);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(93, 16);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(31, 42);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(69, 16);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            // 
            // tbListofProducts
            // 
            this.tbListofProducts.Controls.Add(this.gvProduct);
            this.tbListofProducts.Location = new System.Drawing.Point(4, 25);
            this.tbListofProducts.Name = "tbListofProducts";
            this.tbListofProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbListofProducts.Size = new System.Drawing.Size(791, 421);
            this.tbListofProducts.TabIndex = 1;
            this.tbListofProducts.Text = "List of Products";
            this.tbListofProducts.UseVisualStyleBackColor = true;
            // 
            // gvProduct
            // 
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(3, 3);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.RowHeadersWidth = 51;
            this.gvProduct.RowTemplate.Height = 24;
            this.gvProduct.Size = new System.Drawing.Size(792, 418);
            this.gvProduct.TabIndex = 0;
            // 
            // lbProductDescription
            // 
            this.lbProductDescription.AutoSize = true;
            this.lbProductDescription.Location = new System.Drawing.Point(31, 276);
            this.lbProductDescription.Name = "lbProductDescription";
            this.lbProductDescription.Size = new System.Drawing.Size(124, 16);
            this.lbProductDescription.TabIndex = 14;
            this.lbProductDescription.Text = "Product Description";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(161, 276);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(94, 22);
            this.txtProductDescription.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(628, 350);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Product_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Product_Management";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Management_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbProductManagement.ResumeLayout(false);
            this.tbProductManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            this.tbListofProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbProductManagement;
        private System.Windows.Forms.TabPage tbListofProducts;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbProductImage;
        private System.Windows.Forms.Label lbInventoryQuantity;
        private System.Windows.Forms.Label lbSellingPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label lbProductDescription;
        private System.Windows.Forms.Button btnSearch;
    }
}