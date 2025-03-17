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
    public partial class frmManageWestern: Form
    {
        public frmManageWestern()
        {
            InitializeComponent();
        }

        private void frmManageWestern_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ComboBoxShowWesternItems()
        {
            ItemTable myItemTable = new ItemTable("Data Source = 10.101.47.36, 1433; Initial Catalog = ioop_db; User ID = anderson_login; Password = 123; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False");
            List<string> westernItemNumbers;

            try
            {
                westernItemNumbers = myItemTable.GetItemNumbersOfCategory("Western");
                foreach (string itemNumber in westernItemNumbers)
                {
                    cmbWesternItems.Items.Add(itemNumber);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
