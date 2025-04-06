// Badr

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class Profile : Form
    {
        private Customer _currentCustomer;
        public Profile(Customer customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }

        private void button1_Click(object sender, EventArgs e)



        {
            // Get the customer information
            string customerID = _currentCustomer.GetCustomerID();
            string name = txtName.Text.Trim();
            string gender = txtgender.Text.Trim();
            string phoneNumber = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Create an instance of the CustomerProfile class
            CustomerProfile profile = new CustomerProfile(customerID, name, gender, phoneNumber, email);

            // Update the profile details
            profile.UpdateProfileDetails();


        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            CustomerDashboard mainpage = new CustomerDashboard(_currentCustomer);
            mainpage.Show();
            this.Hide();
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}








