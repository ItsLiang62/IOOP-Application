namespace Foodle_Point_Management_System
{
    partial class UpdateProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoordinatorID = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.Label();
            this.txtBusinessEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.Label();
            this.txtAddres = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Coordinator Profile";
            // 
            // txtCoordinatorID
            // 
            this.txtCoordinatorID.AutoSize = true;
            this.txtCoordinatorID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCoordinatorID.Location = new System.Drawing.Point(12, 79);
            this.txtCoordinatorID.Name = "txtCoordinatorID";
            this.txtCoordinatorID.Size = new System.Drawing.Size(306, 20);
            this.txtCoordinatorID.TabIndex = 1;
            this.txtCoordinatorID.Text = "Reservation Coordinator ID:";
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFullName.Location = new System.Drawing.Point(199, 120);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(119, 20);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Text = "Full Name:";
            // 
            // txtDOB
            // 
            this.txtDOB.AutoSize = true;
            this.txtDOB.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDOB.Location = new System.Drawing.Point(155, 160);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(163, 20);
            this.txtDOB.TabIndex = 3;
            this.txtDOB.Text = "Date of Birth:";
            // 
            // txtBusinessEmail
            // 
            this.txtBusinessEmail.AutoSize = true;
            this.txtBusinessEmail.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBusinessEmail.Location = new System.Drawing.Point(144, 201);
            this.txtBusinessEmail.Name = "txtBusinessEmail";
            this.txtBusinessEmail.Size = new System.Drawing.Size(174, 20);
            this.txtBusinessEmail.TabIndex = 4;
            this.txtBusinessEmail.Text = "Business Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPhone.Location = new System.Drawing.Point(166, 241);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(152, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Text = "Phone Number:";
            // 
            // txtAddres
            // 
            this.txtAddres.AutoSize = true;
            this.txtAddres.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddres.Location = new System.Drawing.Point(221, 283);
            this.txtAddres.Name = "txtAddres";
            this.txtAddres.Size = new System.Drawing.Size(97, 20);
            this.txtAddres.TabIndex = 6;
            this.txtAddres.Text = "Address:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveChanges.Location = new System.Drawing.Point(325, 334);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(283, 64);
            this.btnSaveChanges.TabIndex = 7;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtAddres);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtBusinessEmail);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtCoordinatorID);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProfileForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCoordinatorID;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label txtDOB;
        private System.Windows.Forms.Label txtBusinessEmail;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label txtAddres;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}