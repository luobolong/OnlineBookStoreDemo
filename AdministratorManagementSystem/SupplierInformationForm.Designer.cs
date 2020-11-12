namespace AdministratorManagementSystem
{
    partial class SupplierInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierInformationForm));
            this.buttonFuzzySearch = new System.Windows.Forms.Button();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.buttonPresiseSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFuzzySearch
            // 
            this.buttonFuzzySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFuzzySearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonFuzzySearch.Location = new System.Drawing.Point(847, 25);
            this.buttonFuzzySearch.Name = "buttonFuzzySearch";
            this.buttonFuzzySearch.Size = new System.Drawing.Size(75, 23);
            this.buttonFuzzySearch.TabIndex = 17;
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
            "手机号",
            "电子邮箱"});
            this.comboBoxOption.Location = new System.Drawing.Point(12, 25);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(118, 20);
            this.comboBoxOption.TabIndex = 13;
            // 
            // buttonPresiseSearch
            // 
            this.buttonPresiseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPresiseSearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonPresiseSearch.Location = new System.Drawing.Point(766, 25);
            this.buttonPresiseSearch.Name = "buttonPresiseSearch";
            this.buttonPresiseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPresiseSearch.TabIndex = 15;
            this.buttonPresiseSearch.Text = "精确检索";
            this.buttonPresiseSearch.UseVisualStyleBackColor = true;
            this.buttonPresiseSearch.Click += new System.EventHandler(this.buttonPresiseSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(136, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(621, 21);
            this.textBoxSearch.TabIndex = 14;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonRefresh.Location = new System.Drawing.Point(933, 25);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(51, 23);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.AllowUserToAddRows = false;
            this.dataGridViewSuppliers.AllowUserToDeleteRows = false;
            this.dataGridViewSuppliers.AllowUserToResizeRows = false;
            this.dataGridViewSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSuppliers.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.RealName,
            this.PasswordHash,
            this.PhoneNumber,
            this.EmailAddress,
            this.Order});
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(12, 62);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.ReadOnly = true;
            this.dataGridViewSuppliers.RowHeadersVisible = false;
            this.dataGridViewSuppliers.RowTemplate.Height = 23;
            this.dataGridViewSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(972, 451);
            this.dataGridViewSuppliers.TabIndex = 12;
            this.dataGridViewSuppliers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSuppliers_CellContentClick);
            this.dataGridViewSuppliers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSuppliers_CellMouseClick);
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
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "手机号";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 120;
            // 
            // EmailAddress
            // 
            this.EmailAddress.HeaderText = "电子邮箱";
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.ReadOnly = true;
            this.EmailAddress.Width = 120;
            // 
            // Order
            // 
            this.Order.HeaderText = "发货单";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Text = "查看所有发货单";
            this.Order.UseColumnTextForButtonValue = true;
            this.Order.Width = 95;
            // 
            // SupplierInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.timg;
            this.ClientSize = new System.Drawing.Size(996, 525);
            this.Controls.Add(this.buttonFuzzySearch);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.buttonPresiseSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierInformationForm";
            this.Text = "供货商信息表";
            this.Load += new System.EventHandler(this.SupplierInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFuzzySearch;
        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.Button buttonPresiseSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
    }
}