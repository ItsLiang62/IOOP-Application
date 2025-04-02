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
            try
            {
                EmployeeTable empTable = new EmployeeTable();

                empTable.UpdateValue(employeeID, "EmployeeName", txtUsernameE.Text);
                empTable.UpdateValue(employeeID, "Position", cmbRoleE.Text);
                empTable.UpdateValue(employeeID, "Email", txtEmailE.Text);
                empTable.UpdateValue(employeeID, "PhoneNumber", txtPhoneNumberE.Text);

                MessageBox.Show("User profile updated successfully!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
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
