namespace CustomerClient
{
    partial class ResetPasswordForm
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
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
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
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "重置密码";
            // 
            // panelTextBoxes
            // 
            this.panelTextBoxes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTextBoxes.Controls.Add(this.checkBoxShowPassword);
            this.panelTextBoxes.Controls.Add(this.labelTip);
            this.panelTextBoxes.Controls.Add(this.textBoxRepeatPassword);
            this.panelTextBoxes.Controls.Add(this.textBoxNewPassword);
            this.panelTextBoxes.Location = new System.Drawing.Point(279, 186);
            this.panelTextBoxes.Name = "panelTextBoxes";
            this.panelTextBoxes.Size = new System.Drawing.Size(540, 173);
            this.panelTextBoxes.TabIndex = 10;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.White;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(451, 126);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(84, 24);
            this.checkBoxShowPassword.TabIndex = 2;
            this.checkBoxShowPassword.Text = "显示密码";
            this.checkBoxShowPassword.UseVisualStyleBackColor = false;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.BackColor = System.Drawing.Color.Transparent;
            this.labelTip.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTip.ForeColor = System.Drawing.Color.Yellow;
            this.labelTip.Location = new System.Drawing.Point(3, 42);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(532, 14);
            this.labelTip.TabIndex = 13;
            this.labelTip.Text = "*密码由6-16个字符组成，区分大小写，至少包含一个字母、一个数字和一个特殊字符";
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(0, 81);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '●';
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(540, 39);
            this.textBoxRepeatPassword.TabIndex = 1;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPassword.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.textBoxNewPassword.Location = new System.Drawing.Point(0, 0);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '●';
            this.textBoxNewPassword.Size = new System.Drawing.Size(540, 39);
            this.textBoxNewPassword.TabIndex = 0;
            // 
            // panelLabels
            // 
            this.panelLabels.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelLabels.Controls.Add(this.labelRepeatPassword);
            this.panelLabels.Controls.Add(this.labelNewPassword);
            this.panelLabels.Location = new System.Drawing.Point(132, 189);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(141, 170);
            this.panelLabels.TabIndex = 11;
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelRepeatPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRepeatPassword.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRepeatPassword.ForeColor = System.Drawing.Color.White;
            this.labelRepeatPassword.Location = new System.Drawing.Point(0, 81);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 50);
            this.labelRepeatPassword.Size = new System.Drawing.Size(120, 81);
            this.labelRepeatPassword.TabIndex = 5;
            this.labelRepeatPassword.Text = "重复密码";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNewPassword.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelNewPassword.Location = new System.Drawing.Point(0, 0);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 50);
            this.labelNewPassword.Size = new System.Drawing.Size(144, 81);
            this.labelNewPassword.TabIndex = 4;
            this.labelNewPassword.Text = "设置新密码";
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
            this.iconButtonOK.Location = new System.Drawing.Point(433, 428);
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
            // ResetPasswordForm
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
            this.Name = "ResetPasswordForm";
            this.panelTextBoxes.ResumeLayout(false);
            this.panelTextBoxes.PerformLayout();
            this.panelLabels.ResumeLayout(false);
            this.panelLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonOK;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTextBoxes;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
    }
}