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
    public partial class UpdateReservationStatusForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public UpdateReservationStatusForm()
        {
            InitializeComponent();
            LoadReservations();
        }
        private void LoadReservations()
        {
            dgvReservations.DataSource = db.GetReservations();
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void chkPending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRejected_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page().Show();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation");
                return;
            }

            string newStatus = "";
            if (chkPending.Checked) newStatus = "Pending";
            if (chkConfirmed.Checked) newStatus = "Confirmed";
            if (chkCompleted.Checked) newStatus = "Completed";
            if (chkRejected.Checked) newStatus = "Rejected";

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a status");
                return;
            }

            string reservationId = dgvReservations.SelectedRows[0].Cells["ReservationID"].Value.ToString();

            int result = db.UpdateReservation(
                reservationId,
                dgvReservations.SelectedRows[0].Cells["CustomerID"].Value.ToString(),
                dgvReservations.SelectedRows[0].Cells["HallNumber"].Value.ToString(),
                dgvReservations.SelectedRows[0].Cells["EventType"].Value.ToString(),
                Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["Capacity"].Value),
                newStatus);

            if (result > 0)
            {
                MessageBox.Show("Status updated successfully!");
                LoadReservations();

                // Clear checkboxes
                chkPending.Checked = false;
                chkConfirmed.Checked = false;
                chkCompleted.Checked = false;
                chkRejected.Checked = false;
            }

        }
    }
}
