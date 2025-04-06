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
using Microsoft.Data.SqlClient;


namespace Foodle_Point_Management_System
{
    public partial class UpdateProfile: Form
    {
        private SystemAdministrator currentAdmin;
        private EmployeeTable myEmployeeTable = new EmployeeTable();
        private InputChecker myChecker = new InputChecker();

        private string Email { get; set; }
        private string PhoneNum { get; set; }
        private string Password { get; set; }

        private void FillInputBox()
        {
            txtNewEmail.Text = currentAdmin.GetEmail();
            txtNewPhone.Text = currentAdmin.GetPhoneNum();
        }

        public UpdateProfile(SystemAdministrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;
            this.FillInputBox();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide ManageUsers
            AdminHomePage adminPage = Application.OpenForms["AdminHomePage"] as AdminHomePage;

            if (adminPage != null)
            {
                adminPage.Show(); // Show existing AdminHomePage
            }
            else
            {
                adminPage = new AdminHomePage(currentAdmin); // In case it was closed
                adminPage.Show();
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Email = txtNewEmail.Text;
                PhoneNum = txtNewPhone.Text;
                Password = txtNewPassword.Text;

                try
                {
                    // Start database update
                    myEmployeeTable.UpdateValue(currentAdmin.GetEmployeeID(), "Email", Email);
                    myEmployeeTable.UpdateValue(currentAdmin.GetEmployeeID(), "PhoneNumber", PhoneNum);
                    myEmployeeTable.UpdateValue(currentAdmin.GetEmployeeID(), "AccountPassword", Password);

                    // Provide feedback for success
                    MessageBox.Show("Successfully updated profile.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Disable the button to prevent multiple clicks
                    btnUpdateProfile.Enabled = false;

                    // Refresh the admin profile object to reflect changes
                    currentAdmin.Refresh();
                }
                catch (Exception ex)
                {
                    // Error updating column with the corresponding new value
                    MessageBox.Show($"Error updating column with value {ex.Message}");
                    LogError(ex); // Log the error for developers
                }
            }
        }

        private bool ValidateInput()
        {
            string errorMessage = string.Empty;

            // Validate Email
            if (!myChecker.IsValidEmail(txtNewEmail.Text, out string emailError))
            {
                errorMessage += emailError + "\n";
            }

            // Validate Phone Number
            if (!myChecker.IsValidPhoneNumber(txtNewPhone.Text, out string phoneError))
            {
                errorMessage += phoneError + "\n";
            }

            // Display all accumulated error messages
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Input Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LogError(Exception ex)
        {
            // Log the error details (this could be to a file, database, or logging service)
            System.IO.File.AppendAllText("error_log.txt", $"{DateTime.Now}: {ex.Message}\n");
        }




        private void UpdateProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
