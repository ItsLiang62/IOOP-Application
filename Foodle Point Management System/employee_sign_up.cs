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
    public partial class frmEmployeeSignUp: Form
    {
        private string EmployeeID
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

            EmployeeTable myEmployeeTable = new EmployeeTable("Data Source=10.101.63.254,1433;Initial Catalog=ioop_db;User ID=anderson_login;Password=123;Encrypt=True;Trust Server Certificate=True");

            FullName = txtName.Text;
            Position = cmbPosition.Text;
            Gender = cmbGender.Text;
            Email = txtEmail.Text;
            PhoneNum = txtPhoneNum.Text;
            DOB = txtDOB.Text;
            Password = txtPassword.Text;
            EmployeeID = myEmployeeTable.GetNewEmployeeID(Position);

            if (AllInputValid(out messageBoxErrorMessage))
            {
                myEmployeeTable.InsertRow(EmployeeID, FullName, Position, Gender, Email, PhoneNum, DOB, Password);
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

            bool validName = myChecker.IsTextOnly(FullName, out eName);
            bool validDate = myChecker.IsValidDate(DOB, out eDOB);
            bool validEmail = myChecker.IsValidEmail(Email, out eEmail);
            bool validPhoneNum = myChecker.IsValidPhoneNumber(PhoneNum, out ePhoneNum);

            messageBoxErrorMessage = "";

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
