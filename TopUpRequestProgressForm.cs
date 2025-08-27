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

namespace SedapMakanSystemAdmin
{
    public partial class TopUpRequestProgressForm : Form
    {

        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private Navigation_Code Navi_Code;


        public TopUpRequestProgressForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            userLabell.Text = Username.username + " ▼";
            conn = DatabaseConn.conn;
            command = new SqlCommand("SELECT *,YEAR(TopUpDate) AS [Year], MONTH(TopUpDate) AS [Month] FROM TopUpRequest WHERE (@status IS NULL OR RequestStatus = @status) AND (@year IS NULL OR YEAR(TopUpDate) = @year) AND (@month IS NULL OR MONTH(TopUpDate) = @month)", conn);
            command.Parameters.AddWithValue("@status", DBNull.Value);
            command.Parameters.AddWithValue("@year", DBNull.Value);
            command.Parameters.AddWithValue("@month", DBNull.Value);
            conn.Open();
            adapter = new SqlDataAdapter(command);
            conn.Close();
            adapter.Fill(dt);
            ReqProgressGridView.DataSource = dt;
            ReqProgressGridView.Columns["WalletID"].Visible = false;
            ReqProgressGridView.Columns["Year"].Visible = false;
            ReqProgressGridView.Columns["Month"].Visible = false;

            StatusCmb.Items.Add("All");
            YearCombobox.Items.Add("All");
            MonthCmb.Items.Add("All");

            foreach (DataRow row in dt.Rows)
            {
                if (!StatusCmb.Items.Contains(row[4].ToString()))
                {
                    StatusCmb.Items.Add(row[4].ToString());
                }
                
                if (!YearCombobox.Items.Contains(row[5].ToString()))
                {
                    YearCombobox.Items.Add(row[5].ToString());
                }

                if (!MonthCmb.Items.Contains(row[6].ToString()))
                {
                    MonthCmb.Items.Add(row[6].ToString());
                }
            }
        }

        private void YearCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (YearCombobox.SelectedItem.ToString() == "All")
            {
                command.Parameters["@year"].Value = DBNull.Value;
            }
            else
            {
                command.Parameters["@year"].Value = YearCombobox.SelectedItem.ToString();
            }
            adapter.Fill(dt);
        }

        private void MonthCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (MonthCmb.SelectedItem.ToString() == "All")
            {
                command.Parameters["@month"].Value = DBNull.Value;
            }
            else
            {
                command.Parameters["@month"].Value = MonthCmb.SelectedItem.ToString();
            }
            adapter.Fill(dt);
        }

        private void StatusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Clear();
            if (StatusCmb.SelectedItem.ToString() == "All")
            {
                command.Parameters["@status"].Value = DBNull.Value;
            }
            else
            {
                command.Parameters["@status"].Value = StatusCmb.SelectedItem.ToString();
            }
            adapter.Fill(dt);
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BrowseMenuShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviViewMenuForm();
        }

        private void OrderStatusShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOrderStatus();
        }

        private void ViewCartShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCartForm();
        }

        private void GiveFeedbackShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviFeedbackForm();
        }

        private void CancelRefShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCancelOrder();
        }

        private void OwnAccountShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviOwnAcc();
        }

        private void LogOutShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviExit();
        }

        private void userLabell_Click(object sender, EventArgs e)
        {
            DropDownMenu.Visible = !DropDownMenu.Visible;
        }
    }
}
