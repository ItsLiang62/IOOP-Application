namespace new_customer
{
    partial class Viewing
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
            this.btnCheckReservationStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.btnCheckOrderStatu = new System.Windows.Forms.Button();
            this.txtrequest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check reservation status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckReservationStatus
            // 
            this.btnCheckReservationStatus.Location = new System.Drawing.Point(63, 121);
            this.btnCheckReservationStatus.Name = "btnCheckReservationStatus";
            this.btnCheckReservationStatus.Size = new System.Drawing.Size(105, 36);
            this.btnCheckReservationStatus.TabIndex = 4;
            this.btnCheckReservationStatus.Text = "view";
            this.btnCheckReservationStatus.UseVisualStyleBackColor = true;
            this.btnCheckReservationStatus.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(722, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "View";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "View current order status.";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(187, 300);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(1031, 196);
            this.lstOrders.TabIndex = 9;
            // 
            // lstReservations
            // 
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 16;
            this.lstReservations.Location = new System.Drawing.Point(241, 71);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(935, 180);
            this.lstReservations.TabIndex = 10;
            // 
            // btnCheckOrderStatu
            // 
            this.btnCheckOrderStatu.Location = new System.Drawing.Point(36, 371);
            this.btnCheckOrderStatu.Name = "btnCheckOrderStatu";
            this.btnCheckOrderStatu.Size = new System.Drawing.Size(105, 36);
            this.btnCheckOrderStatu.TabIndex = 11;
            this.btnCheckOrderStatu.Text = "view";
            this.btnCheckOrderStatu.UseVisualStyleBackColor = true;
            this.btnCheckOrderStatu.Click += new System.EventHandler(this.btnCheckOrderStatu_Click);
            // 
            // txtrequest
            // 
            this.txtrequest.Location = new System.Drawing.Point(770, 591);
            this.txtrequest.Name = "txtrequest";
            this.txtrequest.Size = new System.Drawing.Size(100, 22);
            this.txtrequest.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "send a request to reservation coordinator ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Viewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 766);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrequest);
            this.Controls.Add(this.btnCheckOrderStatu);
            this.Controls.Add(this.lstReservations);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckReservationStatus);
            this.Controls.Add(this.label1);
            this.Name = "Viewing";
            this.Text = "Viewing";
            this.Load += new System.EventHandler(this.Viewing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckReservationStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Button btnCheckOrderStatu;
        private System.Windows.Forms.TextBox txtrequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}