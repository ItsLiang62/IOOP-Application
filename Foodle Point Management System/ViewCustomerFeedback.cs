using Shared_Class_Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class ViewCustomerFeedback : Form
    {
        private SystemAdministrator currentAdmin;
        private FeedbackTable _feedbackTable;

        public ViewCustomerFeedback(SystemAdministrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;
            _feedbackTable = new FeedbackTable();
        }

        private void ViewCustomerFeedback_Load(object sender, EventArgs e)
        {
            // Load feedback data when the form loads
            LoadFeedbackData();
        }

        private void LoadFeedbackData()
        {
            try
            {
                // Fetch all feedback records (using FeedbackID as a unique identifier for rows)
                List<object> feedbackIDs = _feedbackTable.GetColumnValues("FeedbackID");

                // Create a DataTable to bind to the DataGridView
                DataTable feedbackDataTable = new DataTable();

                // Add columns to the DataTable (ensure these column names match exactly with the ones in your Feedback table)
                feedbackDataTable.Columns.Add("FeedbackID");
                feedbackDataTable.Columns.Add("CustomerID");
                feedbackDataTable.Columns.Add("FeedbackSentence");
                feedbackDataTable.Columns.Add("Rating");

                // Loop through all FeedbackIDs and fetch the corresponding rows
                foreach (var feedbackID in feedbackIDs)
                {
                    // Fetch row values for the current FeedbackID
                    List<object> rowValues = _feedbackTable.GetRowValues(feedbackID.ToString());

                    // Add the fetched row to the DataTable
                    feedbackDataTable.Rows.Add(rowValues.ToArray());
                }

                // Bind the DataTable to the DataGridView
                dgvFeedback.DataSource = feedbackDataTable;

                // Optional: Format the DataGridView for better readability
                dgvFeedback.Columns["FeedbackID"].HeaderText = "Feedback ID";
                dgvFeedback.Columns["CustomerID"].HeaderText = "Customer ID";
                dgvFeedback.Columns["FeedbackSentence"].HeaderText = "Feedback Sentence";
                dgvFeedback.Columns["Rating"].HeaderText = "Rating";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide ViewCustomerFeedback form
            AdminHomePage adminPage = Application.OpenForms["AdminHomePage"] as AdminHomePage;

            if (adminPage != null)
            {
                adminPage.Show(); // Show existing AdminHomePage
            }
            else
            {
                adminPage = new AdminHomePage(currentAdmin); // In case it was closed
                adminPage.Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implement any action you want on cell click
        }

        private void ViewCustomerFeedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the feedback data in the DataGridView
            LoadFeedbackData();
        }
    }
}
