namespace CustomerClient
{
    partial class BookDetailForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonMinimize = new FontAwesome.Sharp.IconButton();
            this.buttonMaximize = new FontAwesome.Sharp.IconButton();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.textBoxIntroduction = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxPublicationDate = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelIntroduction = new System.Windows.Forms.Label();
            this.labelPublicationDate = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTitleBar.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(74, 22);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "图书详情";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(528, 37);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMinimize.IconColor = System.Drawing.Color.LightGray;
            this.buttonMinimize.IconSize = 20;
            this.buttonMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMinimize.Location = new System.Drawing.Point(453, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Rotation = 0D;
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 9;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.buttonMaximize.IconColor = System.Drawing.Color.LightGray;
            this.buttonMaximize.IconSize = 20;
            this.buttonMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMaximize.Location = new System.Drawing.Point(479, 3);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Rotation = 0D;
            this.buttonMaximize.Size = new System.Drawing.Size(20, 20);
            this.buttonMaximize.TabIndex = 10;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.buttonExit.IconColor = System.Drawing.Color.LightGray;
            this.buttonExit.IconSize = 20;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.Location = new System.Drawing.Point(505, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(20, 22);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxIntroduction
            // 
            this.textBoxIntroduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntroduction.BackColor = System.Drawing.Color.White;
            this.textBoxIntroduction.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxIntroduction.Location = new System.Drawing.Point(0, 338);
            this.textBoxIntroduction.Multiline = true;
            this.textBoxIntroduction.Name = "textBoxIntroduction";
            this.textBoxIntroduction.ReadOnly = true;
            this.textBoxIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIntroduction.Size = new System.Drawing.Size(351, 185);
            this.textBoxIntroduction.TabIndex = 29;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPrice.Location = new System.Drawing.Point(0, 297);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(351, 26);
            this.textBoxPrice.TabIndex = 24;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRate.BackColor = System.Drawing.Color.White;
            this.textBoxRate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRate.Location = new System.Drawing.Point(0, 256);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(351, 26);
            this.textBoxRate.TabIndex = 22;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGenre.BackColor = System.Drawing.Color.White;
            this.textBoxGenre.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxGenre.Location = new System.Drawing.Point(0, 215);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ReadOnly = true;
            this.textBoxGenre.Size = new System.Drawing.Size(351, 26);
            this.textBoxGenre.TabIndex = 20;
            // 
            // textBoxPublicationDate
            // 
            this.textBoxPublicationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPublicationDate.BackColor = System.Drawing.Color.White;
            this.textBoxPublicationDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPublicationDate.Location = new System.Drawing.Point(0, 174);
            this.textBoxPublicationDate.Name = "textBoxPublicationDate";
            this.textBoxPublicationDate.ReadOnly = true;
            this.textBoxPublicationDate.Size = new System.Drawing.Size(351, 26);
            this.textBoxPublicationDate.TabIndex = 18;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPublisher.BackColor = System.Drawing.Color.White;
            this.textBoxPublisher.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPublisher.Location = new System.Drawing.Point(0, 133);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.ReadOnly = true;
            this.textBoxPublisher.Size = new System.Drawing.Size(351, 26);
            this.textBoxPublisher.TabIndex = 16;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAuthor.BackColor = System.Drawing.Color.White;
            this.textBoxAuthor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAuthor.Location = new System.Drawing.Point(0, 92);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(351, 26);
            this.textBoxAuthor.TabIndex = 14;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.BackColor = System.Drawing.Color.White;
            this.textBoxTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTitle.Location = new System.Drawing.Point(0, 51);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(351, 26);
            this.textBoxTitle.TabIndex = 12;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxISBN.BackColor = System.Drawing.Color.White;
            this.textBoxISBN.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxISBN.Location = new System.Drawing.Point(0, 10);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.ReadOnly = true;
            this.textBoxISBN.Size = new System.Drawing.Size(351, 26);
            this.textBoxISBN.TabIndex = 10;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(0, 287);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelPrice.Size = new System.Drawing.Size(42, 41);
            this.labelPrice.TabIndex = 28;
            this.labelPrice.Text = "价格";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRate.ForeColor = System.Drawing.Color.White;
            this.labelRate.Location = new System.Drawing.Point(0, 246);
            this.labelRate.Name = "labelRate";
            this.labelRate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelRate.Size = new System.Drawing.Size(42, 41);
            this.labelRate.TabIndex = 25;
            this.labelRate.Text = "评分";
            // 
            // labelIntroduction
            // 
            this.labelIntroduction.AutoSize = true;
            this.labelIntroduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelIntroduction.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelIntroduction.ForeColor = System.Drawing.Color.White;
            this.labelIntroduction.Location = new System.Drawing.Point(0, 328);
            this.labelIntroduction.Name = "labelIntroduction";
            this.labelIntroduction.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelIntroduction.Size = new System.Drawing.Size(42, 41);
            this.labelIntroduction.TabIndex = 23;
            this.labelIntroduction.Text = "介绍";
            // 
            // labelPublicationDate
            // 
            this.labelPublicationDate.AutoSize = true;
            this.labelPublicationDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPublicationDate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPublicationDate.ForeColor = System.Drawing.Color.White;
            this.labelPublicationDate.Location = new System.Drawing.Point(0, 164);
            this.labelPublicationDate.Name = "labelPublicationDate";
            this.labelPublicationDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelPublicationDate.Size = new System.Drawing.Size(74, 41);
            this.labelPublicationDate.TabIndex = 21;
            this.labelPublicationDate.Text = "出版日期";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelGenre.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelGenre.ForeColor = System.Drawing.Color.White;
            this.labelGenre.Location = new System.Drawing.Point(0, 205);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelGenre.Size = new System.Drawing.Size(42, 41);
            this.labelGenre.TabIndex = 19;
            this.labelGenre.Text = "分类";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPublisher.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPublisher.ForeColor = System.Drawing.Color.White;
            this.labelPublisher.Location = new System.Drawing.Point(0, 123);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelPublisher.Size = new System.Drawing.Size(58, 41);
            this.labelPublisher.TabIndex = 17;
            this.labelPublisher.Text = "出版社";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAuthor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(0, 82);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelAuthor.Size = new System.Drawing.Size(42, 41);
            this.labelAuthor.TabIndex = 15;
            this.labelAuthor.Text = "作者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label1.Size = new System.Drawing.Size(42, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "题名";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelISBN.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelISBN.ForeColor = System.Drawing.Color.White;
            this.labelISBN.Location = new System.Drawing.Point(0, 0);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelISBN.Size = new System.Drawing.Size(47, 41);
            this.labelISBN.TabIndex = 11;
            this.labelISBN.Text = "ISBN";
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(this.labelIntroduction);
            this.panelLabels.Controls.Add(this.labelPrice);
            this.panelLabels.Controls.Add(this.labelRate);
            this.panelLabels.Controls.Add(this.labelGenre);
            this.panelLabels.Controls.Add(this.labelPublicationDate);
            this.panelLabels.Controls.Add(this.labelPublisher);
            this.panelLabels.Controls.Add(this.labelAuthor);
            this.panelLabels.Controls.Add(this.label1);
            this.panelLabels.Controls.Add(this.labelISBN);
            this.panelLabels.Location = new System.Drawing.Point(38, 71);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(87, 474);
            this.panelLabels.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textBoxIntroduction);
            this.panel1.Controls.Add(this.textBoxISBN);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Controls.Add(this.textBoxRate);
            this.panel1.Controls.Add(this.textBoxAuthor);
            this.panel1.Controls.Add(this.textBoxGenre);
            this.panel1.Controls.Add(this.textBoxPublisher);
            this.panel1.Controls.Add(this.textBoxPublicationDate);
            this.panel1.Location = new System.Drawing.Point(143, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 537);
            this.panel1.TabIndex = 31;
            // 
            // BookDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(528, 619);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.panel1);
            this.Name = "BookDetailForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.ReviewsOfBookForm_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private FontAwesome.Sharp.IconButton buttonMaximize;
        private System.Windows.Forms.TextBox textBoxIntroduction;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxPublicationDate;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelIntroduction;
        private System.Windows.Forms.Label labelPublicationDate;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Panel panel1;
    }
}