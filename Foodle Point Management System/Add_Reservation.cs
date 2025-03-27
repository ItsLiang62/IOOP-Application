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
        private ResvCoordinator ResvCoordinatorUser;
        private HallReservationTable reservationTable = new HallReservationTable();
        public Add_Reservation(ResvCoordinator ResvCoordinatorUser)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;

            // Set default status to Pending
            cmbReservationStatus.SelectedIndex = 0;

            // Auto-generate new reservation ID
            txtReservationID.Text = reservationTable.GetNewReservationID();
            txtReservationID.Enabled = false;
        }

        private void SetupForm()
        {
            cmbReservationStatus.Items.AddRange(new object[] { "Pending", "Confirmed", "Completed", "Rejected" });
            cmbReservationStatus.SelectedIndex = 0; 
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
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtHallNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                    string.IsNullOrWhiteSpace(txtEventType.Text) ||
                    string.IsNullOrWhiteSpace(txtEventDate.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Get values from form controls
                string reservationID = txtReservationID.Text;
                string hallNumber = txtHallNumber.Text;
                string customerID = txtCustomerID.Text;
                string eventType = txtEventType.Text;
                string eventDate = txtEventDate.Text;
                int expectedCount = int.Parse(txtExpectedCount.Text);
                string status = cmbReservationStatus.SelectedItem?.ToString() ?? "Pending";
                string requestResponse = txtRequestResponse.Text;
                string remarks = txtRemarks.Text;

                // Insert new reservation
                reservationTable.InsertRow(
                    reservationID, hallNumber, customerID, eventType,
                    eventDate, expectedCount, status, requestResponse, remarks
                );

                MessageBox.Show("Reservation added successfully!");
                this.Close();
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
