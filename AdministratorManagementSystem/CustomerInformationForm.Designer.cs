namespace AdministratorManagementSystem
{
    partial class CustomerInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInformationForm));
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WalletBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Review = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonFuzzySearch = new System.Windows.Forms.Button();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.buttonPresiseSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AllowUserToResizeRows = false;
            this.dataGridViewCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCustomers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.RealName,
            this.PasswordHash,
            this.Address,
            this.PhoneNumber,
            this.EmailAddress,
            this.WalletBalance,
            this.Cart,
            this.Order,
            this.Review});
            this.dataGridViewCustomers.Location = new System.Drawing.Point(15, 65);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersVisible = false;
            this.dataGridViewCustomers.RowTemplate.Height = 23;
            this.dataGridViewCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1088, 597);
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomers_CellContentClick);
            this.dataGridViewCustomers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCustomers_CellMouthClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // Username
            // 
            this.Username.HeaderText = "用户名";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // RealName
            // 
            this.RealName.HeaderText = "真实姓名";
            this.RealName.Name = "RealName";
            this.RealName.ReadOnly = true;
            this.RealName.Width = 80;
            // 
            // PasswordHash
            // 
            this.PasswordHash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PasswordHash.HeaderText = "密码哈希值";
            this.PasswordHash.Name = "PasswordHash";
            this.PasswordHash.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "住址";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "手机号";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "电子邮箱";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 120;
            // 
            // WalletBalance
            // 
            this.WalletBalance.HeaderText = "钱包余额";
            this.WalletBalance.Name = "WalletBalance";
            this.WalletBalance.ReadOnly = true;
            this.WalletBalance.Width = 80;
            // 
            // Cart
            // 
            this.Cart.HeaderText = "购物车";
            this.Cart.Name = "Cart";
            this.Cart.ReadOnly = true;
            this.Cart.Text = "查看购物车";
            this.Cart.UseColumnTextForButtonValue = true;
            this.Cart.Width = 75;
            // 
            // Order
            // 
            this.Order.HeaderText = "订单";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Text = "查看所有订单";
            this.Order.UseColumnTextForButtonValue = true;
            this.Order.Width = 85;
            // 
            // Review
            // 
            this.Review.HeaderText = "评论";
            this.Review.Name = "Review";
            this.Review.ReadOnly = true;
            this.Review.Text = "查看所有评论";
            this.Review.UseColumnTextForButtonValue = true;
            this.Review.Width = 85;
            // 
            // buttonFuzzySearch
            // 
            this.buttonFuzzySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFuzzySearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonFuzzySearch.Location = new System.Drawing.Point(966, 26);
            this.buttonFuzzySearch.Name = "buttonFuzzySearch";
            this.buttonFuzzySearch.Size = new System.Drawing.Size(75, 23);
            this.buttonFuzzySearch.TabIndex = 11;
            this.buttonFuzzySearch.Text = "模糊检索";
            this.buttonFuzzySearch.UseVisualStyleBackColor = true;
            this.buttonFuzzySearch.Click += new System.EventHandler(this.buttonFuzzySearch_Click);
            // 
            // comboBoxOption
            // 
            this.comboBoxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOption.FormattingEnabled = true;
            this.comboBoxOption.Items.AddRange(new object[] {
            "ID",
            "用户名",
            "真实姓名",
            "住址",
            "手机号",
            "电子邮箱",
            "钱包余额"});
            this.comboBoxOption.Location = new System.Drawing.Point(15, 28);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(121, 20);
            this.comboBoxOption.TabIndex = 7;
            // 
            // buttonPresiseSearch
            // 
            this.buttonPresiseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPresiseSearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonPresiseSearch.Location = new System.Drawing.Point(885, 26);
            this.buttonPresiseSearch.Name = "buttonPresiseSearch";
            this.buttonPresiseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPresiseSearch.TabIndex = 9;
            this.buttonPresiseSearch.Text = "精确检索";
            this.buttonPresiseSearch.UseVisualStyleBackColor = true;
            this.buttonPresiseSearch.Click += new System.EventHandler(this.buttonPresiseSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(142, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(737, 21);
            this.textBoxSearch.TabIndex = 8;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonRefresh.Location = new System.Drawing.Point(1052, 26);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(51, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // CustomerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.timg;
            this.ClientSize = new System.Drawing.Size(1112, 674);
            this.Controls.Add(this.buttonFuzzySearch);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.buttonPresiseSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerInformationForm";
            this.Text = "用户详细信息";
            this.Load += new System.EventHandler(this.CustomerInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonFuzzySearch;
        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.Button buttonPresiseSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn WalletBalance;
        private System.Windows.Forms.DataGridViewButtonColumn Cart;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
        private System.Windows.Forms.DataGridViewButtonColumn Review;
    }
}