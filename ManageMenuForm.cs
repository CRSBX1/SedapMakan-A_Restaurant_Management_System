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
    public partial class ManageMenuForm : Form
    {
        private MenuService menuService = new MenuService();
        private Navigation_Code navicode;
        private DataTable dt = new DataTable();
        public ManageMenuForm()
        {
            InitializeComponent();
            navicode = new Navigation_Code(this);
            DropDownMenu.Visible = false;
            AccountNameLabel.Text = Username.username + " ▼";
        }

        private void txtMenuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadMenuItems()
        {
            dt = new DataTable(); // Reset the table

            // Define table columns manually to match MenuItem structure
            dt.Columns.Add("MenuID", typeof(int));
            dt.Columns.Add("MenuName", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("IsAvailable", typeof(bool));

            // Load menu items from service
            var menuItems = menuService.GetAllMenuItems();

            // Add each item into the DataTable
            foreach (var item in menuItems)
            {
                dt.Rows.Add(item.menuId, item.menuName, item.category, item.price, item.isAvailable);
            }

            // Bind to DataGridView
            dataGridMenu.DataSource = dt;
        }

        private void ManageMenuForm_Load(object sender, EventArgs e)
        {
            loadMenuItems();
            loadCategoryOptions();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string menuName = txtMenuName.Text.Trim();
                string category = cmbCategory.Text.Trim();
                decimal price = numPrice.Value;
                bool isAvailable = chkAvailable.Checked;

                // Validate input
                if (string.IsNullOrWhiteSpace(menuName))
                {
                    MessageBox.Show("Please enter a menu name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(category))
                {
                    MessageBox.Show("Please select or enter a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (price <= 0)
                {
                    MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if menu with same name already exists
                if (menuService.MenuNameExists(menuName))
                {
                    MessageBox.Show("A menu item with the same name already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Prepare and insert
                MenuItem newItem = new MenuItem
                {
                    menuName = menuName,
                    category = category,
                    price = price,
                    isAvailable = isAvailable
                };

                menuService.AddMenuItem(newItem);

                MessageBox.Show("Menu item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadMenuItems();
                loadCategoryOptions();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the menu item:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearForm()
        {
            txtMenuName.Clear();
            cmbCategory.SelectedIndex = -1;
            numPrice.Value = 0;
            chkAvailable.Checked = false;
        }
        private void loadCategoryOptions()
        {
            cmbCategory.Items.Clear();
            FilterComboBox.Items.Clear();
            FilterComboBox.Items.Add("All");

            var categories = menuService.GetAllCategories();
            foreach (string category in categories)
            {
                cmbCategory.Items.Add(category);
                FilterComboBox.Items.Add(category);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure a row is selected
                if (dataGridMenu.CurrentRow == null || dataGridMenu.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Please select a menu item to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get input values
                string menuName = txtMenuName.Text.Trim();
                string category = cmbCategory.Text.Trim();
                decimal price = numPrice.Value;
                bool isAvailable = chkAvailable.Checked;

                // Validation
                if (string.IsNullOrWhiteSpace(menuName))
                {
                    MessageBox.Show("Menu name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(category))
                {
                    MessageBox.Show("Please enter or select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (price <= 0)
                {
                    MessageBox.Show("Price must be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get selected ID
                int menuId = Convert.ToInt32(dataGridMenu.CurrentRow.Cells["MenuID"].Value);

                // Create updated item
                MenuItem updatedItem = new MenuItem
                {
                    menuId = menuId,
                    menuName = menuName,
                    category = category,
                    price = price,
                    isAvailable = isAvailable
                };

                // Update using service
                menuService.UpdateMenuItem(updatedItem);

                MessageBox.Show("Menu item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadMenuItems();
                loadCategoryOptions();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the menu item:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ignore clicks on the header row or outside bounds
                if (e.RowIndex >= 0 && e.RowIndex < dataGridMenu.Rows.Count)
                {
                    DataGridViewRow row = dataGridMenu.Rows[e.RowIndex];

                    // Skip if row is a new/empty row (bottom blank row)
                    if (row.IsNewRow) return;

                    txtMenuName.Text = row.Cells["MenuName"].Value?.ToString() ?? "";
                    cmbCategory.Text = row.Cells["Category"].Value?.ToString() ?? "";
                    numPrice.Value = Convert.ToDecimal(row.Cells[3].Value ?? 0);
                    chkAvailable.Checked = Convert.ToBoolean(row.Cells[4].Value ?? false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading selected item: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dataGridMenu.CurrentRow == null || dataGridMenu.CurrentRow.IsNewRow)
                {
                    MessageBox.Show("Please select a menu item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to delete this menu item?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.Yes)
                    return;

                // Get MenuID from selected row
                int menuId = Convert.ToInt32(dataGridMenu.CurrentRow.Cells["MenuID"].Value);

                // Call service to delete
                menuService.DeleteMenuItem(menuId);

                MessageBox.Show("Menu item deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadMenuItems();
                loadCategoryOptions();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the menu item:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("MenuID", typeof(int));
            dt.Columns.Add("MenuName", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("IsAvailable", typeof(bool));

            List<MenuItem> filteredMenu;

            if (FilterComboBox.SelectedItem.ToString() == "All")
            {
                filteredMenu = menuService.GetAllMenuItems();
            }
            else
            {
                string selectedCategory = FilterComboBox.SelectedItem.ToString();
                filteredMenu = menuService.GetMenuItemsByCategory(selectedCategory);
            }

            foreach (var item in filteredMenu)
            {
                dt.Rows.Add(item.menuId, item.menuName, item.category, item.price, item.isAvailable);
            }

            dataGridMenu.DataSource = dt;
        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void ManageMenuShortcut_Click(object sender, EventArgs e)
        {
        }

        private void ViewOrderShortcut_Click(object sender, EventArgs e)
        {
            navicode.NaviViewOrders();
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
