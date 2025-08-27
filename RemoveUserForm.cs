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
    public partial class RemoveUserForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source= (LocalDB)\\MSSQLLocalDB;Initial Catalog= SedapMakan; Integrated Security= True");
        private DataTable dt;
        private DataTable Walletdt;
        private SqlDataAdapter orderadapter;
        private DataTable orderdt = new DataTable();
        private List<int> orderlist = new List<int>();
        private bool userfound = false;
        private bool adminfound = false;
        private string userid;

        public RemoveUserForm()
        {
            InitializeComponent();
            AccountNameLabel.Text = Username.username;
            try
            {
                SqlCommand opendata = new SqlCommand("SELECT * FROM Users", conn);
                SqlCommand accesswallet = new SqlCommand("SELECT * FROM Ewallet", conn);
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(opendata);
                SqlDataAdapter walletadapter = new SqlDataAdapter(accesswallet);
                Walletdt = new DataTable();
                dt = new DataTable();
                adapter.Fill(dt);
                walletadapter.Fill(Walletdt);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error; database connection isn't established. Error message {ex.Message}");
                conn.Close();
            }
        }

        private void RemoveCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            userfound = false;
            adminfound = false;


            if (string.IsNullOrEmpty(AccNameTextbox.Text)|| string.IsNullOrEmpty(PasswordTextbox.Text))
            {
                MessageBox.Show("Please enter all the required values");
            }
            else if(AccNameTextbox.Text == Username.username)
            {
                MessageBox.Show("Can't delete own account while in usage, ask another admin to delete the account");
            }
            else {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[1].ToString() == AccNameTextbox.Text)
                    {
                        userfound = true;
                    }
                    else if (row[3].ToString() == PasswordTextbox.Text && row[1].ToString() == Username.username)
                    {
                        adminfound = true;
                        foreach (DataRow userinfo in dt.Rows) { 
                            if (userinfo[1].ToString() == AccNameTextbox.Text)
                            {
                                userid = userinfo[0].ToString();
                                if (userinfo[7].ToString()=="Customer")
                                {
                                    try
                                    {
                                        SqlCommand getwalletID = new SqlCommand("SELECT WalletID FROM Ewallet WHERE UserID = @userid", conn);
                                        SqlCommand getorderid = new SqlCommand("SELECT OrderID FROM Orders WHERE UserID = @userid", conn);
                                        conn.Open();
                                        getwalletID.Parameters.AddWithValue("@userid", userid);
                                        getorderid.Parameters.AddWithValue("@userid", userid);
                                        object wid = getwalletID.ExecuteScalar();
                                        int walletid = Convert.ToInt32(wid);
                                        orderadapter = new SqlDataAdapter(getorderid);
                                        orderadapter.Fill(orderdt);
                                        conn.Close();

                                        foreach(DataRow rows in orderdt.Rows)
                                        {
                                            orderlist.Add(int.Parse(rows[0].ToString()));
                                        }

                                        var parameters = orderlist.Select((_,index) => $"@orderid{index}").ToArray();
                                        string joinstring = string.Join(",", parameters);


                                        SqlCommand deletetransaction = new SqlCommand("DELETE FROM Transactions WHERE WalletID = @walletid",conn);
                                        SqlCommand deleteorder = new SqlCommand("DELETE FROM Orders WHERE UserID = @userid",conn);
                                        SqlCommand deleteorderitems = new SqlCommand($"DELETE FROM OrderItems WHERE OrderID IN ({joinstring})",conn);
                                        SqlCommand walletcommand = new SqlCommand("DELETE FROM Ewallet WHERE UserID = @userid", conn);
                                        SqlCommand command = new SqlCommand("DELETE FROM Users WHERE UserID = @userid", conn);


                                        for (int i = 0; i < orderlist.Count; i++)
                                        {
                                            deleteorderitems.Parameters.AddWithValue($"@orderid{i}", orderlist[i]);
                                        }
                                        walletcommand.Parameters.AddWithValue("@userid", userid);
                                        command.Parameters.AddWithValue("@userid", userid);
                                        deletetransaction.Parameters.AddWithValue("@walletid",walletid);
                                        deleteorder.Parameters.AddWithValue("@userid",userid);

                                        conn.Open();
                                        if (orderlist.Count > 0)
                                        {
                                            deletetransaction.ExecuteNonQuery();
                                            deleteorderitems.ExecuteNonQuery();
                                            deleteorder.ExecuteNonQuery();
                                            walletcommand.ExecuteNonQuery();
                                            command.ExecuteNonQuery();
                                        }
                                        else
                                        {
                                            deletetransaction.ExecuteNonQuery();
                                            walletcommand.ExecuteNonQuery();
                                            command.ExecuteNonQuery();
                                        }
                                            conn.Close();
                                        MessageBox.Show($"{AccNameTextbox.Text}'s account, ewallet, order history, and transaction history are successfully deleted.");
                                        break;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Error encountered; deletion unsuccessful. Error message: {ex.Message}");
                                        conn.Close();
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        SqlCommand command = new SqlCommand("DELETE FROM Users WHERE UserID = @userid", conn);
                                        command.Parameters.AddWithValue("@userid", userid);
                                        conn.Open();
                                        command.ExecuteNonQuery();
                                        conn.Close();
                                        MessageBox.Show($"{AccNameTextbox.Text}'s account is successfully deleted");
                                        break;
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Error encountered; deletion unsuccessful. Error message: {ex.Message}");
                                        conn.Close();
                                    }
                                }
                            }
                        
                        }

                        
                    }
                    
                }

                if (!userfound)
                {
                    MessageBox.Show("User Not Found");
                    AccNameTextbox.Focus();
                }

                if (!adminfound)
                {
                    MessageBox.Show("Password isn't correct, Try again");
                    PasswordTextbox.Focus();
                }
            }
        }
    }
}
