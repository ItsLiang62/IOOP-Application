namespace Foodle_Point_Management_System
{
    partial class ViewSales
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
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(743, 87);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(146, 47);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(502, 87);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 33);
            this.cmbMonth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Month:";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(167, 166);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowHeadersWidth = 82;
            this.dataGridViewSales.RowTemplate.Height = 33;
            this.dataGridViewSales.Size = new System.Drawing.Size(796, 343);
            this.dataGridViewSales.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(489, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 47);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 647);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.btnFilter);
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Button btnBack;
    }
}