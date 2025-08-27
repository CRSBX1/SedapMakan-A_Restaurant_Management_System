using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedapMakan
{
    public partial class ChefHomeForm : Form
    {

        private Navigation_Code Navi_Code;

        public ChefHomeForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            DropDownMenu.Visible = false;
            AccountNameLabel.Text = Username.username + " ▼";
            lblWelcome.Text = $"Welcome, Chef {Username.username}";
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviManageMenu();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviViewOrders();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           Navi_Code.NaviExit();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void ManageMenuShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviManageMenu();
        }

        private void ViewOrderShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviViewOrders();
        }

        private void EditOwnAccShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
        }

        private void LogoutShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
        }
    }
}
