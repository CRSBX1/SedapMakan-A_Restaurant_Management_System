using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedapMakan.SedapMakanDataSetTableAdapters;

namespace SedapMakan
{
    public partial class AddUserForm : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SedapMakan;Integrated Security=True");
        Random rando = new Random();
        DataTable Userdt = new DataTable();
        private int PasswordGenerator;
        private string Password;
        private bool hasletters;
        private bool hasnumbers;
        private bool state = false;
        private string userid;
        private string oldname;

        public AddUserForm(DataTable datatable)
        {
            InitializeComponent();
            AccountNameLabel.Text = Username.username;
            Userdt = datatable;
            state = true;
        }

        public AddUserForm(Users users, DataTable table)
        {
            InitializeComponent();
            oldname = users.accountname;
            Userdt = table;
            AddUserLabel.Text = "Edit User Credentials";
            userid = users.UserID;
            AccNameTextbox.Text = users.accountname;
            EmailTextbox.Text = users.email;
            FullNameTextbox.Text = users.fullname;
            PhoneNumTextbox.Text = users.phonenumber;
            AddressTextbox.Text = users.address;
            ChooseRoleComboBox.SelectedItem = users.role;
            AddUserBtn.Text = "Save Changes";

            if (ChooseRoleComboBox.SelectedItem.ToString() == "Customer")
            {
                ChooseRoleComboBox.Enabled = false;
            }
            else
            {
                ChooseRoleComboBox.Items.Remove(ChooseRoleComboBox.Items[3]);
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }
        
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            hasnumbers = FullNameTextbox.Text.Any(char.IsDigit);
            hasletters = PhoneNumTextbox.Text.Any(char.IsLetter);

            if (AccNameTextbox.Text == null || EmailTextbox.Text == null || FullNameTextbox.Text == null || PhoneNumTextbox.Text == null || AddressTextbox.Text == null || ChooseRoleComboBox.SelectedItem == null) {
                MessageBox.Show("Please enter all the required values in the provided textboxes");
            }
            else if (hasnumbers || hasletters || PhoneNumTextbox.Text.Length != 11)
            {
                MessageBox.Show("Please only enter letters and 11 numbers for the account's full name phone number respectively");
            }
            else if(state)
            {
                try
                {
                    foreach (DataRow row in Userdt.Rows)
                    {
                        if (row[1].ToString() == AccNameTextbox.Text)
                        {
                            MessageBox.Show("Account name is taken. Please select another name");
                            AccNameTextbox.Focus();
                            return;
                        }
                    }

                    CreatePassword();
                    SqlCommand command = new SqlCommand("INSERT INTO Users(AccountName,Email,Password,FullName,PhoneNumber,Address,Role) VALUES(@AccountName, @Email, @Password, @FullName, @PhoneNum, @Address, @Role)", conn);
                    command.Parameters.AddWithValue("@AccountName", AccNameTextbox.Text);
                    command.Parameters.AddWithValue("@Email", EmailTextbox.Text);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@FullName", FullNameTextbox.Text);
                    command.Parameters.AddWithValue("@PhoneNum", PhoneNumTextbox.Text);
                    command.Parameters.AddWithValue("@Address", AddressTextbox.Text);
                    command.Parameters.AddWithValue("@Role", ChooseRoleComboBox.SelectedItem);
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show($"{AccNameTextbox.Text} has been added. The generated password is {Password}");
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", conn);
                    adapter.Fill(Userdt);
                    conn.Close();

                    if (ChooseRoleComboBox.SelectedItem.ToString() == "Customer")
                    {
                        foreach (DataRow row in Userdt.Rows)
                        {
                            if (row[1].ToString() == AccNameTextbox.Text && row[3].ToString() == Password)
                            {
                                conn.Open();
                                userid = row[0].ToString();
                                SqlCommand addwallet = new SqlCommand("INSERT INTO Ewallet(UserID,Balance) VALUES(@UserID, @Balance)", conn);
                                addwallet.Parameters.AddWithValue("@UserID", userid);
                                addwallet.Parameters.AddWithValue("@Balance", 0);
                                addwallet.ExecuteNonQuery();
                                conn.Close();
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"User addition is unsuccessful. Error message: {ex.Message}");
                    conn.Close();
                }
                
            }
            else
            {
                try
                {
                    foreach (DataRow row in Userdt.Rows)
                    {
                        if (oldname == row[1].ToString())
                        {
                            continue;
                        }
                        if (row[1].ToString() == AccNameTextbox.Text)
                        {
                            MessageBox.Show("Account name is taken. Please select another name");
                            AccNameTextbox.Focus();
                            return;
                        }
                    }

                    SqlCommand command = new SqlCommand("UPDATE Users SET AccountName=@AccountName, Email=@Email, FullName=@FullName, PhoneNumber=@PhoneNum, Address=@Address, Role=@Role WHERE UserID=@UserID", conn);
                    command.Parameters.AddWithValue("@UserID", userid);
                    command.Parameters.AddWithValue("@AccountName", AccNameTextbox.Text);
                    command.Parameters.AddWithValue("@Email", EmailTextbox.Text);
                    command.Parameters.AddWithValue("@FullName", FullNameTextbox.Text);
                    command.Parameters.AddWithValue("@PhoneNum", PhoneNumTextbox.Text);
                    command.Parameters.AddWithValue("@Address", AddressTextbox.Text);
                    command.Parameters.AddWithValue("@Role", ChooseRoleComboBox.SelectedItem);
                    conn.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Changes have been saved");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Update unsuccessful.\n Error message: {ex.Message}");
                    conn.Close();
                }
            }

                
        }
        

        private void CreatePassword()
        {
            PasswordGenerator = rando.Next(0, 999999);
            Password = PasswordGenerator.ToString("D6");

            foreach (DataRow row in Userdt.Rows)
            {
                while (row[3].ToString() == Password)
                {
                    PasswordGenerator = rando.Next(0, 999999);
                    Password = PasswordGenerator.ToString("D6");
                }
            }
        }

        private void AddCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
