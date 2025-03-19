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
    public partial class frmManageHallDetails: Form
    {
        private InputChecker myChecker = new InputChecker();
        private HallTable myHallTable = new HallTable("Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        private Manager ManagerUser
        { get; set; }

        private string InputHallNumberHallName
        { get; set; }

        public frmManageHallDetails(Manager managerUser)
        {
            InitializeComponent();
            this.FillComboBox();

            ManagerUser = managerUser;
        }

        private void FillComboBox()
        {
            List<object> allHallNumbers = myHallTable.GetColumnValues("HallNumber");

            foreach (object hallNumberObj in allHallNumbers)
            {
                string hallNumber = hallNumberObj.ToString();
                string hallName = myHallTable.GetValue(hallNumber, "HallName").ToString();

                cmbHall.Items.Add(hallNumber + " " + hallName);
            }
        }

        private bool IsHallSelected()
        {
            if (String.IsNullOrEmpty(cmbHall.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmManageHallDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (IsHallSelected())
            {
                InputHallNumberHallName = cmbHall.Text;
                frmEditHall editHallPage = new frmEditHall(ManagerUser, InputHallNumberHallName.Substring(0, 2));
                editHallPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a hall");
            }
            
        }
    }
}
