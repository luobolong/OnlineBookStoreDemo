namespace CustomerClient
{
    partial class TopUpForm
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonOK = new FontAwesome.Sharp.IconButton();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(357, 29);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 22);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "充值";
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
            this.buttonExit.Location = new System.Drawing.Point(334, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAmount.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(0, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(54, 28);
            this.labelAmount.TabIndex = 9;
            this.labelAmount.Text = "数额";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxMoney);
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Location = new System.Drawing.Point(62, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 31);
            this.panel1.TabIndex = 12;
            // 
            // iconButtonOK
            // 
            this.iconButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonOK.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButtonOK.FlatAppearance.BorderSize = 0;
            this.iconButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonOK.ForeColor = System.Drawing.Color.White;
            this.iconButtonOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonOK.IconColor = System.Drawing.Color.White;
            this.iconButtonOK.IconSize = 22;
            this.iconButtonOK.Location = new System.Drawing.Point(145, 117);
            this.iconButtonOK.Name = "iconButtonOK";
            this.iconButtonOK.Rotation = 0D;
            this.iconButtonOK.Size = new System.Drawing.Size(74, 29);
            this.iconButtonOK.TabIndex = 13;
            this.iconButtonOK.Text = "确认";
            this.iconButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOK.UseVisualStyleBackColor = false;
            this.iconButtonOK.Click += new System.EventHandler(this.iconButtonOK_Click);
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxMoney.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxMoney.Location = new System.Drawing.Point(114, 0);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(118, 29);
            this.textBoxMoney.TabIndex = 10;
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMoney_KeyPress);
            // 
            // TopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(357, 168);
            this.Controls.Add(this.iconButtonOK);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddToCartForm";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonOK;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.TextBox textBoxMoney;
    }
}