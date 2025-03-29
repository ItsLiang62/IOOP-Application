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
    public partial class frmEditHall: Form
    {
        private HallTable myItemTable = new HallTable();

        private InputChecker myChecker = new InputChecker();

        private Manager ManagerUser
        { get; set; }

        private string HallNumberToEdit
        { get; set; }

        private string HallName
        { get; set; }

        private int Capacity
        { get; set; }

        private string RecommendedEvent1
        { get; set; }

        private string RecommendedEvent2
        { get; set; }

        public frmEditHall(Manager managerUser, string hallNumberToEdit)
        {
            InitializeComponent();
            
            ManagerUser = managerUser;
            HallNumberToEdit = hallNumberToEdit;
            this.ConstructTitle();
            FillInputBox();
        }

        private void ConstructTitle()
        {
            lblTitle.Text = $"Edit Hall {HallNumberToEdit} Details"; 
        }

        private void FillInputBox()
        {
            txtHallName.Text = myItemTable.GetValue(HallNumberToEdit, "HallName").ToString();
            txtCapacity.Text = myItemTable.GetValue(HallNumberToEdit, "Capacity").ToString();
            cmbRecommendedEvent1.Text = myItemTable.GetValue(HallNumberToEdit, "RecommendedEvent1").ToString();
            cmbRecommendedEvent2.Text = myItemTable.GetValue(HallNumberToEdit, "RecommendedEvent2").ToString();
        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            bool validHallName = myChecker.IsTextOnly(txtHallName.Text, out string eHallName, "Hall Name");
            bool validCapacity = myChecker.IsDigitOnly(txtCapacity.Text, out string eCapacity, "Capacity");

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

        private void btnEdit_Resize(object sender, EventArgs e)
        {
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Width) / 2;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (AllInputValid(out string messageBoxErrorMessage))
            {
                HallName = txtHallName.Text;
                Capacity = Convert.ToInt32(txtCapacity.Text);
                RecommendedEvent1 = cmbRecommendedEvent1.Text;
                RecommendedEvent2 = cmbRecommendedEvent2.Text;

                if (RecommendedEvent1 == RecommendedEvent2)
                {
                    MessageBox.Show("Please fill in different recommended events.");
                    return;
                }

                try
                {
                    myItemTable.UpdateValue(HallNumberToEdit, "HallName", HallName);
                    myItemTable.UpdateValue(HallNumberToEdit, "Capacity", Capacity);
                    myItemTable.UpdateValue(HallNumberToEdit, "RecommendedEvent1", RecommendedEvent1);
                    myItemTable.UpdateValue(HallNumberToEdit, "RecommendedEvent2", RecommendedEvent2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Successfully edited hall details");
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private void frmEditHall_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageHallDetails_Click(object sender, EventArgs e)
        {
            frmManageHallDetails manageHallDetailsPage = new frmManageHallDetails(ManagerUser);
            manageHallDetailsPage.Show();
            this.Hide();
        }
    }
}
