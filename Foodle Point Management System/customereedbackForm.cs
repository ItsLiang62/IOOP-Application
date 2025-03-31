using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{

    public partial class customereedbackForm : Form
    {
        private Customer _currentCustomer;
        public customereedbackForm(Customer customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }


        private void customereedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        { // Get the CustomerID from the currently logged-in customer
            string customerID = _currentCustomer.GetCustomerID();

            // Get the feedback from the textbox
            string feedbackSentence = txtFeedback.Text;

            // Get the rating from the combo box
            int rating = Convert.ToInt32(numRating.Value);

            // Validate feedback and rating
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

            // Connection string to your database (you can store this in a configuration file later)
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // Generate unique FeedbackID using Guid
            string feedbackID = Guid.NewGuid().ToString("N");

            // SQL query to insert feedback into the Feedback table
            string query = @"INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackSentence, Rating)
                         VALUES (@FeedbackID, @CustomerID, @FeedbackSentence, @Rating)";

            // Using SQL connection to execute the query
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);  // Ensure this is the correct CustomerID
                    cmd.Parameters.AddWithValue("@FeedbackSentence", feedbackSentence);
                    cmd.Parameters.AddWithValue("@Rating", rating);

                    try
                    {
                        // Execute the insert command to save the feedback in the database
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your feedback has been submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the feedback textbox and reset the rating dropdown
                        txtFeedback.Clear();
                        numRating.Value = 1; //Reset the numeric rating to the default value(e.g., 0)
                    }
                    catch (Exception ex)
                    {
                        // If an error occurs, show an error message
                        MessageBox.Show("Error submitting feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnrequest_Click(object sender, EventArgs e)
        {     // Step 1: Capture the values from the logged-in customer and request UI
             string customerID = _currentCustomer.GetCustomerID();  // Get customer ID from the logged-in user
            string remarks = txtRequest.Text.Trim();  // Get the request from the text box

            // Step 2: Validate input
            if (string.IsNullOrWhiteSpace(remarks))
            {
                MessageBox.Show("Please enter your request before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 3: Retrieve the existing reservation details (HallNumber, EventType, EventDate) from the database
            string hallNumber = "";
            string eventType = "";
            DateTime eventDate = DateTime.Now;

            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = @"SELECT HallNumber, EventType, EventDate 
                     FROM HallReservation 
                     WHERE CustomerID = @CustomerID AND ReservationStatus = 'Pending'";

            // Fetching the Hall Number, Event Type, and Event Date from the existing reservation
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hallNumber = reader["HallNumber"].ToString();
                            eventType = reader["EventType"].ToString();
                            eventDate = Convert.ToDateTime(reader["EventDate"]);
                        }
                        else
                        {
                            MessageBox.Show("No pending reservation found for this customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            // Step 4: Update the Remarks for the current reservation
            string reservationID = "";  // This should be set to the existing reservation ID of the customer

            // Query to update the remarks
            query = @"UPDATE HallReservation 
              SET Remarks = @Remarks 
              WHERE CustomerID = @CustomerID AND HallNumber = @HallNumber AND ReservationStatus = 'Pending'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Remarks", remarks);
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.Parameters.AddWithValue("@HallNumber", hallNumber);

                        // Execute the query
                        cmd.ExecuteNonQuery();

                        // Show success message
                        MessageBox.Show("Your request has been sent to the reservation coordinator!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the text box for remarks
                        txtRequest.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error submitting request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } } }
        }
