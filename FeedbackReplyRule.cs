using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SedapMakan;

namespace SedapMakanSystemAdmin
{
    public class FeedbackReplyRule
    {

        public SqlCommand UpdateForm(SqlCommand command, Button SubmitBtn, TextBox Replytxtbox, string respondid, SqlConnection conn, string FeedbackID)
        {
            // Use respondid to determine INSERT vs UPDATE
            if (string.IsNullOrEmpty(respondid)) // New response
            {
                command = new SqlCommand("INSERT INTO FeedbackResponse(FeedbackID, RespondedBy, Response) VALUES (@id, @respondant, @response)", conn);
                command.Parameters.AddWithValue("@id", FeedbackID);
                command.Parameters.AddWithValue("@respondant", Username.id);
                command.Parameters.AddWithValue("@response", Replytxtbox.Text.Trim());
            }
            else // Update existing response
            {
                command = new SqlCommand("UPDATE FeedbackResponse SET FeedbackID = @id, RespondedBy = @respondant, Response = @response WHERE ResponseID = @respondid", conn);
                command.Parameters.AddWithValue("@respondid", respondid);
                command.Parameters.AddWithValue("@id", FeedbackID);
                command.Parameters.AddWithValue("@respondant", Username.id);
                command.Parameters.AddWithValue("@response", Replytxtbox.Text.Trim());
            }
            return command;
        }

        public bool ReplyRule(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                MessageBox.Show("Reply can't be empty!");
                return false;
            }
            return true;
        }
    }
}
