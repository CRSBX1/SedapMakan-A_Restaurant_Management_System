namespace SedapMakan
{
    partial class ViewMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMenuForm));
            this.Categorylbl = new System.Windows.Forms.Label();
            this.viewCartBtn = new System.Windows.Forms.Button();
            this.userMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_CheckMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_OrderStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_RefundStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_ViewCart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Feedback = new System.Windows.Forms.ToolStripMenuItem();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.walletBalanceLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.MenudataGridView = new System.Windows.Forms.DataGridView();
            this.NameDesignatorlbl = new System.Windows.Forms.Label();
            this.ItemNamelbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.PriceDesignationlbl = new System.Windows.Forms.Label();
            this.AmountDesignationlbl = new System.Windows.Forms.Label();
            this.AddCartBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AmountNum = new System.Windows.Forms.NumericUpDown();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.TotalPricelbl = new System.Windows.Forms.Label();
            this.TotalPriceDesignationlbl = new System.Windows.Forms.Label();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.CancelRefShortcut = new System.Windows.Forms.Button();
            this.ViewCartShortcut = new System.Windows.Forms.Button();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.GiveFeedbackShortcut = new System.Windows.Forms.Button();
            this.OrderStatusShortcut = new System.Windows.Forms.Button();
            this.BrowseMenuShortcut = new System.Windows.Forms.Button();
            this.Filterdesignationlbl = new System.Windows.Forms.Label();
            this.FilterCategorycomboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalOrderPricelbl = new System.Windows.Forms.Label();
            this.CartPricelbl = new System.Windows.Forms.Label();
            this.userMenuStrip.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenudataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
            this.OrderPanel.SuspendLayout();
            this.DropDownMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Categorylbl
            // 
            this.Categorylbl.AutoSize = true;
            this.Categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylbl.Location = new System.Drawing.Point(256, 174);
            this.Categorylbl.Name = "Categorylbl";
            this.Categorylbl.Size = new System.Drawing.Size(321, 40);
            this.Categorylbl.TabIndex = 0;
            this.Categorylbl.Text = "Our Special Menu";
            // 
            // viewCartBtn
            // 
            this.viewCartBtn.BackColor = System.Drawing.Color.LightGreen;
            this.viewCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCartBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewCartBtn.Location = new System.Drawing.Point(805, 872);
            this.viewCartBtn.Name = "viewCartBtn";
            this.viewCartBtn.Size = new System.Drawing.Size(239, 72);
            this.viewCartBtn.TabIndex = 23;
            this.viewCartBtn.Text = "View Cart";
            this.viewCartBtn.UseVisualStyleBackColor = false;
            this.viewCartBtn.Click += new System.EventHandler(this.viewCartButton_Click);
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
            // 
            // menuItem_OrderStatus
            // 
            this.menuItem_OrderStatus.Name = "menuItem_OrderStatus";
            this.menuItem_OrderStatus.Size = new System.Drawing.Size(245, 32);
            this.menuItem_OrderStatus.Text = "Check Order Status";
            // 
            // menuItem_RefundStatus
            // 
            this.menuItem_RefundStatus.Name = "menuItem_RefundStatus";
            this.menuItem_RefundStatus.Size = new System.Drawing.Size(245, 32);
            this.menuItem_RefundStatus.Text = "Check Refund Status";
            // 
            // menuItem_ViewCart
            // 
            this.menuItem_ViewCart.Name = "menuItem_ViewCart";
            this.menuItem_ViewCart.Size = new System.Drawing.Size(245, 32);
            this.menuItem_ViewCart.Text = "View Cart";
            // 
            // menuItem_Feedback
            // 
            this.menuItem_Feedback.Name = "menuItem_Feedback";
            this.menuItem_Feedback.Size = new System.Drawing.Size(245, 32);
            this.menuItem_Feedback.Text = "Provide Feedback";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.HeaderPanel.Controls.Add(this.walletBalanceLabel);
            this.HeaderPanel.Controls.Add(this.label6);
            this.HeaderPanel.Controls.Add(this.userLabel);
            this.HeaderPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HeaderPanel.Location = new System.Drawing.Point(1, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1417, 100);
            this.HeaderPanel.TabIndex = 43;
            // 
            // walletBalanceLabel
            // 
            this.walletBalanceLabel.AutoSize = true;
            this.walletBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletBalanceLabel.ForeColor = System.Drawing.Color.YellowGreen;
            this.walletBalanceLabel.Location = new System.Drawing.Point(596, 37);
            this.walletBalanceLabel.Name = "walletBalanceLabel";
            this.walletBalanceLabel.Size = new System.Drawing.Size(239, 32);
            this.walletBalanceLabel.TabIndex = 54;
            this.walletBalanceLabel.Text = "Balance: RM 0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 26F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 70);
            this.label6.TabIndex = 0;
            this.label6.Text = "SedapMakan";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.userLabel.Location = new System.Drawing.Point(1147, 34);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(232, 37);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Amlan Kesari⏷\r\n";
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // MenudataGridView
            // 
            this.MenudataGridView.AllowUserToAddRows = false;
            this.MenudataGridView.AllowUserToDeleteRows = false;
            this.MenudataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenudataGridView.Location = new System.Drawing.Point(75, 278);
            this.MenudataGridView.MultiSelect = false;
            this.MenudataGridView.Name = "MenudataGridView";
            this.MenudataGridView.RowHeadersWidth = 62;
            this.MenudataGridView.RowTemplate.Height = 28;
            this.MenudataGridView.Size = new System.Drawing.Size(618, 603);
            this.MenudataGridView.TabIndex = 44;
            this.MenudataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenudataGridView_CellClick);
            // 
            // NameDesignatorlbl
            // 
            this.NameDesignatorlbl.AutoSize = true;
            this.NameDesignatorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameDesignatorlbl.Location = new System.Drawing.Point(34, 33);
            this.NameDesignatorlbl.Name = "NameDesignatorlbl";
            this.NameDesignatorlbl.Size = new System.Drawing.Size(171, 32);
            this.NameDesignatorlbl.TabIndex = 45;
            this.NameDesignatorlbl.Text = "Menu name:";
            // 
            // ItemNamelbl
            // 
            this.ItemNamelbl.AutoSize = true;
            this.ItemNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNamelbl.Location = new System.Drawing.Point(242, 33);
            this.ItemNamelbl.Name = "ItemNamelbl";
            this.ItemNamelbl.Size = new System.Drawing.Size(92, 32);
            this.ItemNamelbl.TabIndex = 46;
            this.ItemNamelbl.Text = "label3";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelbl.Location = new System.Drawing.Point(158, 107);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(92, 32);
            this.Pricelbl.TabIndex = 48;
            this.Pricelbl.Text = "label3";
            // 
            // PriceDesignationlbl
            // 
            this.PriceDesignationlbl.AutoSize = true;
            this.PriceDesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceDesignationlbl.Location = new System.Drawing.Point(34, 107);
            this.PriceDesignationlbl.Name = "PriceDesignationlbl";
            this.PriceDesignationlbl.Size = new System.Drawing.Size(87, 32);
            this.PriceDesignationlbl.TabIndex = 47;
            this.PriceDesignationlbl.Text = "Price:";
            // 
            // AmountDesignationlbl
            // 
            this.AmountDesignationlbl.AutoSize = true;
            this.AmountDesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountDesignationlbl.Location = new System.Drawing.Point(35, 180);
            this.AmountDesignationlbl.Name = "AmountDesignationlbl";
            this.AmountDesignationlbl.Size = new System.Drawing.Size(120, 32);
            this.AmountDesignationlbl.TabIndex = 49;
            this.AmountDesignationlbl.Text = "Amount:";
            // 
            // AddCartBtn
            // 
            this.AddCartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCartBtn.Location = new System.Drawing.Point(40, 350);
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.Size = new System.Drawing.Size(239, 71);
            this.AddCartBtn.TabIndex = 51;
            this.AddCartBtn.Text = "Add to cart";
            this.AddCartBtn.UseVisualStyleBackColor = true;
            this.AddCartBtn.Click += new System.EventHandler(this.AddCartBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(1084, 872);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(239, 71);
            this.BackBtn.TabIndex = 52;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AmountNum
            // 
            this.AmountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AmountNum.Location = new System.Drawing.Point(206, 178);
            this.AmountNum.Name = "AmountNum";
            this.AmountNum.Size = new System.Drawing.Size(120, 39);
            this.AmountNum.TabIndex = 53;
            this.AmountNum.ValueChanged += new System.EventHandler(this.AmountNum_ValueChanged);
            // 
            // OrderPanel
            // 
            this.OrderPanel.Controls.Add(this.TotalPricelbl);
            this.OrderPanel.Controls.Add(this.TotalPriceDesignationlbl);
            this.OrderPanel.Controls.Add(this.AmountNum);
            this.OrderPanel.Controls.Add(this.AddCartBtn);
            this.OrderPanel.Controls.Add(this.AmountDesignationlbl);
            this.OrderPanel.Controls.Add(this.Pricelbl);
            this.OrderPanel.Controls.Add(this.PriceDesignationlbl);
            this.OrderPanel.Controls.Add(this.ItemNamelbl);
            this.OrderPanel.Controls.Add(this.NameDesignatorlbl);
            this.OrderPanel.Location = new System.Drawing.Point(763, 364);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(605, 476);
            this.OrderPanel.TabIndex = 54;
            // 
            // TotalPricelbl
            // 
            this.TotalPricelbl.AutoSize = true;
            this.TotalPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPricelbl.Location = new System.Drawing.Point(234, 260);
            this.TotalPricelbl.Name = "TotalPricelbl";
            this.TotalPricelbl.Size = new System.Drawing.Size(80, 32);
            this.TotalPricelbl.TabIndex = 55;
            this.TotalPricelbl.Text = "RM 0";
            // 
            // TotalPriceDesignationlbl
            // 
            this.TotalPriceDesignationlbl.AutoSize = true;
            this.TotalPriceDesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceDesignationlbl.Location = new System.Drawing.Point(34, 260);
            this.TotalPriceDesignationlbl.Name = "TotalPriceDesignationlbl";
            this.TotalPriceDesignationlbl.Size = new System.Drawing.Size(158, 32);
            this.TotalPriceDesignationlbl.TabIndex = 54;
            this.TotalPriceDesignationlbl.Text = "Total Price:";
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
            this.DropDownMenu.TabIndex = 55;
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
            // Filterdesignationlbl
            // 
            this.Filterdesignationlbl.AutoSize = true;
            this.Filterdesignationlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterdesignationlbl.Location = new System.Drawing.Point(888, 185);
            this.Filterdesignationlbl.Name = "Filterdesignationlbl";
            this.Filterdesignationlbl.Size = new System.Drawing.Size(74, 29);
            this.Filterdesignationlbl.TabIndex = 56;
            this.Filterdesignationlbl.Text = "Filter";
            // 
            // FilterCategorycomboBox
            // 
            this.FilterCategorycomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCategorycomboBox.FormattingEnabled = true;
            this.FilterCategorycomboBox.Location = new System.Drawing.Point(1013, 182);
            this.FilterCategorycomboBox.Name = "FilterCategorycomboBox";
            this.FilterCategorycomboBox.Size = new System.Drawing.Size(204, 37);
            this.FilterCategorycomboBox.TabIndex = 57;
            this.FilterCategorycomboBox.SelectedIndexChanged += new System.EventHandler(this.FilterCategorycomboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // TotalOrderPricelbl
            // 
            this.TotalOrderPricelbl.AutoSize = true;
            this.TotalOrderPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrderPricelbl.Location = new System.Drawing.Point(792, 293);
            this.TotalOrderPricelbl.Name = "TotalOrderPricelbl";
            this.TotalOrderPricelbl.Size = new System.Drawing.Size(305, 32);
            this.TotalOrderPricelbl.TabIndex = 56;
            this.TotalOrderPricelbl.Text = "In-cart Item Total Price:";
            // 
            // CartPricelbl
            // 
            this.CartPricelbl.AutoSize = true;
            this.CartPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartPricelbl.Location = new System.Drawing.Point(1149, 293);
            this.CartPricelbl.Name = "CartPricelbl";
            this.CartPricelbl.Size = new System.Drawing.Size(166, 32);
            this.CartPricelbl.TabIndex = 56;
            this.CartPricelbl.Text = "Placeholder";
            // 
            // ViewMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.TotalOrderPricelbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Filterdesignationlbl);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.MenudataGridView);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.viewCartBtn);
            this.Controls.Add(this.Categorylbl);
            this.Controls.Add(this.FilterCategorycomboBox);
            this.Controls.Add(this.CartPricelbl);
            this.Name = "ViewMenuForm";
            this.Text = "View Menu Form";
            this.userMenuStrip.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenudataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Categorylbl;
        private System.Windows.Forms.Button viewCartBtn;
        private System.Windows.Forms.ContextMenuStrip userMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem_CheckMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_OrderStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItem_RefundStatus;
        private System.Windows.Forms.ToolStripMenuItem menuItem_ViewCart;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Feedback;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView MenudataGridView;
        private System.Windows.Forms.Label ItemNamelbl;
        private System.Windows.Forms.Label NameDesignatorlbl;
        private System.Windows.Forms.Label Pricelbl;
        private System.Windows.Forms.Label PriceDesignationlbl;
        private System.Windows.Forms.Label AmountDesignationlbl;
        private System.Windows.Forms.Button AddCartBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.NumericUpDown AmountNum;
        private System.Windows.Forms.Label walletBalanceLabel;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Label TotalPricelbl;
        private System.Windows.Forms.Label TotalPriceDesignationlbl;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button CancelRefShortcut;
        private System.Windows.Forms.Button ViewCartShortcut;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button GiveFeedbackShortcut;
        private System.Windows.Forms.Button OrderStatusShortcut;
        private System.Windows.Forms.Button BrowseMenuShortcut;
        private System.Windows.Forms.Label Filterdesignationlbl;
        private System.Windows.Forms.ComboBox FilterCategorycomboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TotalOrderPricelbl;
        private System.Windows.Forms.Label CartPricelbl;
    }
}