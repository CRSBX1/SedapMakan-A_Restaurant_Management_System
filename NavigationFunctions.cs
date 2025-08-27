using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedapMakanSystemAdmin;

namespace SedapMakan
{
    public class Navigation_Code
    {
        private Form form;

        public Navigation_Code(Form form)
        {
            this.form = form;
        }

        //Navigation Function for the login

        public void NaviAdminMainForm()
        {
            form.Hide();
            MainMenuForm mainmenuform = new MainMenuForm();
            mainmenuform.ShowDialog();
            form.Show();
        }

        public void NaviManagerMainForm()
        {
            form.Hide();
            ManagerMainMenuForm managerform = new ManagerMainMenuForm();
            managerform.ShowDialog();
            form.Show();
        }

        public void NaviChefMainForm()
        {
            form.Hide();
            ChefHomeForm chefform = new ChefHomeForm();
            chefform.ShowDialog();
            form.Show();
        }

        public void NaviCustomerMainForm()
        {
            form.Hide();
            mainForm customerform = new mainForm();
            customerform.ShowDialog();
            form.Show();
        }

        //Navigation Functions for System Admin

        public void NaviUserEdit()
        {
            form.Hide();
            using (UserAccountForm useraccountform = new UserAccountForm(form))
            {
                useraccountform.ShowDialog();
            }
            form.Show();
        }
        public void NaviWalletUsage()
        {
            form.Hide();
            using (WalletUsageForm walletusageform = new WalletUsageForm())
            {
                walletusageform.ShowDialog();
            }
            form.Show();
        }

        public void NaviSales()
        {
            form.Hide();
            using (SalesForm salesform = new SalesForm())
            {
                salesform.ShowDialog();
            }
            form.Show();
        }

        public void NaviExit()
        {
            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        //Navigation function to edit a user's own account
        public void NaviOwnAcc()
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = SedapMakan; Integrated Security = True");
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserID = @userid", conn);
            command.Parameters.AddWithValue("@userid", Username.id);
            conn.Open();
            DataTable dt = new DataTable();
            dt.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            conn.Close();
            DataRow dtrows = dt.Rows[0];
            Users user = new Users(dtrows[0].ToString(), dtrows[1].ToString(), dtrows[2].ToString(), dtrows[3].ToString(), dtrows[4].ToString(), dtrows[5].ToString(), dtrows[6].ToString(), dtrows[7].ToString());
            form.Hide();
            EditOwnAccForm editacc = new EditOwnAccForm(user);
            editacc.ShowDialog();
            form.Show();
        }

        //Navigation functions for Chef

        public void NaviManageMenu()
        {
            form.Hide();
            using (ManageMenuForm manageMenuForm = new ManageMenuForm())
            {
                manageMenuForm.ShowDialog();
            }
            form.Show();
        }

        public void NaviViewOrders()
        {
            form.Hide();
            using (ViewOrdersForm viewordersform = new ViewOrdersForm())
            {
                viewordersform.ShowDialog();
            }
            form.Show();
        }

        //Navigation functions for Customer

        public void NaviFeedbackForm()
        {
            form.Hide();
            using (feedbackForm feedbackform = new feedbackForm())
            {
                feedbackform.ShowDialog();
            }
            form.Show();
        }

        public void NaviOrderStatus()
        {
            form.Hide();
            using (orderStatusForm orderstatusform = new orderStatusForm())
            {
                orderstatusform.ShowDialog();
            }
            form.Show();
        }
        public void NaviCancelOrder()
        {
            form.Hide();
            using (CancelOrderForm cancelorderform = new CancelOrderForm())
            {
                cancelorderform.ShowDialog();
            }
            form.Show();
        }

        public void NaviViewMenuForm()
        {
            form.Hide();
            using (ViewMenuForm viewmenuform = new ViewMenuForm())
            {
                viewmenuform.ShowDialog();
            }
            form.Show();
        }

        public void NaviCartForm()
        {
            form.Hide();
            using (cartForm cartform = new cartForm())
            {
                cartform.ShowDialog();
            }
            form.Show();
        }

        public void NaviRefundForm()
        {
            form.Hide();
            using (refundForm refundform = new refundForm())
            {
                refundform.ShowDialog();
            }
            form.Show();
        }

        public void NaviRefundStatusForm()
        {
            form.Hide();
            using (refundStatusForm refundstatusform = new refundStatusForm())
            {
                refundstatusform.ShowDialog();
            }
            form.Show();
        }

        public void NaviTopUpRequestForm()
        {
            form.Hide();
            using (TopUpRequestForm topupreq = new TopUpRequestForm())
            {
                topupreq.ShowDialog();
            }
            form.Show();
        }

        public void NaviTopUpRequestProgressForm()
        {
            form.Hide();
            using (TopUpRequestProgressForm topupprogreq = new TopUpRequestProgressForm())
            {
                topupprogreq.ShowDialog();
            }
            form.Show();
        }


        //Navigation functions for manager

        public void NaviViewFeedback()
        {
            form.Hide();
            using (ViewFeedbackForm viewfeedbackform = new ViewFeedbackForm())
            {
                viewfeedbackform.ShowDialog();
            }
            form.Show();
        }

        public void NaviTopUpCustomer()
        {
            form.Hide();
            using (TopUpCustomerForm topupcustomerform = new TopUpCustomerForm())
            {
                topupcustomerform.ShowDialog();
            }
            form.Show();
        }
        public void NaviReviewRefund()
        {
            form.Hide();
            using (ReviewRefundRequests reviewrefundrequests = new ReviewRefundRequests())
            {
                reviewrefundrequests.ShowDialog();
            }
            form.Show();
        }
        public void NaviFeedbackReply(string feedback, string cusname, string feedbackID, string response, string respondid)
        {
            form.Hide();
            using (FeedbackReplyForm feedbackreply = new FeedbackReplyForm(feedback, cusname, feedbackID, response, respondid))
            {
                feedbackreply.ShowDialog();
            }
            form.Show();
        }
        public void NaviApproveorReject(int CustomerID, int RefundID, int OrderID, string CustomerName, decimal RefundAmount, string RefundReason)
        {
            form.Hide();
            using (ApproveRejectRefundForm ApproveReject = new ApproveRejectRefundForm(CustomerID, RefundID, OrderID, CustomerName, RefundAmount, RefundReason))
            {
                ApproveReject.ShowDialog();
            }
            form.Show();
        }
    }
}
