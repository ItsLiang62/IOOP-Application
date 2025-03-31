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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateReservationStatus = new System.Windows.Forms.Button();
            this.btnViewCustomerRequests = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
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
            this.btnManageReservations.Click += new System.EventHandler(this.btnManageReservations_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESERVATION COORDINATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(225, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "what would you want to do ?";
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
            // 
            // Resv_Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewCustomerRequests);
            this.Controls.Add(this.btnUpdateReservationStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManageReservations);
            this.Name = "Resv_Main_Page";
            this.Text = "Resv_Main_Page";
            this.Load += new System.EventHandler(this.Resv_Main_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManageReservations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateReservationStatus;
        private System.Windows.Forms.Button btnViewCustomerRequests;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}