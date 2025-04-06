// Wang Liang Xuan

using System;
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
        private ItemTable myItemTable = new ItemTable();

        private InputChecker myChecker = new InputChecker();

        private Manager ManagerUser
        { get; set; }

        private string ItemIDToEdit
        { get; set; }

        private string ItemName
        { get; set; }

        private double Price
        { get; set; }

        private string Category
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
            cmbCategory.Text = myItemTable.GetValue(ItemIDToEdit, "Category").ToString();
        }

        private void frmEditItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageMenuPage_Click(object sender, EventArgs e)
        {
            frmManageMenu manageMenuPage = new frmManageMenu(ManagerUser);
            manageMenuPage.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage;

            if (AllInputValid(out messageBoxErrorMessage))
            {
                ItemName = txtItemName.Text;
                Price = Math.Round(Convert.ToDouble(txtPrice.Text), 2);
                Category = cmbCategory.Text;

                try
                {
                    myItemTable.UpdateValue(ItemIDToEdit, "ItemName", ItemName);
                    myItemTable.UpdateValue(ItemIDToEdit, "Price", Price);
                    myItemTable.UpdateValue(ItemIDToEdit, "Category", Category);
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
            bool validItemName = myChecker.IsTextOnly(txtItemName.Text, out string eItemName, "Item Name");
            bool validPrice = myChecker.IsValidPrice(txtPrice.Text, out string ePrice);

            messageBoxErrorMessage = String.Empty;

            foreach (string error in new string[] { eItemName, ePrice })
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
    }
}
