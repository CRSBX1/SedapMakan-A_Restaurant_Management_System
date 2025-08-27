using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SedapMakan
{
    public partial class MainMenuForm : Form
    {

        private Navigation_Code Navi_Code;

        public MainMenuForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            AccountNameLabel.Text = Username.username + "▼";
            GreetingLabel.Text = $"Welcome {Username.role} {Username.username}";
        }

        private void AccountNameLabel_Click(object sender, EventArgs e) 
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void EditUserFormBtn_Click(object sender, EventArgs e) 
        {
            Navi_Code.NaviUserEdit();
        }

        private void WalletFormBtn_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviWalletUsage();
        }

        private void SalesFormBtn_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviSales();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void WalletReportShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviWalletUsage();
        }

        private void EditUserShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviUserEdit();
        }

        private void SalesShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviSales();
        }

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
        }

        private void LogOutShortcut_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void GreetingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
