using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    class MenuItem
    {
        

        private string ItemNumber { get; set; }
        private string ItemName { get; set; }
        private decimal Price { get; set; }
        private string Category { get; set; }

        public MenuItem(string itemNumber, string itemName, decimal price, string category)
        {
            ItemNumber = itemNumber;
            ItemName = itemName;
            Price = price;
            Category = category;
        }

        // Method to get all menu items from the database
        public static List<MenuItem> GetAllMenuItems(string connectionString)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ItemNumber, ItemName, Price, Category FROM Item";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    menuItems.Add(new MenuItem(
                        reader["ItemNumber"].ToString(),
                        reader["ItemName"].ToString(),
                        Convert.ToDecimal(reader["Price"]),
                        reader["Category"].ToString()
                    ));
                }
            }
            return menuItems;
        }

    }
}
