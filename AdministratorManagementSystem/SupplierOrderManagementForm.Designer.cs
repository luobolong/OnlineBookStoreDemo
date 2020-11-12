namespace AdministratorManagementSystem
{
    partial class SupplierOrderManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierOrderManagementForm));
            this.buttonFuzzySearch = new System.Windows.Forms.Button();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.buttonPresiseSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BookDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Warehouse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFuzzySearch
            // 
            this.buttonFuzzySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFuzzySearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonFuzzySearch.Location = new System.Drawing.Point(1015, 23);
            this.buttonFuzzySearch.Name = "buttonFuzzySearch";
            this.buttonFuzzySearch.Size = new System.Drawing.Size(75, 23);
            this.buttonFuzzySearch.TabIndex = 9;
            this.buttonFuzzySearch.Text = "模糊检索";
            this.buttonFuzzySearch.UseVisualStyleBackColor = true;
            this.buttonFuzzySearch.Click += new System.EventHandler(this.buttonFuzzySearch_Click);
            // 
            // comboBoxOption
            // 
            this.comboBoxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOption.FormattingEnabled = true;
            this.comboBoxOption.Items.AddRange(new object[] {
            "订单号",
            "供应商ID",
            "供应商用户名",
            "发货单日期",
            "数量",
            "发货单状态号",
            "发货单状态",
            "是否是新书"});
            this.comboBoxOption.Location = new System.Drawing.Point(12, 26);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(128, 20);
            this.comboBoxOption.TabIndex = 6;
            // 
            // buttonPresiseSearch
            // 
            this.buttonPresiseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPresiseSearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonPresiseSearch.Location = new System.Drawing.Point(934, 23);
            this.buttonPresiseSearch.Name = "buttonPresiseSearch";
            this.buttonPresiseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPresiseSearch.TabIndex = 8;
            this.buttonPresiseSearch.Text = "精确检索";
            this.buttonPresiseSearch.UseVisualStyleBackColor = true;
            this.buttonPresiseSearch.Click += new System.EventHandler(this.buttonPresiseSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(146, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(782, 21);
            this.textBoxSearch.TabIndex = 7;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonRefresh.Location = new System.Drawing.Point(1096, 23);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(51, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AllowUserToResizeRows = false;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.SupplierId,
            this.Username,
            this.OrderDate,
            this.Amount,
            this.Status,
            this.IsNew,
            this.SupplierDetail,
            this.BookDetail,
            this.Warehouse,
            this.Cancel,
            this.Delete});
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.RowTemplate.Height = 23;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1135, 496);
            this.dataGridViewOrders.TabIndex = 18;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            this.dataGridViewOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_CellMouseClick);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "订单号";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 80;
            // 
            // SupplierId
            // 
            this.SupplierId.HeaderText = "供应商ID";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            this.SupplierId.Width = 80;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.HeaderText = "供应商用户名";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "发货单日期";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 120;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 60;
            // 
            // Status
            // 
            this.Status.HeaderText = "发货单状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // IsNew
            // 
            this.IsNew.HeaderText = "是否是新书";
            this.IsNew.Name = "IsNew";
            this.IsNew.ReadOnly = true;
            // 
            // SupplierDetail
            // 
            this.SupplierDetail.HeaderText = "供货商";
            this.SupplierDetail.Name = "SupplierDetail";
            this.SupplierDetail.ReadOnly = true;
            this.SupplierDetail.Text = "查看供货商详情";
            this.SupplierDetail.UseColumnTextForButtonValue = true;
            this.SupplierDetail.Width = 95;
            // 
            // BookDetail
            // 
            this.BookDetail.HeaderText = "图书";
            this.BookDetail.Name = "BookDetail";
            this.BookDetail.ReadOnly = true;
            this.BookDetail.Text = "查看图书详情";
            this.BookDetail.UseColumnTextForButtonValue = true;
            this.BookDetail.Width = 85;
            // 
            // Warehouse
            // 
            this.Warehouse.HeaderText = "入库";
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.ReadOnly = true;
            this.Warehouse.Text = "图书入库";
            this.Warehouse.UseColumnTextForButtonValue = true;
            this.Warehouse.Width = 60;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "取消";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Text = "取消订单";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 60;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "删除";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "删除订单";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // SupplierOrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.timg;
            this.ClientSize = new System.Drawing.Size(1159, 561);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonFuzzySearch);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.buttonPresiseSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierOrderManagementForm";
            this.Text = "供货商订单管理";
            this.Load += new System.EventHandler(this.SupplierOrderManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFuzzySearch;
        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.Button buttonPresiseSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNew;
        private System.Windows.Forms.DataGridViewButtonColumn SupplierDetail;
        private System.Windows.Forms.DataGridViewButtonColumn BookDetail;
        private System.Windows.Forms.DataGridViewButtonColumn Warehouse;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}