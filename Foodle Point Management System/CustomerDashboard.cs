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
        private CustomerClass1 _currentCustomer;
        
        public CustomerDashboard(CustomerClass1 customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {

            OrderFoodForm orderFoodForm = new OrderFoodForm(_currentCustomer);
            orderFoodForm.Show();

       

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrders = new ViewOrdersForm(_currentCustomer);
            viewOrders.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            customereedbackForm feedbackForm = new customereedbackForm(_currentCustomer);
            feedbackForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Profile profileForm = new Profile();
            //profileForm.Show();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }



}}
