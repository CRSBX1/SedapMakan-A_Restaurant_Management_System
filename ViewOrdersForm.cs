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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SedapMakan
{
    public partial class ViewOrdersForm : Form
    {
        private OrderService orderService = new OrderService();
        private string selectedOrderId = "";
        private string selectedStatus = "";
        private Navigation_Code navicode;
        public ViewOrdersForm()
        {
            InitializeComponent();
            navicode = new Navigation_Code(this);
            DropDownMenu.Visible = false;
            AccountNameLabel.Text = Username.username + " ▼";
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {

            // Add filter options to the ComboBox
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("New");
            cmbStatusFilter.Items.Add("In Progress");
            cmbStatusFilter.Items.Add("Completed");
            cmbStatusFilter.SelectedIndex = 0; // Set default to "All"

            grpOrderDetails.Visible = false; // Make Order Details not vissible

            // Filter for the date (Today or all time order)
            cmbDateFilter.Items.Add("All Time");
            cmbDateFilter.Items.Add("Today");
            cmbDateFilter.SelectedIndex = 0;

            RecalculateAllOrderTotals();
            loadOrders(); // Call this when form opens

        }

        // 1. Load all orders
        private void loadOrders()
        {
            try
            {
                string statusFilter = cmbStatusFilter.SelectedItem?.ToString() ?? "All";
                bool todayOnly = cmbDateFilter.SelectedItem?.ToString() == "Today";

                dataGridOrders.DataSource = orderService.GetOrders(statusFilter, todayOnly);
                dataGridOrders.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 2. Load order items for selected order
        private void loadOrderItems(string orderId)
        {
            try
            {
                dataGridOrderItems.DataSource = orderService.GetOrderItems(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load order items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridOrders.Rows[e.RowIndex];

                string orderId = row.Cells["OrderID"].Value.ToString();
                txtOrderId.Text = "#" + orderId;
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtTotal.Text = "RM " + (row.Cells["TotalPrice"].Value == DBNull.Value ? "0.00" : Convert.ToDecimal(row.Cells["TotalPrice"].Value).ToString("F2"));
                txtStatus.Text = row.Cells["Status"].Value.ToString();

                loadOrderItems(orderId);

  
                string status = row.Cells["Status"].Value.ToString();
                selectedOrderId = orderId;          
                selectedStatus = status;
                txtStatus.Text = status;
                // Update button text based on status
                if (status == "New")
                {
                    btnAction.Text = "Set In Progress";
                    btnAction.Enabled = true;
                }
                else if (status == "In Progress")
                {
                    btnAction.Text = "Set Completed";
                    btnAction.Enabled = true;
                }
                else if (status == "Completed")
                {
                    btnAction.Text = "✓ Completed";
                    btnAction.Enabled = false;
                }
                else
                {
                    btnAction.Text = "NO Action";
                    btnAction.Enabled = false;
                }
            }
            grpOrderDetails.Visible = true; // Make Order Details vissible after choosing data row
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedOrderId))
                {
                    MessageBox.Show("Please select an order first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                long orderId = Convert.ToInt64(selectedOrderId);
                long chefId = Username.id; // your logged-in chef ID

                if (selectedStatus == "New")
                {
                    orderService.UpdateOrderStatus(orderId, "In Progress", chefId);
                }
                else if (selectedStatus == "In Progress")
                {
                    orderService.UpdateOrderStatus(orderId, "Completed");
                }

                orderService.RecalculateAllOrderTotals(); // recalculate total
                loadOrders();                             // refresh orders grid
                dataGridOrderItems.DataSource = null;     // clear items grid

                selectedOrderId = "";
                selectedStatus = "";
                btnAction.Text = "";                      // clear button text
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearForm() // to clear selection after status change
        {
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtTotal.Clear();
            txtStatus.Clear();
            dataGridOrderItems.DataSource = null;

            btnAction.Text = "-";
            btnAction.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderId.Clear();
            txtCustomerName.Clear();
            txtTotal.Clear();
            txtStatus.Clear();
            btnAction.Text = "-";
            btnAction.Enabled = false;
            dataGridOrderItems.DataSource = null;

            grpOrderDetails.Visible = false; // Make Order Details not vissible
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadOrders(); // Reload orders based on selected status 
        }

        private void cmbDateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadOrders(); // Reload orders with the new date filter
        }
        private void RecalculateAllOrderTotals() // Recalculates the TotalPrice of all orders based on whats in OrderItems.
        {
            try
            {
                orderService.RecalculateAllOrderTotals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to recalculate order totals: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void ManageMenuShortcut_Click(object sender, EventArgs e)
        {
            navicode.NaviManageMenu();
        }

        private void ViewOrderShortcut_Click(object sender, EventArgs e)
        {
        }

        private void EditOwnAccShortcut_Click(object sender, EventArgs e)
        {
            navicode.NaviOwnAcc();
        }

        private void LogoutShortcut_Click(object sender, EventArgs e)
        {
            navicode.NaviExit();
        }
    }
}
