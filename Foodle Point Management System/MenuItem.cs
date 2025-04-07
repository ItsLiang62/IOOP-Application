using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    class MenuItemCartItem
    {
        

       public string ItemNumber { get; private set; }
        public string ItemName { get; private set; }
        public decimal Price { get; private set; }
        public string Category { get; private set; }

        public MenuItemCartItem(string itemNumber, string itemName, decimal price, string category = null)
        {
            ItemNumber = itemNumber;
            ItemName = itemName;
            Price = price;
            Category = category;
        }

        // Method to add an item to the cart (for CartItem behavior)
        public static void AddToCart(DataGridView dgvCart, MenuItemCartItem cartItem)
        {
            dgvCart.Rows.Add(cartItem.ItemNumber, cartItem.ItemName, cartItem.Price);
        }
        public static void EditCartItem(DataGridView dgvCart, int rowIndex, MenuItemCartItem newItem)
        {
            dgvCart.Rows[rowIndex].Cells["ItemID"].Value = newItem.ItemNumber;
            dgvCart.Rows[rowIndex].Cells["ItemName"].Value = newItem.ItemName;
            dgvCart.Rows[rowIndex].Cells["Price"].Value = newItem.Price;
        }
        public static void RemoveFromCart(DataGridView dgvCart, int rowIndex)
        {
            dgvCart.Rows.RemoveAt(rowIndex);
        }

        // Method to get all menu items from the database
        public static List<MenuItemCartItem> GetAllMenuItems(string connectionString)
        {
            List<MenuItemCartItem> menuItems = new List<MenuItemCartItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ItemID, ItemName, Price, Category FROM Item";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    menuItems.Add(new MenuItemCartItem(
                        reader["ItemID"].ToString(),
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
