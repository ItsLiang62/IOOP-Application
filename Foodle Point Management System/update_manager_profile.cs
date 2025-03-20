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
    public partial class frmUpdateManagerProfile: Form
    {
        private EmployeeTable myEmployeeTable = new EmployeeTable();

        private InputChecker myChecker = new InputChecker();

        private Manager ManagerUser
        { get; set; }

        private string InputFullName
        { get; set; }

        private string InputDOB
        { get; set; }

        private string InputEmail
        { get; set; }

        private string InputPhoneNum
        { get; set; }

        private string NewFullName
        { get; set; }

        private string NewGender
        { get; set; }

        private string NewDOB
        { get; set; }

        private string NewEmail
        { get; set; }

        private string NewPhoneNum
        { get; set; }

        private string NewPassword
        { get; set; }

        public frmUpdateManagerProfile(Manager managerUser)
        {
            InitializeComponent();
            ManagerUser = managerUser;
            this.FillInputBox();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            frmManagerMain managerMainPage = new frmManagerMain(ManagerUser);
            managerMainPage.Show();
            this.Hide();
        }

        private void FillInputBox()
        {
            lblShowEmployeeID.Text = ManagerUser.GetEmployeeID();
            txtName.Text = ManagerUser.GetFullName();
            lblShowPosition.Text = ManagerUser.GetPosition();
            cmbGender.Text = ManagerUser.GetGender();
            txtDOB.Text = ManagerUser.GetDOB();
            txtPhoneNum.Text = ManagerUser.GetPhoneNum();
            txtEmail.Text = ManagerUser.GetEmail();
            txtPassword.Text = ManagerUser.GetPassword();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string employeeID = lblShowEmployeeID.Text;

            InputFullName = txtName.Text;
            InputEmail = txtEmail.Text;
            InputPhoneNum = txtPhoneNum.Text;
            InputDOB = txtDOB.Text;
            NewGender = cmbGender.Text;
            NewPassword = txtPassword.Text;

            if (AllInputValid(out string messageBoxErrorMessage))
            {
                NewFullName = InputFullName;
                NewDOB = InputDOB;
                NewEmail = InputEmail;
                NewPhoneNum = InputPhoneNum;

                try
                {
                    myEmployeeTable.UpdateValue(employeeID, "EmployeeName", NewFullName);
                    myEmployeeTable.UpdateValue(employeeID, "Gender", NewGender);
                    myEmployeeTable.UpdateValue(employeeID, "DOB", NewDOB);
                    myEmployeeTable.UpdateValue(employeeID, "Email", NewEmail);
                    myEmployeeTable.UpdateValue(employeeID, "PhoneNumber", NewPhoneNum);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Successfully updated profile.");
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

            messageBoxErrorMessage = String.Empty;

            foreach (string error in new string[] { eName, eDOB, eEmail, ePhoneNum })
            {
                if (error != "No error")
                {
                    messageBoxErrorMessage += error + "\n";
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

        private void frmUpdateManagerProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
