﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmEditItem: Form
    {
        private ItemTable myItemTable = new ItemTable("Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        private Manager ManagerUser
        { get; set; }

        private string ItemIDToEdit
        { get; set; }

        private string InputItemName
        { get; set; }

        private string InputPrice
        { get; set; }

        private string NewItemName
        { get; set; }

        private double NewPrice
        { get; set; }

        private string NewCategory
        { get; set; }
        public frmEditItem(Manager manager, string itemIDToEdit)
        {
            InitializeComponent();
            ManagerUser = manager;
            ItemIDToEdit = itemIDToEdit;
            this.ConstructTitle();
            this.FillInputBox();
        }

        private void lblTitle_Resize(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private void ConstructTitle()
        {
            lblTitle.Text = $"Edit Item {ItemIDToEdit}";
        }

        private void FillInputBox()
        {
            txtItemName.Text = myItemTable.GetValue(ItemIDToEdit, "ItemName").ToString();
            txtPrice.Text = myItemTable.GetValue(ItemIDToEdit, "Price").ToString();
            cmbCategory.SelectedItem = myItemTable.GetValue(ItemIDToEdit, "Category").ToString();
        }

        private void frmEditItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageMenuPage_Click(object sender, EventArgs e)
        {
            frmManagerMain managerMainPage = new frmManagerMain(ManagerUser);
            managerMainPage.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InputItemName = txtItemName.Text;
            InputPrice = txtPrice.Text;
            NewCategory = cmbCategory.Text;

            string messageBoxErrorMessage;

            if (AllInputValid(out messageBoxErrorMessage))
            {
                NewItemName = InputItemName;
                NewPrice = Math.Round(Convert.ToDouble(InputPrice), 2);

                try
                {
                    myItemTable.UpdateValue(ItemIDToEdit, "ItemName", NewItemName);
                    myItemTable.UpdateValue(ItemIDToEdit, "Price", NewPrice);
                    myItemTable.UpdateValue(ItemIDToEdit, "Category", NewCategory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Successfully edited item");
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            InputChecker myChecker = new InputChecker();

            bool validItemName = myChecker.IsTextOnly(InputItemName, out string eItemName);
            bool validPrice = myChecker.IsValidPrice(InputPrice, out string ePrice);

            messageBoxErrorMessage = String.Empty;

            if (!validItemName)
            {
                messageBoxErrorMessage += eItemName + "\n";
            }
            if (!validPrice)
            {
                messageBoxErrorMessage += ePrice + "\n";
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
