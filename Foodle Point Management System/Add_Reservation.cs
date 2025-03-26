using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class Add_Reservation : Form
    {
        private HallReservationTable reservationTable = new HallReservationTable();
        public Add_Reservation()
        {
            InitializeComponent();
            SetupForm();
        }
        private void SetupForm()
        {
            // Initialize combo box items
            cmbReservationStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Completed", "Rejected" });
            cmbReservationStatus.SelectedIndex = 0; // Default to "Pending"
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtReservationID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtReservationID.Text) ||
                    string.IsNullOrWhiteSpace(txtHallNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                    string.IsNullOrWhiteSpace(txtEventType.Text) ||
                    string.IsNullOrWhiteSpace(txtEventDate.Text))
                {
                    MessageBox.Show("Please fill in all required fields");
                    return;
                }

                // Validate date format
                if (!DateTime.TryParse(txtEventDate.Text, out DateTime eventDate))
                {
                    MessageBox.Show("Please enter a valid date (e.g., MM/DD/YYYY)");
                    return;
                }

                // Convert expected count to integer (nullable)
                int? expectedCount = null;
                if (!string.IsNullOrWhiteSpace(txtExpectedCount.Text))
                {
                    if (!int.TryParse(txtExpectedCount.Text, out int tempCount))
                    {
                        MessageBox.Show("Expected Count must be a number");
                        return;
                    }
                    expectedCount = tempCount;
                }

                // Insert the new reservation
                // Correct way to call InsertRow with all required parameters
                reservationTable.InsertRow(
                    txtReservationID.Text,
                    txtHallNumber.Text,  // Fixed typo from "Hail" to "Hall"
                    txtCustomerID.Text,
                    txtEventType.Text,
                    txtEventDate.Text,  // Use .Text instead of .ToString()
                    expectedCount: 0,  // Provide default or get from your form
                    cmbReservationStatus.SelectedItem.ToString(),
                    requestResponse: string.Empty,  // Provide default or get from your form
                    txtRemarks.Text);

                // Set request response if provided
                if (!string.IsNullOrWhiteSpace(txtRequestResponse.Text))
                {
                    reservationTable.UpdateValue(txtReservationID.Text, "RequestResponse", txtRequestResponse.Text);
                }

                // Set expected count if provided
                if (expectedCount.HasValue)
                {
                    reservationTable.UpdateValue(txtReservationID.Text, "ExpectedCount", expectedCount.Value);
                }

                MessageBox.Show("Reservation added successfully!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding reservation: {ex.Message}");
            }
        }

        private void txtEventDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
