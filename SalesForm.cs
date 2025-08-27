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
    public partial class SalesForm : Form
    {
        private Navigation_Code Navi_Code;
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog = SedapMakan; Integrated Security = True");
        private SqlCommand command;
        private SqlCommand gettime;
        private SqlDataAdapter Salesadapter;
        private SqlDataAdapter timeadapter;
        private DataTable Sales = new DataTable();
        private DataTable time = new DataTable();
        private List<string> year = new List<string>();
        private List<string> month = new List<string>();
        private List<string> category = new List<string>();
        private List<string> chef = new List<string>();
        private DataTable dt = new DataTable();
        private SqlDataAdapter adapter;

        public SalesForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            AccountNameLabel.Text = Username.username + "▼";
            year.Add("All");
            month.Add("All");
            category.Add("All");
            chef.Add("All");
            command = new SqlCommand("SELECT Orders.OrderID, OrderDate AS [Date], MenuItems.MenuName AS [Menu Item], MenuItems.Price AS [Item Price], MenuItems.Category, TotalPrice, Users.AccountName AS [Chef] FROM Orders INNER JOIN OrderItems ON Orders.OrderID=OrderItems.OrderID INNER JOIN MenuItems ON OrderItems.MenuID = MenuItems.MenuID INNER JOIN Users ON OrderItems.PreparedBy = Users.UserID WHERE CAST(Status AS NVARCHAR(MAX)) = 'Completed' AND (YEAR(OrderDate) = @year OR @year IS NULL) AND (MONTH(OrderDate) = @month OR @month IS NULL) AND (CAST(MenuItems.Category AS NVARCHAR) = @category OR @category IS NULL) AND (Users.AccountName = @chef OR @chef IS NULL)", conn);
            gettime = new SqlCommand("SELECT YEAR(OrderDate) AS [year], MONTH(OrderDate) as [month] FROM Orders",conn);

            command.Parameters.AddWithValue("@year",DBNull.Value);
            command.Parameters.AddWithValue("@month", DBNull.Value);
            command.Parameters.AddWithValue("@category", DBNull.Value);
            command.Parameters.AddWithValue("@chef", DBNull.Value);

            conn.Open();
            Salesadapter = new SqlDataAdapter(command);
            Salesadapter.Fill(Sales);
            timeadapter = new SqlDataAdapter(gettime);
            timeadapter.Fill(time);
            conn.Close();

            foreach(DataRow row in time.Rows)
            {
                if (!year.Contains(row[0].ToString()))
                {
                    year.Add(row[0].ToString());
                }

                if (!month.Contains(row[1].ToString()))
                {
                    month.Add(row[1].ToString());
                }
            }

            foreach (DataRow row in Sales.Rows) {
                if (!category.Contains(row[4].ToString())) { 
                    category.Add(row[4].ToString());
                }
                
                if (!chef.Contains(row[6].ToString()))
                {
                    chef.Add(row[6].ToString());
                }
            }


            SalesReportTable.DataSource = Sales;
            YearFilterComboBox.DataSource = year;
            MonthComboBox.DataSource = month;
            CategoryComboBox.DataSource = category;
            ChefComboBox.DataSource = chef;
        }

        private void YearFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearFilterComboBox.SelectedItem.ToString() != "All")
            {
                Sales.Clear();
                command.Parameters["@year"].Value = YearFilterComboBox.SelectedItem;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
            else
            {
                Sales.Clear();
                command.Parameters["@year"].Value = DBNull.Value;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MonthComboBox.SelectedItem.ToString() != "All")
            {
                Sales.Clear();
                command.Parameters["@month"].Value = MonthComboBox.SelectedItem;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
            else
            {
                Sales.Clear();
                command.Parameters["@month"].Value = DBNull.Value;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem.ToString() != "All")
            {
                Sales.Clear();
                command.Parameters["@category"].Value = CategoryComboBox.SelectedItem;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
            else
            {
                Sales.Clear();
                command.Parameters["@category"].Value = DBNull.Value;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
        }

        private void ChefComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChefComboBox.SelectedItem.ToString() != "All")
            {
                Sales.Clear();
                command.Parameters["@chef"].Value = ChefComboBox.SelectedItem;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
            else
            {
                Sales.Clear();
                command.Parameters["@chef"].Value = DBNull.Value;
                conn.Open();
                Salesadapter = new SqlDataAdapter(command);
                Salesadapter.Fill(Sales);
                conn.Close();
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogOutShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }

        private void EditUserShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviUserEdit();
        }

        private void WalletReportShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviWalletUsage();
        }

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            /*SqlCommand owncommand = new SqlCommand("SELECT * FROM Users WHERE UserID = @userid", conn);
            owncommand.Parameters.AddWithValue("@userid", Username.id);
            conn.Open();
            dt.Clear();
            adapter = new SqlDataAdapter(owncommand);
            adapter.Fill(dt);
            conn.Close();
            DataRow dtrows = dt.Rows[0];
            Users user = new Users(dtrows[0].ToString(), dtrows[1].ToString(), dtrows[2].ToString(), dtrows[3].ToString(), dtrows[4].ToString(), dtrows[5].ToString(), dtrows[6].ToString(), dtrows[7].ToString());
            this.Hide();
            EditOwnAccForm editacc = new EditOwnAccForm(user);
            editacc.ShowDialog();
            this.Show();*/
            Navi_Code.NaviOwnAcc();
        }

        private void LogOutShortcut_Click_1(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
