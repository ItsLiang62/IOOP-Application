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
            string customerID = _currentCustomer.CustomerID;  // Assuming the customer is logged in
            string feedbackSentence = txtfeedback.Text;  // Get feedback from the textbox
            int rating = Convert.ToInt32(comrateing.SelectedItem);  // Get rating from the dropdown (make sure it's between 1-5)

            // Validate the feedback and rating
            if (string.IsNullOrWhiteSpace(feedbackSentence))
            {
                MessageBox.Show("Please provide feedback before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Please select a rating between 1 and 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string feedbackID = Guid.NewGuid().ToString("N"); // Generate unique feedback ID

            // SQL Query to insert feedback into the Feedback table
            string query = @"INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackSentence, Rating)
              VALUES (@FeedbackID, @CustomerID, @FeedbackSentence, @Rating)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@FeedbackSentence", feedbackSentence);
                    cmd.Parameters.AddWithValue("@Rating", rating);

                    try
                    {
                        // Execute the insert command to save the feedback
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your feedback has been submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the feedback textbox and reset the rating dropdown
                        txtfeedback.Clear();
                        comrateing.SelectedIndex = -1;  // Reset the rating dropdown
                    }
                    catch (Exception ex)
                    {
                        // If there is any error, show an error message
                        MessageBox.Show("Error submitting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }
    }
}
