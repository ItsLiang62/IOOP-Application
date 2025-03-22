namespace Foodle_Point_Management_System
{
    partial class FeedbackForm
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
            this.txtfeedback = new System.Windows.Forms.TextBox();
            this.comrateing = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrequest = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Submit Feedback:";
            // 
            // txtfeedback
            // 
            this.txtfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeedback.Location = new System.Drawing.Point(271, 45);
            this.txtfeedback.Name = "txtfeedback";
            this.txtfeedback.Size = new System.Drawing.Size(231, 38);
            this.txtfeedback.TabIndex = 1;
            // 
            // comrateing
            // 
            this.comrateing.FormattingEnabled = true;
            this.comrateing.Location = new System.Drawing.Point(271, 128);
            this.comrateing.Name = "comrateing";
            this.comrateing.Size = new System.Drawing.Size(121, 24);
            this.comrateing.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rating";
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(567, 129);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(155, 23);
            this.btnSubmitFeedback.TabIndex = 4;
            this.btnSubmitFeedback.Text = "Submit feedback";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(672, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "sending a request to  reservation request to Reservation ";
            // 
            // txtrequest
            // 
            this.txtrequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrequest.Location = new System.Drawing.Point(285, 354);
            this.txtrequest.Name = "txtrequest";
            this.txtrequest.Size = new System.Drawing.Size(299, 38);
            this.txtrequest.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit a Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtrequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comrateing);
            this.Controls.Add(this.txtfeedback);
            this.Controls.Add(this.label1);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            this.Load += new System.EventHandler(this.FeedbackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfeedback;
        private System.Windows.Forms.ComboBox comrateing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrequest;
        private System.Windows.Forms.Button button1;
    }
}