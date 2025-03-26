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
    public partial class Edit_Reservation : Form
    {
        private DataRowView row;
        private DatabaseHelper db = new DatabaseHelper();

        public Edit_Reservation(DataRowView row)
        {
            InitializeComponent();
            this.row = row;
            LoadData();
        }
        private void LoadData()
        {
            txtReservationID.Text = row["ReservationID"].ToString();
            txtCustomerID.Text = row["CustomerID"].ToString();
            txtHallNumber.Text = row["HallNumber"].ToString();
            txtEvents.Text = row["EventType"].ToString();
            txtCapacity.Text = row["Capacity"].ToString();
            txtStatus.Text = row["Status"].ToString();

            // Make ID read-only
            txtReservationID.ReadOnly = true;
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
                if (string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
                    string.IsNullOrWhiteSpace(txtHallNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtEvents.Text) ||
                    string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                    string.IsNullOrWhiteSpace(txtStatus.Text))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }

                int capacity;
                if (!int.TryParse(txtCapacity.Text, out capacity))
                {
                    MessageBox.Show("Capacity must be a number");
                    return;
                }

                int result = db.UpdateReservation(
                    txtReservationID.Text,
                    txtCustomerID.Text,
                    txtHallNumber.Text,
                    txtEvents.Text,
                    capacity,
                    txtStatus.Text);

                if (result > 0)
                {
                    MessageBox.Show("Reservation updated successfully!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
