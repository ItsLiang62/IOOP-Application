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
            this.btnManageUser.Location = new System.Drawing.Point(203, 144);
            this.btnManageUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(163, 48);
            this.btnManageUser.TabIndex = 0;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnViewFeedback
            // 
            this.btnViewFeedback.Location = new System.Drawing.Point(201, 205);
            this.btnViewFeedback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewFeedback.Name = "btnViewFeedback";
            this.btnViewFeedback.Size = new System.Drawing.Size(165, 48);
            this.btnViewFeedback.TabIndex = 1;
            this.btnViewFeedback.Text = "View Feedback";
            this.btnViewFeedback.UseVisualStyleBackColor = true;
            this.btnViewFeedback.Click += new System.EventHandler(this.btnViewFeedback_Click);
            // 
            // btnViewSalesReport
            // 
            this.btnViewSalesReport.Location = new System.Drawing.Point(389, 145);
            this.btnViewSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewSalesReport.Name = "btnViewSalesReport";
            this.btnViewSalesReport.Size = new System.Drawing.Size(163, 47);
            this.btnViewSalesReport.TabIndex = 2;
            this.btnViewSalesReport.Text = "View Sales Report";
            this.btnViewSalesReport.UseVisualStyleBackColor = true;
            this.btnViewSalesReport.Click += new System.EventHandler(this.btnViewSalesReport_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(389, 205);
            this.btnUpdateProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(165, 47);
            this.btnUpdateProfile.TabIndex = 3;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(333, 290);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 31);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 474);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewSalesReport);
            this.Controls.Add(this.btnViewFeedback);
            this.Controls.Add(this.btnManageUser);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHomePage_FormClosing);
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
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