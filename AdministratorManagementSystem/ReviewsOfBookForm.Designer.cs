namespace AdministratorManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewsOfBookForm));
            this.dataGridViewReviews = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReviews
            // 
            this.dataGridViewReviews.AllowUserToAddRows = false;
            this.dataGridViewReviews.AllowUserToDeleteRows = false;
            this.dataGridViewReviews.AllowUserToResizeRows = false;
            this.dataGridViewReviews.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.ReviewDate,
            this.ReviewRate,
            this.ReviewContent,
            this.Detail});
            this.dataGridViewReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReviews.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReviews.Name = "dataGridViewReviews";
            this.dataGridViewReviews.ReadOnly = true;
            this.dataGridViewReviews.RowHeadersVisible = false;
            this.dataGridViewReviews.RowTemplate.Height = 23;
            this.dataGridViewReviews.Size = new System.Drawing.Size(1107, 580);
            this.dataGridViewReviews.TabIndex = 2;
            this.dataGridViewReviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReviews_CellContentClick);
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
            // Detail
            // 
            this.Detail.HeaderText = "详情";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "查看用户信息";
            this.Detail.UseColumnTextForButtonValue = true;
            this.Detail.Width = 85;
            // 
            // ReviewsOfBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 580);
            this.Controls.Add(this.dataGridViewReviews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReviewsOfBookForm";
            this.Text = "图书评价";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReviews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewContent;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
    }
}