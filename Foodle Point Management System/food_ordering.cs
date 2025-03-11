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

namespace new_customer
{
    public partial class food_ordering : Form
    {
        public food_ordering()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userControl15_Load(object sender, EventArgs e)
        {

        }

        private void food_ordering_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";
            ;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT Category FROM Item"; // Get unique categories

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbCuisineType.Items.Add(reader["Category"].ToString());



                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCuisineType_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstMenuItems.Items.Clear(); // Clear previous items

            string selectedCategory = cmbCuisineType.SelectedItem.ToString();
            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ItemName FROM Item WHERE Category = @category";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@category", selectedCategory);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstMenuItems.Items.Add(reader["ItemName"].ToString());
                        }


                    }

                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lstMenuItems.SelectedItem != null)
            {
                lstCart.Items.Add(lstMenuItems.SelectedItem.ToString()); // Add selected item to cart
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

            if (lstCart.SelectedItem != null)
            {
                lstCart.Items.Remove(lstCart.SelectedItem);
            }


        }

        private void btnEditQuantity_Click(object sender, EventArgs e)

        { 
        {
            if (lstCart.SelectedItem != null && !string.IsNullOrWhiteSpace(txtEditQuantity.Text))
            {
                int quantity;
                if (int.TryParse(txtEditQuantity.Text, out quantity) && quantity > 0)
                {
                    string selectedItem = lstCart.SelectedItem.ToString();

                    // Extract the item name before " - Qty"
                    int qtyIndex = selectedItem.IndexOf(" - Qty:");
                    string itemName = (qtyIndex > 0) ? selectedItem.Substring(0, qtyIndex) : selectedItem;

                    // Update the selected item with new quantity
                    int index = lstCart.SelectedIndex;
                    lstCart.Items[index] = $"{itemName} - Qty: {quantity}";
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item and enter a quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstMenuItems.Items.Clear();

            string searchText = txtSearch.Text.Trim();
            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ItemName FROM Item WHERE ItemName LIKE @search";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstMenuItems.Items.Add(reader["ItemName"].ToString());
                        }
                    }
                }
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        
        {
            if (lstCart.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before confirming.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); // Start transaction

                try
                {
                    string customerId = "CUST001"; // Replace with actual logged-in customer ID

                    foreach (var item in lstCart.Items)
                    {
                        string cartItem = item.ToString();
                        int qtyIndex = cartItem.LastIndexOf(" - Qty: ");
                        if (qtyIndex == -1) continue;

                        string itemName = cartItem.Substring(0, qtyIndex).Trim();
                        int quantity = int.Parse(cartItem.Substring(qtyIndex + 8).Trim());

                        // Retrieve ItemNumber from Item table
                        string itemNumberQuery = "SELECT ItemNumber FROM Item WHERE ItemName = @itemName";
                        string itemNumber = "";

                        using (SqlCommand cmd = new SqlCommand(itemNumberQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@itemName", itemName);
                            var result = cmd.ExecuteScalar();
                            if (result != null)
                                itemNumber = result.ToString();
                        }

                        if (string.IsNullOrEmpty(itemNumber))
                        {
                            MessageBox.Show($"Error: Item '{itemName}' not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            continue;
                        }

                        // Insert into ItemOrder table
                        string insertOrderQuery = @"
                    INSERT INTO ItemOrder (OrderID, ItemNumber, CustomerID, ChefEmployeeID, DateOfOrder, OrderStatus)
                    VALUES (@orderId, @itemNumber, @customerId, @chefId, @dateOfOrder, @orderStatus)";

                        using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@orderId", Guid.NewGuid().ToString().Substring(0, 8)); // Unique Order ID
                            cmd.Parameters.AddWithValue("@itemNumber", itemNumber);
                            cmd.Parameters.AddWithValue("@customerId", customerId); // Replace with actual Customer ID
                            cmd.Parameters.AddWithValue("@chefId", "EMP001"); // Replace with actual Employee ID
                            cmd.Parameters.AddWithValue("@dateOfOrder", DateTime.Now);
                            cmd.Parameters.AddWithValue("@orderStatus", "Pending");

                            cmd.ExecuteNonQuery();
                        }

                        // Update the Item table to reduce stock quantity
                        string updateItemQuery = "UPDATE Item SET Quantity = Quantity - @orderedQty WHERE ItemNumber = @itemNumber";

                        using (SqlCommand cmd = new SqlCommand(updateItemQuery, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@orderedQty", quantity);
                            cmd.Parameters.AddWithValue("@itemNumber", itemNumber);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); // Save all orders
                    MessageBox.Show("✅ Orders saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstCart.Items.Clear(); // Clear the cart after confirming
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback if error occurs
                    MessageBox.Show("❌ Error saving order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }



}






    

      
