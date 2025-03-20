namespace Foodle_Point_Management_System
{
    partial class frmManagerMain
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
            this.lblWelcomeManager = new System.Windows.Forms.Label();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnManageHall = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeManager
            // 
            this.lblWelcomeManager.AutoSize = true;
            this.lblWelcomeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeManager.Location = new System.Drawing.Point(243, 73);
            this.lblWelcomeManager.Name = "lblWelcomeManager";
            this.lblWelcomeManager.Size = new System.Drawing.Size(325, 38);
            this.lblWelcomeManager.TabIndex = 0;
            this.lblWelcomeManager.Text = "Welcome, Manager!";
            this.lblWelcomeManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcomeManager.Resize += new System.EventHandler(this.lblWelcomeManager_Resize);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMenu.Location = new System.Drawing.Point(250, 145);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(303, 55);
            this.btnManageMenu.TabIndex = 1;
            this.btnManageMenu.Text = "Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = true;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // btnManageHall
            // 
            this.btnManageHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageHall.Location = new System.Drawing.Point(250, 216);
            this.btnManageHall.Name = "btnManageHall";
            this.btnManageHall.Size = new System.Drawing.Size(303, 55);
            this.btnManageHall.TabIndex = 2;
            this.btnManageHall.Text = "Manage Hall Details";
            this.btnManageHall.UseVisualStyleBackColor = true;
            this.btnManageHall.Click += new System.EventHandler(this.btnManageHall_Click);
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservation.Location = new System.Drawing.Point(250, 289);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(303, 55);
            this.btnViewReservation.TabIndex = 3;
            this.btnViewReservation.Text = "View Hall Reservations";
            this.btnViewReservation.UseVisualStyleBackColor = true;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(250, 359);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(303, 55);
            this.btnUpdateProfile.TabIndex = 4;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(12, 12);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(218, 52);
            this.btnMain.TabIndex = 5;
            this.btnMain.Text = "Return to Main Page";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnViewReservation);
            this.Controls.Add(this.btnManageHall);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.lblWelcomeManager);
            this.Name = "frmManagerMain";
            this.Text = "Welcome, Manager!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagerMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeManager;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnManageHall;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnMain;
    }
}