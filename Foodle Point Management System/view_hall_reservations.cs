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
    public partial class frmViewHallReservations: Form
    {
        private HallReservationTable myHallReservationTable = new HallReservationTable();
        
        private Manager ManagerUser
        { get; set; }

        public frmViewHallReservations(Manager managerUser)
        {
            InitializeComponent();
            this.FillListView();
            ManagerUser = managerUser;
        }

        private void FillListView()
        {
            lvwHallReservation.Items.Clear();

            List<object> allReservationIDs = myHallReservationTable.GetColumnValues("ReservationID");
            List<object> reservationRecord;
            ListViewItem newLVItem;

            foreach (object reservationID in allReservationIDs)
            {
                newLVItem = new ListViewItem(reservationID.ToString());
                reservationRecord = myHallReservationTable.GetRowValues(reservationID.ToString());
                reservationRecord.RemoveAt(reservationRecord.Count - 1);
                reservationRecord.RemoveAt(0);

                foreach (object value in reservationRecord)
                {
                    newLVItem.SubItems.Add(value.ToString());
                }

                lvwHallReservation.Items.Add(newLVItem);
            }

            lvwHallReservation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void frmViewHallReservations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnManagerMain_Click(object sender, EventArgs e)
        {
            frmManagerMain managerMainPage = new frmManagerMain(ManagerUser);
            managerMainPage.Show();
            this.Hide();
        }
    }
}
