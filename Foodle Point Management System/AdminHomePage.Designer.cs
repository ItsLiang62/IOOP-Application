namespace Foodle_Point_Management_System
{
    partial class AdminHomePage
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
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnViewFeedback = new System.Windows.Forms.Button();
            this.btnViewSalesReport = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(304, 225);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(244, 75);
            this.btnManageUser.TabIndex = 0;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            // 
            // btnViewFeedback
            // 
            this.btnViewFeedback.Location = new System.Drawing.Point(301, 321);
            this.btnViewFeedback.Name = "btnViewFeedback";
            this.btnViewFeedback.Size = new System.Drawing.Size(247, 75);
            this.btnViewFeedback.TabIndex = 1;
            this.btnViewFeedback.Text = "View Feedback";
            this.btnViewFeedback.UseVisualStyleBackColor = true;
            // 
            // btnViewSalesReport
            // 
            this.btnViewSalesReport.Location = new System.Drawing.Point(584, 226);
            this.btnViewSalesReport.Name = "btnViewSalesReport";
            this.btnViewSalesReport.Size = new System.Drawing.Size(244, 74);
            this.btnViewSalesReport.TabIndex = 2;
            this.btnViewSalesReport.Text = "View Sales Report";
            this.btnViewSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(584, 321);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(247, 74);
            this.btnUpdateProfile.TabIndex = 3;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(499, 453);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(139, 49);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 740);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewSalesReport);
            this.Controls.Add(this.btnViewFeedback);
            this.Controls.Add(this.btnManageUser);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnViewFeedback;
        private System.Windows.Forms.Button btnViewSalesReport;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnLogout;
    }
}