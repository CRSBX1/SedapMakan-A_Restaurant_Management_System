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
    public partial class orderStatusForm : Form
    {

        private SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
        private Navigation_Code Navi_Code;
        private SqlDataAdapter adapter;
        private SqlCommand command;
        private DataTable dt = new DataTable();
        private List<string> status = new List<string>();

        public orderStatusForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            userLabell.Text = $"{Username.username} ▼";
            status.Add("All");
            command = new SqlCommand("SELECT OrderID, OrderDate, Status, TotalPrice FROM Orders WHERE UserID = @id AND (CAST(Status AS NVARCHAR(MAX)) = @status OR @status IS NULL)", conn);
            command.Parameters.AddWithValue("@id", Username.id);
            command.Parameters.AddWithValue("@status", DBNull.Value);
            conn.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();

            foreach(DataRow row in dt.Rows)
            {
                if (!status.Contains(row[2].ToString()))
                {
                    status.Add(row[2].ToString());
                }
            }

            ordersGridView.DataSource = dt;
            FilterCombobox.DataSource = status;
        }

        private void FilterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (FilterCombobox.SelectedItem.ToString() == "All")
            {
                command.Parameters["@status"].Value = DBNull.Value;

            }
            else 
            {
                command.Parameters["@status"].Value = FilterCombobox.SelectedItem.ToString();
            }
            adapter.Fill(dt);
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

        private void Backbtn_Click(object sender, EventArgs e)
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
