namespace Foodle_Point_Management_System
{
    partial class reserve_halls
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpectedPeople = new System.Windows.Forms.TextBox();
            this.txtAdditionalThings = new System.Windows.Forms.TextBox();
            this.jj = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Event Date:";
            // 
            // txtEventType
            // 
            this.txtEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventType.Location = new System.Drawing.Point(748, 153);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(203, 28);
            this.txtEventType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expected Number of People :";
            // 
            // txtExpectedPeople
            // 
            this.txtExpectedPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpectedPeople.Location = new System.Drawing.Point(748, 285);
            this.txtExpectedPeople.Name = "txtExpectedPeople";
            this.txtExpectedPeople.Size = new System.Drawing.Size(203, 28);
            this.txtExpectedPeople.TabIndex = 6;
            // 
            // txtAdditionalThings
            // 
            this.txtAdditionalThings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdditionalThings.Location = new System.Drawing.Point(748, 351);
            this.txtAdditionalThings.Name = "txtAdditionalThings";
            this.txtAdditionalThings.Size = new System.Drawing.Size(203, 28);
            this.txtAdditionalThings.TabIndex = 7;
            // 
            // jj
            // 
            this.jj.AutoSize = true;
            this.jj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jj.Location = new System.Drawing.Point(524, 349);
            this.jj.Name = "jj";
            this.jj.Size = new System.Drawing.Size(198, 29);
            this.jj.TabIndex = 8;
            this.jj.Text = "addition things :";
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(734, 469);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(144, 47);
            this.btnsend.TabIndex = 9;
            this.btnsend.Text = "send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(734, 222);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEventDate.TabIndex = 10;
            // 
            // reserve_halls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 647);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.jj);
            this.Controls.Add(this.txtAdditionalThings);
            this.Controls.Add(this.txtExpectedPeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "reserve_halls";
            this.Text = "reserve_halls";
            this.Load += new System.EventHandler(this.reserve_halls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpectedPeople;
        private System.Windows.Forms.TextBox txtAdditionalThings;
        private System.Windows.Forms.Label jj;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
    }
}