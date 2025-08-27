using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using SedapMakan;

namespace SedapMakanSystemAdmin
{
    public partial class ViewFeedbackForm : Form
    {
        private Navigation_Code Navi_Code;
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private List<string> RespondIDs = new List<string>();
        private string feedbackid;
        private string feedback;
        private string customername;
        private string response;
        private string respondid;

        public ViewFeedbackForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            dt.Clear();
            AccountNameLabel.Text = Username.username + " ▼";
            conn = DatabaseConn.conn;
            command = new SqlCommand("SELECT Feedback.FeedbackID, Customer.AccountName AS [Customer Name], Feedback.OrderID, Rating, Comments, Response, Respondant.AccountName AS [Responded By], ResponseID FROM Feedback LEFT JOIN FeedbackResponse ON Feedback.FeedbackID = FeedbackResponse.FeedbackID LEFT JOIN Users AS Respondant ON Respondant.UserID = FeedbackResponse.RespondedBy INNER JOIN Orders ON Orders.OrderID = Feedback.OrderID INNER JOIN Users AS Customer ON Customer.UserID = Orders.UserID WHERE (@Condition = 'Answered' AND FeedbackResponse.ResponseID IS NOT NULL) OR (@Condition = 'Unanswered' AND FeedbackResponse.ResponseID IS NULL) OR @Condition IS NULL;", conn);
            command.Parameters.AddWithValue("@Condition", DBNull.Value);

            conn.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();

            ViewFeedDgv.DataSource = dt;
            ViewFeedDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewFeedDgv.Columns["ResponseID"].Visible = false;
            ViewFeedDgv.Columns["FeedbackID"].Visible = false;
            FilterCmb.Items.Add("All");
            FilterCmb.Items.Add("Unanswered");
            FilterCmb.Items.Add("Answered");
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewFeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void FilterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (FilterCmb.SelectedItem.ToString() == "All")
            {
                command.Parameters["@Condition"].Value = DBNull.Value;
            }
            else
            {
                command.Parameters["@Condition"].Value = FilterCmb.SelectedItem.ToString();
            }
            adapter.Fill(dt);
        }

        private void ViewFeedDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex<ViewFeedDgv.Rows.Count)
            {
                DataGridViewRow row = ViewFeedDgv.Rows[e.RowIndex];
                if (row.IsNewRow) return;

                feedbackid = row.Cells[0].Value.ToString();
                customername = row.Cells[1].Value.ToString();
                feedback = row.Cells[4].Value.ToString();
                response = row.Cells[5].Value.ToString();
                respondid = row.Cells[7].Value.ToString();
            }
                

        }
        
        private void ReplyFormBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(feedbackid) || String.IsNullOrEmpty(customername))
            {
                MessageBox.Show("Please select a customer's feedback to be replied to\nby selecting it from the table");
                return;
            }

            Navi_Code.NaviFeedbackReply(feedback, customername, feedbackid, response, respondid);
            dt.Rows.Clear();
            adapter.Fill(dt);
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
