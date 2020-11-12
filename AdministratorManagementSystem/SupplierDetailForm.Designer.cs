namespace AdministratorManagementSystem
{
    partial class SupplierDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierDetailForm));
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPasswordHash = new System.Windows.Forms.TextBox();
            this.textBoxRealName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelPasswordHash = new System.Windows.Forms.Label();
            this.labelRealName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailAddress.Location = new System.Drawing.Point(162, 353);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.ReadOnly = true;
            this.textBoxEmailAddress.Size = new System.Drawing.Size(152, 21);
            this.textBoxEmailAddress.TabIndex = 22;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(162, 313);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(152, 21);
            this.textBoxPhoneNumber.TabIndex = 21;
            // 
            // textBoxPasswordHash
            // 
            this.textBoxPasswordHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPasswordHash.Location = new System.Drawing.Point(162, 273);
            this.textBoxPasswordHash.Name = "textBoxPasswordHash";
            this.textBoxPasswordHash.ReadOnly = true;
            this.textBoxPasswordHash.Size = new System.Drawing.Size(152, 21);
            this.textBoxPasswordHash.TabIndex = 19;
            // 
            // textBoxRealName
            // 
            this.textBoxRealName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRealName.Location = new System.Drawing.Point(162, 233);
            this.textBoxRealName.Name = "textBoxRealName";
            this.textBoxRealName.ReadOnly = true;
            this.textBoxRealName.Size = new System.Drawing.Size(152, 21);
            this.textBoxRealName.TabIndex = 18;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Location = new System.Drawing.Point(162, 193);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(152, 21);
            this.textBoxUsername.TabIndex = 17;
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Location = new System.Drawing.Point(162, 153);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(152, 21);
            this.textBoxId.TabIndex = 8;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmailAddress.Location = new System.Drawing.Point(83, 356);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(64, 16);
            this.labelEmailAddress.TabIndex = 10;
            this.labelEmailAddress.Text = "电子邮箱";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(83, 316);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(50, 16);
            this.labelPhoneNumber.TabIndex = 11;
            this.labelPhoneNumber.Text = "手机号";
            // 
            // labelPasswordHash
            // 
            this.labelPasswordHash.AutoSize = true;
            this.labelPasswordHash.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPasswordHash.Location = new System.Drawing.Point(83, 276);
            this.labelPasswordHash.Name = "labelPasswordHash";
            this.labelPasswordHash.Size = new System.Drawing.Size(78, 16);
            this.labelPasswordHash.TabIndex = 13;
            this.labelPasswordHash.Text = "密码哈希值";
            // 
            // labelRealName
            // 
            this.labelRealName.AutoSize = true;
            this.labelRealName.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRealName.Location = new System.Drawing.Point(83, 236);
            this.labelRealName.Name = "labelRealName";
            this.labelRealName.Size = new System.Drawing.Size(64, 16);
            this.labelRealName.TabIndex = 14;
            this.labelRealName.Text = "真实姓名";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUsername.Location = new System.Drawing.Point(83, 196);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(50, 16);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "用户名";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelId.Location = new System.Drawing.Point(83, 156);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(24, 16);
            this.labelId.TabIndex = 16;
            this.labelId.Text = "ID";
            // 
            // SupplierDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources._1344;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 506);
            this.Controls.Add(this.textBoxEmailAddress);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxPasswordHash);
            this.Controls.Add(this.textBoxRealName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelEmailAddress);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelPasswordHash);
            this.Controls.Add(this.labelRealName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelId);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierDetailForm";
            this.Text = "供货商信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPasswordHash;
        private System.Windows.Forms.TextBox textBoxRealName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelPasswordHash;
        private System.Windows.Forms.Label labelRealName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelId;
    }
}