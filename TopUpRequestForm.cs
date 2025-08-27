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
    public partial class TopUpRequestForm : Form
    {
        private EwalletBalance Ewallet;
        private SqlConnection conn;
        private SqlCommand command;
        private Navigation_Code Navi_Code;

        public TopUpRequestForm()
        {
            InitializeComponent();
            AccountNameLabel.Text = Username.username + " ▼";
            Ewallet = new EwalletBalance();
            Navi_Code = new Navigation_Code(this);
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, 0);
            conn = DatabaseConn.conn;
            WalletBalancelbl.Text = "RM " + Ewallet.balance.ToString();
            AfterBalancelbl.Text = "RM " + Ewallet.afterbalance.ToString();
        }

        private void FirstOptbtn_Click(object sender, EventArgs e)
        {
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, 10);
        }

        private void SecondOptbtn_Click(object sender, EventArgs e)
        {
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, 20);
        }

        private void ThirdOptbtn_Click(object sender, EventArgs e)
        {
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, 50);
        }

        private void FourthOptbtn_Click(object sender, EventArgs e)
        {
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, 100);
        }

        private void FifthOptbtn_Click(object sender, EventArgs e)
        {
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, 150);
        }

        private void SixthOptbtn_Click(object sender, EventArgs e)
        {
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, 200);
        }

        private void AmountReqNum_ValueChanged(object sender, EventArgs e)
        {
            Ewallet.CalculateAfterBalance(AmountReqNum, AfterBalancelbl, AmountReqNum.Value);
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReqTopUpBtn_Click(object sender, EventArgs e)
        {
            if (Ewallet.TopUpRule(AmountReqNum) == false)
            {
                return;
            }

            command = new SqlCommand("INSERT INTO TopUpRequest(WalletID, TopUpDate, TopUpAmount, RequestStatus) VALUES (@WalletID, @TopUpDate, @TopUpAmount, @RequestStatus)", conn);
            command.Parameters.AddWithValue("@WalletID", Ewallet.walletid);
            command.Parameters.AddWithValue("@TopUpDate", DateTime.Today);
            command.Parameters.AddWithValue("@TopUpAmount", AmountReqNum.Value);
            command.Parameters.AddWithValue("@RequestStatus", "In Progress");

            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("A top-up request has been made. Please wait for our staff\nto process your request.");
            AmountReqNum.Value = 0;
        }

        private void ReqProgBtn_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviTopUpRequestProgressForm();
        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void BrowseMenuShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviViewMenuForm();
        }

        private void OrderStatusShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOrderStatus();
        }

        private void ViewCartShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCartForm();
        }

        private void GiveFeedbackShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviFeedbackForm();
        }

        private void CancelRefShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCancelOrder();
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
