﻿using System;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            OrderFoodForm orderFoodForm = new OrderFoodForm();
            orderFoodForm.Show();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrders = new ViewOrdersForm();
            viewOrders.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            customereedbackForm feedbackForm = new customereedbackForm();
            feedbackForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            //Profile profileForm = new Profile();
            //profileForm.Show();
        }
    }
}
