namespace AdministratorManagementSystem
{
    partial class BookEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookEditorForm));
            this.textBoxIntroduction = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelIntroduction = new System.Windows.Forms.Label();
            this.labelPublicationDate = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dateTimePickerPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxIsNullDate = new System.Windows.Forms.CheckBox();
            this.checkBoxIsOnSale = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxIntroduction
            // 
            this.textBoxIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntroduction.Location = new System.Drawing.Point(130, 337);
            this.textBoxIntroduction.Multiline = true;
            this.textBoxIntroduction.Name = "textBoxIntroduction";
            this.textBoxIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIntroduction.Size = new System.Drawing.Size(337, 179);
            this.textBoxIntroduction.TabIndex = 9;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuantity.Location = new System.Drawing.Point(130, 306);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(337, 21);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Location = new System.Drawing.Point(130, 271);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(337, 21);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPublisher.Location = new System.Drawing.Point(130, 175);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(337, 21);
            this.textBoxPublisher.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.Location = new System.Drawing.Point(130, 139);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(337, 21);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(130, 106);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(337, 21);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxISBN.Location = new System.Drawing.Point(130, 73);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(337, 21);
            this.textBoxISBN.TabIndex = 0;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrice.Location = new System.Drawing.Point(49, 270);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 18);
            this.labelPrice.TabIndex = 28;
            this.labelPrice.Text = "价格*";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelQuantity.Location = new System.Drawing.Point(49, 305);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(79, 18);
            this.labelQuantity.TabIndex = 27;
            this.labelQuantity.Text = "库存数量*";
            // 
            // labelIntroduction
            // 
            this.labelIntroduction.AutoSize = true;
            this.labelIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.labelIntroduction.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIntroduction.Location = new System.Drawing.Point(49, 336);
            this.labelIntroduction.Name = "labelIntroduction";
            this.labelIntroduction.Size = new System.Drawing.Size(40, 18);
            this.labelIntroduction.TabIndex = 23;
            this.labelIntroduction.Text = "介绍";
            // 
            // labelPublicationDate
            // 
            this.labelPublicationDate.AutoSize = true;
            this.labelPublicationDate.BackColor = System.Drawing.Color.Transparent;
            this.labelPublicationDate.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPublicationDate.Location = new System.Drawing.Point(49, 210);
            this.labelPublicationDate.Name = "labelPublicationDate";
            this.labelPublicationDate.Size = new System.Drawing.Size(72, 18);
            this.labelPublicationDate.TabIndex = 21;
            this.labelPublicationDate.Text = "出版日期";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.Color.Transparent;
            this.labelGenre.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGenre.Location = new System.Drawing.Point(49, 241);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(47, 18);
            this.labelGenre.TabIndex = 19;
            this.labelGenre.Text = "分类*";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.BackColor = System.Drawing.Color.Transparent;
            this.labelPublisher.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPublisher.Location = new System.Drawing.Point(49, 174);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(56, 18);
            this.labelPublisher.TabIndex = 17;
            this.labelPublisher.Text = "出版社";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAuthor.Location = new System.Drawing.Point(49, 138);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(40, 18);
            this.labelAuthor.TabIndex = 15;
            this.labelAuthor.Text = "作者";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(49, 105);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 18);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "题名*";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.BackColor = System.Drawing.Color.Transparent;
            this.labelISBN.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelISBN.Location = new System.Drawing.Point(49, 76);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(44, 18);
            this.labelISBN.TabIndex = 11;
            this.labelISBN.Text = "ISBN";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(130, 238);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(337, 20);
            this.comboBoxGenre.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("华文楷体", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUpdate.Location = new System.Drawing.Point(133, 598);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(83, 42);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "确认";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("华文楷体", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(288, 598);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 42);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dateTimePickerPublicationDate
            // 
            this.dateTimePickerPublicationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPublicationDate.Location = new System.Drawing.Point(130, 208);
            this.dateTimePickerPublicationDate.Name = "dateTimePickerPublicationDate";
            this.dateTimePickerPublicationDate.Size = new System.Drawing.Size(259, 21);
            this.dateTimePickerPublicationDate.TabIndex = 4;
            // 
            // checkBoxIsNullDate
            // 
            this.checkBoxIsNullDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsNullDate.AutoSize = true;
            this.checkBoxIsNullDate.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIsNullDate.Location = new System.Drawing.Point(395, 210);
            this.checkBoxIsNullDate.Name = "checkBoxIsNullDate";
            this.checkBoxIsNullDate.Size = new System.Drawing.Size(72, 16);
            this.checkBoxIsNullDate.TabIndex = 5;
            this.checkBoxIsNullDate.Text = "日期为空";
            this.checkBoxIsNullDate.UseVisualStyleBackColor = false;
            // 
            // checkBoxIsOnSale
            // 
            this.checkBoxIsOnSale.AutoSize = true;
            this.checkBoxIsOnSale.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIsOnSale.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxIsOnSale.Location = new System.Drawing.Point(130, 522);
            this.checkBoxIsOnSale.Name = "checkBoxIsOnSale";
            this.checkBoxIsOnSale.Size = new System.Drawing.Size(98, 22);
            this.checkBoxIsOnSale.TabIndex = 51;
            this.checkBoxIsOnSale.Text = "是否上架*";
            this.checkBoxIsOnSale.UseVisualStyleBackColor = false;
            // 
            // BookEditorForm
            // 
            this.AcceptButton = this.buttonUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.指皇;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 713);
            this.Controls.Add(this.checkBoxIsOnSale);
            this.Controls.Add(this.checkBoxIsNullDate);
            this.Controls.Add(this.dateTimePickerPublicationDate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.textBoxIntroduction);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelIntroduction);
            this.Controls.Add(this.labelPublicationDate);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelISBN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookEditorForm";
            this.Text = "编辑图书信息";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIntroduction;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelIntroduction;
        private System.Windows.Forms.Label labelPublicationDate;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublicationDate;
        private System.Windows.Forms.CheckBox checkBoxIsNullDate;
        private System.Windows.Forms.CheckBox checkBoxIsOnSale;
    }
}