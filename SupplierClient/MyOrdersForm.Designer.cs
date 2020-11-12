namespace SupplierClient
{
    partial class MyOrdersForm
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
            this.dataGridViewMyOrders = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).BeginInit();
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
            this.labelTitle.Size = new System.Drawing.Size(268, 64);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "我的发货单";
            // 
            // dataGridViewMyOrders
            // 
            this.dataGridViewMyOrders.AllowUserToAddRows = false;
            this.dataGridViewMyOrders.AllowUserToDeleteRows = false;
            this.dataGridViewMyOrders.AllowUserToResizeRows = false;
            this.dataGridViewMyOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMyOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridViewMyOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.Amount,
            this.OrderDate,
            this.OrderStatus,
            this.IsNew,
            this.Detail,
            this.Cancel,
            this.Delete});
            this.dataGridViewMyOrders.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMyOrders.Location = new System.Drawing.Point(23, 76);
            this.dataGridViewMyOrders.Name = "dataGridViewMyOrders";
            this.dataGridViewMyOrders.ReadOnly = true;
            this.dataGridViewMyOrders.RowHeadersVisible = false;
            this.dataGridViewMyOrders.RowTemplate.Height = 23;
            this.dataGridViewMyOrders.Size = new System.Drawing.Size(916, 480);
            this.dataGridViewMyOrders.TabIndex = 7;
            this.dataGridViewMyOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMyOrders_CellContentClick);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "订单号";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "数量";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderDate.HeaderText = "发货时间";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "订单状态";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // IsNew
            // 
            this.IsNew.HeaderText = "是否是新书";
            this.IsNew.Name = "IsNew";
            this.IsNew.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "图书";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Text = "图书详情";
            this.Detail.UseColumnTextForButtonValue = true;
            this.Detail.Width = 65;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "取消";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Text = "取消订单";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 65;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "删除";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "删除订单";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 65;
            // 
            // MyOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(951, 568);
            this.Controls.Add(this.dataGridViewMyOrders);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Name = "MyOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewMyOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNew;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}