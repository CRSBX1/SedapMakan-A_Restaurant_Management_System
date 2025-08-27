namespace SedapMakan
{
    partial class RemoveUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUserForm));
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.AccNameTextbox = new System.Windows.Forms.TextBox();
            this.RemoveCancelBtn = new System.Windows.Forms.Button();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.YourPasswordLabel = new System.Windows.Forms.Label();
            this.AccNameEditLabel = new System.Windows.Forms.Label();
            this.RemoveUserLabel = new System.Windows.Forms.Label();
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.SystemHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(410, 454);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(835, 30);
            this.PasswordTextbox.TabIndex = 44;
            // 
            // AccNameTextbox
            // 
            this.AccNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNameTextbox.Location = new System.Drawing.Point(410, 385);
            this.AccNameTextbox.Name = "AccNameTextbox";
            this.AccNameTextbox.Size = new System.Drawing.Size(835, 30);
            this.AccNameTextbox.TabIndex = 43;
            // 
            // RemoveCancelBtn
            // 
            this.RemoveCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCancelBtn.Location = new System.Drawing.Point(700, 539);
            this.RemoveCancelBtn.Name = "RemoveCancelBtn";
            this.RemoveCancelBtn.Size = new System.Drawing.Size(191, 76);
            this.RemoveCancelBtn.TabIndex = 42;
            this.RemoveCancelBtn.Text = "Cancel";
            this.RemoveCancelBtn.UseVisualStyleBackColor = true;
            this.RemoveCancelBtn.Click += new System.EventHandler(this.RemoveCancelBtn_Click);
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUserBtn.Location = new System.Drawing.Point(410, 539);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(191, 76);
            this.RemoveUserBtn.TabIndex = 41;
            this.RemoveUserBtn.Text = "Confirm";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // YourPasswordLabel
            // 
            this.YourPasswordLabel.AutoSize = true;
            this.YourPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourPasswordLabel.Location = new System.Drawing.Point(161, 454);
            this.YourPasswordLabel.Name = "YourPasswordLabel";
            this.YourPasswordLabel.Size = new System.Drawing.Size(183, 29);
            this.YourPasswordLabel.TabIndex = 40;
            this.YourPasswordLabel.Text = "Your Password:";
            // 
            // AccNameEditLabel
            // 
            this.AccNameEditLabel.AutoSize = true;
            this.AccNameEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNameEditLabel.Location = new System.Drawing.Point(161, 381);
            this.AccNameEditLabel.Name = "AccNameEditLabel";
            this.AccNameEditLabel.Size = new System.Drawing.Size(175, 29);
            this.AccNameEditLabel.TabIndex = 39;
            this.AccNameEditLabel.Text = "Account Name:";
            // 
            // RemoveUserLabel
            // 
            this.RemoveUserLabel.AutoSize = true;
            this.RemoveUserLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUserLabel.Location = new System.Drawing.Point(160, 276);
            this.RemoveUserLabel.Name = "RemoveUserLabel";
            this.RemoveUserLabel.Size = new System.Drawing.Size(306, 62);
            this.RemoveUserLabel.TabIndex = 38;
            this.RemoveUserLabel.Text = "Remove User";
            // 
            // SystemHeader
            // 
            this.SystemHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SystemHeader.Controls.Add(this.AccountNameLabel);
            this.SystemHeader.Controls.Add(this.LogoText);
            this.SystemHeader.Location = new System.Drawing.Point(1, 1);
            this.SystemHeader.Name = "SystemHeader";
            this.SystemHeader.Size = new System.Drawing.Size(1416, 100);
            this.SystemHeader.TabIndex = 37;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNameLabel.Location = new System.Drawing.Point(1117, 35);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(256, 37);
            this.AccountNameLabel.TabIndex = 4;
            this.AccountNameLabel.Text = "Antoni Lawrence";
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("Palatino Linotype", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoText.ForeColor = System.Drawing.Color.White;
            this.LogoText.Location = new System.Drawing.Point(23, 9);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(332, 70);
            this.LogoText.TabIndex = 1;
            this.LogoText.Text = "SedapMakan";
            // 
            // RemoveUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.AccNameTextbox);
            this.Controls.Add(this.RemoveCancelBtn);
            this.Controls.Add(this.RemoveUserBtn);
            this.Controls.Add(this.YourPasswordLabel);
            this.Controls.Add(this.AccNameEditLabel);
            this.Controls.Add(this.RemoveUserLabel);
            this.Controls.Add(this.SystemHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveUserForm";
            this.Text = "Remove User";
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox AccNameTextbox;
        private System.Windows.Forms.Button RemoveCancelBtn;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Label YourPasswordLabel;
        private System.Windows.Forms.Label AccNameEditLabel;
        private System.Windows.Forms.Label RemoveUserLabel;
        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Label LogoText;
    }
}