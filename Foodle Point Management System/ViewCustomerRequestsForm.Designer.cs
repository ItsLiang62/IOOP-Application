namespace Foodle_Point_Management_System
{
    partial class ViewCustomerRequestsForm
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
            this.btnSendReply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvReservations = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSendReply
            // 
            this.btnSendReply.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSendReply.Location = new System.Drawing.Point(509, 355);
            this.btnSendReply.Name = "btnSendReply";
            this.btnSendReply.Size = new System.Drawing.Size(221, 59);
            this.btnSendReply.TabIndex = 2;
            this.btnSendReply.Text = "Send Reply";
            this.btnSendReply.UseVisualStyleBackColor = true;
            this.btnSendReply.Click += new System.EventHandler(this.btnSendReply_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 54);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back to Main Page";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIST OF CUSTOMER RESERVATION REQUESTS";
            // 
            // lvReservations
            // 
            this.lvReservations.HideSelection = false;
            this.lvReservations.Location = new System.Drawing.Point(12, 138);
            this.lvReservations.Name = "lvReservations";
            this.lvReservations.Size = new System.Drawing.Size(776, 211);
            this.lvReservations.TabIndex = 9;
            this.lvReservations.UseCompatibleStateImageBehavior = false;
            // 
            // ViewCustomerRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lvReservations);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSendReply);
            this.Controls.Add(this.label1);
            this.Name = "ViewCustomerRequestsForm";
            this.Text = "ViewCustomerRequestsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewCustomerRequestsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendReply;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvReservations;
    }
}