using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.SqlServer.Server;

namespace SedapMakan
{

    public partial class UserAccountForm : Form
    {
        private Navigation_Code Navi_Code;
        private Users users;
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SedapMakan;Integrated Security=True;");
        private SqlDataAdapter useradapter;
        private DataTable userdt = new DataTable();
        private DataTable dt = new DataTable();
        private SqlDataAdapter adapter;
        private string id;
        private string acname;
        private string email;
        private string password;
        private string fullname;
        private string phonenum;
        private string address;
        private string role;

        public UserAccountForm(Form form)
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            /*userdt.Clear();
            SqlCommand sqlcommand = new SqlCommand("SELECT UserID, AccountName AS [Account Name], Email nvarchar(20),FullName AS [Full Name], PhoneNumber AS [Phone Number], Address, Role FROM Users", conn);
            conn.Open();
            useradapter = new SqlDataAdapter(sqlcommand);
            useradapter.Fill(userdt);
            conn.Close();*/
            fillfunction();
            UserAccountTable.DataSource = userdt;
            //this.usersTableAdapter.Fill(this.sedapMakanDataSet.Users);
            AccountNameLabel.Text = Username.username + "▼";
        }

        private void EditUserShortcut_Click(object sender, EventArgs e)
        {
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            
        }

        private void WalletReportShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviWalletUsage();
        }

        private void SalesShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviSales();
        }

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            /*SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserID = @userid",conn);
            command.Parameters.AddWithValue("@userid", Username.id);
            conn.Open();
            dt.Clear();
            adapter = new SqlDataAdapter(command);
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

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm adduserform = new AddUserForm(userdt);
            adduserform.ShowDialog();
            this.Show();
            fillfunction();
            /*userdt.Clear();
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM Users", conn);
            conn.Open();
            useradapter = new SqlDataAdapter(sqlcommand);
            useradapter.Fill(userdt);
            conn.Close();*/
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveUserForm removeuserform = new RemoveUserForm();
            removeuserform.ShowDialog();
            this.Show();
            fillfunction();
            /*userdt.Clear();
            SqlCommand sqlcommand = new SqlCommand("SELECT * FROM Users", conn);
            conn.Open();
            useradapter = new SqlDataAdapter(sqlcommand);
            useradapter.Fill(userdt);
            conn.Close();*/
        }

        private void UserAccountTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (UserAccountTable.SelectedRows.Count == 0)
            {  
                MessageBox.Show("Please select an account to edit from the user table");
            }
            else
            {
                try
                {
                    DataGridViewRow dataGridViewRow = UserAccountTable.SelectedRows[0];

                    foreach (DataRow row in userdt.Rows)
                    {
                        if (row[0].ToString() == dataGridViewRow.Cells[0].Value.ToString())
                        {
                            id = row[0].ToString();
                            acname = row[1].ToString();
                            email = row[2].ToString();
                            password = row[3].ToString();
                            fullname = row[4].ToString();
                            phonenum = row[5].ToString();
                            address = row[6].ToString();
                            role = row[7].ToString();
                        }
                    }

                    users = new Users(id, acname, email, password, fullname, phonenum, address, role);
                    this.Hide();
                    AddUserForm edituserform = new AddUserForm(users, userdt);
                    edituserform.ShowDialog();
                    this.Show();
                    fillfunction();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Encountered error(s) when trying to access edit form. Error message {ex.Message}");
                    conn.Close();
                }
            }
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT UserID, AccountName, Email, '[Encrypted]' AS Password, FullName, PhoneNumber, Address, Role FROM Users WHERE CAST(Role AS NVARCHAR(MAX)) = @role", conn);
            if(RoleComboBox.SelectedItem.ToString() == "All")
            {
                command = new SqlCommand("SELECT UserID, AccountName, Email, '[Encrypted]' AS Password, FullName, PhoneNumber, Address, Role FROM Users", conn);
            }
            else if (RoleComboBox.SelectedItem.ToString() == "System Admin")
            {
                command.Parameters.AddWithValue("@role", RoleComboBox.SelectedItem.ToString());
            }
            else if (RoleComboBox.SelectedItem.ToString() == "Manager")
            {
                command.Parameters.AddWithValue("@role", RoleComboBox.SelectedItem.ToString());
            }
            else if (RoleComboBox.SelectedItem.ToString() == "Chef")
            {
                command.Parameters.AddWithValue("@role", RoleComboBox.SelectedItem.ToString());
            }
            else if (RoleComboBox.SelectedItem.ToString() == "Customer")
            {
                command.Parameters.AddWithValue("@role", RoleComboBox.SelectedItem.ToString());
            }
            conn.Open();
            userdt.Clear();
            SqlDataAdapter usersTableAdapter = new SqlDataAdapter(command);
            usersTableAdapter.Fill(userdt);
            conn.Close();
        }

        private void fillfunction()
        {
            userdt.Clear();
            SqlCommand sqlcommand = new SqlCommand("SELECT UserID, AccountName, Email, '[Encrypted]' AS Password, FullName, PhoneNumber, Address, Role FROM Users", conn);
            conn.Open();
            useradapter = new SqlDataAdapter(sqlcommand);
            useradapter.Fill(userdt);
            conn.Close();
        }
    }
}
