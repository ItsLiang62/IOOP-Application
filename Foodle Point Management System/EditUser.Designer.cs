namespace Foodle_Point_Management_System
{
    partial class EditUser
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
            this.lblUsernameE = new System.Windows.Forms.Label();
            this.lblRoleE = new System.Windows.Forms.Label();
            this.lblEmailE = new System.Windows.Forms.Label();
            this.lblPhoneNumberE = new System.Windows.Forms.Label();
            this.txtUsernameE = new System.Windows.Forms.TextBox();
            this.txtEmailE = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberE = new System.Windows.Forms.TextBox();
            this.cmbRoleE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsernameE
            // 
            this.lblUsernameE.AutoSize = true;
            this.lblUsernameE.Location = new System.Drawing.Point(370, 206);
            this.lblUsernameE.Name = "lblUsernameE";
            this.lblUsernameE.Size = new System.Drawing.Size(116, 25);
            this.lblUsernameE.TabIndex = 0;
            this.lblUsernameE.Text = "Username:";
            // 
            // lblRoleE
            // 
            this.lblRoleE.AutoSize = true;
            this.lblRoleE.Location = new System.Drawing.Point(370, 280);
            this.lblRoleE.Name = "lblRoleE";
            this.lblRoleE.Size = new System.Drawing.Size(62, 25);
            this.lblRoleE.TabIndex = 1;
            this.lblRoleE.Text = "Role:";
            // 
            // lblEmailE
            // 
            this.lblEmailE.AutoSize = true;
            this.lblEmailE.Location = new System.Drawing.Point(370, 365);
            this.lblEmailE.Name = "lblEmailE";
            this.lblEmailE.Size = new System.Drawing.Size(71, 25);
            this.lblEmailE.TabIndex = 2;
            this.lblEmailE.Text = "Email:";
            // 
            // lblPhoneNumberE
            // 
            this.lblPhoneNumberE.AutoSize = true;
            this.lblPhoneNumberE.Location = new System.Drawing.Point(370, 440);
            this.lblPhoneNumberE.Name = "lblPhoneNumberE";
            this.lblPhoneNumberE.Size = new System.Drawing.Size(161, 25);
            this.lblPhoneNumberE.TabIndex = 3;
            this.lblPhoneNumberE.Text = "Phone Number:";
            // 
            // txtUsernameE
            // 
            this.txtUsernameE.Location = new System.Drawing.Point(701, 206);
            this.txtUsernameE.Name = "txtUsernameE";
            this.txtUsernameE.Size = new System.Drawing.Size(165, 31);
            this.txtUsernameE.TabIndex = 4;
            // 
            // txtEmailE
            // 
            this.txtEmailE.Location = new System.Drawing.Point(701, 365);
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.Size = new System.Drawing.Size(165, 31);
            this.txtEmailE.TabIndex = 5;
            // 
            // txtPhoneNumberE
            // 
            this.txtPhoneNumberE.Location = new System.Drawing.Point(701, 440);
            this.txtPhoneNumberE.Name = "txtPhoneNumberE";
            this.txtPhoneNumberE.Size = new System.Drawing.Size(165, 31);
            this.txtPhoneNumberE.TabIndex = 6;
            // 
            // cmbRoleE
            // 
            this.cmbRoleE.FormattingEnabled = true;
            this.cmbRoleE.Location = new System.Drawing.Point(701, 280);
            this.cmbRoleE.Name = "cmbRoleE";
            this.cmbRoleE.Size = new System.Drawing.Size(165, 33);
            this.cmbRoleE.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit Profile";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(701, 600);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(183, 55);
            this.btnSaveChanges.TabIndex = 9;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(375, 600);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 55);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 827);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRoleE);
            this.Controls.Add(this.txtPhoneNumberE);
            this.Controls.Add(this.txtEmailE);
            this.Controls.Add(this.txtUsernameE);
            this.Controls.Add(this.lblPhoneNumberE);
            this.Controls.Add(this.lblEmailE);
            this.Controls.Add(this.lblRoleE);
            this.Controls.Add(this.lblUsernameE);
            this.Name = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameE;
        private System.Windows.Forms.Label lblRoleE;
        private System.Windows.Forms.Label lblEmailE;
        private System.Windows.Forms.Label lblPhoneNumberE;
        private System.Windows.Forms.TextBox txtUsernameE;
        private System.Windows.Forms.TextBox txtEmailE;
        private System.Windows.Forms.TextBox txtPhoneNumberE;
        private System.Windows.Forms.ComboBox cmbRoleE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnBack;
    }
}