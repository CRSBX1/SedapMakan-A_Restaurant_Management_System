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
    public partial class ReviewRefundRequests : Form
    {
        private Navigation_Code Navi_Code;
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private string CustomerName;
        private string RespondantName;
        private string RefundReason;
        private int RefundID;
        private int CustomerID; //For Update balance later on
        private int OrderID;
        private int ResponseID;
        private decimal RefundAmount;
        

        public ReviewRefundRequests()
        {
            InitializeComponent();
            AccountNameLabel.Text = Username.username + " ▼";
            Navi_Code = new Navigation_Code(this);
            conn = DatabaseConn.conn;
            command = new SqlCommand("SELECT RefundRequests.RefundID, Customer.AccountName AS [Customer Name], " +
                "Orders.OrderID, RequestDate, TotalPrice, RefundReason, RefundResponseID, ResponseDate, Decision, " +
                "Reason, Respondant.AccountName AS [Responded By], YEAR(RequestDate) AS Year, " +
                "MONTH(RequestDate) AS Month, Customer.UserID FROM RefundRequests LEFT JOIN RefundResponse ON " +
                "RefundRequests.RefundID = RefundResponse.RefundID LEFT JOIN Users AS Respondant " +
                "ON Respondant.UserID = RefundResponse.RespondedBy INNER JOIN Orders ON Orders.OrderID " +
                "= RefundRequests.OrderID INNER JOIN Users AS Customer ON Customer.UserID = " +
                "Orders.UserID WHERE (YEAR(RequestDate) = @year OR @year IS NULL) AND (MONTH(RequestDate) = " +
                "@month OR @month IS NULL)", conn);
            command.Parameters.AddWithValue("@year", DBNull.Value);
            command.Parameters.AddWithValue("@month", DBNull.Value);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            RefundRequestsDgv.DataSource = dt;
            RefundRequestsDgv.RowHeadersVisible = false;
            RefundRequestsDgv.Columns["RefundID"].Visible = false;
            RefundRequestsDgv.Columns["Year"].Visible = false;
            RefundRequestsDgv.Columns["Month"].Visible = false;
            RefundRequestsDgv.Columns["RefundResponseID"].Visible = false;
            RefundRequestsDgv.Columns["UserID"].Visible = false;
            YearCmb.Items.Add("All");
            MonthCmb.Items.Add("All");


            foreach (DataRow row in dt.Rows)
            {
                if (!YearCmb.Items.Contains(row[11].ToString()))
                {
                    YearCmb.Items.Add(row[11].ToString());
                }

                if (!MonthCmb.Items.Contains(row[12].ToString()))
                {
                    MonthCmb.Items.Add(row[12].ToString());
                }
            }
        }

        private void ApproveRejectFormBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CustomerName))
            {
                MessageBox.Show("Please choose a request from the table to be processed.");
                return;
            }

            if (ResponseID != 0)
            {
                MessageBox.Show("This request has been processed, can't be edited further.");
                return;
            }

            Navi_Code.NaviApproveorReject(CustomerID, RefundID, OrderID, CustomerName, RefundAmount, RefundReason);
            dt.Clear();
            adapter.Fill(dt);
        }

        private void YearCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (YearCmb.SelectedItem.ToString() == "All")
            {
                command.Parameters["@year"].Value = DBNull.Value;
            }
            else
            {
                command.Parameters["@year"].Value = YearCmb.SelectedItem.ToString();
            }
            adapter.Fill(dt);
        }

        private void MonthCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (MonthCmb.SelectedItem.ToString() == "All")
            {
                command.Parameters["@month"].Value = DBNull.Value;
            }
            else
            {
                command.Parameters["@month"].Value = MonthCmb.SelectedItem.ToString();
            }
            adapter.Fill(dt);
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefundRequestsDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RefundRequestsDgv.Rows[e.RowIndex];
                CustomerName = row.Cells[1].Value.ToString();
                RefundID = Convert.ToInt32(row.Cells[0].Value);
                RefundAmount = Convert.ToDecimal(row.Cells[4].Value);
                RefundReason = row.Cells[5].Value.ToString();

                foreach (DataRow datarow in dt.Rows)
                {
                    if (Convert.ToInt32(datarow[0]) == RefundID)
                    {
                        OrderID = Convert.ToInt32(datarow[2]);

                        if (datarow[6] == DBNull.Value)
                        {
                            ResponseID = 0;
                        }
                        else
                        {
                            ResponseID = Convert.ToInt32(datarow[6]);
                        }

                        CustomerID = Convert.ToInt32(datarow[13]);
                        return;
                    }
                }
            }
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
