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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblExpectedCount = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtExpectedCount = new System.Windows.Forms.TextBox();
            this.txtRequestResponse = new System.Windows.Forms.TextBox();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblRequestResponse = new System.Windows.Forms.Label();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(228, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add a Reservation";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReservationID.Location = new System.Drawing.Point(12, 119);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(174, 20);
            this.lblReservationID.TabIndex = 2;
            this.lblReservationID.Text = "Reservation ID:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerID.Location = new System.Drawing.Point(45, 162);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(141, 20);
            this.lblCustomerID.TabIndex = 3;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEventDate.Location = new System.Drawing.Point(429, 123);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(119, 20);
            this.lblEventDate.TabIndex = 5;
            this.lblEventDate.Text = "EventDate:";
            // 
            // lblExpectedCount
            // 
            this.lblExpectedCount.AutoSize = true;
            this.lblExpectedCount.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExpectedCount.Location = new System.Drawing.Point(385, 174);
            this.lblExpectedCount.Name = "lblExpectedCount";
            this.lblExpectedCount.Size = new System.Drawing.Size(163, 20);
            this.lblExpectedCount.TabIndex = 6;
            this.lblExpectedCount.Text = "ExpectedCount:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemarks.Location = new System.Drawing.Point(457, 282);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(97, 20);
            this.lblRemarks.TabIndex = 7;
            this.lblRemarks.Text = "Remarks:";
            // 
            // txtReservationID
            // 
            this.txtReservationID.Location = new System.Drawing.Point(192, 117);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(149, 22);
            this.txtReservationID.TabIndex = 8;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(192, 157);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(149, 22);
            this.txtCustomerID.TabIndex = 9;
            // 
            // txtExpectedCount
            // 
            this.txtExpectedCount.Location = new System.Drawing.Point(560, 175);
            this.txtExpectedCount.Name = "txtExpectedCount";
            this.txtExpectedCount.Size = new System.Drawing.Size(149, 22);
            this.txtExpectedCount.TabIndex = 11;
            // 
            // txtRequestResponse
            // 
            this.txtRequestResponse.Location = new System.Drawing.Point(560, 228);
            this.txtRequestResponse.Name = "txtRequestResponse";
            this.txtRequestResponse.Size = new System.Drawing.Size(149, 22);
            this.txtRequestResponse.TabIndex = 13;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(256, 361);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(257, 59);
            this.btnConfirmAdd.TabIndex = 14;
            this.btnConfirmAdd.Text = "Confirm & Add";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 63);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back to Reservation list";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEventType.Location = new System.Drawing.Point(67, 205);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(119, 20);
            this.lblEventType.TabIndex = 31;
            this.lblEventType.Text = "EventType:";
            // 
            // lblRequestResponse
            // 
            this.lblRequestResponse.AutoSize = true;
            this.lblRequestResponse.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRequestResponse.Location = new System.Drawing.Point(369, 227);
            this.lblRequestResponse.Name = "lblRequestResponse";
            this.lblRequestResponse.Size = new System.Drawing.Size(185, 20);
            this.lblRequestResponse.TabIndex = 33;
            this.lblRequestResponse.Text = "RequestResponse:";
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(192, 206);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(149, 22);
            this.txtEventType.TabIndex = 34;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(560, 283);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(149, 22);
            this.txtRemarks.TabIndex = 35;
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(560, 117);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(149, 22);
            this.txtEventDate.TabIndex = 36;
            // 
            // Add_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.lblRequestResponse);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.txtRequestResponse);
            this.Controls.Add(this.txtExpectedCount);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblExpectedCount);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblReservationID);
            this.Controls.Add(this.lblTitle);
            this.Name = "Add_Reservation";
            this.Text = "Add_Reservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Reservation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblExpectedCount;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtExpectedCount;
        private System.Windows.Forms.TextBox txtRequestResponse;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblRequestResponse;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtEventDate;
    }
}