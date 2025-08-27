namespace SedapMakan
{
    partial class ViewOrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridOrders = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.dataGridOrderItems = new System.Windows.Forms.DataGridView();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.cmbDateFilter = new System.Windows.Forms.ComboBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogoutShortcut = new System.Windows.Forms.Button();
            this.EditOwnAccShortcut = new System.Windows.Forms.Button();
            this.ViewOrderShortcut = new System.Windows.Forms.Button();
            this.ManageMenuShortcut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItems)).BeginInit();
            this.grpOrderDetails.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.DropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(558, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Orders";
            // 
            // dataGridOrders
            // 
            this.dataGridOrders.AllowUserToAddRows = false;
            this.dataGridOrders.AllowUserToResizeColumns = false;
            this.dataGridOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOrders.Location = new System.Drawing.Point(86, 173);
            this.dataGridOrders.Name = "dataGridOrders";
            this.dataGridOrders.RowHeadersVisible = false;
            this.dataGridOrders.RowHeadersWidth = 51;
            this.dataGridOrders.RowTemplate.Height = 24;
            this.dataGridOrders.Size = new System.Drawing.Size(1250, 342);
            this.dataGridOrders.TabIndex = 1;
            this.dataGridOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrders_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnBack.Location = new System.Drawing.Point(1136, 890);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 60);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnClear.Location = new System.Drawing.Point(912, 890);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 60);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(1163, 129);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(173, 31);
            this.cmbStatusFilter.TabIndex = 16;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Details";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(5, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(5, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "Action";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrderId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(178, 78);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(182, 34);
            this.txtOrderId.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(178, 138);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(182, 34);
            this.txtCustomerName.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(178, 191);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(182, 34);
            this.txtTotal.TabIndex = 10;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(178, 242);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(182, 34);
            this.txtStatus.TabIndex = 11;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAction.Location = new System.Drawing.Point(178, 297);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(182, 34);
            this.btnAction.TabIndex = 12;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // dataGridOrderItems
            // 
            this.dataGridOrderItems.AllowUserToAddRows = false;
            this.dataGridOrderItems.AllowUserToResizeColumns = false;
            this.dataGridOrderItems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrderItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOrderItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridOrderItems.Location = new System.Drawing.Point(438, 15);
            this.dataGridOrderItems.Name = "dataGridOrderItems";
            this.dataGridOrderItems.RowHeadersVisible = false;
            this.dataGridOrderItems.RowHeadersWidth = 51;
            this.dataGridOrderItems.RowTemplate.Height = 24;
            this.dataGridOrderItems.Size = new System.Drawing.Size(820, 303);
            this.dataGridOrderItems.TabIndex = 13;
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grpOrderDetails.Controls.Add(this.dataGridOrderItems);
            this.grpOrderDetails.Controls.Add(this.btnAction);
            this.grpOrderDetails.Controls.Add(this.txtStatus);
            this.grpOrderDetails.Controls.Add(this.txtTotal);
            this.grpOrderDetails.Controls.Add(this.txtCustomerName);
            this.grpOrderDetails.Controls.Add(this.txtOrderId);
            this.grpOrderDetails.Controls.Add(this.label7);
            this.grpOrderDetails.Controls.Add(this.label6);
            this.grpOrderDetails.Controls.Add(this.label5);
            this.grpOrderDetails.Controls.Add(this.label4);
            this.grpOrderDetails.Controls.Add(this.label3);
            this.grpOrderDetails.Controls.Add(this.label2);
            this.grpOrderDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderDetails.Location = new System.Drawing.Point(78, 535);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(1271, 349);
            this.grpOrderDetails.TabIndex = 17;
            this.grpOrderDetails.TabStop = false;
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderCount.Location = new System.Drawing.Point(83, 516);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(0, 23);
            this.lblOrderCount.TabIndex = 18;
            // 
            // cmbDateFilter
            // 
            this.cmbDateFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateFilter.FormattingEnabled = true;
            this.cmbDateFilter.Location = new System.Drawing.Point(972, 129);
            this.cmbDateFilter.Name = "cmbDateFilter";
            this.cmbDateFilter.Size = new System.Drawing.Size(173, 31);
            this.cmbDateFilter.TabIndex = 19;
            this.cmbDateFilter.SelectedIndexChanged += new System.EventHandler(this.cmbDateFilter_SelectedIndexChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.AccountNameLabel);
            this.panelHeader.Controls.Add(this.lblAppName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1422, 75);
            this.panelHeader.TabIndex = 20;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.ForeColor = System.Drawing.Color.White;
            this.AccountNameLabel.Location = new System.Drawing.Point(1195, 28);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(204, 31);
            this.AccountNameLabel.TabIndex = 23;
            this.AccountNameLabel.Text = "Alfred William ▼";
            this.AccountNameLabel.Click += new System.EventHandler(this.AccountNameLabel_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Palatino Linotype", 22F);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(19, 13);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(236, 50);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "SedapMakan";
            // 
            // DropDownMenu
            // 
            this.DropDownMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.DropDownMenu.Controls.Add(this.LogoutShortcut);
            this.DropDownMenu.Controls.Add(this.EditOwnAccShortcut);
            this.DropDownMenu.Controls.Add(this.ViewOrderShortcut);
            this.DropDownMenu.Controls.Add(this.ManageMenuShortcut);
            this.DropDownMenu.Location = new System.Drawing.Point(1149, 75);
            this.DropDownMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DropDownMenu.Name = "DropDownMenu";
            this.DropDownMenu.Size = new System.Drawing.Size(273, 223);
            this.DropDownMenu.TabIndex = 44;
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
            this.LogoutShortcut.Location = new System.Drawing.Point(0, 161);
            this.LogoutShortcut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutShortcut.Name = "LogoutShortcut";
            this.LogoutShortcut.Size = new System.Drawing.Size(273, 54);
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
            this.EditOwnAccShortcut.Location = new System.Drawing.Point(0, 107);
            this.EditOwnAccShortcut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditOwnAccShortcut.Name = "EditOwnAccShortcut";
            this.EditOwnAccShortcut.Size = new System.Drawing.Size(273, 54);
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
            this.ViewOrderShortcut.Location = new System.Drawing.Point(0, 54);
            this.ViewOrderShortcut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewOrderShortcut.Name = "ViewOrderShortcut";
            this.ViewOrderShortcut.Size = new System.Drawing.Size(273, 54);
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
            this.ManageMenuShortcut.Location = new System.Drawing.Point(0, -5);
            this.ManageMenuShortcut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManageMenuShortcut.Name = "ManageMenuShortcut";
            this.ManageMenuShortcut.Size = new System.Drawing.Size(273, 54);
            this.ManageMenuShortcut.TabIndex = 3;
            this.ManageMenuShortcut.Text = "Manage Menu";
            this.ManageMenuShortcut.UseVisualStyleBackColor = false;
            this.ManageMenuShortcut.Click += new System.EventHandler(this.ManageMenuShortcut_Click);
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 844);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.cmbDateFilter);
            this.Controls.Add(this.lblOrderCount);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridOrders);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Orders Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderItems)).EndInit();
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridOrders;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.DataGridView dataGridOrderItems;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.ComboBox cmbDateFilter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogoutShortcut;
        private System.Windows.Forms.Button EditOwnAccShortcut;
        private System.Windows.Forms.Button ViewOrderShortcut;
        private System.Windows.Forms.Button ManageMenuShortcut;
    }
}