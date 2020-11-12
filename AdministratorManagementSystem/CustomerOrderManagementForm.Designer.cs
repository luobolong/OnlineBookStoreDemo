namespace AdministratorManagementSystem
{
    partial class CustomerOrderManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrderManagementForm));
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BookDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Ship = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonFuzzySearch = new System.Windows.Forms.Button();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.buttonPresiseSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
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
            this.OrderID,
            this.CustomerId,
            this.Username,
            this.BookISBN,
            this.Title,
            this.OrderDate,
            this.Amount,
            this.TotalPrice,
            this.Status,
            this.CustomerDetail,
            this.BookDetail,
            this.Ship,
            this.Cancel,
            this.Delete});
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.RowTemplate.Height = 23;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1150, 496);
            this.dataGridViewOrders.TabIndex = 17;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            this.dataGridViewOrders.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_CellMouseClick);
            // 
            // OrderID
            // 
            this.OrderID.FillWeight = 89.97911F;
            this.OrderID.HeaderText = "订单号";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 70;
            // 
            // CustomerId
            // 
            this.CustomerId.FillWeight = 52.90772F;
            this.CustomerId.HeaderText = "用户ID";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.Width = 70;
            // 
            // Username
            // 
            this.Username.HeaderText = "用户名";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // BookISBN
            // 
            this.BookISBN.FillWeight = 52.90772F;
            this.BookISBN.HeaderText = "ISBN";
            this.BookISBN.Name = "BookISBN";
            this.BookISBN.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "题名";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "订单日期";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 120;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "总金额";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 80;
            // 
            // Status
            // 
            this.Status.HeaderText = "订单状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // CustomerDetail
            // 
            this.CustomerDetail.HeaderText = "用户";
            this.CustomerDetail.Name = "CustomerDetail";
            this.CustomerDetail.ReadOnly = true;
            this.CustomerDetail.Text = "查看用户详情";
            this.CustomerDetail.UseColumnTextForButtonValue = true;
            this.CustomerDetail.Width = 85;
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
            // Ship
            // 
            this.Ship.HeaderText = "发货";
            this.Ship.Name = "Ship";
            this.Ship.ReadOnly = true;
            this.Ship.Text = "订单发货";
            this.Ship.UseColumnTextForButtonValue = true;
            this.Ship.Width = 60;
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
            // buttonFuzzySearch
            // 
            this.buttonFuzzySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFuzzySearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonFuzzySearch.Location = new System.Drawing.Point(1028, 21);
            this.buttonFuzzySearch.Name = "buttonFuzzySearch";
            this.buttonFuzzySearch.Size = new System.Drawing.Size(75, 23);
            this.buttonFuzzySearch.TabIndex = 15;
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
            "用户ID",
            "ISBN",
            "题名",
            "订单日期",
            "数量",
            "总金额",
            "订单状态号",
            "订单状态"});
            this.comboBoxOption.Location = new System.Drawing.Point(11, 21);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(122, 20);
            this.comboBoxOption.TabIndex = 12;
            // 
            // buttonPresiseSearch
            // 
            this.buttonPresiseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPresiseSearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonPresiseSearch.Location = new System.Drawing.Point(947, 21);
            this.buttonPresiseSearch.Name = "buttonPresiseSearch";
            this.buttonPresiseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPresiseSearch.TabIndex = 14;
            this.buttonPresiseSearch.Text = "精确检索";
            this.buttonPresiseSearch.UseVisualStyleBackColor = true;
            this.buttonPresiseSearch.Click += new System.EventHandler(this.buttonPresiseSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(139, 21);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(802, 21);
            this.textBoxSearch.TabIndex = 13;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonRefresh.Location = new System.Drawing.Point(1111, 21);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(51, 23);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // CustomerOrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.timg;
            this.ClientSize = new System.Drawing.Size(1174, 570);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonFuzzySearch);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.buttonPresiseSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerOrderManagementForm";
            this.Text = "用户订单管理";
            this.Load += new System.EventHandler(this.CustomerOrderManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonFuzzySearch;
        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.Button buttonPresiseSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerDetail;
        private System.Windows.Forms.DataGridViewButtonColumn BookDetail;
        private System.Windows.Forms.DataGridViewButtonColumn Ship;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}