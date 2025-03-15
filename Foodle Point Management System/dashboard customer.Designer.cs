namespace Foodle_Point_Management_System
{
    partial class dashboard_customer
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
            this.profile = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(334, 311);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(132, 72);
            this.profile.TabIndex = 7;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // feedback
            // 
            this.feedback.Location = new System.Drawing.Point(334, 223);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(132, 72);
            this.feedback.TabIndex = 6;
            this.feedback.Text = "FeedBack";
            this.feedback.UseVisualStyleBackColor = true;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(334, 145);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(132, 72);
            this.view.TabIndex = 5;
            this.view.Text = "view order";
            this.view.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(334, 67);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(132, 72);
            this.order.TabIndex = 4;
            this.order.Text = "order food";
            this.order.UseVisualStyleBackColor = true;
            // 
            // dashboard_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.view);
            this.Controls.Add(this.order);
            this.Name = "dashboard_customer";
            this.Text = "dashboard_customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button order;
    }
}