namespace Foodle_Point_Management_System
{
    partial class ViewOrdersForm
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
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.tabControlOrders = new System.Windows.Forms.TabControl();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.tabControlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.dgvReservations);
            this.tabReservations.Location = new System.Drawing.Point(4, 25);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservations.Size = new System.Drawing.Size(777, 382);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Reservations ";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(6, 6);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(809, 354);
            this.dgvReservations.TabIndex = 0;
            // 
            // tabControlOrders
            // 
            this.tabControlOrders.Controls.Add(this.tabOrders);
            this.tabControlOrders.Controls.Add(this.tabReservations);
            this.tabControlOrders.Location = new System.Drawing.Point(3, -4);
            this.tabControlOrders.Name = "tabControlOrders";
            this.tabControlOrders.SelectedIndex = 0;
            this.tabControlOrders.Size = new System.Drawing.Size(785, 411);
            this.tabControlOrders.TabIndex = 1;
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(6, 6);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.Size = new System.Drawing.Size(765, 354);
            this.dgvOrders.TabIndex = 0;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 25);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(777, 382);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Orders ";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlOrders);
            this.Name = "ViewOrdersForm";
            this.Text = "ViewOrdersForm";
            this.Load += new System.EventHandler(this.ViewOrdersForm_Load);
            this.tabReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.tabControlOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.TabControl tabControlOrders;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
    }
}