using System.Diagnostics;

namespace Foodle_Point_Management_System
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class UpdateProfileChef
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
            this.txtFullNameChef = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberChef = new System.Windows.Forms.TextBox();
            this.txtDOBChef = new System.Windows.Forms.TextBox();
            this.cmbGenderChef = new System.Windows.Forms.ComboBox();
            this.lblShowPositionChef = new System.Windows.Forms.Label();
            this.lblEIDChef = new System.Windows.Forms.Label();
            this.lblEmployeeIDChef = new System.Windows.Forms.Label();
            this.lblDOBCshef = new System.Windows.Forms.Label();
            this.lblGenderChef = new System.Windows.Forms.Label();
            this.lblPositionChef = new System.Windows.Forms.Label();
            this.lblFullNameChef = new System.Windows.Forms.Label();
            this.lblPhoneNumberChef = new System.Windows.Forms.Label();
            this.lblPassowrdChef = new System.Windows.Forms.Label();
            this.lblEmailChef = new System.Windows.Forms.Label();
            this.txtPasswordChef = new System.Windows.Forms.TextBox();
            this.txtEmailChef = new System.Windows.Forms.TextBox();
            this.btnUpdateProfileChef = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitleChef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFullNameChef
            // 
            this.txtFullNameChef.Location = new System.Drawing.Point(325, 146);
            this.txtFullNameChef.Name = "txtFullNameChef";
            this.txtFullNameChef.Size = new System.Drawing.Size(214, 22);
            this.txtFullNameChef.TabIndex = 2;
            // 
            // txtPhoneNumberChef
            // 
            this.txtPhoneNumberChef.Location = new System.Drawing.Point(325, 329);
            this.txtPhoneNumberChef.Name = "txtPhoneNumberChef";
            this.txtPhoneNumberChef.Size = new System.Drawing.Size(214, 22);
            this.txtPhoneNumberChef.TabIndex = 3;
            // 
            // txtDOBChef
            // 
            this.txtDOBChef.Location = new System.Drawing.Point(325, 287);
            this.txtDOBChef.Name = "txtDOBChef";
            this.txtDOBChef.Size = new System.Drawing.Size(214, 22);
            this.txtDOBChef.TabIndex = 4;
            // 
            // cmbGenderChef
            // 
            this.cmbGenderChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenderChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenderChef.FormattingEnabled = true;
            this.cmbGenderChef.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGenderChef.Location = new System.Drawing.Point(325, 234);
            this.cmbGenderChef.Name = "cmbGenderChef";
            this.cmbGenderChef.Size = new System.Drawing.Size(214, 33);
            this.cmbGenderChef.TabIndex = 44;
            // 
            // lblShowPositionChef
            // 
            this.lblShowPositionChef.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowPositionChef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowPositionChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPositionChef.Location = new System.Drawing.Point(326, 186);
            this.lblShowPositionChef.Name = "lblShowPositionChef";
            this.lblShowPositionChef.Size = new System.Drawing.Size(214, 35);
            this.lblShowPositionChef.TabIndex = 50;
            // 
            // lblEIDChef
            // 
            this.lblEIDChef.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEIDChef.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEIDChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEIDChef.Location = new System.Drawing.Point(326, 93);
            this.lblEIDChef.Name = "lblEIDChef";
            this.lblEIDChef.Size = new System.Drawing.Size(214, 35);
            this.lblEIDChef.TabIndex = 51;
            // 
            // lblEmployeeIDChef
            // 
            this.lblEmployeeIDChef.AutoSize = true;
            this.lblEmployeeIDChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeIDChef.Location = new System.Drawing.Point(120, 99);
            this.lblEmployeeIDChef.Name = "lblEmployeeIDChef";
            this.lblEmployeeIDChef.Size = new System.Drawing.Size(157, 29);
            this.lblEmployeeIDChef.TabIndex = 52;
            this.lblEmployeeIDChef.Text = "Employee ID:";
            // 
            // lblDOBCshef
            // 
            this.lblDOBCshef.AutoSize = true;
            this.lblDOBCshef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOBCshef.Location = new System.Drawing.Point(120, 280);
            this.lblDOBCshef.Name = "lblDOBCshef";
            this.lblDOBCshef.Size = new System.Drawing.Size(71, 29);
            this.lblDOBCshef.TabIndex = 53;
            this.lblDOBCshef.Text = "DOB:";
            // 
            // lblGenderChef
            // 
            this.lblGenderChef.AutoSize = true;
            this.lblGenderChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderChef.Location = new System.Drawing.Point(120, 238);
            this.lblGenderChef.Name = "lblGenderChef";
            this.lblGenderChef.Size = new System.Drawing.Size(100, 29);
            this.lblGenderChef.TabIndex = 54;
            this.lblGenderChef.Text = "Gender:";
            // 
            // lblPositionChef
            // 
            this.lblPositionChef.AutoSize = true;
            this.lblPositionChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionChef.Location = new System.Drawing.Point(120, 192);
            this.lblPositionChef.Name = "lblPositionChef";
            this.lblPositionChef.Size = new System.Drawing.Size(106, 29);
            this.lblPositionChef.TabIndex = 55;
            this.lblPositionChef.Text = "Position:";
            // 
            // lblFullNameChef
            // 
            this.lblFullNameChef.AutoSize = true;
            this.lblFullNameChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameChef.Location = new System.Drawing.Point(121, 141);
            this.lblFullNameChef.Name = "lblFullNameChef";
            this.lblFullNameChef.Size = new System.Drawing.Size(130, 29);
            this.lblFullNameChef.TabIndex = 56;
            this.lblFullNameChef.Text = "Full Name:";
            // 
            // lblPhoneNumberChef
            // 
            this.lblPhoneNumberChef.AutoSize = true;
            this.lblPhoneNumberChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberChef.Location = new System.Drawing.Point(120, 324);
            this.lblPhoneNumberChef.Name = "lblPhoneNumberChef";
            this.lblPhoneNumberChef.Size = new System.Drawing.Size(182, 29);
            this.lblPhoneNumberChef.TabIndex = 57;
            this.lblPhoneNumberChef.Text = "Phone Number:";
            // 
            // lblPassowrdChef
            // 
            this.lblPassowrdChef.AutoSize = true;
            this.lblPassowrdChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassowrdChef.Location = new System.Drawing.Point(546, 238);
            this.lblPassowrdChef.Name = "lblPassowrdChef";
            this.lblPassowrdChef.Size = new System.Drawing.Size(126, 29);
            this.lblPassowrdChef.TabIndex = 58;
            this.lblPassowrdChef.Text = "Password:";
            // 
            // lblEmailChef
            // 
            this.lblEmailChef.AutoSize = true;
            this.lblEmailChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailChef.Location = new System.Drawing.Point(546, 146);
            this.lblEmailChef.Name = "lblEmailChef";
            this.lblEmailChef.Size = new System.Drawing.Size(80, 29);
            this.lblEmailChef.TabIndex = 59;
            this.lblEmailChef.Text = "Email:";
            // 
            // txtPasswordChef
            // 
            this.txtPasswordChef.Location = new System.Drawing.Point(546, 270);
            this.txtPasswordChef.Name = "txtPasswordChef";
            this.txtPasswordChef.Size = new System.Drawing.Size(214, 22);
            this.txtPasswordChef.TabIndex = 60;
            // 
            // txtEmailChef
            // 
            this.txtEmailChef.Location = new System.Drawing.Point(546, 178);
            this.txtEmailChef.Name = "txtEmailChef";
            this.txtEmailChef.Size = new System.Drawing.Size(214, 22);
            this.txtEmailChef.TabIndex = 61;
            // 
            // btnUpdateProfileChef
            // 
            this.btnUpdateProfileChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfileChef.Location = new System.Drawing.Point(506, 381);
            this.btnUpdateProfileChef.Name = "btnUpdateProfileChef";
            this.btnUpdateProfileChef.Size = new System.Drawing.Size(203, 43);
            this.btnUpdateProfileChef.TabIndex = 62;
            this.btnUpdateProfileChef.Text = "Update Profile";
            this.btnUpdateProfileChef.UseVisualStyleBackColor = true;
            this.btnUpdateProfileChef.Click += new System.EventHandler(this.btnUpdateProfileChef_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(47, 25);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(223, 43);
            this.btnReturn.TabIndex = 63;
            this.btnReturn.Text = "Return to Main";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitleChef
            // 
            this.lblTitleChef.AutoSize = true;
            this.lblTitleChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChef.Location = new System.Drawing.Point(293, 39);
            this.lblTitleChef.Name = "lblTitleChef";
            this.lblTitleChef.Size = new System.Drawing.Size(242, 29);
            this.lblTitleChef.TabIndex = 64;
            this.lblTitleChef.Text = "Update Chef Profile";
            // 
            // UpdateProfileChef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.lblTitleChef);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateProfileChef);
            this.Controls.Add(this.txtEmailChef);
            this.Controls.Add(this.txtPasswordChef);
            this.Controls.Add(this.lblEmailChef);
            this.Controls.Add(this.lblPassowrdChef);
            this.Controls.Add(this.lblPhoneNumberChef);
            this.Controls.Add(this.lblFullNameChef);
            this.Controls.Add(this.lblPositionChef);
            this.Controls.Add(this.lblGenderChef);
            this.Controls.Add(this.lblDOBCshef);
            this.Controls.Add(this.lblEmployeeIDChef);
            this.Controls.Add(this.lblEIDChef);
            this.Controls.Add(this.lblShowPositionChef);
            this.Controls.Add(this.cmbGenderChef);
            this.Controls.Add(this.txtDOBChef);
            this.Controls.Add(this.txtPhoneNumberChef);
            this.Controls.Add(this.txtFullNameChef);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "UpdateProfileChef";
            this.Text = "UpdateProfileChef";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateProfileChef_FormClosing);
            this.Load += new System.EventHandler(this.UpdateProfileChef_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFullNameChef;
        private System.Windows.Forms.TextBox txtPhoneNumberChef;
        private System.Windows.Forms.TextBox txtDOBChef;
        private System.Windows.Forms.ComboBox cmbGenderChef;
        private System.Windows.Forms.Label lblShowPositionChef;
        private System.Windows.Forms.Label lblEIDChef;
        private System.Windows.Forms.Label lblEmployeeIDChef;
        private System.Windows.Forms.Label lblDOBCshef;
        private System.Windows.Forms.Label lblGenderChef;
        private System.Windows.Forms.Label lblPositionChef;
        private System.Windows.Forms.Label lblFullNameChef;
        private System.Windows.Forms.Label lblPhoneNumberChef;
        private System.Windows.Forms.Label lblPassowrdChef;
        private System.Windows.Forms.Label lblEmailChef;
        private System.Windows.Forms.TextBox txtPasswordChef;
        private System.Windows.Forms.TextBox txtEmailChef;
        private System.Windows.Forms.Button btnUpdateProfileChef;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTitleChef;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}