namespace AdministratorManagementSystem
{
    partial class BookAdderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAdderForm));
            this.checkBoxIsNullDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerPublicationDate = new System.Windows.Forms.DateTimePicker();
            this.buttonClear = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
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
            this.checkBoxIsOnSale = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxIsNullDate
            // 
            this.checkBoxIsNullDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsNullDate.AutoSize = true;
            this.checkBoxIsNullDate.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIsNullDate.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxIsNullDate.Location = new System.Drawing.Point(401, 214);
            this.checkBoxIsNullDate.Name = "checkBoxIsNullDate";
            this.checkBoxIsNullDate.Size = new System.Drawing.Size(105, 25);
            this.checkBoxIsNullDate.TabIndex = 5;
            this.checkBoxIsNullDate.Text = "日期为空";
            this.checkBoxIsNullDate.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerPublicationDate
            // 
            this.dateTimePickerPublicationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerPublicationDate.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePickerPublicationDate.Location = new System.Drawing.Point(133, 211);
            this.dateTimePickerPublicationDate.Name = "dateTimePickerPublicationDate";
            this.dateTimePickerPublicationDate.Size = new System.Drawing.Size(226, 32);
            this.dateTimePickerPublicationDate.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(220, 690);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 39);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(133, 241);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(352, 29);
            this.comboBoxGenre.TabIndex = 6;
            // 
            // textBoxIntroduction
            // 
            this.textBoxIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntroduction.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxIntroduction.Location = new System.Drawing.Point(133, 343);
            this.textBoxIntroduction.Multiline = true;
            this.textBoxIntroduction.Name = "textBoxIntroduction";
            this.textBoxIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIntroduction.Size = new System.Drawing.Size(352, 298);
            this.textBoxIntroduction.TabIndex = 9;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuantity.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxQuantity.Location = new System.Drawing.Point(133, 309);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(352, 32);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPrice.Location = new System.Drawing.Point(133, 274);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(352, 32);
            this.textBoxPrice.TabIndex = 7;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPublisher.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPublisher.Location = new System.Drawing.Point(133, 178);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(352, 32);
            this.textBoxPublisher.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAuthor.Location = new System.Drawing.Point(133, 142);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(352, 32);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTitle.Location = new System.Drawing.Point(133, 109);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(352, 32);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxISBN.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxISBN.Location = new System.Drawing.Point(133, 76);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(352, 32);
            this.textBoxISBN.TabIndex = 0;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrice.Location = new System.Drawing.Point(39, 280);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(59, 22);
            this.labelPrice.TabIndex = 49;
            this.labelPrice.Text = "价格*";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantity.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelQuantity.Location = new System.Drawing.Point(39, 315);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(99, 22);
            this.labelQuantity.TabIndex = 48;
            this.labelQuantity.Text = "库存数量*";
            // 
            // labelIntroduction
            // 
            this.labelIntroduction.AutoSize = true;
            this.labelIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.labelIntroduction.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIntroduction.Location = new System.Drawing.Point(39, 347);
            this.labelIntroduction.Name = "labelIntroduction";
            this.labelIntroduction.Size = new System.Drawing.Size(50, 22);
            this.labelIntroduction.TabIndex = 47;
            this.labelIntroduction.Text = "介绍";
            // 
            // labelPublicationDate
            // 
            this.labelPublicationDate.AutoSize = true;
            this.labelPublicationDate.BackColor = System.Drawing.Color.Transparent;
            this.labelPublicationDate.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPublicationDate.Location = new System.Drawing.Point(39, 220);
            this.labelPublicationDate.Name = "labelPublicationDate";
            this.labelPublicationDate.Size = new System.Drawing.Size(90, 22);
            this.labelPublicationDate.TabIndex = 46;
            this.labelPublicationDate.Text = "出版日期";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.BackColor = System.Drawing.Color.Transparent;
            this.labelGenre.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGenre.Location = new System.Drawing.Point(39, 251);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(59, 22);
            this.labelGenre.TabIndex = 45;
            this.labelGenre.Text = "分类*";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.BackColor = System.Drawing.Color.Transparent;
            this.labelPublisher.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPublisher.Location = new System.Drawing.Point(39, 184);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(70, 22);
            this.labelPublisher.TabIndex = 44;
            this.labelPublisher.Text = "出版社";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAuthor.Location = new System.Drawing.Point(39, 149);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(50, 22);
            this.labelAuthor.TabIndex = 43;
            this.labelAuthor.Text = "作者";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(39, 115);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(59, 22);
            this.labelTitle.TabIndex = 42;
            this.labelTitle.Text = "题名*";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.BackColor = System.Drawing.Color.Transparent;
            this.labelISBN.Font = new System.Drawing.Font("华文楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelISBN.Location = new System.Drawing.Point(39, 86);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(63, 22);
            this.labelISBN.TabIndex = 41;
            this.labelISBN.Text = "ISBN*";
            // 
            // checkBoxIsOnSale
            // 
            this.checkBoxIsOnSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxIsOnSale.AutoSize = true;
            this.checkBoxIsOnSale.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxIsOnSale.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxIsOnSale.Location = new System.Drawing.Point(133, 648);
            this.checkBoxIsOnSale.Name = "checkBoxIsOnSale";
            this.checkBoxIsOnSale.Size = new System.Drawing.Size(113, 25);
            this.checkBoxIsOnSale.TabIndex = 50;
            this.checkBoxIsOnSale.Text = "是否上架*";
            this.checkBoxIsOnSale.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(338, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 41);
            this.button1.TabIndex = 51;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInsert.BackColor = System.Drawing.Color.Transparent;
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonInsert.Location = new System.Drawing.Point(103, 690);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(86, 39);
            this.buttonInsert.TabIndex = 52;
            this.buttonInsert.Text = "确认";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // BookAdderForm
            // 
            this.AcceptButton = this.buttonInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.指皇;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 801);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxIsOnSale);
            this.Controls.Add(this.checkBoxIsNullDate);
            this.Controls.Add(this.dateTimePickerPublicationDate);
            this.Controls.Add(this.buttonClear);
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
            this.Name = "BookAdderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "增添图书";
            this.Load += new System.EventHandler(this.BookAdderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxIsNullDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublicationDate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ComboBox comboBoxGenre;
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
        private System.Windows.Forms.CheckBox checkBoxIsOnSale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInsert;
    }
}