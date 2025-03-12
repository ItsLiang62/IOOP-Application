namespace Foodle_Point_Management_System
{
    partial class frmManagerMain
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
            this.lblWelcomeManager = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeManager
            // 
            this.lblWelcomeManager.AutoSize = true;
            this.lblWelcomeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeManager.Location = new System.Drawing.Point(226, 65);
            this.lblWelcomeManager.Name = "lblWelcomeManager";
            this.lblWelcomeManager.Size = new System.Drawing.Size(325, 38);
            this.lblWelcomeManager.TabIndex = 0;
            this.lblWelcomeManager.Text = "Welcome, Manager!";
            this.lblWelcomeManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcomeManager.Resize += new System.EventHandler(this.lblWelcomeManager_Resize);
            // 
            // frmManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWelcomeManager);
            this.Name = "frmManagerMain";
            this.Text = "Welcome, Manager!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagerMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeManager;
    }
}