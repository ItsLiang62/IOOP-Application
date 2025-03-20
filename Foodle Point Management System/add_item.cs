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
    public partial class frmAddItem: Form
    {
        private ItemTable myItemTable = new ItemTable();

        Manager ManagerUser
        { get; set; }

        private string InputItemName
        { get; set; }

        private string InputPrice
        { get; set; }

        private string InputCategory
        { get; set; }

        private string ItemID
        { get; set; }

        private string ItemName
        { get; set; }

        private double Price
        { get; set; }

        private string Category
        { get; set; }

        public frmAddItem(Manager managerUser)
        {
            InitializeComponent();
            ManagerUser = managerUser;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InputItemName = txtItemName.Text;
            InputPrice = txtPrice.Text;
            Category = cmbCategory.Text;

            string messageBoxErrorMessage;

            if (AllInputValid(out messageBoxErrorMessage))
            {
                
                ItemID = myItemTable.GetNewItemID(Category);
                ItemName = InputItemName;
                Price = Math.Round(Convert.ToDouble(InputPrice), 2);

                try
                {
                    myItemTable.InsertRow(ItemID, ItemName, Price, Category);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Successfully added item");
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }


        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            InputChecker myChecker = new InputChecker();

            bool validItemName = myChecker.IsTextOnly(InputItemName, out string eItemName, "Item Name");
            bool validPrice = myChecker.IsValidPrice(InputPrice, out string ePrice);
            bool validCategory = !myChecker.IsEmptyInput(InputCategory, out string eCategory, "Category");

            messageBoxErrorMessage = String.Empty;

            foreach (string error in new string[] {eItemName, ePrice, eCategory})
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

        private void frmAddItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageMenuPage_Click(object sender, EventArgs e)
        {
            frmManageMenu manageMenuPage = new frmManageMenu(ManagerUser);
            manageMenuPage.Show();
            this.Hide();
        }
    }
}
