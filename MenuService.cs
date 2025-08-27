using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapMakan
{
    public class MenuService
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=SedapMakan;Integrated Security=True";

        public List<MenuItem> GetAllMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MenuItems";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    menuItems.Add(new MenuItem
                    {
                        menuId = Convert.ToInt32(reader["MenuID"]),
                        menuName = reader["MenuName"].ToString(),
                        category = reader["Category"].ToString(),
                        price = Convert.ToDecimal(reader["Price"]),
                        isAvailable = Convert.ToBoolean(reader["IsAvailable"])
                    });
                }
                conn.Close();
            }

            return menuItems;
        }
        public bool MenuNameExists(string name)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM MenuItems WHERE CAST(MenuName AS NVARCHAR(MAX)) = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                return count > 0;
            }
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO MenuItems (MenuName, Category, Price, IsAvailable) VALUES (@name, @category, @price, @available)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", menuItem.menuName);
                cmd.Parameters.AddWithValue("@category", menuItem.category);
                cmd.Parameters.AddWithValue("@price", menuItem.price);
                cmd.Parameters.AddWithValue("@available", menuItem.isAvailable);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void UpdateMenuItem(MenuItem item)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE MenuItems SET MenuName=@name, Category=@category, Price=@price, IsAvailable=@available WHERE MenuID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", item.menuName);
                cmd.Parameters.AddWithValue("@category", item.category);
                cmd.Parameters.AddWithValue("@price", item.price);
                cmd.Parameters.AddWithValue("@available", item.isAvailable);
                cmd.Parameters.AddWithValue("@id", item.menuId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void DeleteMenuItem(int menuId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM MenuItems WHERE MenuID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", menuId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Category FROM MenuItems";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                HashSet<string> uniqueCategories = new HashSet<string>();
                while (reader.Read())
                {
                    if (reader["Category"] != DBNull.Value)
                    {
                        string category = reader["Category"].ToString();
                        if (!uniqueCategories.Contains(category))
                        {
                            uniqueCategories.Add(category);
                            categories.Add(category);
                        }
                    }
                }
                conn.Close();
            }

            return categories;
        }
        public List<MenuItem> GetMenuItemsByCategory(string category)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM MenuItems WHERE CAST(Category AS NVARCHAR(MAX)) = @category OR @category IS NULL";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@category", category);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    menuItems.Add(new MenuItem
                    {
                        menuId = Convert.ToInt32(reader["MenuID"]),
                        menuName = reader["MenuName"].ToString(),
                        category = reader["Category"].ToString(),
                        price = Convert.ToDecimal(reader["Price"]),
                        isAvailable = Convert.ToBoolean(reader["IsAvailable"])
                    });
                }
                conn.Close();
            }

            return menuItems;
        }
    }
}
