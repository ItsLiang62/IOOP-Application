using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    class CustomerProfile
    {
        // Attributes to store the customer's profile information
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Constructor to initialize the object
        public CustomerProfile(string customerID, string name, string gender, string phoneNumber, string email)
        {
            CustomerID = customerID;
            Name = name;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Method to update the customer's profile details
        public void UpdateProfileDetails()
        {
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Update the customer profile details
                string query = "UPDATE Customer SET ";

                // Append fields to update based on non-null values
                bool firstField = true;

                if (!string.IsNullOrWhiteSpace(Name))
                {
                    query += firstField ? "Name = @Name" : ", Name = @Name";
                    firstField = false;
                }

                if (!string.IsNullOrWhiteSpace(Gender))
                {
                    query += firstField ? "Gender = @Gender" : ", Gender = @Gender";
                    firstField = false;
                }

                if (!string.IsNullOrWhiteSpace(PhoneNumber))
                {
                    query += firstField ? "PhoneNumber = @PhoneNumber" : ", PhoneNumber = @PhoneNumber";
                    firstField = false;
                }

                if (!string.IsNullOrWhiteSpace(Email))
                {
                    query += firstField ? "Email = @Email" : ", Email = @Email";
                }

                query += " WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters dynamically
                    if (!string.IsNullOrWhiteSpace(Name))
                        cmd.Parameters.AddWithValue("@Name", Name);

                    if (!string.IsNullOrWhiteSpace(Gender))
                        cmd.Parameters.AddWithValue("@Gender", Gender);

                    if (!string.IsNullOrWhiteSpace(PhoneNumber))
                        cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                    if (!string.IsNullOrWhiteSpace(Email))
                        cmd.Parameters.AddWithValue("@Email", Email);

                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

                    try
                    {
                        cmd.ExecuteNonQuery();  // Execute the update query
                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
