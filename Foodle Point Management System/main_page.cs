using System;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoginEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeLogin employeeLoginPage = new frmEmployeeLogin();
            employeeLoginPage.Show();
            this.Hide();
        }


        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerLogin customerLoginPage = new frmCustomerLogin();
            customerLoginPage.Show();
            this.Hide();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void llblSignUpCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeSignUp employeeSignUpPage = new frmEmployeeSignUp();
            employeeSignUpPage.Show();
            this.Hide();
        }

        private void llblSignUpCustomer_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCustomerSignUp customerSignUpPage = new frmCustomerSignUp();
            customerSignUpPage.Show();
            this.Hide();
        }
    }
}
