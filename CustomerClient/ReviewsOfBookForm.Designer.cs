namespace CustomerClient
{
    partial class ReviewsOfBookForm
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
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
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
            this.labelTitle.Text = "图书评论";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(951, 37);
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
            this.buttonMinimize.Location = new System.Drawing.Point(876, 3);
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
            this.buttonMaximize.Location = new System.Drawing.Point(902, 3);
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
            this.buttonExit.Location = new System.Drawing.Point(928, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(20, 22);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.AllowUserToAddRows = false;
            this.dataGridViewReviews.AllowUserToDeleteRows = false;
            this.dataGridViewReviews.AllowUserToResizeRows = false;
            this.dataGridViewReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReviews.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridViewReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.ReviewDate,
            this.ReviewRate,
            this.ReviewContent});
            this.dataGridViewReviews.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReviews.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.ReadOnly = true;
            this.dataGridViewReviews.RowHeadersVisible = false;
            this.dataGridViewReviews.RowTemplate.Height = 23;
            this.dataGridViewReviews.Size = new System.Drawing.Size(927, 502);
            this.dataGridViewReviews.TabIndex = 5;
            // 
            // Username
            // 
            this.Username.HeaderText = "用户名";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // ReviewDate
            // 
            this.ReviewDate.HeaderText = "评论时间";
            this.ReviewDate.Name = "ReviewDate";
            this.ReviewDate.ReadOnly = true;
            this.ReviewDate.Width = 150;
            // 
            // ReviewRate
            // 
            this.ReviewRate.HeaderText = "评价等级";
            this.ReviewRate.Name = "ReviewRate";
            this.ReviewRate.ReadOnly = true;
            this.ReviewRate.Width = 80;
            // 
            // ReviewContent
            // 
            this.ReviewContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReviewContent.HeaderText = "评论内容";
            this.ReviewContent.Name = "ReviewContent";
            this.ReviewContent.ReadOnly = true;
            // 
            // ReviewsOfBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(951, 568);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewReviews);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "ReviewsOfBookForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.ReviewsOfBookForm_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private FontAwesome.Sharp.IconButton buttonMaximize;
        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewContent;
    }
}