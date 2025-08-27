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
using SedapMakan.SedapMakanDataSetTableAdapters;
using SedapMakanSystemAdmin;

namespace SedapMakan
{

    public partial class LoginForm : Form
    {
        private bool found = false;

        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private Navigation_Code navicode;
        private decimal balance;

        public LoginForm()
        {
            InitializeComponent();
            navicode = new Navigation_Code(this);
            conn = DatabaseConn.conn;
            command = new SqlCommand("SELECT * FROM Users", conn);
            adapter = new SqlDataAdapter(command);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            found = false;
            dt.Clear();
            adapter.Fill(dt);
            if (string.IsNullOrEmpty(UserTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter your username and password");
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (UserTextBox.Text == row[1].ToString() && PasswordTextBox.Text == row[3].ToString())
                    {
                        Username.username = row[1].ToString();
                        Username.id = int.Parse(row[0].ToString());
                        Username.role = row[7].ToString();
                        found = true;
                        switch (row[7])
                        {
                            case "System Admin":
                                navicode.NaviAdminMainForm();
                                break;
                            case "Chef":
                                navicode.NaviChefMainForm();
                                break;
                            case "Customer":
                                navicode.NaviCustomerMainForm();
                                break;
                            case "Manager":
                                navicode.NaviManagerMainForm();
                                break;
                        }
                    }
                }
                if (!found) {
                    MessageBox.Show("Account not found. Check your username and password credentials");
                }
            }
        }

        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
