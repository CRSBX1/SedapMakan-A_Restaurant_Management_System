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
using static System.Net.Mime.MediaTypeNames;

namespace SedapMakan
{
    public partial class cartForm : Form
    {
        private EwalletBalance Ewallet;
        private CartAdditionRule cartrule;
        private SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
        private Navigation_Code Navi_Code;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private decimal finalprice;
        private int MenuID;
        private string menuname;
        private int menuamount;
        private int UpdMenuAmount;
        private decimal menuprice;

        public cartForm()
        {
            InitializeComponent();
            cartrule = new CartAdditionRule();
            Ewallet = new EwalletBalance();
            Navi_Code = new Navigation_Code(this);
            EditItemAmountPanel.Visible = false;

            SqlCommand command = new SqlCommand("SELECT * FROM MenuItems",conn);

            conn.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();

            walletBalanceLabel.Text = $"Balance: RM {Ewallet.balance}";
            cartDataGridView.DataSource = Cartlist.customercart;
            finalprice = cartrule.CalculateOverallPrice(finalprice, cartTotalLabel, Cartlist.customercart);
        }

        private void cartForm_Load(object sender, EventArgs e)
        {
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            if (cartrule.CartAdd(cartDataGridView) == false)
            {
                return;
            }

            SqlCommand command = new SqlCommand("INSERT INTO Orders(OrderDate, Status, TotalPrice, UserID) VALUES(@orderdate, @status, @totalprice, @userid); SELECT SCOPE_IDENTITY(); ", conn);
            SqlCommand Itemscommand = new SqlCommand("INSERT INTO OrderItems(OrderID, MenuID, PreparedBy) VALUES(@orderid, @menuid, @preparedby)", conn);
            SqlCommand Updatedbalance = new SqlCommand("UPDATE Ewallet SET Balance = @balance WHERE UserID = @id", conn);
            SqlCommand WalletTransaction = new SqlCommand("INSERT INTO Transactions (TransactionDate, WalletID, TransactionType, Amount) VALUES (@date, @walletid, @trtype, @Amount)", conn);

            command.Parameters.AddWithValue("@orderdate", DateTime.Today);
            command.Parameters.AddWithValue("@status", "New");
            command.Parameters.AddWithValue("@totalprice", finalprice);
            command.Parameters.AddWithValue("@userid",Username.id);

            Updatedbalance.Parameters.AddWithValue("@balance", Ewallet.balance - finalprice);
            Updatedbalance.Parameters.AddWithValue("@id", Username.id);

            WalletTransaction.Parameters.AddWithValue("@date", DateTime.Today);
            WalletTransaction.Parameters.AddWithValue("@walletid", Ewallet.walletid);
            WalletTransaction.Parameters.AddWithValue("@trtype", "Purchase");
            WalletTransaction.Parameters.AddWithValue("Amount", finalprice);

            conn.Open();
            Updatedbalance.ExecuteNonQuery();
            WalletTransaction.ExecuteNonQuery();
            object orderid =  command.ExecuteScalar();
            orderid = Convert.ToInt32(orderid);

            Itemscommand.Parameters.AddWithValue("@orderid", orderid);
            Itemscommand.Parameters.AddWithValue("@preparedby", DBNull.Value);
            Itemscommand.Parameters.Add("@menuid", SqlDbType.Int);

            foreach (DataRow row in dt.Rows)
            {
                foreach (CustomerMenuItem item in Cartlist.customercart)
                {
                    if (row[1].ToString() == item.Menuname && item.MenuAmount == 1)
                    {
                        MenuID = int.Parse(row[0].ToString());
                        Itemscommand.Parameters["@menuid"].Value = MenuID;
                        Itemscommand.ExecuteNonQuery();
                    }
                    else if (row[1].ToString() == item.Menuname && item.MenuAmount > 1)
                    {
                        MenuID = int.Parse(row[0].ToString());
                        Itemscommand.Parameters["@menuid"].Value = MenuID;

                        for (int i = item.MenuAmount; i > 0; i--)
                        {
                            Itemscommand.ExecuteNonQuery();
                        }
                    }
                }
            }

            conn.Close();
            Ewallet.UpdateBalance(walletBalanceLabel);
            MessageBox.Show($"Your order with the Order ID: {orderid} has been placed.\nYour new wallet balance is {Ewallet.balance}");
            EditItemAmountPanel.Visible = false;
            Cartlist.customercart.Clear();
            cartDataGridView.DataSource = null;
            cartDataGridView.DataSource = Cartlist.customercart;
        }


