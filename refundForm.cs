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
    public partial class refundForm : Form
    {
        private Navigation_Code Navi_Code;
        private SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
        private SqlDataAdapter adapter;
        private SqlCommand command;
        private DataTable dt = new DataTable();

        public refundForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            userLabell.Text = $"{Username.username} ▼";
            command = new SqlCommand("SELECT Orders.OrderID FROM Orders LEFT JOIN RefundRequests ON Orders.OrderID = RefundRequests.OrderID WHERE Orders.UserID = @id AND CAST (Orders.Status AS NVARCHAR(MAX)) = @status AND RefundID IS NULL", conn);
            command.Parameters.AddWithValue("@id", Username.id);
            command.Parameters.AddWithValue("@status", "Canceled");
            conn.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();

            refundOrderComboBox.DataSource = dt;
            refundOrderComboBox.ValueMember = "OrderID";
        }

        private void submitRefundButton_Click(object sender, EventArgs e)
        {
            string orderId = refundOrderComboBox.Text.Trim();
            string reason = refundReasonTextBox.Text.Trim();
            if (string.IsNullOrEmpty(orderId) || string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Select an order and enter a reason.");
                return;
            }
            else
            {
                SqlCommand RequestRefund = new SqlCommand("INSERT INTO RefundRequests(OrderID, RequestDate, RefundReason) VALUES(@orderid, @reqdate, @refreason)", conn);
                RequestRefund.Parameters.AddWithValue("@orderid", orderId);
                RequestRefund.Parameters.AddWithValue("@reqdate", DateTime.Today);
                RequestRefund.Parameters.AddWithValue("@refreason", reason);

                conn.Open();
                RequestRefund.ExecuteNonQuery();
                conn.Close();

                dt.Clear();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

                MessageBox.Show($"A refund request regarding order {orderId} has been submitted.\nPlease wait for our staff to respond.");
                refundReasonTextBox.Clear();
            }
            
        }

        private void menuItem_CheckMenu_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_OrderStatus_Click(object sender, EventArgs e)
        {
            new orderStatusForm().ShowDialog();
        }

        private void menuItem_RefundStatus_Click(object sender, EventArgs e)
        {
            new refundStatusForm().ShowDialog();
        }

        private void menuItem_ViewCart_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_Feedback_Click(object sender, EventArgs e)
        {
            new feedbackForm().ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
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
