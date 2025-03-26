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
    public partial class Send_Reply : Form
    {
        private HallReservationTable reservationTable = new HallReservationTable();
        private string reservationId;
        public Send_Reply(string reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            txtReply.Text = $"Replying to Reservation: {reservationId}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReply.Text))
            {
                MessageBox.Show("Please enter a reply message");
                return;
            }

            try
            {
                reservationTable.UpdateValue(reservationId, "RequestResponse", txtReply.Text);
                MessageBox.Show("Reply sent successfully!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending reply: {ex.Message}");
            }
        }

        private void txtReply_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
