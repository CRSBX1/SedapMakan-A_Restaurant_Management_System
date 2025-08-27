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
    public partial class TopUpCustomerForm : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlCommand TopUp;
        private SqlCommand UpdStatus;
        private SqlCommand TransactionRecord;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private Navigation_Code Navi_Code;
        private string Accname;
        private string Email;
        private string fullname;
        private string phonenum;
        private string walletid;
        private string topupid;
        private decimal balance;
        private decimal TopUpReq;
        private decimal UpdBalance;

        public TopUpCustomerForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            AccountNameLabel.Text = Username.username + " ▼";
            CustomerDetailsPanel.Visible = false;
            conn = DatabaseConn.conn;
            command = new SqlCommand("SELECT TopUpID, AccountName AS [Account Name], Balance, TopUpDate AS [Request Date], TopUpAmount AS [Requested Amount], Email, FullName, PhoneNumber, Ewallet.WalletID FROM TopUpRequest INNER JOIN Ewallet ON EWallet.WalletID = TopUpRequest.WalletID INNER JOIN Users ON Users.UserID = Ewallet.UserID WHERE RequestStatus = @status", conn);
            command.Parameters.AddWithValue("@status", "In Progress");
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            TopUpReqDgv.DataSource = dt;
            TopUpReqDgv.RowHeadersVisible = false;
            TopUpReqDgv.Columns["Email"].Visible = false;
            TopUpReqDgv.Columns["FullName"].Visible = false;
            TopUpReqDgv.Columns["PhoneNumber"].Visible = false;
            TopUpReqDgv.Columns["WalletID"].Visible = false;
            TopUpReqDgv.Columns["TopUpID"].Visible = false;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TopUpReqDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dt.Rows.Count)
            { 
                CustomerDetailsPanel.Visible=true;
                DataGridViewRow row = TopUpReqDgv.Rows[e.RowIndex];
                topupid = row.Cells[0].Value.ToString();
                Accname = row.Cells[1].Value.ToString();
                balance = Convert.ToDecimal(row.Cells[2].Value);
                TopUpReq = Convert.ToDecimal(row.Cells[4].Value);


                foreach (DataRow datarow in dt.Rows)
                { 
                    if (datarow[0].ToString() == topupid)
                    {
                        Email = datarow[5].ToString();
                        fullname = datarow[6].ToString();
                        phonenum = datarow[7].ToString();
                        walletid = datarow[8].ToString();
                        break;
                    }
                }

                AccountNamelbl.Text = Accname;
                Emaillbl.Text = Email;
                FNamelbl.Text = fullname;
                PhoneNumlbl.Text = phonenum;
            }
        }

        private void TopUpFormBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Accname))
            {
                MessageBox.Show("Please select a customer from the table");
                return;
            }

            UpdBalance = balance + TopUpReq;
            TopUp = new SqlCommand("UPDATE Ewallet SET Balance = @balance WHERE WalletID = @id", conn);
            UpdStatus = new SqlCommand("UPDATE TopUpRequest SET RequestStatus = 'Completed' WHERE TopUpID = @id", conn);
            TransactionRecord = new SqlCommand("INSERT INTO Transactions (TransactionDate, WalletID, TransactionType, Amount) VALUES (@TransactionDate, @WalletID, @TransactionType, @Amount)", conn);
            TransactionRecord.Parameters.AddWithValue("@TransactionDate", DateTime.Today);
            TransactionRecord.Parameters.AddWithValue("@WalletID", walletid);
            TransactionRecord.Parameters.AddWithValue("@TransactionType", "Top-up");
            TransactionRecord.Parameters.AddWithValue("@Amount", TopUpReq);


            TopUp.Parameters.AddWithValue("@balance", UpdBalance);
            TopUp.Parameters.AddWithValue("@id", walletid);
            UpdStatus.Parameters.AddWithValue("@id", topupid);
            conn.Open();
            TopUp.ExecuteNonQuery();
            UpdStatus.ExecuteNonQuery();
            TransactionRecord.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show($"{Accname}'s Ewallet Balance has been updated.");
            CustomerDetailsPanel.Visible = false;
            dt.Rows.Clear();
            adapter.Fill(dt);
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
