using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Class_Library;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    public partial class CustomerDashboard: Form
    {
        private Customer _currentCustomer;
        
        public CustomerDashboard(Customer customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {

            OrderFoodForm orderFoodForm = new OrderFoodForm(_currentCustomer);
            orderFoodForm.Show();
            this.Hide();



        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrders = new ViewOrdersForm(_currentCustomer);
            viewOrders.Show();
            this.Hide();

        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            customereedbackForm feedbackForm = new customereedbackForm(_currentCustomer);
            feedbackForm.Show();
            this.Hide();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile(_currentCustomer);
            profileForm.Show();
            this.Hide();

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            reserve_halls reserve_halls = new reserve_halls(_currentCustomer);
            reserve_halls.Show();
            this.Hide();

        }

        private void btnMain_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }
    }
}
