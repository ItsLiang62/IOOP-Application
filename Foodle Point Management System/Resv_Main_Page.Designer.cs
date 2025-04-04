namespace Foodle_Point_Management_System
{
    partial class Resv_Main_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManageReservations = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnUpdateReservationStatus = new System.Windows.Forms.Button();
            this.btnViewCustomerRequests = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            this.SuspendLayout();
            // 
            // btnManageReservations
            // 
            this.btnManageReservations.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnManageReservations.Location = new System.Drawing.Point(181, 109);
            this.btnManageReservations.Name = "btnManageReservations";
            this.btnManageReservations.Size = new System.Drawing.Size(443, 56);
            this.btnManageReservations.TabIndex = 0;
            this.btnManageReservations.Text = "Manage Reservations";
            this.btnManageReservations.UseVisualStyleBackColor = true;
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(160, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(477, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "RESERVATION COORDINATOR";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestion.Location = new System.Drawing.Point(225, 73);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(334, 23);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "what would you want to do ?";
            // 
            // btnUpdateReservationStatus
            // 
            this.btnUpdateReservationStatus.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateReservationStatus.Location = new System.Drawing.Point(181, 186);
            this.btnUpdateReservationStatus.Name = "btnUpdateReservationStatus";
            this.btnUpdateReservationStatus.Size = new System.Drawing.Size(443, 56);
            this.btnUpdateReservationStatus.TabIndex = 3;
            this.btnUpdateReservationStatus.Text = "Update Reservation Status";
            this.btnUpdateReservationStatus.UseVisualStyleBackColor = true;
            this.btnUpdateReservationStatus.Click += new System.EventHandler(this.btnUpdateReservationStatus_Click);
            // 
            // btnViewCustomerRequests
            // 
            this.btnViewCustomerRequests.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnViewCustomerRequests.Location = new System.Drawing.Point(181, 265);
            this.btnViewCustomerRequests.Name = "btnViewCustomerRequests";
            this.btnViewCustomerRequests.Size = new System.Drawing.Size(443, 56);
            this.btnViewCustomerRequests.TabIndex = 4;
            this.btnViewCustomerRequests.Text = "View Customer Requests";
            this.btnViewCustomerRequests.UseVisualStyleBackColor = true;
            this.btnViewCustomerRequests.Click += new System.EventHandler(this.btnViewCustomerRequests_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(181, 343);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(443, 56);
            this.btnUpdateProfile.TabIndex = 5;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(8, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back to Main Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Resv_Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewCustomerRequests);
            this.Controls.Add(this.btnUpdateReservationStatus);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnManageReservations);
            this.Name = "Resv_Main_Page";
            this.Text = "Resv_Main_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Resv_Main_Page_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnUpdateReservationStatus;
        private System.Windows.Forms.Button btnViewCustomerRequests;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnBack;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}