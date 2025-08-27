using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapMakanSystemAdmin
{
    public class OrderService
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SedapMakan;Integrated Security=True";

        public DataTable GetOrders(string status = "All", bool todayOnly = false)
        {
            string query = @"
                SELECT o.OrderID, o.OrderDate, u.AccountName AS CustomerName, o.TotalPrice,
                       CAST(o.Status AS NVARCHAR(MAX)) AS Status,
                       (
                           SELECT STRING_AGG(CAST(mi.MenuName AS NVARCHAR(MAX)), ', ')
                           FROM OrderItems oi
                           JOIN MenuItems mi ON mi.MenuID = oi.MenuID
                           WHERE oi.OrderID = o.OrderID
                       ) AS Items
                FROM Orders o
                JOIN Users u ON o.UserID = u.UserID";

            if (status != "All")
            {
                query += " WHERE CAST(o.Status AS NVARCHAR(MAX)) = @status";
                if (todayOnly)
                    query += " AND CAST(o.OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
            }
            else if (todayOnly)
            {
                query += " WHERE CAST(o.OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
            }

            query += " ORDER BY o.OrderID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (status != "All")
                    cmd.Parameters.AddWithValue("@status", status);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public DataTable GetOrderItems(string orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT m.MenuName AS ItemName,
                           u.AccountName AS PreparedBy,
                           1 AS Quantity,
                           FORMAT(m.Price, 'N2') AS Price
                    FROM OrderItems oi
                    JOIN MenuItems m ON oi.MenuID = m.MenuID
                    LEFT JOIN Users u ON oi.PreparedBy = u.UserID
                    WHERE oi.OrderID = @orderId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void UpdateOrderStatus(long orderId, string newStatus, long? chefId = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "UPDATE Orders SET Status = @status WHERE OrderID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", orderId);
                cmd.ExecuteNonQuery();

                if (newStatus == "In Progress" && chefId != null)
                {
                    string prepQuery = "UPDATE OrderItems SET PreparedBy = @chefId WHERE OrderID = @orderId";
                    SqlCommand cmd2 = new SqlCommand(prepQuery, conn);
                    cmd2.Parameters.AddWithValue("@chefId", chefId.Value);
                    cmd2.Parameters.AddWithValue("@orderId", orderId);
                    cmd2.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        public void RecalculateAllOrderTotals()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Orders
                    SET TotalPrice = (
                        SELECT SUM(mi.Price)
                        FROM OrderItems oi
                        JOIN MenuItems mi ON oi.MenuID = mi.MenuID
                        WHERE oi.OrderID = Orders.OrderID
                    )";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
