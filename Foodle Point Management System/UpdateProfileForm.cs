// Adrian Liew Ren Qian

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
        private ResvCoordinator ResvCoordinatorUser;
        private EmployeeTable employeeTable = new EmployeeTable();
        private InputChecker inputChecker = new InputChecker();
        private string InputFullName { get; set; }
        private string InputDOB { get; set; }
        private string InputEmail { get; set; }
        private string InputPhoneNum { get; set; }
        private string InputPassword { get; set; }
        public UpdateProfileForm(ResvCoordinator ResvCoordinatorUser)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            txtReservationCoordinatorID.Text = ResvCoordinatorUser.GetEmployeeID();
            txtReservationCoordinatorID.Enabled = false;
            txtFullName.Text = ResvCoordinatorUser.GetFullName();
            cmbGender.Text = ResvCoordinatorUser.GetGender();
            txtDateOfBirth.Text = ResvCoordinatorUser.GetDOB();
            txtPhoneNumber.Text = ResvCoordinatorUser.GetPhoneNum();
            txtEmail.Text = ResvCoordinatorUser.GetEmail();
            txtPassword.Text = ResvCoordinatorUser.GetPassword();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page(ResvCoordinatorUser).Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            InputFullName = txtFullName.Text;
            InputDOB = txtDateOfBirth.Text;
            InputEmail = txtEmail.Text;
            InputPhoneNum = txtPhoneNumber.Text;
            InputPassword = txtPassword.Text;

            if (AllInputValid(out string errorMessage))
            {
                try
                {
                    employeeTable.UpdateValue(ResvCoordinatorUser.GetEmployeeID(), "EmployeeName", InputFullName);
                    employeeTable.UpdateValue(ResvCoordinatorUser.GetEmployeeID(), "Gender", cmbGender.Text);
                    employeeTable.UpdateValue(ResvCoordinatorUser.GetEmployeeID(), "DOB", InputDOB);
                    employeeTable.UpdateValue(ResvCoordinatorUser.GetEmployeeID(), "PhoneNumber", InputPhoneNum);
                    employeeTable.UpdateValue(ResvCoordinatorUser.GetEmployeeID(), "Email", InputEmail);
                    employeeTable.UpdateValue(ResvCoordinatorUser.GetEmployeeID(), "AccountPassword", InputPassword);

                    ResvCoordinatorUser.Refresh();

                    MessageBox.Show("Profile updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating profile: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            bool validName = inputChecker.IsTextOnly(InputFullName, out string eName, "Full Name");
            bool validDate = inputChecker.IsValidDate(InputDOB, out string eDOB);
            bool validEmail = inputChecker.IsValidEmail(InputEmail, out string eEmail);
            bool validPhoneNum = inputChecker.IsValidPhoneNumber(InputPhoneNum, out string ePhoneNum);
            bool validPassword = !string.IsNullOrWhiteSpace(InputPassword);

            messageBoxErrorMessage = string.Empty;

            foreach (string error in new string[] { eName, eDOB, eEmail, ePhoneNum })
            {
                if (error != "No error")
                {
                    messageBoxErrorMessage += error + Environment.NewLine;
                }
            }

            if (!validPassword)
            {
                messageBoxErrorMessage += "Password cannot be empty" + Environment.NewLine;
            }

            return messageBoxErrorMessage == string.Empty;
        }

        private void UpdateProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
