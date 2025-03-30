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
        ItemTable myItemTable = new ItemTable("Data Source = 172.18.48.1,1433; Initial Catalog = ioop_db; User ID = anderson_login; Password = 123; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False");
        InputChecker myChecker = new InputChecker();

        Manager ManagerUser
        { get; set; }

        string InputItemIDItemName
        { get; set; }

        string InputCategory
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Items.Clear();

            List<string> itemIDs;
            InputCategory = cmbCategory.SelectedItem.ToString();

            try
            {
                itemIDs = myItemTable.GetItemIDsOfCategory(InputCategory);

                foreach (string itemID in itemIDs)
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItemPage = new frmAddItem(ManagerUser);
            addItemPage.Show();
            this.Hide();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage = String.Empty;
            InputCategory = cmbCategory.Text;
            InputItemIDItemName = cmbItem.Text;

            if (myChecker.IsEmptyInput(InputCategory, out string eCategory))
            {
                messageBoxErrorMessage += "Please select a menu category" + "\n";
            }
            
            if (myChecker.IsEmptyInput(InputItemIDItemName, out string eItemIDItemName))
            {
                messageBoxErrorMessage += "Please select an item" + "\n";
            }

            if (messageBoxErrorMessage != String.Empty)
            {
                MessageBox.Show(messageBoxErrorMessage);
                return;
            }
            
            
            frmEditItem editItemPage = new frmEditItem(ManagerUser, InputItemIDItemName.Substring(0, 4));
            editItemPage.Show();
            this.Hide();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage = String.Empty;
            InputCategory = cmbCategory.Text;
            InputItemIDItemName = cmbItem.Text;

            if (myChecker.IsEmptyInput(InputCategory, out string eCategory))
            {
                messageBoxErrorMessage += "Please select a menu category" + "\n";
            }

            if (myChecker.IsEmptyInput(InputItemIDItemName, out string eItemIDItemName))
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
                string itemIDToDelete = InputItemIDItemName.Substring(0, 4);

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
            }
        }
    }
}
