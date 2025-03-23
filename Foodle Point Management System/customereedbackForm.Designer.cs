namespace Foodle_Point_Management_System
{
    partial class customereedbackForm
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
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrequest = new System.Windows.Forms.TextBox();
            this.btnrequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Your Feedback:";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(257, 33);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(182, 34);
            this.txtFeedback.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rating (1-5):";
            // 
            // numRating
            // 
            this.numRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.Location = new System.Drawing.Point(199, 82);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(120, 30);
            this.numRating.TabIndex = 3;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Location = new System.Drawing.Point(243, 161);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(121, 30);
            this.btnSubmitFeedback.TabIndex = 4;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(526, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "\"send a requet to reservation coordinator";
            // 
            // txtrequest
            // 
            this.txtrequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrequest.Location = new System.Drawing.Point(58, 300);
            this.txtrequest.Name = "txtrequest";
            this.txtrequest.Size = new System.Drawing.Size(678, 34);
            this.txtrequest.TabIndex = 6;
            // 
            // btnrequest
            // 
            this.btnrequest.Location = new System.Drawing.Point(333, 374);
            this.btnrequest.Name = "btnrequest";
            this.btnrequest.Size = new System.Drawing.Size(164, 30);
            this.btnrequest.TabIndex = 7;
            this.btnrequest.Text = "Submit a request ";
            this.btnrequest.UseVisualStyleBackColor = true;
            this.btnrequest.Click += new System.EventHandler(this.btnrequest_Click);
            // 
            // customereedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrequest);
            this.Controls.Add(this.txtrequest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label1);
            this.Name = "customereedbackForm";
            this.Text = "customereedbackForm";
            this.Load += new System.EventHandler(this.customereedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrequest;
        private System.Windows.Forms.Button btnrequest;
    }
}