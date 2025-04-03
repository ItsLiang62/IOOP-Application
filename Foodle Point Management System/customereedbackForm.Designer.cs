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
            this.lblfeedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.lblrating = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfeedback
            // 
            this.lblfeedback.AutoSize = true;
            this.lblfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedback.Location = new System.Drawing.Point(24, 134);
            this.lblfeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfeedback.Name = "lblfeedback";
            this.lblfeedback.Size = new System.Drawing.Size(345, 52);
            this.lblfeedback.TabIndex = 0;
            this.lblfeedback.Text = "\"Your Feedback:";
            this.lblfeedback.Click += new System.EventHandler(this.lblfeedback_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(369, 134);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(271, 49);
            this.txtFeedback.TabIndex = 1;
            // 
            // lblrating
            // 
            this.lblrating.AutoSize = true;
            this.lblrating.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrating.Location = new System.Drawing.Point(117, 231);
            this.lblrating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrating.Name = "lblrating";
            this.lblrating.Size = new System.Drawing.Size(265, 52);
            this.lblrating.TabIndex = 2;
            this.lblrating.Text = "Rating (1-5):";
            // 
            // numRating
            // 
            this.numRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.Location = new System.Drawing.Point(410, 238);
            this.numRating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numRating.Size = new System.Drawing.Size(180, 44);
            this.numRating.TabIndex = 3;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitFeedback.Location = new System.Drawing.Point(369, 334);
            this.btnSubmitFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(255, 95);
            this.btnSubmitFeedback.TabIndex = 4;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = true;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(2, 459);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(422, 122);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Return To  The Main Page";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // customereedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 584);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.lblrating);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblfeedback);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "customereedbackForm";
            this.Text = "customereedbackForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.customereedbackForm_FormClosing);
            this.Load += new System.EventHandler(this.customereedbackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfeedback;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Label lblrating;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Button btnSubmitFeedback;
        private System.Windows.Forms.Button btnlogout;
    }
}