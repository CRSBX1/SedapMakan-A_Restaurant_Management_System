namespace SedapMakan
{
    partial class ManageMenuForm
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
            this.dataGridMenu = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMenuName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.Filterlabel = new System.Windows.Forms.Label();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogoutShortcut = new System.Windows.Forms.Button();
            this.EditOwnAccShortcut = new System.Windows.Forms.Button();
            this.ViewOrderShortcut = new System.Windows.Forms.Button();
            this.ManageMenuShortcut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.DropDownMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridMenu
            // 
            this.dataGridMenu.AllowUserToAddRows = false;
            this.dataGridMenu.AllowUserToResizeRows = false;
            this.dataGridMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridMenu.Location = new System.Drawing.Point(83, 260);
            this.dataGridMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridMenu.Name = "dataGridMenu";
            this.dataGridMenu.RowHeadersVisible = false;
            this.dataGridMenu.RowHeadersWidth = 51;
            this.dataGridMenu.RowTemplate.Height = 24;
            this.dataGridMenu.Size = new System.Drawing.Size(1406, 465);
            this.dataGridMenu.TabIndex = 0;
            this.dataGridMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMenu_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(83, 1055);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 75);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1264, 1055);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(225, 75);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Main Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(381, 1055);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(225, 75);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(968, 1055);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(225, 75);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(676, 1055);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(225, 75);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMenuName
            // 
            this.txtMenuName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMenuName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenuName.Location = new System.Drawing.Point(83, 822);
            this.txtMenuName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(506, 39);
            this.txtMenuName.TabIndex = 7;
            this.txtMenuName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMenuName_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 912);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(975, 758);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 45);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category";
            // 
            // chkAvailable
            // 
            this.chkAvailable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAvailable.Location = new System.Drawing.Point(983, 970);
            this.chkAvailable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(182, 49);
            this.chkAvailable.TabIndex = 12;
            this.chkAvailable.Text = "Available";
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(983, 822);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(506, 40);
            this.cmbCategory.TabIndex = 13;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategory_KeyPress);
            // 
            // numPrice
            // 
            this.numPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Location = new System.Drawing.Point(83, 979);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(506, 39);
            this.numPrice.TabIndex = 14;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(609, 148);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(419, 76);
            this.lblWelcome.TabIndex = 15;
            this.lblWelcome.Text = "Manage Menu";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.AccountNameLabel);
            this.panelHeader.Controls.Add(this.lblAppName);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1600, 94);
            this.panelHeader.TabIndex = 16;
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
            this.AccountNameLabel.TabIndex = 45;
            this.AccountNameLabel.Text = "Alfred William ▼";
            this.AccountNameLabel.Click += new System.EventHandler(this.AccountNameLabel_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Palatino Linotype", 22F);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(21, 16);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(281, 59);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "SedapMakan";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(1290, 185);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(199, 33);
            this.FilterComboBox.TabIndex = 17;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Filterlabel
            // 
            this.Filterlabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Filterlabel.AutoSize = true;
            this.Filterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterlabel.Location = new System.Drawing.Point(1206, 189);
            this.Filterlabel.Name = "Filterlabel";
            this.Filterlabel.Size = new System.Drawing.Size(66, 26);
            this.Filterlabel.TabIndex = 18;
            this.Filterlabel.Text = "Filter:";
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
            // ManageMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1221);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.Filterlabel);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManageMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Menu Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMenuName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.Label Filterlabel;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogoutShortcut;
        private System.Windows.Forms.Button EditOwnAccShortcut;
        private System.Windows.Forms.Button ViewOrderShortcut;
        private System.Windows.Forms.Button ManageMenuShortcut;
        private System.Windows.Forms.Label AccountNameLabel;
    }
}