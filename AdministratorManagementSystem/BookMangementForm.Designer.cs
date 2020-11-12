namespace AdministratorManagementSystem
{
    partial class BookMangementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMangementForm));
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Review = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPresiseSearch = new System.Windows.Forms.Button();
            this.comboBoxOption = new System.Windows.Forms.ComboBox();
            this.linkLabelAddNewBook = new System.Windows.Forms.LinkLabel();
            this.buttonFuzzySearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AllowUserToResizeRows = false;
            this.dataGridViewBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Quantity,
            this.IsOnSale,
            this.Detail,
            this.Edit,
            this.Delete,
            this.Review,
            this.Order});
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersVisible = false;
            this.dataGridViewBooks.RowTemplate.Height = 23;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1088, 562);
            this.dataGridViewBooks.TabIndex = 7;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            this.dataGridViewBooks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBooks_CellMouseClick);
            // 
            // ISBN
            // 
            this.ISBN.FillWeight = 89.97911F;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.FillWeight = 52.90772F;
            this.Title.HeaderText = "题名";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 52.90772F;
            this.Quantity.HeaderText = "数量";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // IsOnSale
            // 
            this.IsOnSale.HeaderText = "是否上架";
            this.IsOnSale.Name = "IsOnSale";
            this.IsOnSale.ReadOnly = true;
            this.IsOnSale.Width = 80;
            // 
            // Detail
            // 
            this.Detail.FillWeight = 52.90772F;
            this.Detail.HeaderText = "详情";
            this.Detail.MinimumWidth = 60;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "查看图书详情";
            this.Detail.UseColumnTextForButtonValue = true;
            this.Detail.Width = 85;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 52.90772F;
            this.Edit.HeaderText = "修改";
            this.Edit.MinimumWidth = 60;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "修改图书信息";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 85;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 52.90772F;
            this.Delete.HeaderText = "删除";
            this.Delete.MinimumWidth = 60;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "删除图书信息";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 85;
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
            // Order
            // 
            this.Order.HeaderText = "订单";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Text = "查看所有订单";
            this.Order.UseColumnTextForButtonValue = true;
            this.Order.Width = 85;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonRefresh.Location = new System.Drawing.Point(1049, 36);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(51, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(131, 37);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(750, 21);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonPresiseSearch
            // 
            this.buttonPresiseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPresiseSearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonPresiseSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPresiseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPresiseSearch.Location = new System.Drawing.Point(887, 35);
            this.buttonPresiseSearch.Name = "buttonPresiseSearch";
            this.buttonPresiseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonPresiseSearch.TabIndex = 2;
            this.buttonPresiseSearch.Text = "精确检索";
            this.buttonPresiseSearch.UseVisualStyleBackColor = true;
            this.buttonPresiseSearch.Click += new System.EventHandler(this.buttonPreciseSearch_Click);
            // 
            // comboBoxOption
            // 
            this.comboBoxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOption.FormattingEnabled = true;
            this.comboBoxOption.Items.AddRange(new object[] {
            "ISBN",
            "题名",
            "作者",
            "出版社",
            "中图分类号",
            "出版年",
            "库存数量",
            "价格",
            "是否上架"});
            this.comboBoxOption.Location = new System.Drawing.Point(12, 38);
            this.comboBoxOption.Name = "comboBoxOption";
            this.comboBoxOption.Size = new System.Drawing.Size(113, 20);
            this.comboBoxOption.TabIndex = 0;
            // 
            // linkLabelAddNewBook
            // 
            this.linkLabelAddNewBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAddNewBook.AutoSize = true;
            this.linkLabelAddNewBook.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAddNewBook.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelAddNewBook.Location = new System.Drawing.Point(1047, 85);
            this.linkLabelAddNewBook.Name = "linkLabelAddNewBook";
            this.linkLabelAddNewBook.Size = new System.Drawing.Size(53, 12);
            this.linkLabelAddNewBook.TabIndex = 6;
            this.linkLabelAddNewBook.TabStop = true;
            this.linkLabelAddNewBook.Text = "添加新书";
            this.linkLabelAddNewBook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddNewBook_LinkClicked);
            // 
            // buttonFuzzySearch
            // 
            this.buttonFuzzySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFuzzySearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFuzzySearch.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.ButtonBackgroundImage;
            this.buttonFuzzySearch.Location = new System.Drawing.Point(968, 35);
            this.buttonFuzzySearch.Name = "buttonFuzzySearch";
            this.buttonFuzzySearch.Size = new System.Drawing.Size(75, 23);
            this.buttonFuzzySearch.TabIndex = 3;
            this.buttonFuzzySearch.Text = "模糊检索";
            this.buttonFuzzySearch.UseVisualStyleBackColor = false;
            this.buttonFuzzySearch.Click += new System.EventHandler(this.buttonFuzzySearch_Click);
            // 
            // BookMangementForm
            // 
            this.AcceptButton = this.buttonPresiseSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.timg;
            this.ClientSize = new System.Drawing.Size(1112, 674);
            this.Controls.Add(this.buttonFuzzySearch);
            this.Controls.Add(this.linkLabelAddNewBook);
            this.Controls.Add(this.comboBoxOption);
            this.Controls.Add(this.buttonPresiseSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewBooks);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookMangementForm";
            this.Text = "图书";
            this.Load += new System.EventHandler(this.BookMangementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonPresiseSearch;
        private System.Windows.Forms.ComboBox comboBoxOption;
        private System.Windows.Forms.LinkLabel linkLabelAddNewBook;
        private System.Windows.Forms.Button buttonFuzzySearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsOnSale;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Review;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
    }
}