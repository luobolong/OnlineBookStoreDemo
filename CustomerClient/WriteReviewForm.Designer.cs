namespace CustomerClient
{
    partial class WriteReviewForm
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
            this.textBoxReviewContent = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelReviewContent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelReviewRate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelStars = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.iconButtonOK = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelStars.SuspendLayout();
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
            this.labelTitle.Text = "撰写评论";
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
            this.panelTitleBar.Size = new System.Drawing.Size(507, 37);
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
            this.buttonMinimize.Location = new System.Drawing.Point(432, 3);
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
            this.buttonMaximize.Location = new System.Drawing.Point(458, 3);
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
            this.buttonExit.Location = new System.Drawing.Point(484, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(20, 22);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxReviewContent
            // 
            this.textBoxReviewContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReviewContent.BackColor = System.Drawing.Color.White;
            this.textBoxReviewContent.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReviewContent.Location = new System.Drawing.Point(0, 135);
            this.textBoxReviewContent.Multiline = true;
            this.textBoxReviewContent.Name = "textBoxReviewContent";
            this.textBoxReviewContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReviewContent.Size = new System.Drawing.Size(338, 228);
            this.textBoxReviewContent.TabIndex = 29;
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
            this.textBoxTitle.Size = new System.Drawing.Size(338, 26);
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
            this.textBoxISBN.Size = new System.Drawing.Size(338, 26);
            this.textBoxISBN.TabIndex = 10;
            // 
            // labelReviewContent
            // 
            this.labelReviewContent.AutoSize = true;
            this.labelReviewContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelReviewContent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelReviewContent.ForeColor = System.Drawing.Color.White;
            this.labelReviewContent.Location = new System.Drawing.Point(0, 123);
            this.labelReviewContent.Name = "labelReviewContent";
            this.labelReviewContent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelReviewContent.Size = new System.Drawing.Size(42, 41);
            this.labelReviewContent.TabIndex = 23;
            this.labelReviewContent.Text = "评论";
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
            this.panelLabels.Controls.Add(this.labelReviewContent);
            this.panelLabels.Controls.Add(this.labelReviewRate);
            this.panelLabels.Controls.Add(this.label1);
            this.panelLabels.Controls.Add(this.labelISBN);
            this.panelLabels.Location = new System.Drawing.Point(38, 71);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(87, 169);
            this.panelLabels.TabIndex = 30;
            // 
            // labelReviewRate
            // 
            this.labelReviewRate.AutoSize = true;
            this.labelReviewRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelReviewRate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelReviewRate.ForeColor = System.Drawing.Color.White;
            this.labelReviewRate.Location = new System.Drawing.Point(0, 82);
            this.labelReviewRate.Name = "labelReviewRate";
            this.labelReviewRate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelReviewRate.Size = new System.Drawing.Size(74, 41);
            this.labelReviewRate.TabIndex = 24;
            this.labelReviewRate.Text = "评价等级";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.panelStars);
            this.panel1.Controls.Add(this.textBoxReviewContent);
            this.panel1.Controls.Add(this.textBoxISBN);
            this.panel1.Controls.Add(this.textBoxTitle);
            this.panel1.Location = new System.Drawing.Point(143, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 363);
            this.panel1.TabIndex = 31;
            // 
            // panelStars
            // 
            this.panelStars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStars.Controls.Add(this.radioButton5);
            this.panelStars.Controls.Add(this.radioButton4);
            this.panelStars.Controls.Add(this.radioButton3);
            this.panelStars.Controls.Add(this.radioButton2);
            this.panelStars.Controls.Add(this.radioButton1);
            this.panelStars.Location = new System.Drawing.Point(0, 94);
            this.panelStars.Name = "panelStars";
            this.panelStars.Size = new System.Drawing.Size(338, 18);
            this.panelStars.TabIndex = 31;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton5.ForeColor = System.Drawing.Color.Gold;
            this.radioButton5.Location = new System.Drawing.Point(240, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 18);
            this.radioButton5.TabIndex = 30;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "★★★★★";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.ForeColor = System.Drawing.Color.Gold;
            this.radioButton4.Location = new System.Drawing.Point(159, 0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(81, 18);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.Text = "★★★★";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.ForeColor = System.Drawing.Color.Gold;
            this.radioButton3.Location = new System.Drawing.Point(92, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(67, 18);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.Text = "★★★";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.ForeColor = System.Drawing.Color.Gold;
            this.radioButton2.Location = new System.Drawing.Point(39, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 18);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Text = "★★";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gold;
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 18);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.Text = "★";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // iconButtonOK
            // 
            this.iconButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonOK.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButtonOK.FlatAppearance.BorderSize = 0;
            this.iconButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOK.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonOK.ForeColor = System.Drawing.Color.White;
            this.iconButtonOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonOK.IconColor = System.Drawing.Color.White;
            this.iconButtonOK.IconSize = 32;
            this.iconButtonOK.Location = new System.Drawing.Point(182, 439);
            this.iconButtonOK.Name = "iconButtonOK";
            this.iconButtonOK.Rotation = 0D;
            this.iconButtonOK.Size = new System.Drawing.Size(97, 46);
            this.iconButtonOK.TabIndex = 32;
            this.iconButtonOK.Text = "确认";
            this.iconButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOK.UseVisualStyleBackColor = false;
            this.iconButtonOK.Click += new System.EventHandler(this.iconButtonOK_Click);
            // 
            // WriteReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(507, 511);
            this.ControlBox = false;
            this.Controls.Add(this.iconButtonOK);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.panel1);
            this.Name = "WriteReviewForm";
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
            this.panelStars.ResumeLayout(false);
            this.panelStars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private FontAwesome.Sharp.IconButton buttonMaximize;
        private System.Windows.Forms.TextBox textBoxReviewContent;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelReviewContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonOK;
        private System.Windows.Forms.Label labelReviewRate;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panelStars;
    }
}