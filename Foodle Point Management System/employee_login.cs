﻿using System;
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
        private string EmployeeID
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

        private void btnReturnMain_Click(object sender, EventArgs e)
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

            employeeTable myEmployeeTable = new employeeTable("Data Source=10.101.33.31,1433;Initial Catalog=ioop_db;User ID=anderson_login;Password=123;Encrypt=True;Trust Server Certificate=True");

            InputEmail = txtEmail.Text;
            InputPassword = txtPassword.Text;

            try
            {
                EmployeeID = myEmployeeTable.GetEmployeeIDWithEmail(InputEmail);
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
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
            
            
        }
    }
}
