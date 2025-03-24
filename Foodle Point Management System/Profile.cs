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
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class Profile : Form
    {
        private CustomerClass1 _currentCustomer;
        public Profile(CustomerClass1 customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }

        private void button1_Click(object sender, EventArgs e)



        {
            // Step 1: Capture the new values entered by the user
            string customerName = txtName.Text.Trim();
            string gender = txtgender.Text.Trim();
            string phoneNumber = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Step 2: Validate input (ensure none of the fields are empty)
            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all the fields before applying.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 3: SQL Update query to update the user's profile information
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string query = @"UPDATE Customer 
                     SET CustomerName = @CustomerName, 
                         Gender = @Gender, 
                         PhoneNumber = @PhoneNumber, 
                         Email = @Email
                     WHERE CustomerID = @CustomerID";  // CustomerID from the logged-in session (_currentCustomer.CustomerID)

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@CustomerID", _currentCustomer.CustomerID);  // The logged-in customer's ID

                    try
                    {
                        // Execute the query to update the customer's information
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your profile has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that may occur during the update
                        MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

    }

}








