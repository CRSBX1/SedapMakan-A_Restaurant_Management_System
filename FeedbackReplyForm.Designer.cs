namespace SedapMakanSystemAdmin
{
    partial class FeedbackReplyForm
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
            this.SystemHeader = new System.Windows.Forms.Panel();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.CustmerNamelbl = new System.Windows.Forms.Label();
            this.Feedbacklbl = new System.Windows.Forms.Label();
            this.Replytxtbox = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.CustomerFeedbacktextbox = new System.Windows.Forms.TextBox();
            this.DropDownMenu = new System.Windows.Forms.Panel();
            this.LogOutShortcut = new System.Windows.Forms.Button();
            this.OwnAccountShortcut = new System.Windows.Forms.Button();
            this.ReviewRefundShortcut = new System.Windows.Forms.Button();
            this.TopUpShortcut = new System.Windows.Forms.Button();
            this.ViewFeedbackShortcut = new System.Windows.Forms.Button();
            this.SystemHeader.SuspendLayout();
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
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Tai Le", 24F);
            this.Titlelbl.Location = new System.Drawing.Point(103, 127);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(413, 62);
            this.Titlelbl.TabIndex = 5;
            this.Titlelbl.Text = "Reply to Feedback";
            // 
            // CustmerNamelbl
            // 
            this.CustmerNamelbl.AutoSize = true;
            this.CustmerNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustmerNamelbl.Location = new System.Drawing.Point(122, 237);
            this.CustmerNamelbl.Name = "CustmerNamelbl";
            this.CustmerNamelbl.Size = new System.Drawing.Size(247, 29);
            this.CustmerNamelbl.TabIndex = 6;
            this.CustmerNamelbl.Text = "Customer\'s Feedback";
            // 
            // Feedbacklbl
            // 
            this.Feedbacklbl.AutoSize = true;
            this.Feedbacklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feedbacklbl.Location = new System.Drawing.Point(122, 534);
            this.Feedbacklbl.Name = "Feedbacklbl";
            this.Feedbacklbl.Size = new System.Drawing.Size(81, 29);
            this.Feedbacklbl.TabIndex = 9;
            this.Feedbacklbl.Text = "Reply:";
            // 
            // Replytxtbox
            // 
            this.Replytxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replytxtbox.Location = new System.Drawing.Point(126, 597);
            this.Replytxtbox.Multiline = true;
            this.Replytxtbox.Name = "Replytxtbox";
            this.Replytxtbox.Size = new System.Drawing.Size(1160, 187);
            this.Replytxtbox.TabIndex = 11;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(158, 836);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(273, 90);
            this.SubmitBtn.TabIndex = 12;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(511, 836);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(273, 90);
            this.Backbtn.TabIndex = 13;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // CustomerFeedbacktextbox
            // 
            this.CustomerFeedbacktextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFeedbacktextbox.Location = new System.Drawing.Point(127, 300);
            this.CustomerFeedbacktextbox.Multiline = true;
            this.CustomerFeedbacktextbox.Name = "CustomerFeedbacktextbox";
            this.CustomerFeedbacktextbox.Size = new System.Drawing.Size(1160, 187);
            this.CustomerFeedbacktextbox.TabIndex = 14;
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
            this.DropDownMenu.TabIndex = 19;
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
            // FeedbackReplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.DropDownMenu);
            this.Controls.Add(this.CustomerFeedbacktextbox);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Replytxtbox);
            this.Controls.Add(this.Feedbacklbl);
            this.Controls.Add(this.CustmerNamelbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.SystemHeader);
            this.Name = "FeedbackReplyForm";
            this.Text = "Reply to Feedback";
            this.Load += new System.EventHandler(this.FeedbackReplyForm_Load);
            this.SystemHeader.ResumeLayout(false);
            this.SystemHeader.PerformLayout();
            this.DropDownMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SystemHeader;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label CustmerNamelbl;
        private System.Windows.Forms.Label Feedbacklbl;
        private System.Windows.Forms.TextBox Replytxtbox;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox CustomerFeedbacktextbox;
        private System.Windows.Forms.Panel DropDownMenu;
        private System.Windows.Forms.Button LogOutShortcut;
        private System.Windows.Forms.Button OwnAccountShortcut;
        private System.Windows.Forms.Button ReviewRefundShortcut;
        private System.Windows.Forms.Button TopUpShortcut;
        private System.Windows.Forms.Button ViewFeedbackShortcut;
    }
}