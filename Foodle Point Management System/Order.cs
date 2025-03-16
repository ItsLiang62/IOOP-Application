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
        public List<CartItem> Items { get; private set; }
        public string ChefEmployeeID { get; private set; }
        public string OrderStatus { get; private set; } = "Confirmed";
        public DateTime DateOfOrder { get; private set; }

        public Order(string connectionString, string customerID, List<CartItem> items)
        {
            _connectionString = connectionString;
            OrderID = Guid.NewGuid().ToString("N");
            CustomerID = customerID;
            Items = items;
            DateOfOrder = DateTime.Now;
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
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    foreach (CartItem item in Items)
                    {
                        string uniqueOrderID = Guid.NewGuid().ToString("N"); // ✅ Generate a UNIQUE OrderID for each item

                        string query = "INSERT INTO ItemOrder (OrderID, ItemNumber, CustomerID, ChefEmployeeID, DateOfOrder, OrderStatus) " +
                                       "VALUES (@OrderID, @ItemNumber, @CustomerID, @ChefEmployeeID, @DateOfOrder, @OrderStatus)";

                        using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@OrderID", uniqueOrderID);
                            cmd.Parameters.AddWithValue("@ItemNumber", item.ItemNumber);
                            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                            cmd.Parameters.AddWithValue("@ChefEmployeeID", ChefEmployeeID);
                            cmd.Parameters.AddWithValue("@DateOfOrder", DateOfOrder);
                            cmd.Parameters.AddWithValue("@OrderStatus", OrderStatus);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error processing payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


    }
}
