namespace SedapMakan
{
    partial class refundStatusForm
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
            this.refundStatusGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.userLabell = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.CancelRefShortcut = new System.Windows.Forms.Button();
            this.ViewCartShortcut = new System.Windows.Forms.Button();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.GiveFeedbackShortcut = new System.Windows.Forms.Button();
            this.OrderStatusShortcut = new System.Windows.Forms.Button();
            this.BrowseMenuShortcut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.refundStatusGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.DropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // refundStatusGridView
            // 
            this.refundStatusGridView.AllowUserToAddRows = false;
            this.refundStatusGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.refundStatusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.refundStatusGridView.Location = new System.Drawing.Point(108, 260);
            this.refundStatusGridView.Name = "refundStatusGridView";
            this.refundStatusGridView.ReadOnly = true;
            this.refundStatusGridView.RowHeadersWidth = 62;
            this.refundStatusGridView.RowTemplate.Height = 28;
            this.refundStatusGridView.Size = new System.Drawing.Size(1226, 559);
            this.refundStatusGridView.TabIndex = 0;
            this.refundStatusGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.refundStatusGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.userLabell);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 100);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 70);
            this.label2.TabIndex = 0;
            this.label2.Text = "SedapMakan";
            // 
            // userLabell
            // 
            this.userLabell.AutoSize = true;
            this.userLabell.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.userLabell.Location = new System.Drawing.Point(1147, 34);
            this.userLabell.Name = "userLabell";
            this.userLabell.Size = new System.Drawing.Size(232, 37);
            this.userLabell.TabIndex = 2;
            this.userLabell.Text = "Amlan Kesari⏷\r\n";
            this.userLabell.Click += new System.EventHandler(this.userLabell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F);
            this.label1.Location = new System.Drawing.Point(135, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 62);
            this.label1.TabIndex = 11;
            this.label1.Text = "Refund Status";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(134, 854);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(211, 78);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DropDownMenu
            // 
            this.DropDownMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DropDownMenu.Controls.Add(this.CancelRefShortcut);
            this.DropDownMenu.Controls.Add(this.ViewCartShortcut);
            this.DropDownMenu.Controls.Add(this.LogOutShortcut);
            this.DropDownMenu.Controls.Add(this.OwnAccountShortcut);
            this.DropDownMenu.Controls.Add(this.GiveFeedbackShortcut);
            this.DropDownMenu.Controls.Add(this.OrderStatusShortcut);
            this.DropDownMenu.Controls.Add(this.BrowseMenuShortcut);
            this.DropDownMenu.Location = new System.Drawing.Point(1111, 100);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(307, 478);
            this.DropDownMenu.TabIndex = 13;
            this.DropDownMenu.Visible = false;
            // 
            // CancelRefShortcut
            // 
            this.CancelRefShortcut.BackColor = System.Drawing.Color.Transparent;
            this.CancelRefShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.CancelRefShortcut.FlatAppearance.BorderSize = 0;
            this.CancelRefShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.CancelRefShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelRefShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelRefShortcut.ForeColor = System.Drawing.Color.White;
            this.CancelRefShortcut.Location = new System.Drawing.Point(1, 276);
            this.CancelRefShortcut.Name = "CancelRefShortcut";
            this.CancelRefShortcut.Size = new System.Drawing.Size(307, 67);
            this.CancelRefShortcut.TabIndex = 9;
            this.CancelRefShortcut.Text = "Cancel/Refund Orders";
            this.CancelRefShortcut.UseVisualStyleBackColor = false;
            this.CancelRefShortcut.Click += new System.EventHandler(this.CancelRefShortcut_Click);
            // 
            // ViewCartShortcut
            // 
            this.ViewCartShortcut.BackColor = System.Drawing.Color.Transparent;
            this.ViewCartShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ViewCartShortcut.FlatAppearance.BorderSize = 0;
            this.ViewCartShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.ViewCartShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCartShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCartShortcut.ForeColor = System.Drawing.Color.White;
            this.ViewCartShortcut.Location = new System.Drawing.Point(1, 142);
            this.ViewCartShortcut.Name = "ViewCartShortcut";
            this.ViewCartShortcut.Size = new System.Drawing.Size(307, 67);
            this.ViewCartShortcut.TabIndex = 8;
            this.ViewCartShortcut.Text = "View Cart";
            this.ViewCartShortcut.UseVisualStyleBackColor = false;
            this.ViewCartShortcut.Click += new System.EventHandler(this.ViewCartShortcut_Click);
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
            this.LogOutShortcut.Location = new System.Drawing.Point(1, 410);
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
            this.OwnAccountShortcut.Location = new System.Drawing.Point(1, 343);
            this.OwnAccountShortcut.Name = "OwnAccountShortcut";
            this.OwnAccountShortcut.Size = new System.Drawing.Size(307, 67);
            this.OwnAccountShortcut.TabIndex = 6;
            this.OwnAccountShortcut.Text = "Edit Own Account";
            this.OwnAccountShortcut.UseVisualStyleBackColor = false;
            this.OwnAccountShortcut.Click += new System.EventHandler(this.OwnAccountShortcut_Click);
            // 
            // GiveFeedbackShortcut
            // 
            this.GiveFeedbackShortcut.BackColor = System.Drawing.Color.Transparent;
            this.GiveFeedbackShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.GiveFeedbackShortcut.FlatAppearance.BorderSize = 0;
            this.GiveFeedbackShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GiveFeedbackShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiveFeedbackShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveFeedbackShortcut.ForeColor = System.Drawing.Color.White;
            this.GiveFeedbackShortcut.Location = new System.Drawing.Point(1, 209);
            this.GiveFeedbackShortcut.Name = "GiveFeedbackShortcut";
            this.GiveFeedbackShortcut.Size = new System.Drawing.Size(307, 67);
            this.GiveFeedbackShortcut.TabIndex = 5;
            this.GiveFeedbackShortcut.Text = "Give Feedback";
            this.GiveFeedbackShortcut.UseVisualStyleBackColor = false;
            this.GiveFeedbackShortcut.Click += new System.EventHandler(this.GiveFeedbackShortcut_Click);
            // 
            // OrderStatusShortcut
            // 
            this.OrderStatusShortcut.BackColor = System.Drawing.Color.Transparent;
            this.OrderStatusShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.OrderStatusShortcut.FlatAppearance.BorderSize = 0;
            this.OrderStatusShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.OrderStatusShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderStatusShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderStatusShortcut.ForeColor = System.Drawing.Color.White;
            this.OrderStatusShortcut.Location = new System.Drawing.Point(1, 67);
            this.OrderStatusShortcut.Name = "OrderStatusShortcut";
            this.OrderStatusShortcut.Size = new System.Drawing.Size(307, 67);
            this.OrderStatusShortcut.TabIndex = 4;
            this.OrderStatusShortcut.Text = "View Order Status";
            this.OrderStatusShortcut.UseVisualStyleBackColor = false;
            this.OrderStatusShortcut.Click += new System.EventHandler(this.OrderStatusShortcut_Click);
            // 
            // BrowseMenuShortcut
            // 
            this.BrowseMenuShortcut.BackColor = System.Drawing.Color.Transparent;
            this.BrowseMenuShortcut.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BrowseMenuShortcut.FlatAppearance.BorderSize = 0;
            this.BrowseMenuShortcut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BrowseMenuShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseMenuShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseMenuShortcut.ForeColor = System.Drawing.Color.White;
            this.BrowseMenuShortcut.Location = new System.Drawing.Point(1, 0);
            this.BrowseMenuShortcut.Name = "BrowseMenuShortcut";
            this.BrowseMenuShortcut.Size = new System.Drawing.Size(307, 67);
            this.BrowseMenuShortcut.TabIndex = 3;
            this.BrowseMenuShortcut.Text = "Browse Menu";
            this.BrowseMenuShortcut.UseVisualStyleBackColor = false;
            this.BrowseMenuShortcut.Click += new System.EventHandler(this.BrowseMenuShortcut_Click);
            // 
            // refundStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refundStatusGridView);
            this.Name = "refundStatusForm";
            this.Text = "refundStatusForm";
            this.Load += new System.EventHandler(this.refundStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refundStatusGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView refundStatusGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userLabell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button CancelRefShortcut;
        private System.Windows.Forms.Button ViewCartShortcut;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button GiveFeedbackShortcut;
        private System.Windows.Forms.Button OrderStatusShortcut;
        private System.Windows.Forms.Button BrowseMenuShortcut;
    }
}