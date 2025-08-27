namespace SedapMakanSystemAdmin
{
    partial class TopUpCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopUpCustomerForm));
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.TopUpReqDgv = new System.Windows.Forms.DataGridView();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.TopUpFormBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AccNameDesignationlbl = new System.Windows.Forms.Label();
            this.AccountNamelbl = new System.Windows.Forms.Label();
            this.EmailDesignationlbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.FNamedesignationlbl = new System.Windows.Forms.Label();
            this.FNamelbl = new System.Windows.Forms.Label();
            this.PhoneNumdesignationlbl = new System.Windows.Forms.Label();
            this.PhoneNumlbl = new System.Windows.Forms.Label();
            this.CustomerDetailslbl = new System.Windows.Forms.Label();
            this.CustomerDetailsPanel = new System.Windows.Forms.Panel();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.ReviewRefundShortcut = new System.Windows.Forms.Button();
            this.TopUpShortcut = new System.Windows.Forms.Button();
            this.ViewFeedbackShortcut = new System.Windows.Forms.Button();
            this.SystemHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopUpReqDgv)).BeginInit();
            this.CustomerDetailsPanel.SuspendLayout();
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
            this.SystemHeader.TabIndex = 4;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNameLabel.Location = new System.Drawing.Point(1117, 35);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(35, 37);
            this.AccountNameLabel.TabIndex = 4;
            this.AccountNameLabel.Text = "a";
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
            // TopUpReqDgv
            // 
            this.TopUpReqDgv.AllowUserToAddRows = false;
            this.TopUpReqDgv.AllowUserToDeleteRows = false;
            this.TopUpReqDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopUpReqDgv.Location = new System.Drawing.Point(92, 249);
            this.TopUpReqDgv.Name = "TopUpReqDgv";
            this.TopUpReqDgv.RowHeadersWidth = 62;
            this.TopUpReqDgv.RowTemplate.Height = 28;
            this.TopUpReqDgv.Size = new System.Drawing.Size(601, 655);
            this.TopUpReqDgv.TabIndex = 8;
            this.TopUpReqDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TopUpReqDgv_CellClick);
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 24F);
            this.Titlelbl.Location = new System.Drawing.Point(104, 148);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(580, 62);
            this.Titlelbl.TabIndex = 7;
            this.Titlelbl.Text = "Top-up Customer Ewallets";
            // 
            // TopUpFormBtn
            // 
            this.TopUpFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopUpFormBtn.Location = new System.Drawing.Point(768, 797);
            this.TopUpFormBtn.Name = "TopUpFormBtn";
            this.TopUpFormBtn.Size = new System.Drawing.Size(273, 90);
            this.TopUpFormBtn.TabIndex = 9;
            this.TopUpFormBtn.Text = "Top-up";
            this.TopUpFormBtn.UseVisualStyleBackColor = true;
            this.TopUpFormBtn.Click += new System.EventHandler(this.TopUpFormBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(1084, 797);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(273, 90);
            this.BackBtn.TabIndex = 10;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AccNameDesignationlbl
            // 
            this.AccNameDesignationlbl.AutoSize = true;
            this.AccNameDesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNameDesignationlbl.Location = new System.Drawing.Point(27, 129);
            this.AccNameDesignationlbl.Name = "AccNameDesignationlbl";
            this.AccNameDesignationlbl.Size = new System.Drawing.Size(220, 32);
            this.AccNameDesignationlbl.TabIndex = 11;
            this.AccNameDesignationlbl.Text = "Account Name:";
            // 
            // AccountNamelbl
            // 
            this.AccountNamelbl.AutoSize = true;
            this.AccountNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNamelbl.Location = new System.Drawing.Point(267, 129);
            this.AccountNamelbl.Name = "AccountNamelbl";
            this.AccountNamelbl.Size = new System.Drawing.Size(166, 32);
            this.AccountNamelbl.TabIndex = 12;
            this.AccountNamelbl.Text = "Placeholder";
            // 
            // EmailDesignationlbl
            // 
            this.EmailDesignationlbl.AutoSize = true;
            this.EmailDesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailDesignationlbl.Location = new System.Drawing.Point(27, 209);
            this.EmailDesignationlbl.Name = "EmailDesignationlbl";
            this.EmailDesignationlbl.Size = new System.Drawing.Size(100, 32);
            this.EmailDesignationlbl.TabIndex = 14;
            this.EmailDesignationlbl.Text = "Email:";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(267, 209);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(166, 32);
            this.Emaillbl.TabIndex = 13;
            this.Emaillbl.Text = "Placeholder";
            // 
            // FNamedesignationlbl
            // 
            this.FNamedesignationlbl.AutoSize = true;
            this.FNamedesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNamedesignationlbl.Location = new System.Drawing.Point(27, 290);
            this.FNamedesignationlbl.Name = "FNamedesignationlbl";
            this.FNamedesignationlbl.Size = new System.Drawing.Size(161, 32);
            this.FNamedesignationlbl.TabIndex = 16;
            this.FNamedesignationlbl.Text = "Full Name:";
            // 
            // FNamelbl
            // 
            this.FNamelbl.AutoSize = true;
            this.FNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNamelbl.Location = new System.Drawing.Point(267, 290);
            this.FNamelbl.Name = "FNamelbl";
            this.FNamelbl.Size = new System.Drawing.Size(166, 32);
            this.FNamelbl.TabIndex = 15;
            this.FNamelbl.Text = "Placeholder";
            // 
            // PhoneNumdesignationlbl
            // 
            this.PhoneNumdesignationlbl.AutoSize = true;
            this.PhoneNumdesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumdesignationlbl.Location = new System.Drawing.Point(27, 375);
            this.PhoneNumdesignationlbl.Name = "PhoneNumdesignationlbl";
            this.PhoneNumdesignationlbl.Size = new System.Drawing.Size(225, 32);
            this.PhoneNumdesignationlbl.TabIndex = 18;
            this.PhoneNumdesignationlbl.Text = "Phone Number:";
            // 
            // PhoneNumlbl
            // 
            this.PhoneNumlbl.AutoSize = true;
            this.PhoneNumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumlbl.Location = new System.Drawing.Point(267, 375);
            this.PhoneNumlbl.Name = "PhoneNumlbl";
            this.PhoneNumlbl.Size = new System.Drawing.Size(166, 32);
            this.PhoneNumlbl.TabIndex = 17;
            this.PhoneNumlbl.Text = "Placeholder";
            // 
            // CustomerDetailslbl
            // 
            this.CustomerDetailslbl.AutoSize = true;
            this.CustomerDetailslbl.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDetailslbl.Location = new System.Drawing.Point(28, 38);
            this.CustomerDetailslbl.Name = "CustomerDetailslbl";
            this.CustomerDetailslbl.Size = new System.Drawing.Size(290, 45);
            this.CustomerDetailslbl.TabIndex = 19;
            this.CustomerDetailslbl.Text = "Customer Details";
            // 
            // CustomerDetailsPanel
            // 
            this.CustomerDetailsPanel.Controls.Add(this.CustomerDetailslbl);
            this.CustomerDetailsPanel.Controls.Add(this.PhoneNumdesignationlbl);
            this.CustomerDetailsPanel.Controls.Add(this.PhoneNumlbl);
            this.CustomerDetailsPanel.Controls.Add(this.FNamedesignationlbl);
            this.CustomerDetailsPanel.Controls.Add(this.FNamelbl);
            this.CustomerDetailsPanel.Controls.Add(this.EmailDesignationlbl);
            this.CustomerDetailsPanel.Controls.Add(this.Emaillbl);
            this.CustomerDetailsPanel.Controls.Add(this.AccountNamelbl);
            this.CustomerDetailsPanel.Controls.Add(this.AccNameDesignationlbl);
            this.CustomerDetailsPanel.Location = new System.Drawing.Point(753, 260);
            this.CustomerDetailsPanel.Name = "CustomerDetailsPanel";
            this.CustomerDetailsPanel.Size = new System.Drawing.Size(603, 490);
            this.CustomerDetailsPanel.TabIndex = 20;
            // 
            // DropDownMenu
            // 
            this.DropDownMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DropDownMenu.Controls.Add(this.LogOutShortcut);
            this.DropDownMenu.Controls.Add(this.OwnAccountShortcut);
            this.DropDownMenu.Controls.Add(this.ReviewRefundShortcut);
            this.DropDownMenu.Controls.Add(this.TopUpShortcut);
            this.DropDownMenu.Controls.Add(this.ViewFeedbackShortcut);
            this.DropDownMenu.Location = new System.Drawing.Point(1110, 100);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(307, 336);
            this.DropDownMenu.TabIndex = 21;
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
            // ReviewRefundShortcut
            // 
            this.ReviewRefundShortcut.BackColor = System.Drawing.Color.Transparent;
            this.ReviewRefundShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ReviewRefundShortcut.FlatAppearance.BorderSize = 0;
            this.ReviewRefundShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ReviewRefundShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewRefundShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewRefundShortcut.ForeColor = System.Drawing.Color.White;
            this.ReviewRefundShortcut.Location = new System.Drawing.Point(0, 134);
            this.ReviewRefundShortcut.Name = "ReviewRefundShortcut";
            this.ReviewRefundShortcut.Size = new System.Drawing.Size(307, 67);
            this.ReviewRefundShortcut.TabIndex = 5;
            this.ReviewRefundShortcut.Text = "Review Refund Requests";
            this.ReviewRefundShortcut.UseVisualStyleBackColor = false;
            this.ReviewRefundShortcut.Click += new System.EventHandler(this.ReviewRefundShortcut_Click);
            // 
            // TopUpShortcut
            // 
            this.TopUpShortcut.BackColor = System.Drawing.Color.Transparent;
            this.TopUpShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.TopUpShortcut.FlatAppearance.BorderSize = 0;
            this.TopUpShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.TopUpShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopUpShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopUpShortcut.ForeColor = System.Drawing.Color.White;
            this.TopUpShortcut.Location = new System.Drawing.Point(0, 67);
            this.TopUpShortcut.Name = "TopUpShortcut";
            this.TopUpShortcut.Size = new System.Drawing.Size(307, 67);
            this.TopUpShortcut.TabIndex = 4;
            this.TopUpShortcut.Text = "Top-up Customer Ewallets";
            this.TopUpShortcut.UseVisualStyleBackColor = false;
            this.TopUpShortcut.Click += new System.EventHandler(this.TopUpShortcut_Click);
            // 
            // ViewFeedbackShortcut
            // 
            this.ViewFeedbackShortcut.BackColor = System.Drawing.Color.Transparent;
            this.ViewFeedbackShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ViewFeedbackShortcut.FlatAppearance.BorderSize = 0;
            this.ViewFeedbackShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ViewFeedbackShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewFeedbackShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFeedbackShortcut.ForeColor = System.Drawing.Color.White;
            this.ViewFeedbackShortcut.Location = new System.Drawing.Point(0, 0);
            this.ViewFeedbackShortcut.Name = "ViewFeedbackShortcut";
            this.ViewFeedbackShortcut.Size = new System.Drawing.Size(307, 67);
            this.ViewFeedbackShortcut.TabIndex = 3;
            this.ViewFeedbackShortcut.Text = "View Customer Feedback";
            this.ViewFeedbackShortcut.UseVisualStyleBackColor = false;
            this.ViewFeedbackShortcut.Click += new System.EventHandler(this.ViewFeedbackShortcut_Click);
            // 
            // TopUpCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.CustomerDetailsPanel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TopUpFormBtn);
            this.Controls.Add(this.TopUpReqDgv);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.SystemHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopUpCustomerForm";
            this.Text = "Top-up Customers";
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopUpReqDgv)).EndInit();
            this.CustomerDetailsPanel.ResumeLayout(false);
            this.CustomerDetailsPanel.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.DataGridView TopUpReqDgv;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label AccNameDesignationlbl;
        private System.Windows.Forms.Label AccountNamelbl;
        private System.Windows.Forms.Label EmailDesignationlbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label FNamedesignationlbl;
        private System.Windows.Forms.Label FNamelbl;
        private System.Windows.Forms.Label PhoneNumdesignationlbl;
        private System.Windows.Forms.Label PhoneNumlbl;
        private System.Windows.Forms.Label CustomerDetailslbl;
        private System.Windows.Forms.Panel CustomerDetailsPanel;
        private System.Windows.Forms.Button TopUpFormBtn;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button ReviewRefundShortcut;
        private System.Windows.Forms.Button TopUpShortcut;
        private System.Windows.Forms.Button ViewFeedbackShortcut;
    }
}