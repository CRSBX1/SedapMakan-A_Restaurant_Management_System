using SedapMakan;
using SedapMakan.Properties;
using SedapMakanSystemAdmin.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace SedapMakan
{
    public partial class feedbackForm : Form
    {
        private int selectedRating = 0;
        private Navigation_Code Navi_Code;
        private int OrderID;
        private PictureBox[] stars;
        private SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;Initial Catalog = SedapMakan; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dt = new DataTable();
        private List<int> OrderIDs = new List<int>();


        public feedbackForm()
        {
            InitializeComponent();
            Navi_Code = new Navigation_Code(this);
            command = new SqlCommand("SELECT Orders.OrderID FROM Orders LEFT JOIN Feedback ON Orders.OrderID = Feedback.OrderID WHERE Orders.UserID = @id AND CAST(Orders.Status AS NVARCHAR(MAX)) = @completed AND Feedback.FeedbackID IS NULL", conn);
            command.Parameters.AddWithValue("@id", Username.id);
            command.Parameters.AddWithValue("@completed", "Completed");
            conn.Open();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();
            userLabell.Text = $"{Username.username} ▼";
            loadlistitems();

            feedbackOrderComboBox.DataSource = OrderIDs;
        }

        private void feedbackForm_Load(object sender, EventArgs e)
        {
            stars = new PictureBox[] { star1PictureBox, star2PictureBox, star3PictureBox, star4PictureBox, star5PictureBox };
            loadstars();
        }

        private void loadstars()
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Image = Resources.star_empty;
                stars[i].SizeMode = PictureBoxSizeMode.Zoom;
                int index = i;
                stars[i].Click += (s, e2) => SetStarRating(index + 1);
            }
        }

        private void SetStarRating(int rating)
        {
            selectedRating = rating;

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Image = (i < rating) ? Resources.star_filled : Resources.star_empty;
            }
        }

        private void loadlistitems()
        {
            OrderIDs.Clear();
            foreach (DataRow row in dt.Rows)
            {
                OrderID = int.Parse(row[0].ToString());
                if (!OrderIDs.Contains(OrderID))
                {
                    OrderIDs.Add(OrderID);
                }
            }
        }

        private void submitFeedbackButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(commentsTextBox.Text) || selectedRating <= 0 || feedbackOrderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please enter all the required values.");
            }
            else
            {
                SqlCommand InsertFeedback = new SqlCommand("INSERT INTO Feedback (OrderID, Rating, Comments) VALUES (@orderid, @rating, @comments)", conn);
                InsertFeedback.Parameters.AddWithValue("@orderid", int.Parse(feedbackOrderComboBox.SelectedItem.ToString()));
                InsertFeedback.Parameters.AddWithValue("@rating", selectedRating);
                InsertFeedback.Parameters.AddWithValue("@comments", commentsTextBox.Text.Trim());
                conn.Open();
                InsertFeedback.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Your feedback has been submitted to our team.\nThank you for dining in SedapMakan :)");

                commentsTextBox.Clear();
                OrderIDs.Clear();
                dt.Clear();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                loadlistitems();
                loadstars();
            }
        }


        private void feedbackOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void commentsTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

        }

        private void menuItem_CheckMenu_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_OrderStatus_Click(object sender, EventArgs e)
        {
            new orderStatusForm().ShowDialog();
        }

        private void menuItem_RefundStatus_Click(object sender, EventArgs e)
        {
            new refundStatusForm().ShowDialog();
        }

        private void menuItem_ViewCart_Click(object sender, EventArgs e)
        {
        }

        private void menuItem_Feedback_Click(object sender, EventArgs e)
        {
            new feedbackForm().ShowDialog();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelRefShortcut_Click(object sender, EventArgs e)
        {
            Navi_Code.NaviCancelOrder();
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