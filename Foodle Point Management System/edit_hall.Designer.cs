namespace Foodle_Point_Management_System
{
    partial class frmEditHall
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbRecommendedEvent1 = new System.Windows.Forms.ComboBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtHallName = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblRecommendedEvent1 = new System.Windows.Forms.Label();
            this.lblHallName = new System.Windows.Forms.Label();
            this.btnManageMenuPage = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbRecommendedEvent2 = new System.Windows.Forms.ComboBox();
            this.lblRecommendedEvent2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(316, 361);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(177, 50);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Resize += new System.EventHandler(this.btnEdit_Resize);
            // 
            // cmbRecommendedEvent1
            // 
            this.cmbRecommendedEvent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecommendedEvent1.FormattingEnabled = true;
            this.cmbRecommendedEvent1.Items.AddRange(new object[] {
            "Birthday Party",
            "Graduation Party",
            "Business Conferences",
            "Product Launches",
            "Workshops",
            "Wedding",
            "Cultural Night",
            "Charity Dinner",
            "Gala Dinner",
            "Live Music Performance"});
            this.cmbRecommendedEvent1.Location = new System.Drawing.Point(363, 233);
            this.cmbRecommendedEvent1.Name = "cmbRecommendedEvent1";
            this.cmbRecommendedEvent1.Size = new System.Drawing.Size(247, 37);
            this.cmbRecommendedEvent1.TabIndex = 29;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapacity.Location = new System.Drawing.Point(363, 184);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(247, 34);
            this.txtCapacity.TabIndex = 28;
            // 
            // txtHallName
            // 
            this.txtHallName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHallName.Location = new System.Drawing.Point(363, 132);
            this.txtHallName.Name = "txtHallName";
            this.txtHallName.Size = new System.Drawing.Size(247, 34);
            this.txtHallName.TabIndex = 27;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(225, 184);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(111, 29);
            this.lblCapacity.TabIndex = 26;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblRecommendedEvent1
            // 
            this.lblRecommendedEvent1.AutoSize = true;
            this.lblRecommendedEvent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendedEvent1.Location = new System.Drawing.Point(70, 236);
            this.lblRecommendedEvent1.Name = "lblRecommendedEvent1";
            this.lblRecommendedEvent1.Size = new System.Drawing.Size(270, 29);
            this.lblRecommendedEvent1.TabIndex = 25;
            this.lblRecommendedEvent1.Text = "Recommended Event 1:";
            // 
            // lblHallName
            // 
            this.lblHallName.AutoSize = true;
            this.lblHallName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHallName.Location = new System.Drawing.Point(204, 132);
            this.lblHallName.Name = "lblHallName";
            this.lblHallName.Size = new System.Drawing.Size(132, 29);
            this.lblHallName.TabIndex = 24;
            this.lblHallName.Text = "Hall Name:";
            // 
            // btnManageMenuPage
            // 
            this.btnManageMenuPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMenuPage.Location = new System.Drawing.Point(25, 12);
            this.btnManageMenuPage.Name = "btnManageMenuPage";
            this.btnManageMenuPage.Size = new System.Drawing.Size(290, 37);
            this.btnManageMenuPage.TabIndex = 23;
            this.btnManageMenuPage.Text = "Return to Manage Menu Page";
            this.btnManageMenuPage.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(328, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 38);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Edit Hall";
            // 
            // cmbRecommendedEvent2
            // 
            this.cmbRecommendedEvent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRecommendedEvent2.FormattingEnabled = true;
            this.cmbRecommendedEvent2.Items.AddRange(new object[] {
            "Birthday Party",
            "Graduation Party",
            "Business Conferences",
            "Product Launches",
            "Workshops",
            "Wedding",
            "Cultural Night",
            "Charity Dinner",
            "Gala Dinner",
            "Live Music Performance"});
            this.cmbRecommendedEvent2.Location = new System.Drawing.Point(363, 286);
            this.cmbRecommendedEvent2.Name = "cmbRecommendedEvent2";
            this.cmbRecommendedEvent2.Size = new System.Drawing.Size(247, 37);
            this.cmbRecommendedEvent2.TabIndex = 32;
            // 
            // lblRecommendedEvent2
            // 
            this.lblRecommendedEvent2.AutoSize = true;
            this.lblRecommendedEvent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendedEvent2.Location = new System.Drawing.Point(70, 289);
            this.lblRecommendedEvent2.Name = "lblRecommendedEvent2";
            this.lblRecommendedEvent2.Size = new System.Drawing.Size(270, 29);
            this.lblRecommendedEvent2.TabIndex = 31;
            this.lblRecommendedEvent2.Text = "Recommended Event 2:";
            // 
            // frmEditHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbRecommendedEvent2);
            this.Controls.Add(this.lblRecommendedEvent2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbRecommendedEvent1);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtHallName);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblRecommendedEvent1);
            this.Controls.Add(this.lblHallName);
            this.Controls.Add(this.btnManageMenuPage);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmEditHall";
            this.Text = "Edit Hall Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditHall_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbRecommendedEvent1;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtHallName;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblRecommendedEvent1;
        private System.Windows.Forms.Label lblHallName;
        private System.Windows.Forms.Button btnManageMenuPage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbRecommendedEvent2;
        private System.Windows.Forms.Label lblRecommendedEvent2;
    }
}