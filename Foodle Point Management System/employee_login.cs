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
    public partial class frmEmployeeLogin: Form
    {
        private EmployeeTable myEmployeeTable = new EmployeeTable();
        
        private string EmployeeID
        { get; set; }

        private string Position
        { get; set; }

        private string CorrectPassword
        { get; set; }

        private string InputEmail
        { get; set; }

        private string InputPassword
        { get; set; }

        public frmEmployeeLogin()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }

        private void frmEmployeeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage;

            InputEmail = txtEmail.Text;
            InputPassword = txtPassword.Text;

            try
            {
                EmployeeID = myEmployeeTable.GetEmployeeIDWithEmail(InputEmail);
                Position = myEmployeeTable.GetValue(EmployeeID, "Position").ToString();
            }
            catch (Exception ex)
            {
                messageBoxErrorMessage = ex.Message;
                MessageBox.Show(messageBoxErrorMessage);
                return;
            }

            CorrectPassword = myEmployeeTable.GetValue(EmployeeID, "AccountPassword").ToString();

            if (InputPassword == CorrectPassword)
            {
                if (Position == "Manager")
                {
                    frmManagerMain managerMainPage = new frmManagerMain(new Manager(EmployeeID));
                    managerMainPage.Show();
                    this.Hide();
                }

                else if (Position == "Reservation Coordinator")
                {
                    Resv_Main_Page resvCoordinatorMainPage = new Resv_Main_Page(new ResvCoordinator(EmployeeID));
                    resvCoordinatorMainPage.Show();
                    this.Hide();
                }

                else if (Position == "System Administrator")
                {
                    AdminHomePage systemAdministratorMainPage = new AdminHomePage(new SystemAdministrator(EmployeeID));
                    systemAdministratorMainPage.Show();
                    this.Hide();
                }

                    MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
            
            
        }
    }
}
