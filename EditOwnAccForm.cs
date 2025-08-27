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
    public partial class EditOwnAccForm : Form
    {

        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SedapMakan;Integrated Security=True");
        private string userid;
        private SqlDataAdapter dataadapter;
        private DataTable dt = new DataTable();

        public EditOwnAccForm(Users user)
        {
            InitializeComponent();
            AccountNameLabel.Text = Username.username;
            userid = user.UserID;
            AccNameTextbox.Text = user.accountname;
            PasswordEditTextBox.Text = user.password;
            EmailTextbox.Text = user.email;
            FullNameTextbox.Text = user.fullname;
            PhoneNumTextbox.Text = user.phonenumber;
            AddressTextbox.Text = user.address;

            SqlCommand command = new SqlCommand("SELECT * FROM Users", conn);
            conn.Open();
            dt.Clear();
            dataadapter = new SqlDataAdapter(command);
            dataadapter.Fill(dt);
            conn.Close();
        }

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            
        }

        private void EditCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOwnAccBtn_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {
                if(Username.username == row[1].ToString())
                {
                    continue;
                }
                else if (row[1].ToString() == AccNameTextbox.Text)
                {
                    MessageBox.Show("Account name is taken. Please select another name");
                    AccNameTextbox.Focus();
                    return;
                }
            }

            SqlCommand command = new SqlCommand("UPDATE Users SET AccountName = @accname, Email = @email, FullName = @fullname, PhoneNumber = @phonenum, Address = @address, Password = @password WHERE UserID = @userid", conn);
            command.Parameters.AddWithValue("@accname", AccNameTextbox.Text);
            command.Parameters.AddWithValue("@password",PasswordEditTextBox.Text);
            command.Parameters.AddWithValue("@email", EmailTextbox.Text);
            command.Parameters.AddWithValue("@fullname", FullNameTextbox.Text);
            command.Parameters.AddWithValue("@phonenum", PhoneNumTextbox.Text);
            command.Parameters.AddWithValue("@address", AddressTextbox.Text);
            command.Parameters.AddWithValue("@userid", userid);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Your account credentials are updated.");
            EditCancelBtn.Text = "Close";
        }


        private void AccountNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void EditOwnAccForm_Load(object sender, EventArgs e)
        {

        }
    }
}
