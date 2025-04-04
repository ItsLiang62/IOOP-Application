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
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnGR = new System.Windows.Forms.Button();
            this.lblTotalSales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(601, 42);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(180, 33);
            this.cmbMonth.TabIndex = 1;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(147, 50);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(144, 25);
            this.lblSales.TabIndex = 2;
            this.lblSales.Text = "Select Month:";
            // 
            // dgvSales
            // 
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(152, 236);
            this.dgvSales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 82;
            this.dgvSales.RowTemplate.Height = 33;
            this.dgvSales.Size = new System.Drawing.Size(924, 345);
            this.dgvSales.TabIndex = 3;
            this.dgvSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSales_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(370, 677);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(191, 73);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(147, 165);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(130, 25);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "Select Year:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.comboBoxYear.Location = new System.Drawing.Point(601, 162);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(180, 33);
            this.comboBoxYear.TabIndex = 6;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(928, 90);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(148, 57);
            this.btnClearFilter.TabIndex = 7;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnGR
            // 
            this.btnGR.Location = new System.Drawing.Point(652, 677);
            this.btnGR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGR.Name = "btnGR";
            this.btnGR.Size = new System.Drawing.Size(207, 73);
            this.btnGR.TabIndex = 8;
            this.btnGR.Text = "Generate Report";
            this.btnGR.UseVisualStyleBackColor = true;
            this.btnGR.Click += new System.EventHandler(this.btnGR_Click);
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(863, 618);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(213, 25);
            this.lblTotalSales.TabIndex = 9;
            this.lblTotalSales.Text = "Total Sales: RM 0.00";
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 795);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.btnGR);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.cmbMonth);
            this.Name = "ViewSales";
            this.Text = "ViewSales";
            this.Load += new System.EventHandler(this.ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnGR;
        private System.Windows.Forms.Label lblTotalSales;
    }
}