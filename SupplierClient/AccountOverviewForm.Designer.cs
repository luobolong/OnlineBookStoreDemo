namespace SupplierClient
{
    partial class AccountOverviewForm
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxRealName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelRealName = new System.Windows.Forms.Label();
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.panelLabels.SuspendLayout();
            this.panelTextBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUsername.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(0, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Padding = new System.Windows.Forms.Padding(10, 0, 0, 45);
            this.labelUsername.Size = new System.Drawing.Size(96, 76);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "用户名";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.BackColor = System.Drawing.Color.White;
            this.textBoxUsername.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUsername.Location = new System.Drawing.Point(0, 0);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(505, 39);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxRealName
            // 
            this.textBoxRealName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRealName.BackColor = System.Drawing.Color.White;
            this.textBoxRealName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRealName.Location = new System.Drawing.Point(0, 76);
            this.textBoxRealName.Name = "textBoxRealName";
            this.textBoxRealName.ReadOnly = true;
            this.textBoxRealName.Size = new System.Drawing.Size(505, 39);
            this.textBoxRealName.TabIndex = 1;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(3, 152);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(505, 39);
            this.textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailAddress.BackColor = System.Drawing.Color.White;
            this.textBoxEmailAddress.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEmailAddress.Location = new System.Drawing.Point(3, 228);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.ReadOnly = true;
            this.textBoxEmailAddress.Size = new System.Drawing.Size(505, 39);
            this.textBoxEmailAddress.TabIndex = 4;
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
            this.labelTitle.Text = "账户信息";
            // 
            // panelLabels
            // 
            this.panelLabels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLabels.Controls.Add(this.labelEmailAddress);
            this.panelLabels.Controls.Add(this.labelPhoneNumber);
            this.panelLabels.Controls.Add(this.labelRealName);
            this.panelLabels.Controls.Add(this.labelUsername);
            this.panelLabels.Location = new System.Drawing.Point(134, 131);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(140, 328);
            this.panelLabels.TabIndex = 4;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmailAddress.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmailAddress.ForeColor = System.Drawing.Color.White;
            this.labelEmailAddress.Location = new System.Drawing.Point(0, 228);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 45);
            this.labelEmailAddress.Size = new System.Drawing.Size(120, 76);
            this.labelEmailAddress.TabIndex = 7;
            this.labelEmailAddress.Text = "电子邮箱";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPhoneNumber.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.labelPhoneNumber.Location = new System.Drawing.Point(0, 152);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 0, 0, 45);
            this.labelPhoneNumber.Size = new System.Drawing.Size(96, 76);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "手机号";
            // 
            // labelRealName
            // 
            this.labelRealName.AutoSize = true;
            this.labelRealName.BackColor = System.Drawing.Color.Transparent;
            this.labelRealName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRealName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRealName.ForeColor = System.Drawing.Color.White;
            this.labelRealName.Location = new System.Drawing.Point(0, 76);
            this.labelRealName.Name = "labelRealName";
            this.labelRealName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 45);
            this.labelRealName.Size = new System.Drawing.Size(120, 76);
            this.labelRealName.TabIndex = 4;
            this.labelRealName.Text = "真实姓名";
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTextBoxes.Controls.Add(this.textBoxEmailAddress);
            this.panelTextBoxes.Controls.Add(this.textBoxPhoneNumber);
            this.panelTextBoxes.Controls.Add(this.textBoxUsername);
            this.panelTextBoxes.Controls.Add(this.textBoxRealName);
            this.panelTextBoxes.Location = new System.Drawing.Point(280, 128);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(505, 331);
            this.panelTextBoxes.TabIndex = 0;
            // 
            // AccountOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(951, 568);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTextBoxes);
            this.Controls.Add(this.panelLabels);
            this.DoubleBuffered = true;
            this.Name = "AccountOverviewForm";
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.panelTextBoxes.ResumeLayout(false);
            this.panelTextBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxRealName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelRealName;
        private System.Windows.Forms.Panel panelTextBoxes;
    }
}