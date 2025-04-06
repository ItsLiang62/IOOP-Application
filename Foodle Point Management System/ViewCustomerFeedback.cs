// Badr

using Shared_Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class ViewCustomerFeedback: Form
    {
        private SystemAdministrator currentAdmin;
        private FeedbackTable _feedbackTable;

        public ViewCustomerFeedback(SystemAdministrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;
           _feedbackTable = new FeedbackTable();
        }

        private void LoadFeedbackData()
        {
            try
            {


                // Create a DataTable to hold the feedback data
                DataTable feedbackDataTable = new DataTable();

                // Add columns to the DataTable (ensure these column names match exactly with the ones in your Feedback table)
                feedbackDataTable.Columns.Add("FeedbackID");
                feedbackDataTable.Columns.Add("CustomerID");
                feedbackDataTable.Columns.Add("FeedbackSentence");
                feedbackDataTable.Columns.Add("Rating");

                // Fetch all feedback records (using FeedbackID as a unique identifier for rows)
                List<object> feedbackIDs = _feedbackTable.GetColumnValues("FeedbackID");

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

                dgvFeedback.Columns["FeedbackID"].HeaderText = "FeedbackID";
                dgvFeedback.Columns["CustomerID"].HeaderText = "CustomerID";
                dgvFeedback.Columns["FeedbackSentence"].HeaderText = "FeedbackSentence";
                dgvFeedback.Columns["Rating"].HeaderText = "Rating";
            }



            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide ManageUsers
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

        }

        private void ViewCustomerFeedback_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewCustomerFeedback_Load(object sender, EventArgs e)
        {
            LoadFeedbackData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFeedbackData();
        }
    }
}
