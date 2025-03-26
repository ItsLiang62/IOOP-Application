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
    public partial class Add_Reservation : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public Add_Reservation()
        {
            InitializeComponent();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtReservationID.Text))
            {
                MessageBox.Show("Please enter Reservation ID");
                return false;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Please enter a valid capacity (positive number)");
                return false;
            }

            return true;
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
                if (string.IsNullOrWhiteSpace(txtReservationID.Text) ||
                    string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
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

                int result = db.AddReservation(
                    txtReservationID.Text,
                    txtCustomerID.Text,
                    txtHallNumber.Text,
                    txtEvents.Text,
                    capacity,
                    txtStatus.Text);

                if (result > 0)
                {
                    MessageBox.Show("Reservation added successfully!");
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
