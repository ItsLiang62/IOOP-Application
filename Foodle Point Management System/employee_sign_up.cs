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
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmEmployeeSignUp: Form
    {
        private EmployeeTable myEmployeeTable = new EmployeeTable();

        private InputChecker myChecker = new InputChecker();

        private string EmployeeID
        { get; set; }

        private string InputFullName
        { get; set; }

        private string InputPosition
        { get; set; }

        private string InputGender
        { get; set; }

        private string InputDOB
        { get; set; }

        private string InputPhoneNum
        { get; set; }

        private string InputEmail
        { get; set; }

        private string FullName
        { get; set; }

        private string Position
        { get; set; }

        private string Gender
        { get; set; }

        private string DOB
        { get; set; }

        private string PhoneNum
        { get; set; }

        private string Email
        { get; set; }

        private string Password
        { get; set; }

        public frmEmployeeSignUp()
        {
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }

        private void frmEmployeeSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage;

            InputFullName = txtName.Text;
            InputPosition = cmbPosition.Text;
            InputGender = cmbGender.Text;
            InputEmail = txtEmail.Text;
            InputPhoneNum = txtPhoneNum.Text;
            InputDOB = txtDOB.Text;
            Password = txtPassword.Text;

            if (AllInputValid(out messageBoxErrorMessage))
            {
                FullName = InputFullName;
                Gender = InputGender;
                Position = InputPosition;
                Email = InputEmail;
                PhoneNum = InputPhoneNum;
                DOB = InputDOB;
                EmployeeID = myEmployeeTable.GetNewEmployeeID(Position);

                try
                {
                    myEmployeeTable.InsertRow(EmployeeID, FullName, Position, Gender, Email, PhoneNum, DOB, Password);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601 || ex.Number == 2627)
                    {
                        MessageBox.Show("Email has been registered. Please enter another email");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Unexpected error: {ex.Message}");
                        return;
                    }

                }
                MessageBox.Show($"Successfully signed up as {Position}");

            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            bool validName = myChecker.IsTextOnly(InputFullName, out string eName, "Full Name");
            bool validDate = myChecker.IsValidDate(InputDOB, out string eDOB);
            bool validEmail = myChecker.IsValidEmail(InputEmail, out string eEmail);
            bool validPhoneNum = myChecker.IsValidPhoneNumber(InputPhoneNum, out string ePhoneNum);
            bool validGender = !myChecker.IsEmptyInput(InputGender, out string eGender, "Gender");
            bool validPosition = !myChecker.IsEmptyInput(InputPosition, out string ePosition, "Position");

            messageBoxErrorMessage = String.Empty;

            foreach (string error in new string[] {eName, eGender, ePosition, eDOB, eEmail, ePhoneNum})
            {
                if (!error.Equals("No error"))
                {
                    messageBoxErrorMessage +=  error + "\n";
                }
            }

            if (messageBoxErrorMessage != String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
                  
    }
}
