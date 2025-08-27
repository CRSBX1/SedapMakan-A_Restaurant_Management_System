namespace SedapMakanSystemAdmin
{
    partial class ReviewRefundRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewRefundRequests));
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.YearCmb = new System.Windows.Forms.ComboBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.ApproveRejectFormBtn = new System.Windows.Forms.Button();
            this.RefundRequestsDgv = new System.Windows.Forms.DataGridView();
            this.Yearlbl = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.MonthCmb = new System.Windows.Forms.ComboBox();
            this.Monthlbl = new System.Windows.Forms.Label();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.ReviewRefundShortcut = new System.Windows.Forms.Button();
            this.TopUpShortcut = new System.Windows.Forms.Button();
            this.ViewFeedbackShortcut = new System.Windows.Forms.Button();
            this.SystemHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefundRequestsDgv)).BeginInit();
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
            // YearCmb
            // 
            this.YearCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearCmb.FormattingEnabled = true;
            this.YearCmb.Location = new System.Drawing.Point(787, 168);
            this.YearCmb.Name = "YearCmb";
            this.YearCmb.Size = new System.Drawing.Size(204, 37);
            this.YearCmb.TabIndex = 15;
            this.YearCmb.SelectedIndexChanged += new System.EventHandler(this.YearCmb_SelectedIndexChanged);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(463, 842);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(273, 90);
            this.Backbtn.TabIndex = 14;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // ApproveRejectFormBtn
            // 
            this.ApproveRejectFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveRejectFormBtn.Location = new System.Drawing.Point(115, 842);
            this.ApproveRejectFormBtn.Name = "ApproveRejectFormBtn";
            this.ApproveRejectFormBtn.Size = new System.Drawing.Size(273, 90);
            this.ApproveRejectFormBtn.TabIndex = 13;
            this.ApproveRejectFormBtn.Text = "Approve/Reject Request";
            this.ApproveRejectFormBtn.UseVisualStyleBackColor = true;
            this.ApproveRejectFormBtn.Click += new System.EventHandler(this.ApproveRejectFormBtn_Click);
            // 
            // RefundRequestsDgv
            // 
            this.RefundRequestsDgv.AllowUserToAddRows = false;
            this.RefundRequestsDgv.AllowUserToDeleteRows = false;
            this.RefundRequestsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RefundRequestsDgv.Location = new System.Drawing.Point(71, 248);
            this.RefundRequestsDgv.Name = "RefundRequestsDgv";
            this.RefundRequestsDgv.RowHeadersWidth = 62;
            this.RefundRequestsDgv.RowTemplate.Height = 28;
            this.RefundRequestsDgv.Size = new System.Drawing.Size(1277, 563);
            this.RefundRequestsDgv.TabIndex = 12;
            this.RefundRequestsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RefundRequestsDgv_CellClick);
            // 
            // Yearlbl
            // 
            this.Yearlbl.AutoSize = true;
            this.Yearlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearlbl.Location = new System.Drawing.Point(687, 171);
            this.Yearlbl.Name = "Yearlbl";
            this.Yearlbl.Size = new System.Drawing.Size(64, 29);
            this.Yearlbl.TabIndex = 11;
            this.Yearlbl.Text = "Year";
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 24F);
            this.Titlelbl.Location = new System.Drawing.Point(104, 149);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(381, 62);
            this.Titlelbl.TabIndex = 10;
            this.Titlelbl.Text = "Refund Requests";
            // 
            // MonthCmb
            // 
            this.MonthCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthCmb.FormattingEnabled = true;
            this.MonthCmb.Location = new System.Drawing.Point(1132, 168);
            this.MonthCmb.Name = "MonthCmb";
            this.MonthCmb.Size = new System.Drawing.Size(204, 37);
            this.MonthCmb.TabIndex = 17;
            this.MonthCmb.SelectedIndexChanged += new System.EventHandler(this.MonthCmb_SelectedIndexChanged);
            // 
            // Monthlbl
            // 
            this.Monthlbl.AutoSize = true;
            this.Monthlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthlbl.Location = new System.Drawing.Point(1032, 171);
            this.Monthlbl.Name = "Monthlbl";
            this.Monthlbl.Size = new System.Drawing.Size(79, 29);
            this.Monthlbl.TabIndex = 16;
            this.Monthlbl.Text = "Month";
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
            this.DropDownMenu.TabIndex = 18;
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
            // ReviewRefundRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.MonthCmb);
            this.Controls.Add(this.Monthlbl);
            this.Controls.Add(this.YearCmb);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.ApproveRejectFormBtn);
            this.Controls.Add(this.RefundRequestsDgv);
            this.Controls.Add(this.Yearlbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.SystemHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReviewRefundRequests";
            this.Text = "Review Refund Requests";
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefundRequestsDgv)).EndInit();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.ComboBox YearCmb;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button ApproveRejectFormBtn;
        private System.Windows.Forms.DataGridView RefundRequestsDgv;
        private System.Windows.Forms.Label Yearlbl;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.ComboBox MonthCmb;
        private System.Windows.Forms.Label Monthlbl;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button ReviewRefundShortcut;
        private System.Windows.Forms.Button TopUpShortcut;
        private System.Windows.Forms.Button ViewFeedbackShortcut;
    }
}