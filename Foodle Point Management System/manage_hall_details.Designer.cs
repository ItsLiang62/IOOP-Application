namespace Foodle_Point_Management_System
{
    partial class frmManageHallDetails
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
            this.cmbHall = new System.Windows.Forms.ComboBox();
            this.btnAddHall = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lblAddHall = new System.Windows.Forms.Label();
            this.lblEditDeleteHall = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManagerMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbHall
            // 
            this.cmbHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.Location = new System.Drawing.Point(94, 187);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(301, 37);
            this.cmbHall.TabIndex = 17;
            // 
            // btnAddHall
            // 
            this.btnAddHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHall.Location = new System.Drawing.Point(329, 314);
            this.btnAddHall.Name = "btnAddHall";
            this.btnAddHall.Size = new System.Drawing.Size(118, 45);
            this.btnAddHall.TabIndex = 16;
            this.btnAddHall.Text = "Add";
            this.btnAddHall.UseVisualStyleBackColor = true;
            this.btnAddHall.Click += new System.EventHandler(this.btnAddHall_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(568, 187);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(118, 45);
            this.btnDeleteItem.TabIndex = 15;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItem.Location = new System.Drawing.Point(434, 187);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(118, 45);
            this.btnEditItem.TabIndex = 14;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditHall_Click);
            // 
            // lblAddHall
            // 
            this.lblAddHall.AutoSize = true;
            this.lblAddHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddHall.Location = new System.Drawing.Point(230, 271);
            this.lblAddHall.Name = "lblAddHall";
            this.lblAddHall.Size = new System.Drawing.Size(297, 29);
            this.lblAddHall.TabIndex = 13;
            this.lblAddHall.Text = "Or to add a hall, click here:";
            // 
            // lblEditDeleteHall
            // 
            this.lblEditDeleteHall.AutoSize = true;
            this.lblEditDeleteHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditDeleteHall.Location = new System.Drawing.Point(172, 142);
            this.lblEditDeleteHall.Name = "lblEditDeleteHall";
            this.lblEditDeleteHall.Size = new System.Drawing.Size(471, 29);
            this.lblEditDeleteHall.TabIndex = 12;
            this.lblEditDeleteHall.Text = "Please select a hall to be edited or deleted";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(284, 57);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 38);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Manage Hall";
            // 
            // btnManagerMain
            // 
            this.btnManagerMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerMain.Location = new System.Drawing.Point(36, 29);
            this.btnManagerMain.Name = "btnManagerMain";
            this.btnManagerMain.Size = new System.Drawing.Size(118, 45);
            this.btnManagerMain.TabIndex = 18;
            this.btnManagerMain.Text = "Back";
            this.btnManagerMain.UseVisualStyleBackColor = true;
            this.btnManagerMain.Click += new System.EventHandler(this.btnManagerMain_Click);
            // 
            // frmManageHallDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnManagerMain);
            this.Controls.Add(this.cmbHall);
            this.Controls.Add(this.btnAddHall);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.lblAddHall);
            this.Controls.Add(this.lblEditDeleteHall);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmManageHallDetails";
            this.Text = "Manage Hall Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageHallDetails_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbHall;
        private System.Windows.Forms.Button btnAddHall;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Label lblAddHall;
        private System.Windows.Forms.Label lblEditDeleteHall;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManagerMain;
    }
}