namespace SupplierClient
{
    partial class SupplyForm
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
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.iconButtonSupply = new FontAwesome.Sharp.IconButton();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.panelLabels.SuspendLayout();
            this.panelTextBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.BackColor = System.Drawing.Color.Transparent;
            this.labelISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelISBN.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelISBN.ForeColor = System.Drawing.Color.White;
            this.labelISBN.Location = new System.Drawing.Point(0, 0);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Padding = new System.Windows.Forms.Padding(10, 0, 0, 100);
            this.labelISBN.Size = new System.Drawing.Size(82, 131);
            this.labelISBN.TabIndex = 1;
            this.labelISBN.Text = "ISBN";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxISBN.BackColor = System.Drawing.Color.White;
            this.textBoxISBN.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxISBN.Location = new System.Drawing.Point(0, 0);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(505, 39);
            this.textBoxISBN.TabIndex = 0;
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
            this.labelTitle.Text = "供应图书";
            // 
            // panelLabels
            // 
            this.panelLabels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLabels.Controls.Add(this.labelAmount);
            this.panelLabels.Controls.Add(this.labelISBN);
            this.panelLabels.Location = new System.Drawing.Point(134, 129);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(140, 271);
            this.panelLabels.TabIndex = 4;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAmount.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(0, 131);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 100);
            this.labelAmount.Size = new System.Drawing.Size(120, 131);
            this.labelAmount.TabIndex = 4;
            this.labelAmount.Text = "供应数量";
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTextBoxes.Controls.Add(this.numericUpDownAmount);
            this.panelTextBoxes.Controls.Add(this.textBoxISBN);
            this.panelTextBoxes.Location = new System.Drawing.Point(280, 128);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(505, 272);
            this.panelTextBoxes.TabIndex = 0;
            // 
            // iconButtonSupply
            // 
            this.iconButtonSupply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonSupply.BackColor = System.Drawing.Color.DarkViolet;
            this.iconButtonSupply.FlatAppearance.BorderSize = 0;
            this.iconButtonSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSupply.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonSupply.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonSupply.ForeColor = System.Drawing.Color.White;
            this.iconButtonSupply.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconButtonSupply.IconColor = System.Drawing.Color.White;
            this.iconButtonSupply.IconSize = 32;
            this.iconButtonSupply.Location = new System.Drawing.Point(378, 406);
            this.iconButtonSupply.Name = "iconButtonSupply";
            this.iconButtonSupply.Rotation = 0D;
            this.iconButtonSupply.Size = new System.Drawing.Size(144, 46);
            this.iconButtonSupply.TabIndex = 5;
            this.iconButtonSupply.Text = "供应图书";
            this.iconButtonSupply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSupply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSupply.UseVisualStyleBackColor = false;
            this.iconButtonSupply.Click += new System.EventHandler(this.iconButtonSupply_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(0, 134);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(505, 35);
            this.numericUpDownAmount.TabIndex = 1;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(951, 568);
            this.Controls.Add(this.iconButtonSupply);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTextBoxes);
            this.Controls.Add(this.panelLabels);
            this.DoubleBuffered = true;
            this.Name = "SupplyForm";
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.panelTextBoxes.ResumeLayout(false);
            this.panelTextBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Panel panelTextBoxes;
        private FontAwesome.Sharp.IconButton iconButtonSupply;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
    }
}