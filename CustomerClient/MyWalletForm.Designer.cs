namespace CustomerClient
{
    partial class MyWalletForm
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
            this.labelWalletBalance = new System.Windows.Forms.Label();
            this.textBoxWalletBalance = new System.Windows.Forms.TextBox();
            this.iconButtonTopUp = new FontAwesome.Sharp.IconButton();
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
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "我的钱包";
            // 
            // labelWalletBalance
            // 
            this.labelWalletBalance.AutoSize = true;
            this.labelWalletBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelWalletBalance.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWalletBalance.ForeColor = System.Drawing.Color.White;
            this.labelWalletBalance.Location = new System.Drawing.Point(234, 221);
            this.labelWalletBalance.Name = "labelWalletBalance";
            this.labelWalletBalance.Size = new System.Drawing.Size(110, 31);
            this.labelWalletBalance.TabIndex = 5;
            this.labelWalletBalance.Text = "账户余额";
            // 
            // textBoxWalletBalance
            // 
            this.textBoxWalletBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWalletBalance.BackColor = System.Drawing.Color.White;
            this.textBoxWalletBalance.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxWalletBalance.Location = new System.Drawing.Point(392, 221);
            this.textBoxWalletBalance.Name = "textBoxWalletBalance";
            this.textBoxWalletBalance.ReadOnly = true;
            this.textBoxWalletBalance.Size = new System.Drawing.Size(307, 35);
            this.textBoxWalletBalance.TabIndex = 11;
            // 
            // iconButtonTopUp
            // 
            this.iconButtonTopUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonTopUp.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButtonTopUp.FlatAppearance.BorderSize = 0;
            this.iconButtonTopUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTopUp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonTopUp.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonTopUp.ForeColor = System.Drawing.Color.White;
            this.iconButtonTopUp.IconChar = FontAwesome.Sharp.IconChar.YenSign;
            this.iconButtonTopUp.IconColor = System.Drawing.Color.White;
            this.iconButtonTopUp.IconSize = 32;
            this.iconButtonTopUp.Location = new System.Drawing.Point(407, 330);
            this.iconButtonTopUp.Name = "iconButtonTopUp";
            this.iconButtonTopUp.Rotation = 0D;
            this.iconButtonTopUp.Size = new System.Drawing.Size(97, 46);
            this.iconButtonTopUp.TabIndex = 12;
            this.iconButtonTopUp.Text = "充值";
            this.iconButtonTopUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTopUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTopUp.UseVisualStyleBackColor = false;
            this.iconButtonTopUp.Click += new System.EventHandler(this.iconButtonTopUp_Click);
            // 
            // MyWalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(951, 568);
            this.Controls.Add(this.iconButtonTopUp);
            this.Controls.Add(this.textBoxWalletBalance);
            this.Controls.Add(this.labelWalletBalance);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.Name = "MyWalletForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelWalletBalance;
        private System.Windows.Forms.TextBox textBoxWalletBalance;
        private FontAwesome.Sharp.IconButton iconButtonTopUp;
    }
}