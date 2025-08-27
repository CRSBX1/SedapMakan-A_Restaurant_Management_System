using SedapMakan;
using SedapMakanSystemAdmin;
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


namespace SedapMakan
{
    public partial class mainForm : Form
    {

        Navigation_Code Navi_Code;
        EwalletBalance Ewallet;

        public mainForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            Ewallet = new EwalletBalance();
            userLabel.Text = $"{Username.username} ▼";
            Greetinglbl.Text = $"Welcome Customer {Username.username}";
            walletBalanceLabel.Text = $"Balance: RM {Ewallet.balance.ToString()}";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void browseMenuButton_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviViewMenuForm();
            Ewallet.UpdateBalance(walletBalanceLabel);
        }

        private void feedbackButton_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviFeedbackForm();
            Ewallet.UpdateBalance(walletBalanceLabel);
        }

        private void yourOrdersButton_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOrderStatus();
            Ewallet.UpdateBalance(walletBalanceLabel);
        }

        private void cancelOrderButton_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCancelOrder();
            Ewallet.UpdateBalance(walletBalanceLabel);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void walletBalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditOwnAccbtn_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelRefShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCancelOrder();
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

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
        }

        private void LogOutShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
        }

        private void TopUpReqBtn_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviTopUpRequestForm();
        }

        private void userLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }
    }
}
