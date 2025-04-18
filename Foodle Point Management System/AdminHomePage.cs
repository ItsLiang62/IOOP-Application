﻿// Mohammad

using Shared_Class_Library;
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
    public partial class AdminHomePage: Form
    {
        private SystemAdministrator currentAdmin;

        public AdminHomePage(SystemAdministrator admin)
        {
            InitializeComponent();
            //MessageBox.Show("AdminHomePage loaded");
            currentAdmin = admin;
            // Check if admin is null
            if (admin == null)
            {
                MessageBox.Show("Admin object is null! Check if the login was successful.");
                return; // Prevent form from loading if admin is null
            }

            currentAdmin = admin; // Initialize currentAdmin if valid

        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            UserManagement UserForm = new UserManagement(currentAdmin);
            this.Hide(); // Hide AdminHomePage
            UserForm.Show();        }

        private void btnViewSalesReport_Click(object sender, EventArgs e)
        {
            ViewSales SalesForm = new ViewSales(currentAdmin);
            this.Hide();
            SalesForm.Show(); 
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            ViewCustomerFeedback FeedbackForm = new ViewCustomerFeedback(currentAdmin);
            this.Hide();
            FeedbackForm.Show(); 
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile ProfileForm = new UpdateProfile(currentAdmin);
            this.Hide();
            ProfileForm.Show(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide(); 
            frmMain.Show(); 
        }

        private void AdminHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
