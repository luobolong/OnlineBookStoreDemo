namespace CustomerClient
{
    partial class SubmitOrderForm
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
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.textBoxPirce = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.iconButtonSubmit = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            this.panelLabels.SuspendLayout();
            this.panelTextBoxes.SuspendLayout();
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
            this.labelTitle.Text = "提交订单";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(577, 37);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.buttonExit.Location = new System.Drawing.Point(554, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(20, 22);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxPirce
            // 
            this.textBoxPirce.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPirce.BackColor = System.Drawing.Color.White;
            this.textBoxPirce.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPirce.Location = new System.Drawing.Point(0, 92);
            this.textBoxPirce.Name = "textBoxPirce";
            this.textBoxPirce.ReadOnly = true;
            this.textBoxPirce.Size = new System.Drawing.Size(400, 26);
            this.textBoxPirce.TabIndex = 14;
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
            this.textBoxTitle.Size = new System.Drawing.Size(400, 26);
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
            this.textBoxISBN.Size = new System.Drawing.Size(400, 26);
            this.textBoxISBN.TabIndex = 10;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(0, 82);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelPrice.Size = new System.Drawing.Size(42, 41);
            this.labelPrice.TabIndex = 28;
            this.labelPrice.Text = "单价";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAmount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(0, 123);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelAmount.Size = new System.Drawing.Size(42, 41);
            this.labelAmount.TabIndex = 23;
            this.labelAmount.Text = "数量";
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
            this.panelLabels.Controls.Add(this.labelTotalPrice);
            this.panelLabels.Controls.Add(this.labelAmount);
            this.panelLabels.Controls.Add(this.labelPrice);
            this.panelLabels.Controls.Add(this.label1);
            this.panelLabels.Controls.Add(this.labelISBN);
            this.panelLabels.Location = new System.Drawing.Point(38, 71);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(87, 217);
            this.panelLabels.TabIndex = 30;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTotalPrice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelTotalPrice.Location = new System.Drawing.Point(0, 164);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.labelTotalPrice.Size = new System.Drawing.Size(42, 41);
            this.labelTotalPrice.TabIndex = 29;
            this.labelTotalPrice.Text = "合计";
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTextBoxes.Controls.Add(this.textBoxISBN);
            this.panelTextBoxes.Controls.Add(this.textBoxTitle);
            this.panelTextBoxes.Controls.Add(this.textBoxTotalPrice);
            this.panelTextBoxes.Controls.Add(this.textBoxAmount);
            this.panelTextBoxes.Controls.Add(this.textBoxPirce);
            this.panelTextBoxes.Location = new System.Drawing.Point(143, 59);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(400, 229);
            this.panelTextBoxes.TabIndex = 31;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotalPrice.BackColor = System.Drawing.Color.White;
            this.textBoxTotalPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxTotalPrice.Location = new System.Drawing.Point(0, 174);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(400, 26);
            this.textBoxTotalPrice.TabIndex = 14;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAmount.BackColor = System.Drawing.Color.White;
            this.textBoxAmount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAmount.Location = new System.Drawing.Point(0, 133);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(400, 26);
            this.textBoxAmount.TabIndex = 14;
            // 
            // iconButtonSubmit
            // 
            this.iconButtonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSubmit.BackColor = System.Drawing.Color.Chocolate;
            this.iconButtonSubmit.FlatAppearance.BorderSize = 0;
            this.iconButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSubmit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSubmit.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.iconButtonSubmit.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButtonSubmit.IconColor = System.Drawing.Color.White;
            this.iconButtonSubmit.IconSize = 32;
            this.iconButtonSubmit.Location = new System.Drawing.Point(216, 294);
            this.iconButtonSubmit.Name = "iconButtonSubmit";
            this.iconButtonSubmit.Rotation = 0D;
            this.iconButtonSubmit.Size = new System.Drawing.Size(140, 46);
            this.iconButtonSubmit.TabIndex = 32;
            this.iconButtonSubmit.Text = "提交订单";
            this.iconButtonSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSubmit.UseVisualStyleBackColor = false;
            this.iconButtonSubmit.Click += new System.EventHandler(this.iconButtonSubmit_Click);
            // 
            // SubmitOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(577, 381);
            this.ControlBox = false;
            this.Controls.Add(this.iconButtonSubmit);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.panelTextBoxes);
            this.Name = "SubmitOrderForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.panelTextBoxes.ResumeLayout(false);
            this.panelTextBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.TextBox textBoxPirce;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Panel panelTextBoxes;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private FontAwesome.Sharp.IconButton iconButtonSubmit;
    }
}