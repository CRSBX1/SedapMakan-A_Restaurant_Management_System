namespace SedapMakanSystemAdmin
{
    partial class ViewFeedbackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFeedbackForm));
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Filterlbl = new System.Windows.Forms.Label();
            this.ViewFeedDgv = new System.Windows.Forms.DataGridView();
            this.ReplyFormBtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.FilterCmb = new System.Windows.Forms.ComboBox();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.ReviewRefundShortcut = new System.Windows.Forms.Button();
            this.TopUpShortcut = new System.Windows.Forms.Button();
            this.ViewFeedbackShortcut = new System.Windows.Forms.Button();
            this.SystemHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFeedDgv)).BeginInit();
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
            this.SystemHeader.TabIndex = 3;
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
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 24F);
            this.Titlelbl.Location = new System.Drawing.Point(112, 147);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(443, 62);
            this.Titlelbl.TabIndex = 4;
            this.Titlelbl.Text = "Customer Feedback";
            // 
            // Filterlbl
            // 
            this.Filterlbl.AutoSize = true;
            this.Filterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterlbl.Location = new System.Drawing.Point(996, 169);
            this.Filterlbl.Name = "Filterlbl";
            this.Filterlbl.Size = new System.Drawing.Size(68, 29);
            this.Filterlbl.TabIndex = 5;
            this.Filterlbl.Text = "Filter";
            // 
            // ViewFeedDgv
            // 
            this.ViewFeedDgv.AllowUserToAddRows = false;
            this.ViewFeedDgv.AllowUserToDeleteRows = false;
            this.ViewFeedDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFeedDgv.Location = new System.Drawing.Point(79, 240);
            this.ViewFeedDgv.Name = "ViewFeedDgv";
            this.ViewFeedDgv.RowHeadersWidth = 62;
            this.ViewFeedDgv.RowTemplate.Height = 28;
            this.ViewFeedDgv.Size = new System.Drawing.Size(1277, 563);
            this.ViewFeedDgv.TabIndex = 6;
            this.ViewFeedDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewFeedDgv_CellClick);
            // 
            // ReplyFormBtn
            // 
            this.ReplyFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplyFormBtn.Location = new System.Drawing.Point(172, 842);
            this.ReplyFormBtn.Name = "ReplyFormBtn";
            this.ReplyFormBtn.Size = new System.Drawing.Size(273, 90);
            this.ReplyFormBtn.TabIndex = 7;
            this.ReplyFormBtn.Text = "Reply to Feedback";
            this.ReplyFormBtn.UseVisualStyleBackColor = true;
            this.ReplyFormBtn.Click += new System.EventHandler(this.ReplyFormBtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(620, 842);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(273, 90);
            this.Backbtn.TabIndex = 8;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // FilterCmb
            // 
            this.FilterCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterCmb.FormattingEnabled = true;
            this.FilterCmb.Location = new System.Drawing.Point(1096, 166);
            this.FilterCmb.Name = "FilterCmb";
            this.FilterCmb.Size = new System.Drawing.Size(244, 37);
            this.FilterCmb.TabIndex = 9;
            this.FilterCmb.SelectedIndexChanged += new System.EventHandler(this.FilterCmb_SelectedIndexChanged);
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
            this.DropDownMenu.TabIndex = 22;
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
            // ViewFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.FilterCmb);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.ReplyFormBtn);
            this.Controls.Add(this.ViewFeedDgv);
            this.Controls.Add(this.Filterlbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.SystemHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewFeedbackForm";
            this.Text = "View Customer Feedback";
            this.Load += new System.EventHandler(this.ViewFeedbackForm_Load);
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFeedDgv)).EndInit();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label Filterlbl;
        private System.Windows.Forms.DataGridView ViewFeedDgv;
        private System.Windows.Forms.Button ReplyFormBtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.ComboBox FilterCmb;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button ReviewRefundShortcut;
        private System.Windows.Forms.Button TopUpShortcut;
        private System.Windows.Forms.Button ViewFeedbackShortcut;
    }
}