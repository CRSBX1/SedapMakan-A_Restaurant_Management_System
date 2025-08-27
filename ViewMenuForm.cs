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
using SedapMakanSystemAdmin;
namespace SedapMakan
{
    public partial class ViewMenuForm : Form
    {
        private EwalletBalance Ewallet;
        private PurchaseRule purchaserule;
        private CartAdditionRule cartrule;
        private string Category;
        private decimal CartPrice;
        private Navigation_Code Navi_Code;
        private SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private List<CustomerMenuItem> items = new List<CustomerMenuItem>();
        private List<string> categories = new List<string>();
        private decimal totalprice;

        public ViewMenuForm()
        {
            InitializeComponent();
            cartrule = new CartAdditionRule();
            purchaserule = new PurchaseRule();
            Ewallet = new EwalletBalance();
            Navi_Code = new Navigation_Code(this);
            userLabel.Text = $"{Username.username} ▼";
            OrderPanel.Visible = false;
            FilterCategorycomboBox.Items.Clear();
            categories.Clear();
            FilterCategorycomboBox.Items.Add("All");
            command = new SqlCommand("SELECT MenuName, Price, Category FROM MenuItems WHERE IsAvailable = 1 AND (CAST(Category AS NVARCHAR(MAX)) = @category OR @category IS NULL) AND Price <= @balance",conn);
            command.Parameters.AddWithValue("@category", DBNull.Value);
            command.Parameters.AddWithValue("@balance", Ewallet.balance);
            conn.Open();
            MenudataGridView.Visible = true;
            walletBalanceLabel.Text = "Balance: RM " + Ewallet.balance;
            menuload();
            conn.Close();
            

            foreach (DataRow row in dt.Rows)
            {
                if (!categories.Contains(row[2].ToString()))
                {
                    categories.Add(row[2].ToString());
                    FilterCategorycomboBox.Items.Add(row[2].ToString());
                }
            }

            CartPrice = cartrule.CalculateOverallPrice(CartPrice, CartPricelbl, Cartlist.customercart);

            MenudataGridView.DataSource = dt;
            MenudataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        private void MenudataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                AmountNum.Value = 0;
                OrderPanel.Visible = true;
                DataGridViewRow dgvrow = MenudataGridView.Rows[e.RowIndex];
                ItemNamelbl.Text = dgvrow.Cells[0].Value.ToString();
                Pricelbl.Text = dgvrow.Cells[1].Value.ToString();
            }
        }

        private void AmountNum_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalItemPrice();
        }

        private void CalculateTotalItemPrice()
        {
            totalprice = Convert.ToDecimal(Pricelbl.Text) * Convert.ToInt32(AmountNum.Value.ToString());
            TotalPricelbl.Text = "RM " + totalprice.ToString();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {

            bool state = purchaserule.CanAddToCart(totalprice, Convert.ToInt32(AmountNum.Value), CartPrice, Ewallet.balance);
            
            /*if (AmountNum.Value <= 0)
            {
                MessageBox.Show("Please specify the amount.");
                return;
            }

            if (CartPrice + totalprice > Ewallet.balance)
            {
                MessageBox.Show("Insufficient balance to add this item.");
                return;
            }*/

            if (!state)
            {
                MessageBox.Show("Can't add item to the cart; item total price can't exceed Ewallet balance and item amount can't be less than 1");
                return;
            }
            
            foreach (CustomerMenuItem Item in Cartlist.customercart)
            {
                if (Item.Menuname == ItemNamelbl.Text)
                {
                    Item.MenuAmount += int.Parse(AmountNum.Value.ToString());
                    MessageBox.Show($"{AmountNum.Value} more {Item.Menuname} are added to your cart.");
                    //CalculateAfterAdd();
                    CartPrice = cartrule.CalculateOverallPrice(CartPrice, CartPricelbl, Cartlist.customercart);
                    AmountNum.Value = 0;
                    return;
                }
            }
            
            CustomerMenuItem item = new CustomerMenuItem(ItemNamelbl.Text, int.Parse(AmountNum.Value.ToString()), decimal.Parse(Pricelbl.Text));
            Cartlist.customercart.Add(item);
            MessageBox.Show($"{ItemNamelbl.Text} has been added to the cart");
            //CalculateAfterAdd();
            CartPrice = cartrule.CalculateOverallPrice(CartPrice, CartPricelbl, Cartlist.customercart);
            AmountNum.Value = 0;
            
        }

        private void menuload()
        {
            dt.Clear();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            if (dt.Rows.Count is 0)
            {
                MessageBox.Show("Your balance isn't enough to purchase any item. Please top-up your account");
                MenudataGridView.Visible = false;
            }
        }

        private void viewCartButton_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCartForm();
            Ewallet.UpdateBalance(walletBalanceLabel);
            menuload();
        }


        private void userLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void CancelRefShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCancelOrder();
            Ewallet.UpdateBalance(walletBalanceLabel);
            menuload();
        }

        private void BrowseMenuShortcut_Click(object sender, EventArgs e)
        {
        }

        private void OrderStatusShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOrderStatus();
            Ewallet.UpdateBalance(walletBalanceLabel);
            menuload();
        }

        private void ViewCartShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCartForm();
            Ewallet.UpdateBalance(walletBalanceLabel);
            menuload();
        }

        private void GiveFeedbackShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviFeedbackForm();
            Ewallet.UpdateBalance(walletBalanceLabel);
            menuload();
        }

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
            Ewallet.UpdateBalance(walletBalanceLabel);
            menuload();
        }

        private void LogOutShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
            Ewallet.UpdateBalance(walletBalanceLabel);
            menuload();
        }

        private void FilterCategorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterCategorycomboBox.SelectedItem.ToString() != "All")
            {
                command.Parameters["@category"].Value = FilterCategorycomboBox.SelectedItem.ToString();
                Categorylbl.Text = $"{FilterCategorycomboBox.SelectedItem.ToString()} Delights";
            }
            else
            {
                command.Parameters["@category"].Value = DBNull.Value;
                Categorylbl.Text = "Our Special Menu";
            }
            menuload();
        }
    }
}
