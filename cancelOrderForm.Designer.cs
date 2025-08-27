namespace SedapMakan
{
    partial class CancelOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.openRefundFormButton = new System.Windows.Forms.Button();
            this.CheckRefStatusBtn = new System.Windows.Forms.Button();
            this.userMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_CheckMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_OrderStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_RefundStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ViewCart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Feedback = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.userLabell = new System.Windows.Forms.Label();
            this.InProcessOrdersDgv = new System.Windows.Forms.DataGridView();
            this.YourOrderlbl = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.CanceledOrderIDlabel = new System.Windows.Forms.Label();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.CancelRefShortcut = new System.Windows.Forms.Button();
            this.ViewCartShortcut = new System.Windows.Forms.Button();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.GiveFeedbackShortcut = new System.Windows.Forms.Button();
            this.OrderStatusShortcut = new System.Windows.Forms.Button();
            this.BrowseMenuShortcut = new System.Windows.Forms.Button();
            this.userMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InProcessOrdersDgv)).BeginInit();
            this.DropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 765);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an order to cancel: ";
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.BackColor = System.Drawing.Color.Red;
            this.cancelOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderBtn.Location = new System.Drawing.Point(83, 852);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(241, 86);
            this.cancelOrderBtn.TabIndex = 2;
            this.cancelOrderBtn.Text = "Cancel Order";
            this.cancelOrderBtn.UseVisualStyleBackColor = false;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderButton2_Click);
            // 
            // openRefundFormButton
            // 
            this.openRefundFormButton.BackColor = System.Drawing.Color.Yellow;
            this.openRefundFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openRefundFormButton.Location = new System.Drawing.Point(369, 852);
            this.openRefundFormButton.Name = "openRefundFormButton";
            this.openRefundFormButton.Size = new System.Drawing.Size(241, 86);
            this.openRefundFormButton.TabIndex = 3;
            this.openRefundFormButton.Text = "Request Refund";
            this.openRefundFormButton.UseVisualStyleBackColor = false;
            this.openRefundFormButton.Click += new System.EventHandler(this.openRefundFormButton_Click);
            // 
            // CheckRefStatusBtn
            // 
            this.CheckRefStatusBtn.BackColor = System.Drawing.Color.MistyRose;
            this.CheckRefStatusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRefStatusBtn.Location = new System.Drawing.Point(663, 852);
            this.CheckRefStatusBtn.Name = "CheckRefStatusBtn";
            this.CheckRefStatusBtn.Size = new System.Drawing.Size(241, 86);
            this.CheckRefStatusBtn.TabIndex = 8;
            this.CheckRefStatusBtn.Text = "Check Refund Status";
            this.CheckRefStatusBtn.UseVisualStyleBackColor = false;
            this.CheckRefStatusBtn.Click += new System.EventHandler(this.CheckRefStatusBtn_Click);
            // 
            // userMenuStrip
            // 
            this.userMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.userMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_CheckMenu,
            this.menuItem_OrderStatus,
            this.menuItem_RefundStatus,
            this.menuItem_ViewCart,
            this.menuItem_Feedback});
            this.userMenuStrip.Name = "userMenuStrip";
            this.userMenuStrip.Size = new System.Drawing.Size(246, 164);
            // 
            // menuItem_CheckMenu
            // 
            this.menuItem_CheckMenu.Name = "menuItem_CheckMenu";
            this.menuItem_CheckMenu.Size = new System.Drawing.Size(245, 32);
            this.menuItem_CheckMenu.Text = "Check Menu";
            this.menuItem_CheckMenu.Click += new System.EventHandler(this.menuItem_CheckMenu_Click);
            // 
            // menuItem_OrderStatus
            // 
            this.menuItem_OrderStatus.Name = "menuItem_OrderStatus";
            this.menuItem_OrderStatus.Size = new System.Drawing.Size(245, 32);
            this.menuItem_OrderStatus.Text = "Check Order Status";
            this.menuItem_OrderStatus.Click += new System.EventHandler(this.menuItem_OrderStatus_Click);
            // 
            // menuItem_RefundStatus
            // 
            this.menuItem_RefundStatus.Name = "menuItem_RefundStatus";
            this.menuItem_RefundStatus.Size = new System.Drawing.Size(245, 32);
            this.menuItem_RefundStatus.Text = "Check Refund Status";
            this.menuItem_RefundStatus.Click += new System.EventHandler(this.menuItem_RefundStatus_Click);
            // 
            // menuItem_ViewCart
            // 
            this.menuItem_ViewCart.Name = "menuItem_ViewCart";
            this.menuItem_ViewCart.Size = new System.Drawing.Size(245, 32);
            this.menuItem_ViewCart.Text = "View Cart";
            this.menuItem_ViewCart.Click += new System.EventHandler(this.menuItem_ViewCart_Click);
            // 
            // menuItem_Feedback
            // 
            this.menuItem_Feedback.Name = "menuItem_Feedback";
            this.menuItem_Feedback.Size = new System.Drawing.Size(245, 32);
            this.menuItem_Feedback.Text = "Provide Feedback";
            this.menuItem_Feedback.Click += new System.EventHandler(this.menuItem_Feedback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.userLabell);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1417, 100);
            this.panel1.TabIndex = 9;
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
            // InProcessOrdersDgv
            // 
            this.InProcessOrdersDgv.AllowUserToAddRows = false;
            this.InProcessOrdersDgv.AllowUserToDeleteRows = false;
            this.InProcessOrdersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InProcessOrdersDgv.Location = new System.Drawing.Point(75, 233);
            this.InProcessOrdersDgv.Name = "InProcessOrdersDgv";
            this.InProcessOrdersDgv.RowHeadersWidth = 62;
            this.InProcessOrdersDgv.RowTemplate.Height = 28;
            this.InProcessOrdersDgv.Size = new System.Drawing.Size(1263, 482);
            this.InProcessOrdersDgv.TabIndex = 10;
            this.InProcessOrdersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // YourOrderlbl
            // 
            this.YourOrderlbl.AutoSize = true;
            this.YourOrderlbl.Font = new System.Drawing.Font("Microsoft Tai Le", 24F);
            this.YourOrderlbl.Location = new System.Drawing.Point(101, 138);
            this.YourOrderlbl.Name = "YourOrderlbl";
            this.YourOrderlbl.Size = new System.Drawing.Size(619, 62);
            this.YourOrderlbl.TabIndex = 11;
            this.YourOrderlbl.Text = "New and In Progress Orders";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(1097, 852);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(241, 86);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Go Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CanceledOrderIDlabel
            // 
            this.CanceledOrderIDlabel.AutoSize = true;
            this.CanceledOrderIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanceledOrderIDlabel.Location = new System.Drawing.Point(421, 765);
            this.CanceledOrderIDlabel.Name = "CanceledOrderIDlabel";
            this.CanceledOrderIDlabel.Size = new System.Drawing.Size(0, 32);
            this.CanceledOrderIDlabel.TabIndex = 13;
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
            this.DropDownMenu.Location = new System.Drawing.Point(1110, 100);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(307, 478);
            this.DropDownMenu.TabIndex = 32;
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
            // CancelOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.CanceledOrderIDlabel);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.YourOrderlbl);
            this.Controls.Add(this.InProcessOrdersDgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CheckRefStatusBtn);
            this.Controls.Add(this.openRefundFormButton);
            this.Controls.Add(this.cancelOrderBtn);
            this.Controls.Add(this.label1);
            this.Name = "CancelOrderForm";
            this.Text = "cancelOrderForm";
            this.userMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InProcessOrdersDgv)).EndInit();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Button openRefundFormButton;
        private System.Windows.Forms.Button CheckRefStatusBtn;
        private System.Windows.Forms.ContextMenuStrip userMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem_CheckMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_OrderStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItem_RefundStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ViewCart;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Feedback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userLabell;
        private System.Windows.Forms.DataGridView InProcessOrdersDgv;
        private System.Windows.Forms.Label YourOrderlbl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label CanceledOrderIDlabel;
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