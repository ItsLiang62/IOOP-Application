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
    public partial class Send_Reply : Form
    {
        private string requestId;
        private DatabaseHelper db = new DatabaseHelper();
        public Send_Reply(string requestId)
        {
            InitializeComponent();
            this.requestId = requestId;
            lblRequestId.Text = $"Replying to Request: {requestId}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReply.Text))
            {
                MessageBox.Show("Please enter a reply message");
                return;
            }

            // In a real application, you would save the reply to database
            MessageBox.Show($"Reply sent for request {requestId}:\n\n{txtReply.Text}");
            this.DialogResult = DialogResult.OK;
        }

        private void txtReply_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
