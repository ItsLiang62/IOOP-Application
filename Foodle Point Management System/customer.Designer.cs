namespace Foodle_Point_Management_System
{
    partial class customer
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
            this.order = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.feedback = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(332, 180);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(132, 72);
            this.order.TabIndex = 0;
            this.order.Text = "order food";
            this.order.UseVisualStyleBackColor = true;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(332, 258);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(132, 72);
            this.view.TabIndex = 1;
            this.view.Text = "view order";
            this.view.UseVisualStyleBackColor = true;
            // 
            // feedback
            // 
            this.feedback.Location = new System.Drawing.Point(332, 336);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(132, 72);
            this.feedback.TabIndex = 2;
            this.feedback.Text = "FeedBack";
            this.feedback.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(332, 424);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(132, 72);
            this.profile.TabIndex = 3;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 696);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.view);
            this.Controls.Add(this.order);
            this.Name = "customer";
            this.Text = "customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button feedback;
        private System.Windows.Forms.Button profile;
    }
}