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
    public partial class AdminHomePage: Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            UserManagement UserForm = new UserManagement();
            this.Hide(); // Hide AdminHomePage
            UserForm.ShowDialog(); // Open in modal mode (prevents external window behavior)
            this.Show(); // Show AdminHomePage again when ManageUsers closes
        }

        private void btnViewSalesReport_Click(object sender, EventArgs e)
        {
            ViewSales SalesForm = new ViewSales();
            this.Hide();
            SalesForm.ShowDialog(); 
            this.Show(); 
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ViewCustomerFeedback FeedbackForm = new ViewCustomerFeedback();
            this.Hide();
            FeedbackForm.ShowDialog(); 
            this.Show(); 
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile ProfileForm = new UpdateProfile();
            this.Hide();
            ProfileForm.ShowDialog(); 
            this.Show(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide(); 
            frmMain.ShowDialog(); 
            this.Show(); 
        }
    }
}
