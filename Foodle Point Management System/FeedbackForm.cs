using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class FeedbackForm : Form
    {
        private CustomerClass1 _currentCustomer;
        public FeedbackForm(CustomerClass1 customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            string feedbackText = txtfeedback.Text.Trim();
            int rating = Convert.ToInt32(comrateing.SelectedItem);  // Make sure to convert the rating properly

            // Validate the feedback and rating
            if (string.IsNullOrWhiteSpace(feedbackText))
            {
                MessageBox.Show("Please provide feedback before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Please select a rating between 1 and 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the CustomerID
            string customerID = _currentCustomer.CustomerID;

            // Connection string for the database
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Generate unique FeedbackID
            string feedbackID = Guid.NewGuid().ToString("N").Substring(0, 8);

            // SQL Query to insert feedback into the Feedback table
            string query = @"INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackSentence, Rating) 
                     VALUES (@FeedbackID, @CustomerID, @FeedbackSentence, @Rating)";

            // Use a SQL connection and command to insert feedback
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the SQL query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);  // Unique FeedbackID
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);   // CustomerID from the logged-in user
                    cmd.Parameters.AddWithValue("@FeedbackSentence", feedbackText);  // Feedback text
                    cmd.Parameters.AddWithValue("@Rating", rating);  // Rating value (1-5)

                    try
                    {
                        // Execute the query to save the feedback into the database
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your feedback has been submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the text boxes after submission
                        txtfeedback.Clear();
                        comrateing.SelectedIndex = -1;  // Reset the rating selection
                    }
                    catch (Exception ex)
                    {
                        // If there's any error, show it in a message box
                        MessageBox.Show("Error submitting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
