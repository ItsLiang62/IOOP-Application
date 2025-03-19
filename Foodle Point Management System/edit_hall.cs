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
        private HallTable myItemTable = new HallTable("Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        private Manager ManagerUser
        { get; set; }

        private string HallNumberToEdit
        { get; set; }

        private string InputHallName
        { get; set; }

        private string InputCapacity
        { get; set; }

        private string NewHallName
        { get; set; }

        private double NewCapacity
        { get; set; }

        private string NewRecommendedEvent1
        { get; set; }

        private string NewRecommendedEvent2
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
            InputChecker myChecker = new InputChecker();

            bool validHallName = myChecker.IsTextOnly(InputHallName, out string eHallName, "Hall Name");
            bool validCapacity = myChecker.IsDigitOnly(InputCapacity, out string eCapacity, "Capacity");

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
            InputHallName = txtHallName.Text;
            InputCapacity = txtCapacity.Text;
            NewRecommendedEvent1 = cmbRecommendedEvent1.Text;
            NewRecommendedEvent2 = cmbRecommendedEvent2.Text;

            if (NewRecommendedEvent1 == NewRecommendedEvent2)
            {
                MessageBox.Show("Please fill in different recommended events.");
                return;
            }

            if (AllInputValid(out string messageBoxErrorMessage))
            {
                NewHallName = InputHallName;
                NewCapacity = Convert.ToInt32(InputCapacity);

                try
                {
                    myItemTable.UpdateValue(HallNumberToEdit, "HallName", NewHallName);
                    myItemTable.UpdateValue(HallNumberToEdit, "Capacity", NewCapacity);
                    myItemTable.UpdateValue(HallNumberToEdit, "RecommendedEvent1", NewRecommendedEvent1);
                    myItemTable.UpdateValue(HallNumberToEdit, "RecommendedEvent2", NewRecommendedEvent2);
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
    }
}
