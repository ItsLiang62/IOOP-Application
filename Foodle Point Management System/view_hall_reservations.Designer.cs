namespace Foodle_Point_Management_System
{
    partial class frmViewHallReservations
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
            this.btnManagerMain = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwHallReservation = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnManagerMain
            // 
            this.btnManagerMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerMain.Location = new System.Drawing.Point(31, 25);
            this.btnManagerMain.Name = "btnManagerMain";
            this.btnManagerMain.Size = new System.Drawing.Size(118, 42);
            this.btnManagerMain.TabIndex = 12;
            this.btnManagerMain.Text = "Back";
            this.btnManagerMain.UseVisualStyleBackColor = true;
            this.btnManagerMain.Click += new System.EventHandler(this.btnManagerMain_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(218, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 38);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "View Hall Reservations";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reservation ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hall Number";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Customer ID";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Event Type";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Event Date";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 50;
            // 
            // lvwHallReservation
            // 
            this.lvwHallReservation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwHallReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHallReservation.FullRowSelect = true;
            this.lvwHallReservation.GridLines = true;
            this.lvwHallReservation.HideSelection = false;
            this.lvwHallReservation.Location = new System.Drawing.Point(59, 111);
            this.lvwHallReservation.Name = "lvwHallReservation";
            this.lvwHallReservation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvwHallReservation.Size = new System.Drawing.Size(668, 284);
            this.lvwHallReservation.TabIndex = 0;
            this.lvwHallReservation.UseCompatibleStateImageBehavior = false;
            this.lvwHallReservation.View = System.Windows.Forms.View.Details;
            // 
            // frmViewHallReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnManagerMain);
            this.Controls.Add(this.lvwHallReservation);
            this.Name = "frmViewHallReservations";
            this.Text = "View Hall Reservations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewHallReservations_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnManagerMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvwHallReservation;
    }
}