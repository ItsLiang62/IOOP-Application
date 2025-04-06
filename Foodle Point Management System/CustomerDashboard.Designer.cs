namespace Foodle_Point_Management_System
{
    partial class CustomerDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(401, 45);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(538, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome , what would you want to do?";
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderFood.Location = new System.Drawing.Point(407, 99);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(384, 73);
            this.btnOrderFood.TabIndex = 1;
            this.btnOrderFood.Text = "Order Food";
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.btnOrderFood_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(407, 204);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(384, 73);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "View Orders & Reservations";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Location = new System.Drawing.Point(407, 301);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(384, 73);
            this.btnFeedback.TabIndex = 3;
            this.btnFeedback.Text = "Send Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(407, 496);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(384, 73);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.Location = new System.Drawing.Point(407, 398);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(384, 73);
            this.btnReservation.TabIndex = 5;
            this.btnReservation.Text = "Reserve Hall";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(3, 518);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(281, 78);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Return To  The Main Page";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 600);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnOrderFood);
            this.Controls.Add(this.lblWelcome);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerDashboard_FormClosing);
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnOrderFood;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnlogout;
    }
}