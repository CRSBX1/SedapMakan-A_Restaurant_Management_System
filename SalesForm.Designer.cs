namespace SedapMakan
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.SalesReportTable = new System.Windows.Forms.DataGridView();
            this.SalesReportLabel = new System.Windows.Forms.Label();
            this.YearFilterComboBox = new System.Windows.Forms.ComboBox();
            this.YearFilterLabel = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MonthFilterLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryFilterLabel = new System.Windows.Forms.Label();
            this.ChefComboBox = new System.Windows.Forms.ComboBox();
            this.ChefFilterLabel = new System.Windows.Forms.Label();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.SalesShortcut = new System.Windows.Forms.Button();
            this.WalletReportShortcut = new System.Windows.Forms.Button();
            this.EditUserShortcut = new System.Windows.Forms.Button();
            this.SystemHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportTable)).BeginInit();
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
            this.SystemHeader.Location = new System.Drawing.Point(3, 1);
            this.SystemHeader.Name = "SystemHeader";
            this.SystemHeader.Size = new System.Drawing.Size(1416, 100);
            this.SystemHeader.TabIndex = 11;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNameLabel.Location = new System.Drawing.Point(1117, 35);
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
            // SalesReportTable
            // 
            this.SalesReportTable.AllowUserToAddRows = false;
            this.SalesReportTable.AllowUserToDeleteRows = false;
            this.SalesReportTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesReportTable.Location = new System.Drawing.Point(157, 401);
            this.SalesReportTable.Name = "SalesReportTable";
            this.SalesReportTable.ReadOnly = true;
            this.SalesReportTable.RowHeadersWidth = 62;
            this.SalesReportTable.RowTemplate.Height = 28;
            this.SalesReportTable.Size = new System.Drawing.Size(1121, 433);
            this.SalesReportTable.TabIndex = 10;
            // 
            // SalesReportLabel
            // 
            this.SalesReportLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesReportLabel.AutoSize = true;
            this.SalesReportLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesReportLabel.Location = new System.Drawing.Point(145, 192);
            this.SalesReportLabel.Name = "SalesReportLabel";
            this.SalesReportLabel.Size = new System.Drawing.Size(338, 71);
            this.SalesReportLabel.TabIndex = 9;
            this.SalesReportLabel.Text = "Sales Report";
            // 
            // YearFilterComboBox
            // 
            this.YearFilterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearFilterComboBox.FormattingEnabled = true;
            this.YearFilterComboBox.Location = new System.Drawing.Point(245, 309);
            this.YearFilterComboBox.Name = "YearFilterComboBox";
            this.YearFilterComboBox.Size = new System.Drawing.Size(127, 33);
            this.YearFilterComboBox.TabIndex = 43;
            this.YearFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.YearFilterComboBox_SelectedIndexChanged);
            // 
            // YearFilterLabel
            // 
            this.YearFilterLabel.AutoSize = true;
            this.YearFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearFilterLabel.Location = new System.Drawing.Point(156, 309);
            this.YearFilterLabel.Name = "YearFilterLabel";
            this.YearFilterLabel.Size = new System.Drawing.Size(70, 29);
            this.YearFilterLabel.TabIndex = 42;
            this.YearFilterLabel.Text = "Year:";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(534, 309);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(127, 33);
            this.MonthComboBox.TabIndex = 45;
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBox_SelectedIndexChanged);
            // 
            // MonthFilterLabel
            // 
            this.MonthFilterLabel.AutoSize = true;
            this.MonthFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthFilterLabel.Location = new System.Drawing.Point(434, 309);
            this.MonthFilterLabel.Name = "MonthFilterLabel";
            this.MonthFilterLabel.Size = new System.Drawing.Size(85, 29);
            this.MonthFilterLabel.TabIndex = 44;
            this.MonthFilterLabel.Text = "Month:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(852, 309);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(127, 33);
            this.CategoryComboBox.TabIndex = 49;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CategoryFilterLabel
            // 
            this.CategoryFilterLabel.AutoSize = true;
            this.CategoryFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryFilterLabel.Location = new System.Drawing.Point(719, 309);
            this.CategoryFilterLabel.Name = "CategoryFilterLabel";
            this.CategoryFilterLabel.Size = new System.Drawing.Size(116, 29);
            this.CategoryFilterLabel.TabIndex = 48;
            this.CategoryFilterLabel.Text = "Category:";
            // 
            // ChefComboBox
            // 
            this.ChefComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChefComboBox.FormattingEnabled = true;
            this.ChefComboBox.Location = new System.Drawing.Point(1112, 309);
            this.ChefComboBox.Name = "ChefComboBox";
            this.ChefComboBox.Size = new System.Drawing.Size(177, 33);
            this.ChefComboBox.TabIndex = 51;
            this.ChefComboBox.SelectedIndexChanged += new System.EventHandler(this.ChefComboBox_SelectedIndexChanged);
            // 
            // ChefFilterLabel
            // 
            this.ChefFilterLabel.AutoSize = true;
            this.ChefFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChefFilterLabel.Location = new System.Drawing.Point(1028, 309);
            this.ChefFilterLabel.Name = "ChefFilterLabel";
            this.ChefFilterLabel.Size = new System.Drawing.Size(69, 29);
            this.ChefFilterLabel.TabIndex = 50;
            this.ChefFilterLabel.Text = "Chef:";
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(1087, 868);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(191, 76);
            this.ReturnBtn.TabIndex = 52;
            this.ReturnBtn.Text = "Back";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
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
            this.DropDownMenu.TabIndex = 53;
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
            this.LogOutShortcut.Click += new System.EventHandler(this.LogOutShortcut_Click_1);
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
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.ChefComboBox);
            this.Controls.Add(this.ChefFilterLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryFilterLabel);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.MonthFilterLabel);
            this.Controls.Add(this.YearFilterComboBox);
            this.Controls.Add(this.YearFilterLabel);
            this.Controls.Add(this.SystemHeader);
            this.Controls.Add(this.SalesReportTable);
            this.Controls.Add(this.SalesReportLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesForm";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportTable)).EndInit();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.DataGridView SalesReportTable;
        private System.Windows.Forms.Label SalesReportLabel;
        private System.Windows.Forms.ComboBox YearFilterComboBox;
        private System.Windows.Forms.Label YearFilterLabel;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label MonthFilterLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryFilterLabel;
        private System.Windows.Forms.Label ChefFilterLabel;
        private System.Windows.Forms.ComboBox ChefComboBox;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button SalesShortcut;
        private System.Windows.Forms.Button WalletReportShortcut;
        private System.Windows.Forms.Button EditUserShortcut;
    }
}