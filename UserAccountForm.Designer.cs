namespace SedapMakan
{
    partial class UserAccountForm
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
            System.Windows.Forms.Button AddUserBtn;
            System.Windows.Forms.Button EditUserBtn;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountForm));
            this.UserAccountLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.UserAccountTable = new System.Windows.Forms.DataGridView();
            this.RemoveUserBtn = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.SalesShortcut = new System.Windows.Forms.Button();
            this.WalletReportShortcut = new System.Windows.Forms.Button();
            this.EditUserShortcut = new System.Windows.Forms.Button();
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            AddUserBtn = new System.Windows.Forms.Button();
            EditUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserAccountTable)).BeginInit();
            this.DropDownMenu.SuspendLayout();
            this.SystemHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddUserBtn
            // 
            AddUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            AddUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AddUserBtn.Location = new System.Drawing.Point(71, 829);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new System.Drawing.Size(191, 76);
            AddUserBtn.TabIndex = 4;
            AddUserBtn.Text = "Add User";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // EditUserBtn
            // 
            EditUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            EditUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            EditUserBtn.Location = new System.Drawing.Point(335, 829);
            EditUserBtn.Name = "EditUserBtn";
            EditUserBtn.Size = new System.Drawing.Size(191, 76);
            EditUserBtn.TabIndex = 10;
            EditUserBtn.Text = "Edit User";
            EditUserBtn.UseVisualStyleBackColor = true;
            EditUserBtn.Click += new System.EventHandler(this.EditUserBtn_Click);
            // 
            // UserAccountLabel
            // 
            this.UserAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserAccountLabel.AutoSize = true;
            this.UserAccountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccountLabel.Location = new System.Drawing.Point(143, 190);
            this.UserAccountLabel.Name = "UserAccountLabel";
            this.UserAccountLabel.Size = new System.Drawing.Size(383, 71);
            this.UserAccountLabel.TabIndex = 0;
            this.UserAccountLabel.Text = "User Accounts";
            // 
            // RoleLabel
            // 
            this.RoleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.Location = new System.Drawing.Point(976, 215);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(97, 37);
            this.RoleLabel.TabIndex = 1;
            this.RoleLabel.Text = "Roles";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "All",
            "System Admin",
            "Manager",
            "Chef",
            "Customer"});
            this.RoleComboBox.Location = new System.Drawing.Point(1085, 219);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(180, 33);
            this.RoleComboBox.TabIndex = 2;
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // UserAccountTable
            // 
            this.UserAccountTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserAccountTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserAccountTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserAccountTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserAccountTable.Location = new System.Drawing.Point(71, 297);
            this.UserAccountTable.MultiSelect = false;
            this.UserAccountTable.Name = "UserAccountTable";
            this.UserAccountTable.ReadOnly = true;
            this.UserAccountTable.RowHeadersWidth = 62;
            this.UserAccountTable.RowTemplate.Height = 28;
            this.UserAccountTable.Size = new System.Drawing.Size(1285, 487);
            this.UserAccountTable.TabIndex = 3;
            this.UserAccountTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserAccountTable_CellContentClick);
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUserBtn.Location = new System.Drawing.Point(613, 829);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(191, 76);
            this.RemoveUserBtn.TabIndex = 6;
            this.RemoveUserBtn.Text = "Remove User";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            this.RemoveUserBtn.Click += new System.EventHandler(this.RemoveUserBtn_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackButton.Location = new System.Drawing.Point(1110, 829);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(191, 76);
            this.GoBackButton.TabIndex = 7;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
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
            this.DropDownMenu.Location = new System.Drawing.Point(1110, 101);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(307, 336);
            this.DropDownMenu.TabIndex = 9;
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
            this.SystemHeader.TabIndex = 8;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNameLabel.Location = new System.Drawing.Point(1119, 35);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(286, 37);
            this.AccountNameLabel.TabIndex = 4;
            this.AccountNameLabel.Text = "Antoni Lawrence ▼";
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
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(EditUserBtn);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.SystemHeader);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.RemoveUserBtn);
            this.Controls.Add(AddUserBtn);
            this.Controls.Add(this.UserAccountTable);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.UserAccountLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserAccountForm";
            this.Text = "View and Edit User Accounts";
            this.Load += new System.EventHandler(this.UserAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserAccountTable)).EndInit();
            this.DropDownMenu.ResumeLayout(false);
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserAccountLabel;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.DataGridView UserAccountTable;
        private System.Windows.Forms.Button RemoveUserBtn;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button SalesShortcut;
        private System.Windows.Forms.Button WalletReportShortcut;
        private System.Windows.Forms.Button EditUserShortcut;
        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Label RoleLabel;
    }
}