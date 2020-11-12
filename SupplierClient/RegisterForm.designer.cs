namespace SupplierClient
{
    partial class RegisterForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxRealName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRealName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.panelBackgroud = new System.Windows.Forms.Panel();
            this.labelTipForEmailAddress = new System.Windows.Forms.Label();
            this.labelTipForPhoneNumber = new System.Windows.Forms.Label();
            this.labelTipForPassword = new System.Windows.Forms.Label();
            this.labelTipForRealName = new System.Windows.Forms.Label();
            this.labelTipForUsername = new System.Windows.Forms.Label();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBackgroud.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SupplierClient.Properties.Resources.RegisterFormImage1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(416, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 313);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxRealName
            // 
            this.textBoxRealName.Font = new System.Drawing.Font("宋体", 15F);
            this.textBoxRealName.Location = new System.Drawing.Point(159, 152);
            this.textBoxRealName.Name = "textBoxRealName";
            this.textBoxRealName.Size = new System.Drawing.Size(195, 30);
            this.textBoxRealName.TabIndex = 1;
            this.textBoxRealName.TextChanged += new System.EventHandler(this.textBoxRealName_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("宋体", 15F);
            this.textBoxPassword.Location = new System.Drawing.Point(159, 222);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(195, 30);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("宋体", 15F);
            this.textBoxUsername.Location = new System.Drawing.Point(159, 82);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(195, 30);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::SupplierClient.Properties.Resources.ZoomIn;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.Location = new System.Drawing.Point(539, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(65, 65);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUsername.Location = new System.Drawing.Point(56, 81);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(72, 27);
            this.labelUsername.TabIndex = 20;
            this.labelUsername.Text = "用户名";
            // 
            // labelRealName
            // 
            this.labelRealName.AutoSize = true;
            this.labelRealName.BackColor = System.Drawing.Color.Transparent;
            this.labelRealName.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelRealName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRealName.Location = new System.Drawing.Point(36, 151);
            this.labelRealName.Name = "labelRealName";
            this.labelRealName.Size = new System.Drawing.Size(92, 27);
            this.labelRealName.TabIndex = 21;
            this.labelRealName.Text = "真实姓名";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPassword.Location = new System.Drawing.Point(76, 221);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(52, 27);
            this.labelPassword.TabIndex = 21;
            this.labelPassword.Text = "密码";
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailAddress.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelEmailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelEmailAddress.Location = new System.Drawing.Point(36, 381);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Size = new System.Drawing.Size(92, 27);
            this.labelEmailAddress.TabIndex = 21;
            this.labelEmailAddress.Text = "电子邮箱";
            // 
            // panelBackgroud
            // 
            this.panelBackgroud.BackColor = System.Drawing.Color.White;
            this.panelBackgroud.Controls.Add(this.labelTipForEmailAddress);
            this.panelBackgroud.Controls.Add(this.labelTipForPhoneNumber);
            this.panelBackgroud.Controls.Add(this.labelTipForPassword);
            this.panelBackgroud.Controls.Add(this.labelTipForRealName);
            this.panelBackgroud.Controls.Add(this.labelTipForUsername);
            this.panelBackgroud.Controls.Add(this.textBoxEmailAddress);
            this.panelBackgroud.Controls.Add(this.labelTip);
            this.panelBackgroud.Controls.Add(this.labelUsername);
            this.panelBackgroud.Controls.Add(this.labelPhoneNumber);
            this.panelBackgroud.Controls.Add(this.labelPassword);
            this.panelBackgroud.Controls.Add(this.textBoxUsername);
            this.panelBackgroud.Controls.Add(this.textBoxRealName);
            this.panelBackgroud.Controls.Add(this.textBoxPhoneNumber);
            this.panelBackgroud.Controls.Add(this.labelEmailAddress);
            this.panelBackgroud.Controls.Add(this.textBoxPassword);
            this.panelBackgroud.Controls.Add(this.labelRealName);
            this.panelBackgroud.Location = new System.Drawing.Point(23, 65);
            this.panelBackgroud.Name = "panelBackgroud";
            this.panelBackgroud.Size = new System.Drawing.Size(387, 484);
            this.panelBackgroud.TabIndex = 0;
            // 
            // labelTipForEmailAddress
            // 
            this.labelTipForEmailAddress.AutoSize = true;
            this.labelTipForEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelTipForEmailAddress.ForeColor = System.Drawing.Color.Red;
            this.labelTipForEmailAddress.Location = new System.Drawing.Point(157, 414);
            this.labelTipForEmailAddress.Name = "labelTipForEmailAddress";
            this.labelTipForEmailAddress.Size = new System.Drawing.Size(0, 12);
            this.labelTipForEmailAddress.TabIndex = 26;
            // 
            // labelTipForPhoneNumber
            // 
            this.labelTipForPhoneNumber.AutoSize = true;
            this.labelTipForPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelTipForPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.labelTipForPhoneNumber.Location = new System.Drawing.Point(157, 345);
            this.labelTipForPhoneNumber.Name = "labelTipForPhoneNumber";
            this.labelTipForPhoneNumber.Size = new System.Drawing.Size(0, 12);
            this.labelTipForPhoneNumber.TabIndex = 25;
            // 
            // labelTipForPassword
            // 
            this.labelTipForPassword.AutoSize = true;
            this.labelTipForPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelTipForPassword.ForeColor = System.Drawing.Color.Red;
            this.labelTipForPassword.Location = new System.Drawing.Point(157, 255);
            this.labelTipForPassword.Name = "labelTipForPassword";
            this.labelTipForPassword.Size = new System.Drawing.Size(0, 12);
            this.labelTipForPassword.TabIndex = 25;
            // 
            // labelTipForRealName
            // 
            this.labelTipForRealName.AutoSize = true;
            this.labelTipForRealName.BackColor = System.Drawing.Color.Transparent;
            this.labelTipForRealName.ForeColor = System.Drawing.Color.Red;
            this.labelTipForRealName.Location = new System.Drawing.Point(157, 185);
            this.labelTipForRealName.Name = "labelTipForRealName";
            this.labelTipForRealName.Size = new System.Drawing.Size(0, 12);
            this.labelTipForRealName.TabIndex = 24;
            // 
            // labelTipForUsername
            // 
            this.labelTipForUsername.AutoSize = true;
            this.labelTipForUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelTipForUsername.ForeColor = System.Drawing.Color.Red;
            this.labelTipForUsername.Location = new System.Drawing.Point(157, 115);
            this.labelTipForUsername.Name = "labelTipForUsername";
            this.labelTipForUsername.Size = new System.Drawing.Size(0, 12);
            this.labelTipForUsername.TabIndex = 23;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Font = new System.Drawing.Font("宋体", 15F);
            this.textBoxEmailAddress.Location = new System.Drawing.Point(159, 382);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(195, 30);
            this.textBoxEmailAddress.TabIndex = 5;
            this.textBoxEmailAddress.TextChanged += new System.EventHandler(this.textBoxEmailAddress_TextChanged);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.BackColor = System.Drawing.Color.Transparent;
            this.labelTip.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTip.Location = new System.Drawing.Point(137, 16);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(123, 36);
            this.labelTip.TabIndex = 20;
            this.labelTip.Text = "用户注册";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPhoneNumber.Location = new System.Drawing.Point(56, 311);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(72, 27);
            this.labelPhoneNumber.TabIndex = 21;
            this.labelPhoneNumber.Text = "手机号";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("宋体", 15F);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(159, 312);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(195, 30);
            this.textBoxPhoneNumber.TabIndex = 4;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.BackgroundImage = global::SupplierClient.Properties.Resources.ButtonBackgroundImage;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(166, 586);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(108, 44);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "注册";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.buttonRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SupplierClient.Properties.Resources.RegisterFormBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 661);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelBackgroud);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBackgroud.ResumeLayout(false);
            this.panelBackgroud.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxRealName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRealName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Panel panelBackgroud;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.Label labelTipForEmailAddress;
        private System.Windows.Forms.Label labelTipForPassword;
        private System.Windows.Forms.Label labelTipForRealName;
        private System.Windows.Forms.Label labelTipForUsername;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelTipForPhoneNumber;
    }
}