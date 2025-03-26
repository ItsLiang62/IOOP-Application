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
        private HallReservationTable reservationTable = new HallReservationTable();
        private string reservationId;

        public Edit_Reservation(string reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            LoadReservationData();
        }
        private void LoadReservationData()
        {
            try
            {
                List<object> rowValues = reservationTable.GetRowValues(reservationId);
                txtReservationID.Text = rowValues[0].ToString();
                txtHallNumber.Text = rowValues[1].ToString();
                txtCustomerID.Text = rowValues[2].ToString();
                txtEventType.Text = rowValues[3].ToString();
                txtEventDate.Text = rowValues[4].ToString();
                cmbReservationStatus.Text = rowValues[5].ToString();
                txtRemarks.Text = rowValues[6].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation: {ex.Message}");
                this.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEvents_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHallNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReservationID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCoordinatorID_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                reservationTable.UpdateValue(reservationId, "HallNumber", txtHallNumber.Text);
                reservationTable.UpdateValue(reservationId, "CustomerID", txtCustomerID.Text);
                reservationTable.UpdateValue(reservationId, "EventType", txtEventType.Text);
                reservationTable.UpdateValue(reservationId, "EventDate", txtEventDate.Text);
                reservationTable.UpdateValue(reservationId, "ReservationStatus", cmbReservationStatus.Text);
                reservationTable.UpdateValue(reservationId, "Remarks", txtRemarks.Text);

                MessageBox.Show("Reservation updated successfully!");
                this.DialogResult = DialogResult.OK;
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
    }
}
