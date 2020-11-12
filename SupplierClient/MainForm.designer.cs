namespace SupplierClient
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButtonLogout = new FontAwesome.Sharp.IconButton();
            this.buttonMinimize = new FontAwesome.Sharp.IconButton();
            this.buttonMaximize = new FontAwesome.Sharp.IconButton();
            this.buttonExit = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.buttonResetPassword = new FontAwesome.Sharp.IconButton();
            this.buttonEditProfile = new FontAwesome.Sharp.IconButton();
            this.buttonOrders = new FontAwesome.Sharp.IconButton();
            this.buttonSupply = new FontAwesome.Sharp.IconButton();
            this.buttonAccountOverview = new FontAwesome.Sharp.IconButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelMenu.Controls.Add(this.buttonResetPassword);
            this.panelMenu.Controls.Add(this.buttonEditProfile);
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.buttonSupply);
            this.panelMenu.Controls.Add(this.buttonAccountOverview);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(233, 700);
            this.panelMenu.TabIndex = 16;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 127);
            this.panelLogo.TabIndex = 21;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.iconButtonLogout);
            this.panelTitleBar.Controls.Add(this.buttonMinimize);
            this.panelTitleBar.Controls.Add(this.buttonMaximize);
            this.panelTitleBar.Controls.Add(this.buttonExit);
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelTitleBar.Location = new System.Drawing.Point(233, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(967, 93);
            this.panelTitleBar.TabIndex = 17;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleChildForm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.labelTitleChildForm.Location = new System.Drawing.Point(62, 46);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(62, 31);
            this.labelTitleChildForm.TabIndex = 6;
            this.labelTitleChildForm.Text = "主页";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelDesktop.Location = new System.Drawing.Point(233, 93);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(967, 607);
            this.panelDesktop.TabIndex = 18;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonLogout
            // 
            this.iconButtonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLogout.FlatAppearance.BorderSize = 0;
            this.iconButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonLogout.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonLogout.ForeColor = System.Drawing.Color.White;
            this.iconButtonLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonLogout.IconColor = System.Drawing.Color.Lime;
            this.iconButtonLogout.IconSize = 46;
            this.iconButtonLogout.Location = new System.Drawing.Point(824, 32);
            this.iconButtonLogout.Name = "iconButtonLogout";
            this.iconButtonLogout.Rotation = 0D;
            this.iconButtonLogout.Size = new System.Drawing.Size(143, 46);
            this.iconButtonLogout.TabIndex = 8;
            this.iconButtonLogout.Text = "退出登录";
            this.iconButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogout.UseVisualStyleBackColor = true;
            this.iconButtonLogout.Click += new System.EventHandler(this.iconButtonLogout_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMinimize.IconColor = System.Drawing.Color.LightGray;
            this.buttonMinimize.IconSize = 20;
            this.buttonMinimize.Location = new System.Drawing.Point(895, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Rotation = 0D;
            this.buttonMinimize.Size = new System.Drawing.Size(20, 20);
            this.buttonMinimize.TabIndex = 7;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.buttonMaximize.IconColor = System.Drawing.Color.LightGray;
            this.buttonMaximize.IconSize = 20;
            this.buttonMaximize.Location = new System.Drawing.Point(921, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Rotation = 0D;
            this.buttonMaximize.Size = new System.Drawing.Size(20, 20);
            this.buttonMaximize.TabIndex = 7;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
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
            this.buttonExit.Location = new System.Drawing.Point(947, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Rotation = 0D;
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.iconCurrentChildForm.IconSize = 31;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(25, 47);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(31, 31);
            this.iconCurrentChildForm.TabIndex = 5;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonResetPassword.FlatAppearance.BorderSize = 0;
            this.buttonResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPassword.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonResetPassword.Font = new System.Drawing.Font("微软雅黑", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonResetPassword.ForeColor = System.Drawing.Color.White;
            this.buttonResetPassword.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.buttonResetPassword.IconColor = System.Drawing.Color.White;
            this.buttonResetPassword.IconSize = 39;
            this.buttonResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResetPassword.Location = new System.Drawing.Point(0, 407);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Padding = new System.Windows.Forms.Padding(10, 0, 8, 0);
            this.buttonResetPassword.Rotation = 0D;
            this.buttonResetPassword.Size = new System.Drawing.Size(233, 70);
            this.buttonResetPassword.TabIndex = 20;
            this.buttonResetPassword.Text = "重置密码";
            this.buttonResetPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditProfile.FlatAppearance.BorderSize = 0;
            this.buttonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProfile.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonEditProfile.Font = new System.Drawing.Font("微软雅黑", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonEditProfile.ForeColor = System.Drawing.Color.White;
            this.buttonEditProfile.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.buttonEditProfile.IconColor = System.Drawing.Color.White;
            this.buttonEditProfile.IconSize = 39;
            this.buttonEditProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditProfile.Location = new System.Drawing.Point(0, 337);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Padding = new System.Windows.Forms.Padding(10, 0, 8, 0);
            this.buttonEditProfile.Rotation = 0D;
            this.buttonEditProfile.Size = new System.Drawing.Size(233, 70);
            this.buttonEditProfile.TabIndex = 19;
            this.buttonEditProfile.Text = "修改信息";
            this.buttonEditProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditProfile.UseVisualStyleBackColor = true;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonOrders.Font = new System.Drawing.Font("微软雅黑", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.buttonOrders.IconColor = System.Drawing.Color.White;
            this.buttonOrders.IconSize = 39;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(0, 267);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Padding = new System.Windows.Forms.Padding(10, 0, 8, 0);
            this.buttonOrders.Rotation = 0D;
            this.buttonOrders.Size = new System.Drawing.Size(233, 70);
            this.buttonOrders.TabIndex = 16;
            this.buttonOrders.Text = "我的发货单";
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonSupply
            // 
            this.buttonSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSupply.FlatAppearance.BorderSize = 0;
            this.buttonSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupply.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonSupply.Font = new System.Drawing.Font("微软雅黑", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSupply.ForeColor = System.Drawing.Color.White;
            this.buttonSupply.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.buttonSupply.IconColor = System.Drawing.Color.White;
            this.buttonSupply.IconSize = 39;
            this.buttonSupply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupply.Location = new System.Drawing.Point(0, 197);
            this.buttonSupply.Name = "buttonSupply";
            this.buttonSupply.Padding = new System.Windows.Forms.Padding(10, 0, 8, 0);
            this.buttonSupply.Rotation = 0D;
            this.buttonSupply.Size = new System.Drawing.Size(233, 70);
            this.buttonSupply.TabIndex = 14;
            this.buttonSupply.Text = "我要发货";
            this.buttonSupply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSupply.UseVisualStyleBackColor = true;
            this.buttonSupply.Click += new System.EventHandler(this.buttonSupply_Click);
            // 
            // buttonAccountOverview
            // 
            this.buttonAccountOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccountOverview.FlatAppearance.BorderSize = 0;
            this.buttonAccountOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccountOverview.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAccountOverview.Font = new System.Drawing.Font("微软雅黑", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAccountOverview.ForeColor = System.Drawing.Color.White;
            this.buttonAccountOverview.IconChar = FontAwesome.Sharp.IconChar.User;
            this.buttonAccountOverview.IconColor = System.Drawing.Color.White;
            this.buttonAccountOverview.IconSize = 39;
            this.buttonAccountOverview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccountOverview.Location = new System.Drawing.Point(0, 127);
            this.buttonAccountOverview.Name = "buttonAccountOverview";
            this.buttonAccountOverview.Padding = new System.Windows.Forms.Padding(10, 0, 8, 0);
            this.buttonAccountOverview.Rotation = 0D;
            this.buttonAccountOverview.Size = new System.Drawing.Size(233, 70);
            this.buttonAccountOverview.TabIndex = 13;
            this.buttonAccountOverview.Text = "账户信息";
            this.buttonAccountOverview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccountOverview.UseVisualStyleBackColor = true;
            this.buttonAccountOverview.Click += new System.EventHandler(this.buttonAccountOverview_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::SupplierClient.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogo.Location = new System.Drawing.Point(6, 8);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(224, 113);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1216, 716);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private FontAwesome.Sharp.IconButton buttonMaximize;
        private FontAwesome.Sharp.IconButton buttonExit;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton buttonResetPassword;
        private FontAwesome.Sharp.IconButton buttonEditProfile;
        private FontAwesome.Sharp.IconButton buttonOrders;
        private FontAwesome.Sharp.IconButton buttonSupply;
        private FontAwesome.Sharp.IconButton buttonAccountOverview;
        private FontAwesome.Sharp.IconButton iconButtonLogout;
    }
}