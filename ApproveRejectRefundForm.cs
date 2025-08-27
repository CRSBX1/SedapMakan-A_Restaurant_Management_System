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
    public partial class ApproveRejectRefundForm : Form
    {

        private SqlConnection conn;
        private Navigation_Code Navi_Code;
        private SqlCommand SubmitResponse;
        private SqlCommand ReturnBalance;
        private SqlCommand GetBalance;
        private string cusname;
        private int RefID;
        private int UserID;
        private decimal balance;
        private decimal RefAmount;

        public ApproveRejectRefundForm(int CustomerID, int RefundID, int OrderID, string CustomerName, decimal RefundAmount, string RefundReason)
        {
            InitializeComponent();
            AccountNameLabel.Text = Username.username + " ▼";
            Navi_Code = new Navigation_Code(this);
            conn = DatabaseConn.conn;
            cusname = CustomerName;
            Titlelbl.Text = $"Approve or Reject {cusname}'s Refund Request";
            OrderIDlbl.Text = OrderID.ToString();
            RefundReasontxtbox.Text = RefundReason;
            DecisionCmb.Items.Add("Approved");
            DecisionCmb.Items.Add("Rejected");
            
            RefAmount = RefundAmount;
            RefID = RefundID;
            UserID = CustomerID;

            GetBalance = new SqlCommand("SELECT Balance From Ewallet Where UserID = @id",conn);
            GetBalance.Parameters.AddWithValue("@id", CustomerID);
            conn.Open();
            balance = Convert.ToDecimal(GetBalance.ExecuteScalar());
            conn.Close();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            SubmitResponse = new SqlCommand("INSERT INTO RefundResponse(RefundID, RespondedBy, Decision, ResponseDate, Reason) VALUES(@RefundID, @RespondedBy, @Decision, @ResponseDate, @Reason)", conn);
            SubmitResponse.Parameters.AddWithValue("@RefundID", RefID);
            SubmitResponse.Parameters.AddWithValue("@RespondedBy", Username.id);
            SubmitResponse.Parameters.AddWithValue("@Decision", DecisionCmb.SelectedItem);
            SubmitResponse.Parameters.AddWithValue("@ResponseDate", DateTime.Today);
            SubmitResponse.Parameters.AddWithValue("@Reason", Reasontxtbox.Text);

            conn.Open();
            SubmitResponse.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show($"Customer {cusname}'s refund request has been {DecisionCmb.SelectedItem}.");

            if (DecisionCmb.SelectedItem.ToString() == "Approved")
            {
                decimal updatedbalance = balance + RefAmount;

                ReturnBalance = new SqlCommand("UPDATE Ewallet SET Balance = @balance WHERE UserID = @id", conn);

                ReturnBalance.Parameters.AddWithValue("@balance", updatedbalance);
                ReturnBalance.Parameters.AddWithValue("@id", UserID);

                conn.Open();
                ReturnBalance.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"RM {RefAmount} has been refunded to customer {cusname}'s Ewallet.\nThe new Ewallet balance is {updatedbalance}");
            }
            this.Close();
        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
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
    }
}
