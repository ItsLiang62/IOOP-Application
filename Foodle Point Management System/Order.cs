using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    class Order
    {
        private string _connectionString;
        public string OrderID { get; private set; }
        public string CustomerID { get; private set; }
        public List<MenuItemCartItem> Items { get; private set; }
        public string ChefEmployeeID { get; private set; }
        public string OrderStatus { get; private set; } = "Confirmed";
        public DateTime DateOfOrder { get; private set; }

        public Order(string connectionString, string customerID, List<MenuItemCartItem> items,DateTime dateOfOrder)
        {
            _connectionString = connectionString;
            OrderID = Guid.NewGuid().ToString("N");
            CustomerID = customerID;
            Items = items;
            DateOfOrder = dateOfOrder;
            ChefEmployeeID = GetAvailableChef(); // Dynamically assign a chef
        }

        // ✅ Get an available chef from the Employee table
        private string GetAvailableChef()
        {
            string chefID = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 1 EmployeeID FROM Employee WHERE Position = 'Chef'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        chefID = result.ToString(); // Assign the first available chef
                    }
                }
            }

            // If no chef exists, return null to avoid FK constraint errors
            return chefID ?? "E001"; // Default to E001 if no chef is found
        }

        // ✅ Save Order to Database
        public bool SaveOrder()
        {
            // Create the SQL insert statement to save the order with the current date
            string query = @"INSERT INTO ItemOrder (OrderID, ItemNumber, CustomerID, DateOfOrder, OrderStatus, ChefEmployeeID)
                     VALUES (@OrderID, @ItemNumber, @CustomerID, @DateOfOrder, @OrderStatus, @ChefEmployeeID)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                foreach (var cartItem in Items)
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Create a new OrderID
                        string orderID = Guid.NewGuid().ToString();
                        // Assign the ChefEmployeeID (default to 'EMP001' if not available)
                        string chefEmployeeID = GetAvailableChef();
                        DateTime dateOfOrder = DateTime.Now;
                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@ItemNumber", cartItem.ItemNumber);
                        cmd.Parameters.AddWithValue("@CustomerID", this.CustomerID);
                        cmd.Parameters.AddWithValue("@DateOfOrder", this.DateOfOrder);
                        cmd.Parameters.AddWithValue("@OrderStatus", "Confirmed");  // Set the initial status to Confirmed
                        cmd.Parameters.AddWithValue("@ChefEmployeeID", chefEmployeeID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            return false;  // If insertion fails for any item, return false
                        }
                    }
                }
            }

            return true;


        }  }
}
