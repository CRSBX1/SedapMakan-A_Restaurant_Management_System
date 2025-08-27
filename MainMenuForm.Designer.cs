namespace SedapMakan
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.SalesShortcut = new System.Windows.Forms.Button();
            this.WalletReportShortcut = new System.Windows.Forms.Button();
            this.EditUserShortcut = new System.Windows.Forms.Button();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.EditUserFormLabel = new System.Windows.Forms.Label();
            this.EwalletFormLabel = new System.Windows.Forms.Label();
            this.SalesFormLabel = new System.Windows.Forms.Label();
            this.LogOutFormLabel = new System.Windows.Forms.Label();
            this.EditUserFormBtn = new System.Windows.Forms.Button();
            this.WalletFormBtn = new System.Windows.Forms.Button();
            this.SalesFormBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.SystemHeader.SuspendLayout();
            this.DropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemHeader
            // 
            this.SystemHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SystemHeader.Controls.Add(this.AccountNameLabel);
            this.SystemHeader.Controls.Add(this.LogoText);
            this.SystemHeader.Location = new System.Drawing.Point(1, 0);
            this.SystemHeader.Name = "SystemHeader";
            this.SystemHeader.Size = new System.Drawing.Size(1416, 100);
            this.SystemHeader.TabIndex = 0;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNameLabel.Location = new System.Drawing.Point(1117, 35);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(0, 37);
            this.AccountNameLabel.TabIndex = 4;
            this.AccountNameLabel.Click += new System.EventHandler(this.AccountNameLabel_Click);
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
            // DropDownMenu
            // 
            this.DropDownMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DropDownMenu.Controls.Add(this.LogOutShortcut);
            this.DropDownMenu.Controls.Add(this.OwnAccountShortcut);
            this.DropDownMenu.Controls.Add(this.SalesShortcut);
            this.DropDownMenu.Controls.Add(this.WalletReportShortcut);
            this.DropDownMenu.Controls.Add(this.EditUserShortcut);
            this.DropDownMenu.Location = new System.Drawing.Point(1110, 100);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(307, 336);
            this.DropDownMenu.TabIndex = 1;
            this.DropDownMenu.Visible = false;
            // 
            // LogOutShortcut
            // 
            this.LogOutShortcut.BackColor = System.Drawing.Color.Transparent;
            this.LogOutShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogOutShortcut.FlatAppearance.BorderSize = 0;
            this.LogOutShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.LogOutShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutShortcut.ForeColor = System.Drawing.Color.White;
            this.LogOutShortcut.Location = new System.Drawing.Point(0, 268);
            this.LogOutShortcut.Name = "LogOutShortcut";
            this.LogOutShortcut.Size = new System.Drawing.Size(307, 67);
            this.LogOutShortcut.TabIndex = 7;
            this.LogOutShortcut.Text = "Log Out";
            this.LogOutShortcut.UseVisualStyleBackColor = false;
            this.LogOutShortcut.Click += new System.EventHandler(this.LogOutShortcut_Click);
            // 
            // OwnAccountShortcut
            // 
            this.OwnAccountShortcut.BackColor = System.Drawing.Color.Transparent;
            this.OwnAccountShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.OwnAccountShortcut.FlatAppearance.BorderSize = 0;
            this.OwnAccountShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.OwnAccountShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OwnAccountShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnAccountShortcut.ForeColor = System.Drawing.Color.White;
            this.OwnAccountShortcut.Location = new System.Drawing.Point(0, 201);
            this.OwnAccountShortcut.Name = "OwnAccountShortcut";
            this.OwnAccountShortcut.Size = new System.Drawing.Size(307, 67);
            this.OwnAccountShortcut.TabIndex = 6;
            this.OwnAccountShortcut.Text = "Edit Own Account";
            this.OwnAccountShortcut.UseVisualStyleBackColor = false;
            this.OwnAccountShortcut.Click += new System.EventHandler(this.OwnAccountShortcut_Click);
            // 
            // SalesShortcut
            // 
            this.SalesShortcut.BackColor = System.Drawing.Color.Transparent;
            this.SalesShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SalesShortcut.FlatAppearance.BorderSize = 0;
            this.SalesShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.SalesShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesShortcut.ForeColor = System.Drawing.Color.White;
            this.SalesShortcut.Location = new System.Drawing.Point(0, 134);
            this.SalesShortcut.Name = "SalesShortcut";
            this.SalesShortcut.Size = new System.Drawing.Size(307, 67);
            this.SalesShortcut.TabIndex = 5;
            this.SalesShortcut.Text = "View Sales Report";
            this.SalesShortcut.UseVisualStyleBackColor = false;
            this.SalesShortcut.Click += new System.EventHandler(this.SalesShortcut_Click);
            // 
            // WalletReportShortcut
            // 
            this.WalletReportShortcut.BackColor = System.Drawing.Color.Transparent;
            this.WalletReportShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.WalletReportShortcut.FlatAppearance.BorderSize = 0;
            this.WalletReportShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.WalletReportShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WalletReportShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletReportShortcut.ForeColor = System.Drawing.Color.White;
            this.WalletReportShortcut.Location = new System.Drawing.Point(0, 67);
            this.WalletReportShortcut.Name = "WalletReportShortcut";
            this.WalletReportShortcut.Size = new System.Drawing.Size(307, 67);
            this.WalletReportShortcut.TabIndex = 4;
            this.WalletReportShortcut.Text = "View E-wallet Report";
            this.WalletReportShortcut.UseVisualStyleBackColor = false;
            this.WalletReportShortcut.Click += new System.EventHandler(this.WalletReportShortcut_Click);
            // 
            // EditUserShortcut
            // 
            this.EditUserShortcut.BackColor = System.Drawing.Color.Transparent;
            this.EditUserShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EditUserShortcut.FlatAppearance.BorderSize = 0;
            this.EditUserShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.EditUserShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserShortcut.ForeColor = System.Drawing.Color.White;
            this.EditUserShortcut.Location = new System.Drawing.Point(0, 0);
            this.EditUserShortcut.Name = "EditUserShortcut";
            this.EditUserShortcut.Size = new System.Drawing.Size(307, 67);
            this.EditUserShortcut.TabIndex = 3;
            this.EditUserShortcut.Text = "Edit User Accounts";
            this.EditUserShortcut.UseVisualStyleBackColor = false;
            this.EditUserShortcut.Click += new System.EventHandler(this.EditUserShortcut_Click);
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.BackColor = System.Drawing.Color.Transparent;
            this.GreetingLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel.Location = new System.Drawing.Point(274, 155);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(451, 71);
            this.GreetingLabel.TabIndex = 2;
            this.GreetingLabel.Text = "Welcome, Admin";
            this.GreetingLabel.Click += new System.EventHandler(this.GreetingLabel_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(456, 248);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(515, 40);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "What do you want to do for today?";
            // 
            // EditUserFormLabel
            // 
            this.EditUserFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditUserFormLabel.AutoSize = true;
            this.EditUserFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.EditUserFormLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserFormLabel.Location = new System.Drawing.Point(142, 371);
            this.EditUserFormLabel.Name = "EditUserFormLabel";
            this.EditUserFormLabel.Size = new System.Drawing.Size(423, 40);
            this.EditUserFormLabel.TabIndex = 5;
            this.EditUserFormLabel.Text = "View and Edit User Accounts";
            // 
            // EwalletFormLabel
            // 
            this.EwalletFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EwalletFormLabel.AutoSize = true;
            this.EwalletFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.EwalletFormLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EwalletFormLabel.Location = new System.Drawing.Point(728, 371);
            this.EwalletFormLabel.Name = "EwalletFormLabel";
            this.EwalletFormLabel.Size = new System.Drawing.Size(584, 40);
            this.EwalletFormLabel.TabIndex = 6;
            this.EwalletFormLabel.Text = "View E-wallet Top-up and Usage Report";
            // 
            // SalesFormLabel
            // 
            this.SalesFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesFormLabel.AutoSize = true;
            this.SalesFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.SalesFormLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesFormLabel.Location = new System.Drawing.Point(214, 643);
            this.SalesFormLabel.Name = "SalesFormLabel";
            this.SalesFormLabel.Size = new System.Drawing.Size(271, 40);
            this.SalesFormLabel.TabIndex = 7;
            this.SalesFormLabel.Text = "View Sales Report";
            // 
            // LogOutFormLabel
            // 
            this.LogOutFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogOutFormLabel.AutoSize = true;
            this.LogOutFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogOutFormLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutFormLabel.Location = new System.Drawing.Point(965, 643);
            this.LogOutFormLabel.Name = "LogOutFormLabel";
            this.LogOutFormLabel.Size = new System.Drawing.Size(132, 40);
            this.LogOutFormLabel.TabIndex = 8;
            this.LogOutFormLabel.Text = "Log Out";
            // 
            // EditUserFormBtn
            // 
            this.EditUserFormBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditUserFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserFormBtn.Location = new System.Drawing.Point(263, 469);
            this.EditUserFormBtn.Name = "EditUserFormBtn";
            this.EditUserFormBtn.Size = new System.Drawing.Size(191, 76);
            this.EditUserFormBtn.TabIndex = 9;
            this.EditUserFormBtn.Text = "Go";
            this.EditUserFormBtn.UseVisualStyleBackColor = true;
            this.EditUserFormBtn.Click += new System.EventHandler(this.EditUserFormBtn_Click);
            // 
            // WalletFormBtn
            // 
            this.WalletFormBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WalletFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletFormBtn.Location = new System.Drawing.Point(936, 469);
            this.WalletFormBtn.Name = "WalletFormBtn";
            this.WalletFormBtn.Size = new System.Drawing.Size(191, 76);
            this.WalletFormBtn.TabIndex = 10;
            this.WalletFormBtn.Text = "Go";
            this.WalletFormBtn.UseVisualStyleBackColor = true;
            this.WalletFormBtn.Click += new System.EventHandler(this.WalletFormBtn_Click);
            // 
            // SalesFormBtn
            // 
            this.SalesFormBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesFormBtn.Location = new System.Drawing.Point(263, 738);
            this.SalesFormBtn.Name = "SalesFormBtn";
            this.SalesFormBtn.Size = new System.Drawing.Size(191, 76);
            this.SalesFormBtn.TabIndex = 11;
            this.SalesFormBtn.Text = "Go";
            this.SalesFormBtn.UseVisualStyleBackColor = true;
            this.SalesFormBtn.Click += new System.EventHandler(this.SalesFormBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.Location = new System.Drawing.Point(936, 738);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(191, 76);
            this.LogOutBtn.TabIndex = 12;
            this.LogOutBtn.Text = "Go";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.SalesFormBtn);
            this.Controls.Add(this.WalletFormBtn);
            this.Controls.Add(this.EditUserFormBtn);
            this.Controls.Add(this.LogOutFormLabel);
            this.Controls.Add(this.SalesFormLabel);
            this.Controls.Add(this.EditUserFormLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.SystemHeader);
            this.Controls.Add(this.EwalletFormLabel);
            this.Controls.Add(this.GreetingLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Admin Main Menu";
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button SalesShortcut;
        private System.Windows.Forms.Button WalletReportShortcut;
        private System.Windows.Forms.Button EditUserShortcut;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label EditUserFormLabel;
        private System.Windows.Forms.Label EwalletFormLabel;
        private System.Windows.Forms.Label SalesFormLabel;
        private System.Windows.Forms.Label LogOutFormLabel;
        private System.Windows.Forms.Button EditUserFormBtn;
        private System.Windows.Forms.Button WalletFormBtn;
        private System.Windows.Forms.Button SalesFormBtn;
        private System.Windows.Forms.Button LogOutBtn;
    }
}