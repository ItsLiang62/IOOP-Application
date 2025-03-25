namespace Foodle_Point_Management_System
{
    partial class Add_Reservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtHallNumber = new System.Windows.Forms.TextBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(228, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a Reservation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCoordinatorID
            // 
            this.txtCoordinatorID.AutoSize = true;
            this.txtCoordinatorID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCoordinatorID.Location = new System.Drawing.Point(96, 87);
            this.txtCoordinatorID.Name = "txtCoordinatorID";
            this.txtCoordinatorID.Size = new System.Drawing.Size(174, 20);
            this.txtCoordinatorID.TabIndex = 2;
            this.txtCoordinatorID.Text = "Reservation ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(129, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(129, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hall Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(184, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Events:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(162, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capacity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(184, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status:";
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(297, 82);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(285, 25);
            this.txtReservationID.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(297, 134);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(285, 25);
            this.txtCustomerID.TabIndex = 9;
            // 
            // txtHallNumber
            // 
            this.txtHallNumber.Location = new System.Drawing.Point(297, 178);
            this.txtHallNumber.Name = "txtHallNumber";
            this.txtHallNumber.Size = new System.Drawing.Size(285, 25);
            this.txtHallNumber.TabIndex = 10;
            // 
            // txtEvents
            // 
            this.txtEvents.Location = new System.Drawing.Point(297, 216);
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.Size = new System.Drawing.Size(285, 25);
            this.txtEvents.TabIndex = 11;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(297, 262);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(285, 25);
            this.txtCapacity.TabIndex = 12;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(297, 307);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(285, 25);
            this.txtStatus.TabIndex = 13;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(306, 358);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(257, 55);
            this.btnConfirmAdd.TabIndex = 14;
            this.btnConfirmAdd.Text = "Confirm & Add";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // Add_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.txtHallNumber);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCoordinatorID);
            this.Controls.Add(this.label1);
            this.Name = "Add_Reservation";
            this.Text = "Add_Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCoordinatorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtHallNumber;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnConfirmAdd;
    }
}