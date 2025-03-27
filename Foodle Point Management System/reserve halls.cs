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
    public partial class reserve_halls : Form
    {
        private CustomerClass1 _currentCustomer;
        public reserve_halls(CustomerClass1 customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string customerID = _currentCustomer.CustomerID;

            // Get the input values from the form
            string eventType = txtEventType.Text.Trim();
            DateTime eventDate = dtpEventDate.Value;
            int expectedPeople;

            // Validate the input
            if (string.IsNullOrWhiteSpace(eventType) ||
                !int.TryParse(txtExpectedPeople.Text, out expectedPeople) ||
                expectedPeople <= 0 ||
                string.IsNullOrWhiteSpace(jj.Text))
            {
                MessageBox.Show("Please fill out all fields correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the additional things entered by the user (remarks)
            string additionalThings = txtAdditionalThings.Text.Trim();

            // Generate a unique Reservation ID
            string reservationID = Guid.NewGuid().ToString("N");

            // HallNumber is "TBD" by default
            string hallNumber = "TBD";

            // ReservationStatus is set to "Pending"
            string reservationStatus = "Pending";

            // RequestResponse is initially empty
            string requestResponse = "";

            // Connection string to your database
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            string query = @"INSERT INTO HallReservation 
                 (ReservationID, HallNumber, CustomerID, EventType, EventDate, ReservationStatus, Remarks, RequestResponse, ExpectedCount)
                 VALUES 
                 (@ReservationID, @HallNumber, @CustomerID, @EventType, @EventDate, @ReservationStatus, @Remarks, @RequestResponse, @ExpectedCount)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@HallNumber", hallNumber); // "TBD"
                    cmd.Parameters.AddWithValue("@CustomerID", customerID); // Customer ID
                    cmd.Parameters.AddWithValue("@EventType", eventType);   // Event type
                    cmd.Parameters.AddWithValue("@EventDate", eventDate);   // Event date
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservationStatus); // Pending status
                    cmd.Parameters.AddWithValue("@Remarks", additionalThings); // Request from the user
                    cmd.Parameters.AddWithValue("@RequestResponse", requestResponse); // Empty initially
                    cmd.Parameters.AddWithValue("@ExpectedCount", expectedPeople); // Expected number of people

                    try
                    {
                        // Execute the query to insert the reservation
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your reservation request has been submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the input fields after submission
                        ClearFields();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error submitting request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
       }
        private void ClearFields()
        {
            // Clears the fields
            txtEventType.Clear();
            dtpEventDate.Value = DateTime.Now;  // Reset to the current date
            txtExpectedPeople.Clear();
            txtAdditionalThings.Clear();
        }

    }
 }

 
    

