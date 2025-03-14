﻿using System;
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
    public partial class CustomerDashboard: Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {
            OrderFood orderFoodForm = new OrderFood();
            orderFoodForm.Show();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrdersForm = new ViewOrders();
            viewOrdersForm.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.Show();
        }
    }
}
