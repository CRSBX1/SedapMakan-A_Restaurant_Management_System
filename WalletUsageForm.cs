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
    public partial class WalletUsageForm : Form
    {
        private Navigation_Code Navi_Code;
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SedapMakan;Integrated Security=True"); //Establish a connection to SedapMakan's SQL database
        //Create 2 data adapters and data tables to fetch and store data.
        private DataTable transactions = new DataTable();
        private DataTable transactiondates = new DataTable();
        private SqlDataAdapter dataAdapter;
        private SqlDataAdapter datedataAdaper;
        private List<string> AccountNames = new List<string>(); //Create a string to store customer names
        private List<string> Year = new List<string>();
        private List<string> Month = new List<string>();
        private SqlCommand command;
        private SqlCommand Transactiondate;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();


        public WalletUsageForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            AccountNameLabel.Text = Username.username + "▼";
            AccountNames.Add("All");
            Year.Add("All");
            Month.Add("All");
            conn.Open();
            sqldataconnection();
            conn.Close();
            
            foreach (DataRow row in transactions.Rows) //Looping to add all the customers that have transaction records to a list
            {
                if (!AccountNames.Contains(row[2].ToString())){
                    AccountNames.Add(row[2].ToString());
                }
            }

            foreach (DataRow row in transactiondates.Rows)
            {
                if (!Year.Contains(row[0].ToString()))
                {
                    Year.Add(row[0].ToString());
                }

                if (!Month.Contains(row[1].ToString()))
                {
                    Month.Add(row[1].ToString());
                }
            }

            WalletReportTable.DataSource = transactions;
            CustomerComboBox.DataSource = AccountNames; //Uses the customer list as a data source for the customer filter combo box
            YearFilterComboBox.DataSource = Year; //Uses the year list as a data source for the customer filter combo box
            MonthComboBox.DataSource = Month; //Uses the month list as a data source for the customer filter combo box
            WalletReportTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedItem.ToString() != "All")
            {
                transactions.Clear();
                command.Parameters["@users"].Value = CustomerComboBox.SelectedItem.ToString();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(transactions);
            }
            else
            {
                transactions.Clear();
                command.Parameters["@users"].Value = DBNull.Value;
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(transactions);
            }
        }


        private void YearFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearFilterComboBox.SelectedItem.ToString() != "All")
            {
                transactions.Clear();
                command.Parameters["@year"].Value = YearFilterComboBox.SelectedItem.ToString();
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(transactions);
            }
            else
            {
                transactions.Clear();
                command.Parameters["@year"].Value = DBNull.Value;
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(transactions);
            }
        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MonthComboBox.SelectedItem.ToString() != "All")
            {
                transactions.Clear();
                command.Parameters["@month"].Value = MonthComboBox.SelectedItem.ToString();
                dataAdapter = new SqlDataAdapter(command); //The same thing as before but instead executes the contained command in the "command" variable
                dataAdapter.Fill(transactions);
            }
            else
            {
                transactions.Clear();
                command.Parameters["@month"].Value= DBNull.Value;
                dataAdapter = new SqlDataAdapter(command); //The same thing as before but instead executes the contained command in the "command" variable
                dataAdapter.Fill(transactions);
            }
        }

        private void sqldataconnection()
        {
            command = new SqlCommand("SELECT TransactionID,Transactions.WalletID,Users.AccountName,TransactionDate,TransactionType,Amount FROM Transactions INNER JOIN Ewallet ON Transactions.WalletID = Ewallet.WalletID INNER JOIN Users ON Ewallet.UserID=Users.UserID WHERE (YEAR(TransactionDate) = @year OR @year IS NULL) AND (MONTH(TransactionDate) = @month OR @month IS NULL) AND (Users.AccountName = @users OR @users IS NULL)", conn); //SQL query to fetch every customer's transaction records
            command.Parameters.AddWithValue("@users", DBNull.Value);
            command.Parameters.AddWithValue("@year", DBNull.Value);
            command.Parameters.AddWithValue("@month", DBNull.Value);
            dataAdapter = new SqlDataAdapter(command); //The same thing as before but instead executes the contained command in the "command" variable
            dataAdapter.Fill(transactions); //Fills "transactions" datatable with the data fetched by the dataadapter

            Transactiondate = new SqlCommand("SELECT YEAR(TransactionDate) AS year_value, MONTH(TransactionDate) AS month_value FROM Transactions;", conn); //SQL query to extract year and month data from the TransactionDate column.
            datedataAdaper = new SqlDataAdapter(Transactiondate); //Establish the connection between the app and sql database through a data adapter. Execute the command contained in the "TransactionDate" variable.
            datedataAdaper.Fill(transactiondates); //Fills "transactiondates" datatable with the data fetched by the datedataadapter 
        }

        private void EditUserShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviUserEdit();
        }

        private void WalletReportShortcut_Click(object sender, EventArgs e)
        {
        }

        private void SalesShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviSales();
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

        private void LogOutShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
        }

        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }
    }
}
