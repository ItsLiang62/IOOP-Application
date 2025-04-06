// Adrian Liew Ren Qian

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
        private string reservationID;
        private ResvCoordinator ResvCoordinatorUser;
        public Send_Reply(ResvCoordinator ResvCoordinatorUser, string reservationID, string currentResponse)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            this.reservationID = reservationID;
            txtReply.Text = currentResponse;
            InitializeReservationListView();

            LoadReservationDetails();

            txtReply.Text = currentResponse;
        }
        private void InitializeReservationListView()
        {
            lvReservations.Columns.Clear();
            lvReservations.Items.Clear();

            lvReservations.Columns.Add("Reservation ID", 100);
            lvReservations.Columns.Add("Hall Number", 80);
            lvReservations.Columns.Add("Customer ID", 100);
            lvReservations.Columns.Add("Event Type", 120);
            lvReservations.Columns.Add("Event Date", 100);
            lvReservations.Columns.Add("Expected Count", 90);
            lvReservations.Columns.Add("Status", 80);
            lvReservations.Columns.Add("Current Response", 200);
            lvReservations.Columns.Add("Remarks", 200);

            lvReservations.View = View.Details;
            lvReservations.FullRowSelect = true;
        }
        private void LoadReservationDetails()
        {
            try
            {
                var rowValues = reservationTable.GetRowValues(reservationID);

                lvReservations.Items.Clear();

                ListViewItem item = new ListViewItem(rowValues[0].ToString()); 
                item.SubItems.Add(rowValues[1].ToString()); 
                item.SubItems.Add(rowValues[2].ToString()); 
                item.SubItems.Add(rowValues[3].ToString()); 
                item.SubItems.Add(rowValues[4].ToString()); 
                item.SubItems.Add(rowValues[5].ToString()); 
                item.SubItems.Add(rowValues[6].ToString()); 
                item.SubItems.Add(rowValues[7]?.ToString() ?? ""); 
                item.SubItems.Add(rowValues[8]?.ToString() ?? ""); 

                lvReservations.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation details: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string response = txtReply.Text;

                if (string.IsNullOrWhiteSpace(response))
                {
                    MessageBox.Show("Please enter a reply message.");
                    return;
                }

                reservationTable.UpdateValue(reservationID, "RequestResponse", response);

                MessageBox.Show("Reply sent successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending reply: {ex.Message}");
            }
        }

        private void Send_Reply_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
