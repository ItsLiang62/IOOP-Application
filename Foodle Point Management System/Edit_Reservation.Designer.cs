namespace Foodle_Point_Management_System
{
    partial class Edit_Reservation
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
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbReservationStatus = new System.Windows.Forms.ComboBox();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.lblRequestResponse = new System.Windows.Forms.Label();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.txtlblRequestResponse = new System.Windows.Forms.TextBox();
            this.txtExpectedCount = new System.Windows.Forms.TextBox();
            this.txtHallNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblExpectedCount = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblHallNumber = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(324, 358);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(257, 55);
            this.btnSaveChanges.TabIndex = 28;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(179, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Edit Reservation Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 59);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back to Reservation list";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbReservationStatus
            // 
            this.cmbReservationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReservationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReservationStatus.FormattingEnabled = true;
            this.cmbReservationStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Completed",
            "Rejected"});
            this.cmbReservationStatus.Location = new System.Drawing.Point(600, 209);
            this.cmbReservationStatus.Name = "cmbReservationStatus";
            this.cmbReservationStatus.Size = new System.Drawing.Size(149, 33);
            this.cmbReservationStatus.TabIndex = 63;
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(600, 108);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(149, 25);
            this.txtEventDate.TabIndex = 62;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(600, 318);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(149, 25);
            this.txtRemarks.TabIndex = 61;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(232, 266);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(149, 25);
            this.txtEventType.TabIndex = 60;
            // 
            // lblRequestResponse
            // 
            this.lblRequestResponse.AutoSize = true;
            this.lblRequestResponse.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRequestResponse.Location = new System.Drawing.Point(409, 265);
            this.lblRequestResponse.Name = "lblRequestResponse";
            this.lblRequestResponse.Size = new System.Drawing.Size(185, 20);
            this.lblRequestResponse.TabIndex = 59;
            this.lblRequestResponse.Text = "RequestResponse:";
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReservationStatus.Location = new System.Drawing.Point(387, 209);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(207, 20);
            this.lblReservationStatus.TabIndex = 58;
            this.lblReservationStatus.Text = "ReservationStatus:";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEventType.Location = new System.Drawing.Point(85, 265);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(119, 20);
            this.lblEventType.TabIndex = 57;
            this.lblEventType.Text = "EventType:";
            // 
            // txtlblRequestResponse
            // 
            this.txtlblRequestResponse.Location = new System.Drawing.Point(600, 266);
            this.txtlblRequestResponse.Name = "txtlblRequestResponse";
            this.txtlblRequestResponse.Size = new System.Drawing.Size(149, 25);
            this.txtlblRequestResponse.TabIndex = 56;
            // 
            // txtExpectedCount
            // 
            this.txtExpectedCount.Location = new System.Drawing.Point(600, 162);
            this.txtExpectedCount.Name = "txtExpectedCount";
            this.txtExpectedCount.Size = new System.Drawing.Size(149, 25);
            this.txtExpectedCount.TabIndex = 55;
            // 
            // txtHallNumber
            // 
            this.txtHallNumber.Location = new System.Drawing.Point(232, 156);
            this.txtHallNumber.Name = "txtHallNumber";
            this.txtHallNumber.Size = new System.Drawing.Size(149, 25);
            this.txtHallNumber.TabIndex = 54;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(232, 204);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(149, 25);
            this.txtCustomerID.TabIndex = 53;
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(232, 108);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(149, 25);
            this.txtReservationID.TabIndex = 52;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemarks.Location = new System.Drawing.Point(497, 317);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(97, 20);
            this.lblRemarks.TabIndex = 51;
            this.lblRemarks.Text = "Remarks:";
            // 
            // lblExpectedCount
            // 
            this.lblExpectedCount.AutoSize = true;
            this.lblExpectedCount.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExpectedCount.Location = new System.Drawing.Point(425, 161);
            this.lblExpectedCount.Name = "lblExpectedCount";
            this.lblExpectedCount.Size = new System.Drawing.Size(163, 20);
            this.lblExpectedCount.TabIndex = 50;
            this.lblExpectedCount.Text = "ExpectedCount:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEventDate.Location = new System.Drawing.Point(469, 113);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(119, 20);
            this.lblEventDate.TabIndex = 49;
            this.lblEventDate.Text = "EventDate:";
            // 
            // lblHallNumber
            // 
            this.lblHallNumber.AutoSize = true;
            this.lblHallNumber.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHallNumber.Location = new System.Drawing.Point(85, 161);
            this.lblHallNumber.Name = "lblHallNumber";
            this.lblHallNumber.Size = new System.Drawing.Size(141, 20);
            this.lblHallNumber.TabIndex = 48;
            this.lblHallNumber.Text = "Hall Number:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerID.Location = new System.Drawing.Point(85, 209);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(141, 20);
            this.lblCustomerID.TabIndex = 47;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReservationID.Location = new System.Drawing.Point(52, 110);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(174, 20);
            this.lblReservationID.TabIndex = 46;
            this.lblReservationID.Text = "Reservation ID:";
            // 
            // Edit_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbReservationStatus);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.lblRequestResponse);
            this.Controls.Add(this.lblReservationStatus);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.txtlblRequestResponse);
            this.Controls.Add(this.txtExpectedCount);
            this.Controls.Add(this.txtHallNumber);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblExpectedCount);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblHallNumber);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Reservation";
            this.Text = "Edit_Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbReservationStatus;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.Label lblRequestResponse;
        private System.Windows.Forms.Label lblReservationStatus;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.TextBox txtlblRequestResponse;
        private System.Windows.Forms.TextBox txtExpectedCount;
        private System.Windows.Forms.TextBox txtHallNumber;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblExpectedCount;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblHallNumber;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblReservationID;
    }
}