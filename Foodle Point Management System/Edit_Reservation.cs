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
    public partial class Edit_Reservation : Form
    {
        private ResvCoordinator ResvCoordinatorUser;
        private HallReservationTable reservationTable = new HallReservationTable();
        private string reservationID;

        public Edit_Reservation(ResvCoordinator ResvCoordinatorUser, string reservationID)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            this.reservationID = reservationID;
            LoadReservationDetails();
        }
        private void LoadReservationDetails()
        {
            var rowValues = reservationTable.GetRowValues(reservationID);

            txtReservationID.Text = rowValues[0].ToString();
            txtHallNumber.Text = rowValues[1].ToString();
            txtCustomerID.Text = rowValues[2].ToString();
            txtEventType.Text = rowValues[3].ToString();
            txtEventDate.Text = rowValues[4].ToString();
            txtExpectedCount.Text = rowValues[5].ToString();

            // Set combobox to current status
            cmbReservationStatus.SelectedItem = rowValues[6].ToString();

            txtRequestResponse.Text = rowValues[7]?.ToString() ?? "";
            txtRemarks.Text = rowValues[8]?.ToString() ?? "";
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Update each field that can be edited
                reservationTable.UpdateValue(reservationID, "ReservationID", txtReservationID.Text);
                reservationTable.UpdateValue(reservationID, "HallNumber", txtHallNumber.Text);
                reservationTable.UpdateValue(reservationID, "CustomerID", txtCustomerID.Text);
                reservationTable.UpdateValue(reservationID, "EventType", txtEventType.Text);
                reservationTable.UpdateValue(reservationID, "EventDate", txtEventDate.Text);
                reservationTable.UpdateValue(reservationID, "ExpectedCount", int.Parse(txtExpectedCount.Text));
                reservationTable.UpdateValue(reservationID, "ReservationStatus", cmbReservationStatus.SelectedItem.ToString());
                reservationTable.UpdateValue(reservationID, "RequestResponse", txtRequestResponse.Text);
                reservationTable.UpdateValue(reservationID, "Remarks", txtRemarks.Text);

                MessageBox.Show("Reservation updated successfully!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating reservation: {ex.Message}");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Edit_Reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
