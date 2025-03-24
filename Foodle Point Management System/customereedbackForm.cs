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
        private CustomerClass1 _currentCustomer;
        public customereedbackForm(CustomerClass1 customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }


        private void customereedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        { // Get the CustomerID from the currently logged-in customer
            string customerID = _currentCustomer.CustomerID;

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


        {
            // Get the logged-in customer's ID and the request entered
            string customerID = _currentCustomer.CustomerID; // Customer ID from the logged-in user
            string remarks = txtrequest.Text.Trim(); // Request entered by the user

            if (string.IsNullOrWhiteSpace(remarks))
            {
                MessageBox.Show("Please enter your request before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 1: Fetch the existing ReservationID from the database for the logged-in customer
            string reservationID = "";

            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string query = "SELECT ReservationID FROM HallReservation " +
                           "WHERE CustomerID = @CustomerID AND ReservationStatus = 'Pending'";  // Only for pending reservations

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reservationID = reader["ReservationID"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No pending reservation found for this customer.", "No Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return; // Exit if no pending reservation is found
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching reservation details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Step 2: Update the Remarks for the existing ReservationID
            string updateQuery = @"UPDATE HallReservation 
                           SET Remarks = @Remarks
                           WHERE ReservationID = @ReservationID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@Remarks", remarks);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your request has been sent to the reservation coordinator!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtrequest.Clear(); // Clear the request textbox
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error submitting request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }



        }
        }
}
