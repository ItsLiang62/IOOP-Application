﻿using System;

namespace Foodle_Point_Management_System
{
    partial class frmChefMain
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
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnUpdateOrders = new System.Windows.Forms.Button();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.lblChefPortal = new System.Windows.Forms.Label();
            this.lblComment0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.Silver;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(225, 94);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(466, 86);
            this.btnViewOrders.TabIndex = 1;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnUpdateOrders
            // 
            this.btnUpdateOrders.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrders.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrders.Location = new System.Drawing.Point(225, 186);
            this.btnUpdateOrders.Name = "btnUpdateOrders";
            this.btnUpdateOrders.Size = new System.Drawing.Size(466, 86);
            this.btnUpdateOrders.TabIndex = 2;
            this.btnUpdateOrders.Text = "Update Orders";
            this.btnUpdateOrders.UseVisualStyleBackColor = false;
            this.btnUpdateOrders.Click += new System.EventHandler(this.btnUpdateOrders_Click);
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.BackColor = System.Drawing.Color.Silver;
            this.btnManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInventory.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.Location = new System.Drawing.Point(225, 278);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(466, 86);
            this.btnManageInventory.TabIndex = 3;
            this.btnManageInventory.Text = "Manage Inventory";
            this.btnManageInventory.UseVisualStyleBackColor = false;
            this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(225, 370);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(466, 86);
            this.btnUpdateProfile.TabIndex = 4;
            this.btnUpdateProfile.Text = "Update My Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            // 
            // lblChefPortal
            // 
            this.lblChefPortal.AutoSize = true;
            this.lblChefPortal.BackColor = System.Drawing.Color.SlateGray;
            this.lblChefPortal.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefPortal.Location = new System.Drawing.Point(366, 9);
            this.lblChefPortal.Name = "lblChefPortal";
            this.lblChefPortal.Size = new System.Drawing.Size(181, 37);
            this.lblChefPortal.TabIndex = 5;
            this.lblChefPortal.Text = "Chef Portal";
            // 
            // lblComment0
            // 
            this.lblComment0.AutoSize = true;
            this.lblComment0.BackColor = System.Drawing.Color.SlateGray;
            this.lblComment0.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment0.Location = new System.Drawing.Point(30, 46);
            this.lblComment0.Name = "lblComment0";
            this.lblComment0.Size = new System.Drawing.Size(875, 37);
            this.lblComment0.TabIndex = 6;
            this.lblComment0.Text = "Welcome Chef.<Chef Name> what would you want to check ?";
            // 
            // frmChefMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 491);
            this.Controls.Add(this.lblComment0);
            this.Controls.Add(this.lblChefPortal);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnManageInventory);
            this.Controls.Add(this.btnUpdateOrders);
            this.Controls.Add(this.btnViewOrders);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmChefMain";
            this.Text = "Welcome, Chef!";
            this.Load += new System.EventHandler(this.frmChefMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnUpdateOrders;
        private System.Windows.Forms.Button btnManageInventory;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Label lblChefPortal;
        private System.Windows.Forms.Label lblComment0;
        private EventHandler btnUpdateProfile_Click;
    }
}