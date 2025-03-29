using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmManageMenu: Form
    {
        private ItemTable myItemTable = new ItemTable();

        private InputChecker myChecker = new InputChecker();

        private Manager ManagerUser
        { get; set; }

        private string SelectedItemIDItemName
        { get; set; }

        private string SelectedCategory
        { get; set; }

        public frmManageMenu(Manager managerUser)
        {
            InitializeComponent();
            ManagerUser = managerUser;
        }

        private void frmManageWestern_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FillItemComboBox()
        {
            cmbItem.Items.Clear();

            SelectedCategory = cmbCategory.SelectedItem.ToString();

            try
            {
                List<string> allItemIDs = myItemTable.GetItemIDsOfCategory(SelectedCategory);

                foreach (string itemID in allItemIDs)
                {
                    string itemName = myItemTable.GetValue(itemID, "ItemName").ToString();
                    cmbItem.Items.Add(itemID + " " + itemName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillItemComboBox();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItemPage = new frmAddItem(ManagerUser);
            addItemPage.Show();
            this.Hide();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage = String.Empty;
            SelectedCategory = cmbCategory.Text;
            SelectedItemIDItemName = cmbItem.Text;

            if (myChecker.IsEmptyInput(SelectedCategory, out string eCategory))
            {
                messageBoxErrorMessage += "Please select a menu category" + "\n";
            }
            
            if (myChecker.IsEmptyInput(SelectedItemIDItemName, out string eItemIDItemName))
            {
                messageBoxErrorMessage += "Please select an item" + "\n";
            }

            if (messageBoxErrorMessage != String.Empty)
            {
                MessageBox.Show(messageBoxErrorMessage);
                return;
            }
            
            
            frmEditItem editItemPage = new frmEditItem(ManagerUser, SelectedItemIDItemName.Substring(0, 4));
            editItemPage.Show();
            this.Hide();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage = String.Empty;
            SelectedCategory = cmbCategory.Text;
            SelectedItemIDItemName = cmbItem.Text;

            if (myChecker.IsEmptyInput(SelectedCategory, out string eCategory))
            {
                messageBoxErrorMessage += "Please select a menu category" + "\n";
            }

            if (myChecker.IsEmptyInput(SelectedItemIDItemName, out string eItemIDItemName))
            {
                messageBoxErrorMessage += "Please select an item" + "\n";
            }

            if (messageBoxErrorMessage != String.Empty)
            {
                MessageBox.Show(messageBoxErrorMessage);
                return;
            }
            else
            {
                string itemIDToDelete = SelectedItemIDItemName.Substring(0, 4);

                try
                {
                    myItemTable.DeleteRow(itemIDToDelete);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Successfully deleted item");

                this.FillItemComboBox();
            }
        }

        private void btnManagerMain_Click(object sender, EventArgs e)
        {
            frmManagerMain managerMainPage = new frmManagerMain(ManagerUser);
            managerMainPage.Show();
            this.Hide();
        }
    }
}
