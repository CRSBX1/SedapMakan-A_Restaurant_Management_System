using SedapMakan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SedapMakan
{

    public partial class CancelOrderForm : Form
    {

        private SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
        private Navigation_Code Navi_Code;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private string orderid;
        private SqlCommand command;

        public CancelOrderForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            userLabell.Text = $"{Username.username} ▼";
            command = new SqlCommand("SELECT OrderID, OrderDate, Status, TotalPrice FROM Orders WHERE UserID = @id AND CAST(Status AS NVARCHAR(MAX)) IN (@new, @inpro)", conn);
            command.Parameters.AddWithValue("@id", Username.id);
            command.Parameters.AddWithValue("@new", "New");
            command.Parameters.AddWithValue("@inpro", "In Progress");
            conn.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();
            InProcessOrdersDgv.DataSource = dt;
            InProcessOrdersDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cancelOrderButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CanceledOrderIDlabel.Text))
            {
                MessageBox.Show("Please select an order to be removed.");
            }
            else
            {
                SqlCommand Updcommand = new SqlCommand("UPDATE Orders SET Status = @status WHERE OrderID = @id", conn);
                Updcommand.Parameters.AddWithValue("@status", "Canceled");
                Updcommand.Parameters.AddWithValue("@id", orderid);
                conn.Open();
                Updcommand.ExecuteNonQuery();
                dt.Clear();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                conn.Close();
                MessageBox.Show($"Your order with the order id of {orderid} has been canceled");
                CanceledOrderIDlabel.Text = string.Empty;
            }
        }

        private void openRefundFormButton_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviRefundForm();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = InProcessOrdersDgv.Rows[e.RowIndex];
                orderid = row.Cells[0].Value.ToString();
                CanceledOrderIDlabel.Text = orderid;
            }
        }

        private void CheckRefStatusBtn_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviRefundStatusForm();
        }

        private void menuItem_CheckMenu_Click(object sender, EventArgs e)
        {
            //new menuForm().ShowDialog();
        }

        private void menuItem_OrderStatus_Click(object sender, EventArgs e)
        {
            //new orderStatusForm().ShowDialog();
        }

        private void menuItem_RefundStatus_Click(object sender, EventArgs e)
        {
            //new refundStatusForm().ShowDialog();
        }

        private void menuItem_ViewCart_Click(object sender, EventArgs e)
        {
            //new cartForm().ShowDialog();
        }

        private void menuItem_Feedback_Click(object sender, EventArgs e)
        {
            //new feedbackForm().ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
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

        private void userLabell_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }
    }
}