        private void closeCartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cartTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EditItemAmountPanel.Visible = true;
                DataGridViewRow row = cartDataGridView.Rows[e.RowIndex];
                menuname = row.Cells[0].Value.ToString();
                menuamount = int.Parse(row.Cells[1].Value.ToString());
                menuprice = Convert.ToDecimal(row.Cells[2].Value.ToString());
                ItemAmountLbl.Text = menuamount.ToString();
            }
        }
        private void AddAmountBtn_Click(object sender, EventArgs e)
        {
            if (cartrule.ifempty(menuname) == false || cartrule.ItemAdd(menuprice, finalprice, Ewallet.balance) == false)
            {
                return;
            }

            menuamount++;
            ItemAmountLbl.Text = menuamount.ToString();

            foreach (CustomerMenuItem item in Cartlist.customercart)
            {
                if (item.Menuname == menuname)
                {
                    item.MenuAmount = menuamount;
                }
            }

            cartDataGridView.DataSource = null;
            cartDataGridView.DataSource = Cartlist.customercart;
            finalprice = cartrule.CalculateOverallPrice(finalprice, cartTotalLabel, Cartlist.customercart);
        }

        private void SubAmountBtn_Click(object sender, EventArgs e)
        {
            if (cartrule.ifempty(menuname) == false)
            {
                return ;
            }

            if (menuamount > 1)
            {
                menuamount--;
                ItemAmountLbl.Text = menuamount.ToString();

                foreach (CustomerMenuItem item in Cartlist.customercart)
                {
                    if (item.Menuname == menuname)
                    {
                        item.MenuAmount = menuamount;
                    }
                }

                cartDataGridView.DataSource = null;
                cartDataGridView.DataSource = Cartlist.customercart;
                finalprice = cartrule.CalculateOverallPrice(finalprice, cartTotalLabel, Cartlist.customercart);
            }
            else if (menuamount == 1)
            {
                DialogResult deleteconfirmation = MessageBox.Show("Do you want to remove this item from your cart?","Confirm Delete", MessageBoxButtons.OKCancel);
                if (deleteconfirmation == DialogResult.OK)
                {
                    foreach (CustomerMenuItem item in Cartlist.customercart)
                    {
                        if (item.Menuname == menuname)
                        {
                            Cartlist.customercart.Remove(item);
                            MessageBox.Show($"Menu item {item.Menuname} is successfully removed from your cart");
                            cartDataGridView.DataSource = null;
                            cartDataGridView.DataSource = Cartlist.customercart;
                            menuname = string.Empty;
                            menuprice = 0;
                            menuamount = 0;
                            EditItemAmountPanel.Visible = false;
                            break;
                        }
                    }
                    finalprice = cartrule.CalculateOverallPrice(finalprice, cartTotalLabel, Cartlist.customercart);
                }
                else
                {
                    return;
                }
            }
        }

        private void userLabell_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void menuItem_CheckMenu_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_OrderStatus_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_RefundStatus_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_ViewCart_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_Feedback_Click(object sender, EventArgs e)
        {
        }

        private void walletBalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void BrowseMenuShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviViewMenuForm();
        }

        private void OrderStatusShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOrderStatus();
        }

        private void CancelRefShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCancelOrder();
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
