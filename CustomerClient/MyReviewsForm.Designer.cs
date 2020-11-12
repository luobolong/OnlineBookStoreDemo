namespace CustomerClient
{
    partial class MyReviewsForm
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
            this.dataGridViewMyReviews = new System.Windows.Forms.DataGridView();
            this.BookISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(220, 64);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "我的评论";
            // 
            // dataGridViewMyReviews
            // 
            this.dataGridViewMyReviews.AllowUserToAddRows = false;
            this.dataGridViewMyReviews.AllowUserToDeleteRows = false;
            this.dataGridViewMyReviews.AllowUserToResizeRows = false;
            this.dataGridViewMyReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMyReviews.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridViewMyReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMyReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookISBN,
            this.Title,
            this.ReviewDate,
            this.ReviewRate,
            this.ReviewContent,
            this.Edit,
            this.Delete});
            this.dataGridViewMyReviews.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMyReviews.Location = new System.Drawing.Point(23, 76);
            this.dataGridViewMyReviews.Name = "dataGridViewMyReviews";
            this.dataGridViewMyReviews.ReadOnly = true;
            this.dataGridViewMyReviews.RowHeadersVisible = false;
            this.dataGridViewMyReviews.RowTemplate.Height = 23;
            this.dataGridViewMyReviews.Size = new System.Drawing.Size(916, 480);
            this.dataGridViewMyReviews.TabIndex = 7;
            this.dataGridViewMyReviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyReviews_CellContentClick);
            // 
            // BookISBN
            // 
            this.BookISBN.HeaderText = "ISBN";
            this.BookISBN.Name = "BookISBN";
            this.BookISBN.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "书名";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 150;
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
            // Edit
            // 
            this.Edit.HeaderText = "修改";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "修改评论";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 65;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "删除";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "删除评论";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 65;
            // 
            // MyReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(951, 568);
            this.Controls.Add(this.dataGridViewMyReviews);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Name = "MyReviewsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyReviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewMyReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviewContent;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}