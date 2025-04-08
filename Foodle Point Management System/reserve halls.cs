// Badr

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
using Microsoft.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    public partial class reserve_halls : Form
    {
        private Customer _currentCustomer;
        public reserve_halls(Customer customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Get the values from the textboxes
            string eventType = txtEventType.Text.Trim();
            DateTime eventDate = dtpEventDate.Value; // DateTimePicker for selecting the date
            int expectedPeople;

            // Get the optional remarks (additional things)
            string additionalThings = txtAdditionalThings.Text.Trim();

            // Customer ID (this will be passed from your current customer object)
            string customerID = _currentCustomer.GetCustomerID();

            // Validate the input: EventType, EventDate, and ExpectedPeople
            if (string.IsNullOrWhiteSpace(eventType) || !int.TryParse(txtExpectedPeople.Text, out expectedPeople) || expectedPeople <= 0)
            {
                MessageBox.Show("Please fill in all required fields: Event Type, Event Date, and Expected Number of People.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new ReservationHandler instance
            Reservation_handler reservationHandler = new Reservation_handler(
                "Data Source=172.18.48.1,1433;Initial Catalog=ioop_db;User ID=anderson_login;Password=123;Trust Server Certificate=True",
                customerID,
                eventType,
                eventDate,
                expectedPeople,
                additionalThings
            );

            // Save the reservation
            if (reservationHandler.SaveReservation())
            {
                MessageBox.Show("Your reservation has been successfully submitted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the fields after submission
                ClearFields();
            }
            else
            {
                MessageBox.Show("There was an error submitting your reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtEventType.Clear();
            dtpEventDate.Value = DateTime.Now;  // Reset to current date
            txtExpectedPeople.Clear();
            txtAdditionalThings.Clear();
        }
        
        
       

        private void reserve_halls_Load(object sender, EventArgs e)
        {
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            CustomerDashboard mainpage = new CustomerDashboard(_currentCustomer);
            mainpage.Show();
            this.Hide();
        }

        private void reserve_halls_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    
 }

 
    

