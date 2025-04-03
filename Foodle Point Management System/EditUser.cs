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
    public partial class EditUser: Form
    {
        private SystemAdministrator currentAdmin;
        private string employeeID;


        public EditUser(SystemAdministrator admin, string Id)
        {
            InitializeComponent();
            currentAdmin = admin;  // Store the passed admin object
            employeeID = Id;

            // Load the user's current info into the form
            LoadUserData();


        }

        private void LoadUserData()
        {
            EmployeeTable empTable = new EmployeeTable();
            List<object> row = empTable.GetRowValues(employeeID);

            if (row.Count == 8)
            {
                txtUsernameE.Text = row[1].ToString();
                cmbRoleE.Text = row[2].ToString();
                txtEmailE.Text = row[4].ToString();
                txtPhoneNumberE.Text = row[5].ToString();
            }
            else
            {
                MessageBox.Show("Failed to load user data.");
                this.Close();
            }

        }

        private bool ValidateInputs()
        {
            // Validate Username
            if (string.IsNullOrWhiteSpace(txtUsernameE.Text))
            {
                MessageBox.Show("Username cannot be empty.");
                return false;
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(txtEmailE.Text) || !txtEmailE.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            // Validate Phone Number (ensure it's at least 10 characters long)
            if (string.IsNullOrWhiteSpace(txtPhoneNumberE.Text) || txtPhoneNumberE.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid phone number.");
                return false;
            }

            return true;
        }


        private void EditUser_Load(object sender, EventArgs e)
        {

        }

        private void txtUsernameE_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRoleE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())  // Only proceed if the inputs are valid
            {
                try
                {
                    EmployeeTable empTable = new EmployeeTable();

                    // Save the updated user data to the database
                    empTable.UpdateValue(employeeID, "EmployeeName", txtUsernameE.Text);
                    empTable.UpdateValue(employeeID, "Position", cmbRoleE.Text);
                    empTable.UpdateValue(employeeID, "Email", txtEmailE.Text);
                    empTable.UpdateValue(employeeID, "PhoneNumber", txtPhoneNumberE.Text);

                    MessageBox.Show("User profile updated successfully!");
                    this.Hide(); // Close the form after successful save
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message);
                }
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            // Hide the EditUser form
            this.Hide();

            // Check if the UserManagement form is already open
            UserManagement userManagementForm = Application.OpenForms["UserManagement"] as UserManagement;

            // If the form isn't open, create a new instance
            if (userManagementForm == null)
            {
                userManagementForm = new UserManagement(currentAdmin);  // Pass currentAdmin if required
            }

            // Show the UserManagement form
            userManagementForm.Show();
        }

        private void EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
