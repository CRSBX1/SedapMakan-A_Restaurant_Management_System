using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedapMakan;

namespace SedapMakanSystemAdmin
{
    public partial class FeedbackReplyForm : Form
    {

        private SqlConnection conn;
        private SqlCommand command;
        private string FeedbackID;
        private bool state = true;
        private string respondid;
        private FeedbackReplyRule txtload = new FeedbackReplyRule();
        private Navigation_Code Navi_Code;

        public FeedbackReplyForm(string feedback, string customername, string feedbackID, string response, string respondid)
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            AccountNameLabel.Text = Username.username + " ▼";
            FeedbackID = feedbackID;
            this.respondid = respondid;
            conn = DatabaseConn.conn;
            CustomerFeedbacktextbox.Text = feedback;
            CustomerFeedbacktextbox.ReadOnly = true;
            Replytxtbox.Text = response;
            CustmerNamelbl.Text = $"{customername}'s Feedback:";

            if (!string.IsNullOrEmpty(response))
            {
                SubmitBtn.Text = "Save Changes";
            }
        }

        private void FeedbackReplyForm_Load(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (txtload.ReplyRule(Replytxtbox) == false)
            {
                return;
            }

            command = txtload.UpdateForm(command, SubmitBtn, Replytxtbox, respondid, conn, FeedbackID);

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Reply has been saved.");
        }

        private void ViewFeedbackShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviViewFeedback();
        }

        private void TopUpShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviTopUpCustomer();
        }

        private void ReviewRefundShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviReviewRefund();
        }

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
        }

        private void LogOutShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }
    }
}
