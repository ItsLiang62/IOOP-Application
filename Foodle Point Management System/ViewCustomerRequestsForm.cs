using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class ViewCustomerRequestsForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public ViewCustomerRequestsForm()
        {
            InitializeComponent();
            LoadRequests();
        }
        private void LoadRequests()
        {
            dgvRequests.DataSource = db.GetCustomerRequests();
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page().Show();
        }

        private void btnSendReply_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count > 0)
            {
                string requestId = dgvRequests.SelectedRows[0].Cells["RequestID"].Value.ToString();
                new Send_Reply(requestId).ShowDialog();
                LoadRequests();
            }
            else
            {
                MessageBox.Show("Please select a request");
            }
        }
    }
}
