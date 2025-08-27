using SedapMakan;
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
    public partial class refundStatusForm : Form
    {
        private Navigation_Code Navi_Code;
        SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
        SqlDataAdapter adapter;
        SqlCommand command;
        DataTable dt = new DataTable();

        public refundStatusForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            userLabell.Text = $"{Username.username} ▼";
            command = new SqlCommand("SELECT RefundRequests.OrderID, RefundRequests.RequestDate, TotalPrice, RefundRequests.RefundReason, RefundResponse.ResponseDate, RefundResponse.Decision, RefundResponse.Reason, Responder.AccountName AS [Responded By] FROM RefundRequests LEFT JOIN RefundResponse ON RefundRequests.RefundID = RefundResponse.RefundID LEFT JOIN Users AS Responder ON RefundResponse.RespondedBy = Responder.UserID INNER JOIN Orders ON Orders.OrderID = RefundRequests.OrderID INNER JOIN Users AS Customer ON Customer.UserID = Orders.UserID WHERE Customer.UserID = @id", conn);
            command.Parameters.AddWithValue("@id", Username.id);
            conn.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();

            refundStatusGridView.DataSource = dt;
        }

        private void refundStatusForm_Load(object sender, EventArgs e)
        {
        }

        private void refundStatusGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userLabell_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
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
    }
}
