using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class UpdateProfileForm : Form
    {
        private EmployeeTable employeeTable = new EmployeeTable();
        private InputChecker inputChecker = new InputChecker();

        private string InputFullName { get; set; }
        private string InputDOB { get; set; }
        private string InputEmail { get; set; }
        private string InputPhoneNum { get; set; }
        private string InputPassword { get; set; }
        private string SelectedGender { get; set; }

        public UpdateProfileForm()
        {
            InitializeComponent();
            LoadProfile();
        }
        private void LoadProfile()
        {
            try
            {

                txtReservationCoordinatorID.Text = "RC001"; 
                txtFullName.Text = "John Coordinator";
                cmbGender.Text = "Male";
                txtDateOfBirth.Text = "1985-05-15";
                txtPhoneNumber.Text = "555-123-4567";
                txtEmail.Text = "john.coordinator@business.com";
                txtPassword.Text = "securepassword123";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page().Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string coordinatorID = txtReservationCoordinatorID.Text;


            InputFullName = txtFullName.Text;
            InputDOB = txtDateOfBirth.Text;
            InputEmail = txtEmail.Text;
            InputPhoneNum = txtPhoneNumber.Text;
            InputPassword = txtPassword.Text;
            SelectedGender = cmbGender.Text;

            if (ValidateInputs(out string errorMessage))
            {
                try
                {

                    employeeTable.UpdateValue(coordinatorID, "EmployeeName", InputFullName);
                    employeeTable.UpdateValue(coordinatorID, "Gender", SelectedGender);
                    employeeTable.UpdateValue(coordinatorID, "DOB", InputDOB);
                    employeeTable.UpdateValue(coordinatorID, "Email", InputEmail);
                    employeeTable.UpdateValue(coordinatorID, "PhoneNumber", InputPhoneNum);
                    employeeTable.UpdateValue(coordinatorID, "AccountPassword", InputPassword);

                    MessageBox.Show("Profile updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating profile: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Validation Error");
            }
        }
        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = string.Empty;

            bool validName = inputChecker.IsTextOnly(InputFullName, out string nameError, "Full Name");
            bool validDOB = inputChecker.IsValidDate(InputDOB, out string dobError);
            bool validEmail = inputChecker.IsValidEmail(InputEmail, out string emailError);
            bool validPhone = inputChecker.IsValidPhoneNumber(InputPhoneNum, out string phoneError);
            bool validPassword = !string.IsNullOrWhiteSpace(InputPassword);


            if (!validName) errorMessage += nameError + "\n";
            if (!validDOB) errorMessage += dobError + "\n";
            if (!validEmail) errorMessage += emailError + "\n";
            if (!validPhone) errorMessage += phoneError + "\n";
            if (!validPassword) errorMessage += "Password cannot be empty\n";

            return string.IsNullOrEmpty(errorMessage);
        }
        private void UpdateProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
