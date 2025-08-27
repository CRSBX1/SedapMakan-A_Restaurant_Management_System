namespace SedapMakan
{
    partial class ChefHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefHomeForm));
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogoutShortcut = new System.Windows.Forms.Button();
            this.EditOwnAccShortcut = new System.Windows.Forms.Button();
            this.ViewOrderShortcut = new System.Windows.Forms.Button();
            this.ManageMenuShortcut = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.DropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Palatino Linotype", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(21, 16);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(281, 59);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "SedapMakan";
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.AccountNameLabel);
            this.panelHeader.Controls.Add(this.lblAppName);
            this.panelHeader.Location = new System.Drawing.Point(2, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1600, 94);
            this.panelHeader.TabIndex = 21;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNameLabel.Location = new System.Drawing.Point(1344, 35);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(244, 37);
            this.AccountNameLabel.TabIndex = 22;
            this.AccountNameLabel.Text = "Alfred William ▼";
            this.AccountNameLabel.Click += new System.EventHandler(this.AccountNameLabel_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 48);
            this.label5.TabIndex = 20;
            this.label5.Text = "What would you like to do?\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1113, 756);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Return to login screen";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 756);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Change profile information";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1073, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Check and update order status";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Go to menu editor (add/edit/delete)";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(399, 175);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(836, 76);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Welcome, Chef Alfred William";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(960, 794);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(534, 162);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "🔓 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(107, 794);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(534, 162);
            this.btnUpdateProfile.TabIndex = 13;
            this.btnUpdateProfile.Text = "✏️ Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(960, 421);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(534, 162);
            this.btnViewOrders.TabIndex = 12;
            this.btnViewOrders.Text = "📦 View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManageMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnManageMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMenu.Location = new System.Drawing.Point(107, 421);
            this.btnManageMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(534, 162);
            this.btnManageMenu.TabIndex = 11;
            this.btnManageMenu.Text = "🍽 Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = false;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // DropDownMenu
            // 
            this.DropDownMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DropDownMenu.Controls.Add(this.LogoutShortcut);
            this.DropDownMenu.Controls.Add(this.EditOwnAccShortcut);
            this.DropDownMenu.Controls.Add(this.ViewOrderShortcut);
            this.DropDownMenu.Controls.Add(this.ManageMenuShortcut);
            this.DropDownMenu.Location = new System.Drawing.Point(1293, 94);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(307, 279);
            this.DropDownMenu.TabIndex = 43;
            this.DropDownMenu.Visible = false;
            // 
            // LogoutShortcut
            // 
            this.LogoutShortcut.BackColor = System.Drawing.Color.Transparent;
            this.LogoutShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.LogoutShortcut.FlatAppearance.BorderSize = 0;
            this.LogoutShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.LogoutShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutShortcut.ForeColor = System.Drawing.Color.White;
            this.LogoutShortcut.Location = new System.Drawing.Point(0, 201);
            this.LogoutShortcut.Name = "LogoutShortcut";
            this.LogoutShortcut.Size = new System.Drawing.Size(307, 67);
            this.LogoutShortcut.TabIndex = 6;
            this.LogoutShortcut.Text = "Log Out";
            this.LogoutShortcut.UseVisualStyleBackColor = false;
            this.LogoutShortcut.Click += new System.EventHandler(this.LogoutShortcut_Click);
            // 
            // EditOwnAccShortcut
            // 
            this.EditOwnAccShortcut.BackColor = System.Drawing.Color.Transparent;
            this.EditOwnAccShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EditOwnAccShortcut.FlatAppearance.BorderSize = 0;
            this.EditOwnAccShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.EditOwnAccShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditOwnAccShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditOwnAccShortcut.ForeColor = System.Drawing.Color.White;
            this.EditOwnAccShortcut.Location = new System.Drawing.Point(0, 134);
            this.EditOwnAccShortcut.Name = "EditOwnAccShortcut";
            this.EditOwnAccShortcut.Size = new System.Drawing.Size(307, 67);
            this.EditOwnAccShortcut.TabIndex = 5;
            this.EditOwnAccShortcut.Text = "Edit Own Account";
            this.EditOwnAccShortcut.UseVisualStyleBackColor = false;
            this.EditOwnAccShortcut.Click += new System.EventHandler(this.EditOwnAccShortcut_Click);
            // 
            // ViewOrderShortcut
            // 
            this.ViewOrderShortcut.BackColor = System.Drawing.Color.Transparent;
            this.ViewOrderShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ViewOrderShortcut.FlatAppearance.BorderSize = 0;
            this.ViewOrderShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ViewOrderShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewOrderShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOrderShortcut.ForeColor = System.Drawing.Color.White;
            this.ViewOrderShortcut.Location = new System.Drawing.Point(0, 67);
            this.ViewOrderShortcut.Name = "ViewOrderShortcut";
            this.ViewOrderShortcut.Size = new System.Drawing.Size(307, 67);
            this.ViewOrderShortcut.TabIndex = 4;
            this.ViewOrderShortcut.Text = "View Orders";
            this.ViewOrderShortcut.UseVisualStyleBackColor = false;
            this.ViewOrderShortcut.Click += new System.EventHandler(this.ViewOrderShortcut_Click);
            // 
            // ManageMenuShortcut
            // 
            this.ManageMenuShortcut.BackColor = System.Drawing.Color.Transparent;
            this.ManageMenuShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ManageMenuShortcut.FlatAppearance.BorderSize = 0;
            this.ManageMenuShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ManageMenuShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageMenuShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageMenuShortcut.ForeColor = System.Drawing.Color.White;
            this.ManageMenuShortcut.Location = new System.Drawing.Point(0, 0);
            this.ManageMenuShortcut.Name = "ManageMenuShortcut";
            this.ManageMenuShortcut.Size = new System.Drawing.Size(307, 67);
            this.ManageMenuShortcut.TabIndex = 3;
            this.ManageMenuShortcut.Text = "Manage Menu";
            this.ManageMenuShortcut.UseVisualStyleBackColor = false;
            this.ManageMenuShortcut.Click += new System.EventHandler(this.ManageMenuShortcut_Click);
            // 
            // ChefHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1221);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnManageMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChefHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chef Home Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogoutShortcut;
        private System.Windows.Forms.Button ViewOrderShortcut;
        private System.Windows.Forms.Button ManageMenuShortcut;
        private System.Windows.Forms.Button EditOwnAccShortcut;
    }
}