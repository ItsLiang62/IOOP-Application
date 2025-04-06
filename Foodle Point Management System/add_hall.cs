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
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmAddHall: Form
    {
        HallTable myHallTable = new HallTable();

        InputChecker myChecker = new InputChecker();

        private Manager ManagerUser
        { get; set; }

        private string HallNumber
        { get; set; }

        private string HallName
        { get; set; }

        private int Capacity
        { get; set; }

        private string RecommendedEvent1
        { get; set; }

        private string RecommendedEvent2
        { get; set; }

        private bool IsAvailable
        { get; set; }


        public frmAddHall(Manager managerUser)
        {
            InitializeComponent();
            ManagerUser = managerUser;
        }


        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            bool validHallName = myChecker.IsTextOnly(txtHallName.Text, out string eHallName, "Hall Name");
            bool validPrice = myChecker.IsDigitOnly(txtCapacity.Text, out string eCapacity, "Capacity");

            messageBoxErrorMessage = String.Empty;

            foreach (string error in new string[] { eHallName, eCapacity })
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AllInputValid(out string messageBoxErrorMessage))
            {
                HallName = txtHallName.Text;
                Capacity = Convert.ToInt32(txtCapacity.Text);
                RecommendedEvent1 = cmbRecommendedEvent1.Text;
                RecommendedEvent2 = cmbRecommendedEvent2.Text;
                HallNumber = myHallTable.GetNewHallNumber();
                IsAvailable = true; ;

                if (RecommendedEvent1 == RecommendedEvent2)
                {
                    MessageBox.Show("Please fill in different recommended events.");
                    return;
                }

                try
                {
                    myHallTable.InsertRow(HallNumber, HallName, Capacity, RecommendedEvent1, RecommendedEvent2, IsAvailable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Successfully added hall.");
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private void add_hall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageHallPage_Click(object sender, EventArgs e)
        {
            frmManageHallDetails manageHallDetailsPage = new frmManageHallDetails(ManagerUser);
            manageHallDetailsPage.Show();
            this.Hide();
        }
    }
}
