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

namespace Foodle_Point_Management_System
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        
            
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Please enter your feedback.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRating.SelectedItem == null)
            {
                MessageBox.Show("Please select a rating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";
            string customerId = "CUST001"; // Replace with actual logged-in customer ID
            string feedbackText = txtFeedback.Text.Trim();
            int rating = int.Parse(cmbRating.SelectedItem.ToString());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackSentence, Rating)
            VALUES (@feedbackId, @customerId, @feedbackText, @rating)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@feedbackId", Guid.NewGuid().ToString().Substring(0, 8)); // Generate unique ID
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    cmd.Parameters.AddWithValue("@feedbackText", feedbackText);
                    cmd.Parameters.AddWithValue("@rating", rating);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFeedback.Clear();
                        cmbRating.SelectedIndex = -1; // Reset rating selection
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    
}
}
