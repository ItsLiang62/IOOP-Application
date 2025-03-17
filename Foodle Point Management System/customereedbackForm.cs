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
    public partial class customereedbackForm : Form
    {

        public customereedbackForm()
        {
            InitializeComponent();
        }
           

        private void customereedbackForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Debug: CustomerID in Feedback Form = " + _customerID);

            if (string.IsNullOrWhiteSpace(_customerID))
            {
                MessageBox.Show("Error: Customer ID is missing in FeedbackForm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Please enter your feedback before submitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numRating.Value < 1 || numRating.Value > 5)
            {
                MessageBox.Show("Please select a rating between 1 and 5.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string feedbackText = txtFeedback.Text.Trim();
            int rating = (int)numRating.Value;
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            // ✅ Step 2: Save Feedback to Database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackSentence, Rating) VALUES (@FeedbackID, @CustomerID, @FeedbackSentence, @Rating)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FeedbackID", Guid.NewGuid().ToString().Substring(0, 8)); // Generate unique FeedbackID
                    cmd.Parameters.AddWithValue("@CustomerID", _customerID);
                    cmd.Parameters.AddWithValue("@FeedbackSentence", feedbackText);
                    cmd.Parameters.AddWithValue("@Rating", rating);

                    cmd.ExecuteNonQuery();
                }
            }

            // ✅ Step 3: Show Success Message and Clear Fields
            MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFeedback.Clear();
            numRating.Value = 5; // Reset to default rating
        }
    } 
}
