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
        private string EmployeeID
        { get; set; }

        private string InputFullName
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

            EmployeeTable myEmployeeTable = new EmployeeTable("Data Source=10.101.57.209,1433;Initial Catalog=ioop_db;User ID=anderson_login;Password=123;Encrypt=True;Trust Server Certificate=True");

            InputFullName = txtName.Text;
            Position = cmbPosition.Text;
            Gender = cmbGender.Text;
            InputEmail = txtEmail.Text;
            InputPhoneNum = txtPhoneNum.Text;
            InputDOB = txtDOB.Text;
            Password = txtPassword.Text;

            if (AllInputValid(out messageBoxErrorMessage))
            {
                FullName = InputFullName;
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
                    }

                }
                
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            InputChecker myChecker = new InputChecker();

            string eName;
            string eDOB;
            string eEmail;
            string ePhoneNum;

            bool validName = myChecker.IsTextOnly(InputFullName, out eName);
            bool validDate = myChecker.IsValidDate(InputDOB, out eDOB);
            bool validEmail = myChecker.IsValidEmail(InputEmail, out eEmail);
            bool validPhoneNum = myChecker.IsValidPhoneNumber(InputPhoneNum, out ePhoneNum);

            messageBoxErrorMessage = String.Empty;

            if (!(validName && validDate && validEmail && validPhoneNum))
            {

                foreach (string error in new string[] {eName, eDOB, eEmail, ePhoneNum})
                {
                    if (!error.Equals("No error"))
                    {
                        messageBoxErrorMessage = messageBoxErrorMessage + error + "\n";
                    }
                }

                return false;
            }

            messageBoxErrorMessage = "No error";
            return true;
        }
                  
    }
}
