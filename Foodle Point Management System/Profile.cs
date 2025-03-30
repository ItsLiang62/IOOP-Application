using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)



        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtgender.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";
            string newCustomerId = GenerateCustomerID(); // ✅ Generate unique CustomerID
            string name = txtName.Text.Trim();
            string gender = txtgender.Text.Trim();
            string email = txtEmail.Text.Trim();  // ✅ Email comes first
            string phone = txtPhone.Text.Trim();  // ✅ Phone comes after email

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open(); // ✅ Ensure the connection is open before using it

                    // ✅ Always insert a new customer (without checking if they exist)
                    string insertQuery = @"
                INSERT INTO Customer (CustomerID, CustomerName, Gender, Email, PhoneNumber)
                VALUES (@customerId, @name, @gender, @email, @phone)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", newCustomerId);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@email", email);  // ✅ Email first
                        cmd.Parameters.AddWithValue("@phone", phone);  // ✅ Phone after email

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Profile added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // ✅ The connection automatically closes when the 'using' block ends
        }

        private string GenerateCustomerID()
        {
            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MAX(CustomerID) FROM Customer";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        int lastId = int.Parse(result.ToString().Replace("CUST", ""));
                        return "CUST" + (lastId + 1).ToString("D3"); // Example: CUST005
                    }
                    else
                    {
                        return "CUST001"; // First customer
                    }
                }
            }
        }



    }

}








