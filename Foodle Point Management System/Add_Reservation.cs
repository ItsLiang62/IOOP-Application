// Adrian Liew Ren Qian

using System;
using System.Collections;
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
        private HallTable hallTable = new HallTable();

        public Add_Reservation(ResvCoordinator ResvCoordinatorUser)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;

            txtReservationID.Text = reservationTable.GetNewReservationID();
            txtReservationID.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                    string.IsNullOrWhiteSpace(txtEventType.Text) ||
                    string.IsNullOrWhiteSpace(txtEventDate.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                string reservationID = txtReservationID.Text;
                string customerID = txtCustomerID.Text;
                string eventType = txtEventType.Text;
                string eventDate = txtEventDate.Text;
                int expectedCount = int.Parse(txtExpectedCount.Text);
                string status = "Pending";
                string requestResponse = txtRequestResponse.Text;
                string remarks = txtRemarks.Text;

                try
                {
                    string hallNumber = GetAvailableHalls(expectedCount)[0];
                    reservationTable.InsertRow(
                    reservationID, hallNumber, customerID, eventType,
                    eventDate, expectedCount, status, requestResponse, remarks
                    );
                    MessageBox.Show($"Reservation added successfully! Automatically assigned to {hallNumber}.");
                    hallTable.UpdateValue(hallNumber, "IsAvailable", false);
                    this.Hide();
                }
                catch (Exception)
                {
                    MessageBox.Show("Operation failed. All halls are currently unavailable.");
                    return;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error adding reservation: {ex.Message}");
            }
        }

        private List<string> GetAvailableHalls(int expectedCount)
        {
            List<string> suitableHalls = new List<string>();

            List<object> hallNumbers = hallTable.GetColumnValues("HallNumber");

            foreach (object hallNumber in hallNumbers)
            {
                bool isAvailable = Convert.ToBoolean(hallTable.GetValue(hallNumber.ToString(), "IsAvailable"));
                int capacity = Convert.ToInt32(hallTable.GetValue(hallNumber.ToString(), "Capacity"));

                if (isAvailable && capacity >= expectedCount)
                {
                    suitableHalls.Add(hallNumber.ToString());
                }
            }

            return suitableHalls;
        }

        private void Add_Reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
