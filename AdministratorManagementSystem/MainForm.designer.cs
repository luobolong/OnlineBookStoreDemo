namespace AdministratorManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCustomerOrderManagement = new System.Windows.Forms.Button();
            this.buttonBookManagement = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCustomerInformation = new System.Windows.Forms.Button();
            this.buttonSupplierInformation = new System.Windows.Forms.Button();
            this.buttonSupplierOrderManagement = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCustomerOrderManagement
            // 
            this.buttonCustomerOrderManagement.BackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerOrderManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCustomerOrderManagement.BackgroundImage")));
            this.buttonCustomerOrderManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCustomerOrderManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerOrderManagement.FlatAppearance.BorderSize = 0;
            this.buttonCustomerOrderManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerOrderManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerOrderManagement.Font = new System.Drawing.Font("华文楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCustomerOrderManagement.ForeColor = System.Drawing.Color.Black;
            this.buttonCustomerOrderManagement.Location = new System.Drawing.Point(3, 310);
            this.buttonCustomerOrderManagement.Name = "buttonCustomerOrderManagement";
            this.buttonCustomerOrderManagement.Size = new System.Drawing.Size(218, 62);
            this.buttonCustomerOrderManagement.TabIndex = 0;
            this.buttonCustomerOrderManagement.Text = "用户订单";
            this.buttonCustomerOrderManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonCustomerOrderManagement.UseVisualStyleBackColor = false;
            this.buttonCustomerOrderManagement.Click += new System.EventHandler(this.buttonCustomerOrderManagement_Click);
            // 
            // buttonBookManagement
            // 
            this.buttonBookManagement.BackColor = System.Drawing.Color.Transparent;
            this.buttonBookManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBookManagement.BackgroundImage")));
            this.buttonBookManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBookManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBookManagement.FlatAppearance.BorderSize = 0;
            this.buttonBookManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBookManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBookManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBookManagement.Font = new System.Drawing.Font("华文楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBookManagement.ForeColor = System.Drawing.Color.Black;
            this.buttonBookManagement.Location = new System.Drawing.Point(3, 10);
            this.buttonBookManagement.Name = "buttonBookManagement";
            this.buttonBookManagement.Size = new System.Drawing.Size(218, 65);
            this.buttonBookManagement.TabIndex = 1;
            this.buttonBookManagement.Text = "图书管理";
            this.buttonBookManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonBookManagement.UseVisualStyleBackColor = false;
            this.buttonBookManagement.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.BackButtonImage;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(1164, 725);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(72, 80);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(370, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(592, 75);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "网上图书销售管理系统";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.logo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(274, 9);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(90, 84);
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.CloseButtonImage;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(1171, 9);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(65, 65);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCustomerInformation
            // 
            this.buttonCustomerInformation.BackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCustomerInformation.BackgroundImage")));
            this.buttonCustomerInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCustomerInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustomerInformation.FlatAppearance.BorderSize = 0;
            this.buttonCustomerInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCustomerInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerInformation.Font = new System.Drawing.Font("华文楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCustomerInformation.ForeColor = System.Drawing.Color.Black;
            this.buttonCustomerInformation.Location = new System.Drawing.Point(3, 110);
            this.buttonCustomerInformation.Name = "buttonCustomerInformation";
            this.buttonCustomerInformation.Size = new System.Drawing.Size(218, 62);
            this.buttonCustomerInformation.TabIndex = 11;
            this.buttonCustomerInformation.Text = "用户信息";
            this.buttonCustomerInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonCustomerInformation.UseVisualStyleBackColor = false;
            this.buttonCustomerInformation.Click += new System.EventHandler(this.buttonCustomerInformation_Click);
            // 
            // buttonSupplierInformation
            // 
            this.buttonSupplierInformation.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupplierInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSupplierInformation.BackgroundImage")));
            this.buttonSupplierInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSupplierInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupplierInformation.FlatAppearance.BorderSize = 0;
            this.buttonSupplierInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSupplierInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSupplierInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplierInformation.Font = new System.Drawing.Font("华文楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSupplierInformation.ForeColor = System.Drawing.Color.Black;
            this.buttonSupplierInformation.Location = new System.Drawing.Point(3, 210);
            this.buttonSupplierInformation.Name = "buttonSupplierInformation";
            this.buttonSupplierInformation.Size = new System.Drawing.Size(218, 62);
            this.buttonSupplierInformation.TabIndex = 12;
            this.buttonSupplierInformation.Text = "供货商信息";
            this.buttonSupplierInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonSupplierInformation.UseVisualStyleBackColor = false;
            this.buttonSupplierInformation.Click += new System.EventHandler(this.buttonSupplierInformation_Click);
            // 
            // buttonSupplierOrderManagement
            // 
            this.buttonSupplierOrderManagement.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupplierOrderManagement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSupplierOrderManagement.BackgroundImage")));
            this.buttonSupplierOrderManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSupplierOrderManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupplierOrderManagement.FlatAppearance.BorderSize = 0;
            this.buttonSupplierOrderManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSupplierOrderManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSupplierOrderManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupplierOrderManagement.Font = new System.Drawing.Font("华文楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSupplierOrderManagement.ForeColor = System.Drawing.Color.Black;
            this.buttonSupplierOrderManagement.Location = new System.Drawing.Point(3, 410);
            this.buttonSupplierOrderManagement.Name = "buttonSupplierOrderManagement";
            this.buttonSupplierOrderManagement.Size = new System.Drawing.Size(224, 62);
            this.buttonSupplierOrderManagement.TabIndex = 0;
            this.buttonSupplierOrderManagement.Text = "供应商发货单";
            this.buttonSupplierOrderManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonSupplierOrderManagement.UseVisualStyleBackColor = false;
            this.buttonSupplierOrderManagement.Click += new System.EventHandler(this.buttonSupplierOrderManagement_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.buttonSupplierOrderManagement);
            this.panel1.Controls.Add(this.buttonSupplierInformation);
            this.panel1.Controls.Add(this.buttonCustomerOrderManagement);
            this.panel1.Controls.Add(this.buttonCustomerInformation);
            this.panel1.Controls.Add(this.buttonBookManagement);
            this.panel1.Location = new System.Drawing.Point(951, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 500);
            this.panel1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::AdministratorManagementSystem.Properties.Resources.反面1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 808);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBack);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomerOrderManagement;
        private System.Windows.Forms.Button buttonBookManagement;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCustomerInformation;
        private System.Windows.Forms.Button buttonSupplierInformation;
        private System.Windows.Forms.Button buttonSupplierOrderManagement;
        private System.Windows.Forms.Panel panel1;
    }
}