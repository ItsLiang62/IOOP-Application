// Wang Liang Xuan

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmManageHallDetails: Form
    {
        private HallTable myHallTable = new HallTable();

        private Manager ManagerUser
        { get; set; }

        private string SelectedHallNumberHallName
        { get; set; }

        public frmManageHallDetails(Manager managerUser)
        {
            InitializeComponent();
            this.FillComboBox();

            ManagerUser = managerUser;
        }

        private void FillComboBox()
        {
            cmbHall.Items.Clear();

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

        private void btnEditHall_Click(object sender, EventArgs e)
        {
            if (IsHallSelected())
            {
                SelectedHallNumberHallName = cmbHall.Text;
                frmEditHall editHallPage = new frmEditHall(ManagerUser, SelectedHallNumberHallName.Substring(0, 2));
                editHallPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a hall");
            }
            
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            frmAddHall addHallPage = new frmAddHall(ManagerUser);
            addHallPage.Show();
            this.Hide();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (IsHallSelected())
            {
                SelectedHallNumberHallName = cmbHall.Text;
                string hallNumberToDelete = SelectedHallNumberHallName.Substring(0, 2);

                DialogResult result = MessageBox.Show(
                    "Deleting this hall will delete all the hall reservations that use the hall. Proceed deletion?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        myHallTable.DeleteRow(hallNumberToDelete);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
                else
                {
                    return;
                }


                MessageBox.Show("Successfully deleted hall.");

                this.FillComboBox();
            }
            else
            {
                MessageBox.Show("Please select a hall");
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
