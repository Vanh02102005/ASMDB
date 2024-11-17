namespace asm1_db
{
    partial class Customer
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
            this.tpInformation = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbHistory = new System.Windows.Forms.TabPage();
            this.gvCustomer = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tpInformation.SuspendLayout();
            this.tbHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInformation);
            this.tabControl1.Controls.Add(this.tbHistory);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 452);
            this.tabControl1.TabIndex = 1;
            // 
            // tpInformation
            // 
            this.tpInformation.Controls.Add(this.btnSearch);
            this.tpInformation.Controls.Add(this.btnDelete);
            this.tpInformation.Controls.Add(this.btnEdit);
            this.tpInformation.Controls.Add(this.btnAdd);
            this.tpInformation.Controls.Add(this.txtAddress);
            this.tpInformation.Controls.Add(this.txtEmail);
            this.tpInformation.Controls.Add(this.txtPhone);
            this.tpInformation.Controls.Add(this.txtName);
            this.tpInformation.Controls.Add(this.txtID);
            this.tpInformation.Controls.Add(this.lbID);
            this.tpInformation.Controls.Add(this.lbAddress);
            this.tpInformation.Controls.Add(this.lbEmail);
            this.tpInformation.Controls.Add(this.lbPhone);
            this.tpInformation.Controls.Add(this.lbName);
            this.tpInformation.Location = new System.Drawing.Point(4, 25);
            this.tpInformation.Name = "tpInformation";
            this.tpInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpInformation.Size = new System.Drawing.Size(791, 423);
            this.tpInformation.TabIndex = 0;
            this.tpInformation.Text = "Customer Information";
            this.tpInformation.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(532, 221);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSeach_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(380, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(229, 221);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(75, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(414, 96);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(106, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(411, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(109, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(139, 139);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(111, 22);
            this.txtPhone.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 96);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(114, 22);
            this.txtID.TabIndex = 6;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(72, 45);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 16);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(342, 102);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(58, 16);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "Address";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(342, 51);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(72, 139);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(46, 16);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(72, 102);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // tbHistory
            // 
            this.tbHistory.Controls.Add(this.gvCustomer);
            this.tbHistory.Location = new System.Drawing.Point(4, 25);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tbHistory.Size = new System.Drawing.Size(791, 423);
            this.tbHistory.TabIndex = 1;
            this.tbHistory.Text = "Purchase History";
            this.tbHistory.UseVisualStyleBackColor = true;
            // 
            // gvCustomer
            // 
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomer.Location = new System.Drawing.Point(6, 6);
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.RowHeadersWidth = 51;
            this.gvCustomer.RowTemplate.Height = 24;
            this.gvCustomer.Size = new System.Drawing.Size(778, 417);
            this.gvCustomer.TabIndex = 0;
            this.gvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomer_CellContentClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.lbCustomer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpInformation.ResumeLayout(false);
            this.tpInformation.PerformLayout();
            this.tbHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInformation;
        private System.Windows.Forms.TabPage tbHistory;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvCustomer;
    }
}