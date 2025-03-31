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

        private string FullName
        { get; set; }

        private string DOB
        { get; set; }

        private string Email
        { get; set; }

        private string PhoneNum
        { get; set; }

        private string Gender
        { get; set; }

        private string Password
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

            if (AllInputValid(out string messageBoxErrorMessage))
            {
                FullName = txtName.Text;
                Email = txtEmail.Text;
                PhoneNum = txtPhoneNum.Text;
                DOB = txtDOB.Text;
                Gender = cmbGender.Text;
                Password = txtPassword.Text;

                try
                {
                    myEmployeeTable.UpdateValue(employeeID, "EmployeeName", FullName);
                    myEmployeeTable.UpdateValue(employeeID, "Gender", Gender);
                    myEmployeeTable.UpdateValue(employeeID, "DOB", DOB);
                    myEmployeeTable.UpdateValue(employeeID, "Email", Email);
                    myEmployeeTable.UpdateValue(employeeID, "PhoneNumber", PhoneNum);
                    myEmployeeTable.UpdateValue(employeeID, "Password", Password);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Successfully updated profile.");
                ManagerUser.Refresh();
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            bool validName = myChecker.IsTextOnly(txtName.Text, out string eName, "Full Name");
            bool validDate = myChecker.IsValidDate(txtDOB.Text, out string eDOB);
            bool validEmail = myChecker.IsValidEmail(txtEmail.Text, out string eEmail);
            bool validPhoneNum = myChecker.IsValidPhoneNumber(txtPhoneNum.Text, out string ePhoneNum);

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
