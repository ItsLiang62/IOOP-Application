namespace Foodle_Point_Management_System
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnLoginCustomer = new System.Windows.Forms.Button();
            this.btnLoginEmployee = new System.Windows.Forms.Button();
            this.lblLoginAs = new System.Windows.Forms.Label();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.llblSignUpEmployee = new System.Windows.Forms.LinkLabel();
            this.llblSignUpCustomer = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(180, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(393, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to FoodlePoint";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(134, 134);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(531, 25);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Indulge in our flavorful meals, crafted with care and attention.";
            // 
            // btnLoginCustomer
            // 
            this.btnLoginCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginCustomer.Location = new System.Drawing.Point(297, 215);
            this.btnLoginCustomer.Name = "btnLoginCustomer";
            this.btnLoginCustomer.Size = new System.Drawing.Size(161, 45);
            this.btnLoginCustomer.TabIndex = 2;
            this.btnLoginCustomer.Text = "Customer";
            this.btnLoginCustomer.UseVisualStyleBackColor = true;
            this.btnLoginCustomer.Click += new System.EventHandler(this.btnLoginCustomer_Click);
            // 
            // btnLoginEmployee
            // 
            this.btnLoginEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginEmployee.Location = new System.Drawing.Point(297, 266);
            this.btnLoginEmployee.Name = "btnLoginEmployee";
            this.btnLoginEmployee.Size = new System.Drawing.Size(161, 45);
            this.btnLoginEmployee.TabIndex = 3;
            this.btnLoginEmployee.Text = "Employee";
            this.btnLoginEmployee.UseVisualStyleBackColor = true;
            this.btnLoginEmployee.Click += new System.EventHandler(this.btnLoginEmployee_Click);
            // 
            // lblLoginAs
            // 
            this.lblLoginAs.AutoSize = true;
            this.lblLoginAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginAs.Location = new System.Drawing.Point(332, 183);
            this.lblLoginAs.Name = "lblLoginAs";
            this.lblLoginAs.Size = new System.Drawing.Size(85, 20);
            this.lblLoginAs.TabIndex = 4;
            this.lblLoginAs.Text = "Login as...";
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAccount.Location = new System.Drawing.Point(228, 349);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(304, 20);
            this.lblNoAccount.TabIndex = 5;
            this.lblNoAccount.Text = "Don\'t Have a FoodlePoint Account Yet?";
            // 
            // llblSignUpEmployee
            // 
            this.llblSignUpEmployee.ActiveLinkColor = System.Drawing.Color.Red;
            this.llblSignUpEmployee.AutoSize = true;
            this.llblSignUpEmployee.Location = new System.Drawing.Point(394, 390);
            this.llblSignUpEmployee.Name = "llblSignUpEmployee";
            this.llblSignUpEmployee.Size = new System.Drawing.Size(138, 16);
            this.llblSignUpEmployee.TabIndex = 6;
            this.llblSignUpEmployee.TabStop = true;
            this.llblSignUpEmployee.Text = "Sign Up as Employee";
            this.llblSignUpEmployee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignUpCustomer_LinkClicked);
            // 
            // llblSignUpCustomer
            // 
            this.llblSignUpCustomer.AutoSize = true;
            this.llblSignUpCustomer.Location = new System.Drawing.Point(229, 390);
            this.llblSignUpCustomer.Name = "llblSignUpCustomer";
            this.llblSignUpCustomer.Size = new System.Drawing.Size(133, 16);
            this.llblSignUpCustomer.TabIndex = 7;
            this.llblSignUpCustomer.TabStop = true;
            this.llblSignUpCustomer.Text = "Sign Up as Customer";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llblSignUpCustomer);
            this.Controls.Add(this.llblSignUpEmployee);
            this.Controls.Add(this.lblNoAccount);
            this.Controls.Add(this.lblLoginAs);
            this.Controls.Add(this.btnLoginEmployee);
            this.Controls.Add(this.btnLoginCustomer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Welcome to FoodlePoint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnLoginCustomer;
        private System.Windows.Forms.Button btnLoginEmployee;
        private System.Windows.Forms.Label lblLoginAs;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel llblSignUpEmployee;
        private System.Windows.Forms.LinkLabel llblSignUpCustomer;
    }
}

