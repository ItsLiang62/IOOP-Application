using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmManageMenu: Form
    {
        Manager ManagerUser
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

            ItemTable myItemTable = new ItemTable("Data Source = 10.101.57.209,1433; Initial Catalog = ioop_db; User ID = anderson_login; Password = 123; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False");
            List<string> itemNumbers;
            string chosenMenuCategory = cmbCategory.SelectedItem.ToString();

            try
            {
                itemNumbers = myItemTable.GetItemNumbersOfCategory(chosenMenuCategory);

                foreach (string itemNumber in itemNumbers)
                {
                    string itemName = myItemTable.GetValue(itemNumber, "ItemName").ToString();
                    cmbItem.Items.Add(itemNumber + " " + itemName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
