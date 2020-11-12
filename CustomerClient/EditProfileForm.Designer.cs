namespace CustomerClient
{
    partial class EditProfileForm
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
            this.panelTextBoxes = new System.Windows.Forms.Panel();
            this.textBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxRealName = new System.Windows.Forms.TextBox();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelEmailAddress = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelRealName = new System.Windows.Forms.Label();
            this.iconButtonOK = new FontAwesome.Sharp.IconButton();
            this.panelTextBoxes.SuspendLayout();
            this.panelLabels.SuspendLayout();
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
            this.labelTitle.Text = "修改信息";
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTextBoxes.Controls.Add(this.textBoxEmailAddress);
            this.panelTextBoxes.Controls.Add(this.textBoxPhoneNumber);
            this.panelTextBoxes.Controls.Add(this.textBoxAddress);
            this.panelTextBoxes.Controls.Add(this.textBoxRealName);
            this.panelTextBoxes.Location = new System.Drawing.Point(280, 128);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(505, 227);
            this.panelTextBoxes.TabIndex = 6;
            // 
            // textBoxEmailAddress
            // 
            this.textBoxEmailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmailAddress.BackColor = System.Drawing.Color.White;
            this.textBoxEmailAddress.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxEmailAddress.Location = new System.Drawing.Point(2, 171);
            this.textBoxEmailAddress.Name = "textBoxEmailAddress";
            this.textBoxEmailAddress.Size = new System.Drawing.Size(503, 39);
            this.textBoxEmailAddress.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.White;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(2, 115);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(503, 39);
            this.textBoxPhoneNumber.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.BackColor = System.Drawing.Color.White;
            this.textBoxAddress.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxAddress.Location = new System.Drawing.Point(0, 59);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(505, 39);
            this.textBoxAddress.TabIndex = 1;
            // 
            // textBoxRealName
            // 
            this.textBoxRealName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRealName.BackColor = System.Drawing.Color.White;
            this.textBoxRealName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRealName.Location = new System.Drawing.Point(0, 3);
            this.textBoxRealName.Name = "textBoxRealName";
            this.textBoxRealName.Size = new System.Drawing.Size(505, 39);
            this.textBoxRealName.TabIndex = 0;
            // 
            // panelLabels
            // 
            this.panelLabels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLabels.Controls.Add(this.labelEmailAddress);
            this.panelLabels.Controls.Add(this.labelPhoneNumber);
            this.panelLabels.Controls.Add(this.labelAddress);
            this.panelLabels.Controls.Add(this.labelRealName);
            this.panelLabels.Location = new System.Drawing.Point(134, 131);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(140, 224);
            this.panelLabels.TabIndex = 7;
            // 
            // labelEmailAddress
            // 
            this.labelEmailAddress.AutoSize = true;
            this.labelEmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelEmailAddress.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEmailAddress.ForeColor = System.Drawing.Color.White;
            this.labelEmailAddress.Location = new System.Drawing.Point(0, 168);
            this.labelEmailAddress.Name = "labelEmailAddress";
            this.labelEmailAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 25);
            this.labelEmailAddress.Size = new System.Drawing.Size(120, 56);
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
            this.labelPhoneNumber.Location = new System.Drawing.Point(0, 112);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 0, 0, 25);
            this.labelPhoneNumber.Size = new System.Drawing.Size(96, 56);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "手机号";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAddress.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(0, 56);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Padding = new System.Windows.Forms.Padding(10, 0, 0, 25);
            this.labelAddress.Size = new System.Drawing.Size(72, 56);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "住址";
            // 
            // labelRealName
            // 
            this.labelRealName.AutoSize = true;
            this.labelRealName.BackColor = System.Drawing.Color.Transparent;
            this.labelRealName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRealName.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRealName.ForeColor = System.Drawing.Color.White;
            this.labelRealName.Location = new System.Drawing.Point(0, 0);
            this.labelRealName.Name = "labelRealName";
            this.labelRealName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 25);
            this.labelRealName.Size = new System.Drawing.Size(120, 56);
            this.labelRealName.TabIndex = 4;
            this.labelRealName.Text = "真实姓名";
            // 
            // iconButtonOK
            // 
            this.iconButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButtonOK.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButtonOK.FlatAppearance.BorderSize = 0;
            this.iconButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOK.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOK.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iconButtonOK.ForeColor = System.Drawing.Color.White;
            this.iconButtonOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonOK.IconColor = System.Drawing.Color.White;
            this.iconButtonOK.IconSize = 32;
            this.iconButtonOK.Location = new System.Drawing.Point(407, 399);
            this.iconButtonOK.Name = "iconButtonOK";
            this.iconButtonOK.Rotation = 0D;
            this.iconButtonOK.Size = new System.Drawing.Size(97, 46);
            this.iconButtonOK.TabIndex = 0;
            this.iconButtonOK.Text = "确认";
            this.iconButtonOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOK.UseVisualStyleBackColor = false;
            this.iconButtonOK.Click += new System.EventHandler(this.iconButtonOK_Click);
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(951, 568);
            this.Controls.Add(this.iconButtonOK);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelTextBoxes);
            this.Controls.Add(this.panelLabels);
            this.DoubleBuffered = true;
            this.Name = "EditProfileForm";
            this.panelTextBoxes.ResumeLayout(false);
            this.panelTextBoxes.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTextBoxes;
        private System.Windows.Forms.TextBox textBoxEmailAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxRealName;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label labelEmailAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelRealName;
        private FontAwesome.Sharp.IconButton iconButtonOK;
    }
}