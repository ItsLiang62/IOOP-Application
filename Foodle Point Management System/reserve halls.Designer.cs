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
            this.lblet = new System.Windows.Forms.Label();
            this.lbled = new System.Windows.Forms.Label();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.lblenop = new System.Windows.Forms.Label();
            this.txtExpectedPeople = new System.Windows.Forms.TextBox();
            this.txtAdditionalThings = new System.Windows.Forms.TextBox();
            this.lblat = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblet
            // 
            this.lblet.AutoSize = true;
            this.lblet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblet.Location = new System.Drawing.Point(524, 153);
            this.lblet.Name = "lblet";
            this.lblet.Size = new System.Drawing.Size(151, 29);
            this.lblet.TabIndex = 1;
            this.lblet.Text = "Event Type:";
            // 
            // lbled
            // 
            this.lbled.AutoSize = true;
            this.lbled.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbled.Location = new System.Drawing.Point(524, 217);
            this.lbled.Name = "lbled";
            this.lbled.Size = new System.Drawing.Size(146, 29);
            this.lbled.TabIndex = 3;
            this.lbled.Text = "Event Date:";
            // 
            // txtEventType
            // 
            this.txtEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventType.Location = new System.Drawing.Point(748, 153);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(203, 28);
            this.txtEventType.TabIndex = 4;
            // 
            // lblenop
            // 
            this.lblenop.AutoSize = true;
            this.lblenop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenop.Location = new System.Drawing.Point(386, 285);
            this.lblenop.Name = "lblenop";
            this.lblenop.Size = new System.Drawing.Size(356, 29);
            this.lblenop.TabIndex = 5;
            this.lblenop.Text = "Expected Number of People :";
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
            // lblat
            // 
            this.lblat.AutoSize = true;
            this.lblat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblat.Location = new System.Drawing.Point(524, 349);
            this.lblat.Name = "lblat";
            this.lblat.Size = new System.Drawing.Size(198, 29);
            this.lblat.TabIndex = 8;
            this.lblat.Text = "addition things :";
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(780, 414);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(144, 47);
            this.btnsend.TabIndex = 9;
            this.btnsend.Text = "send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(748, 222);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEventDate.TabIndex = 10;
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(1, 469);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(281, 78);
            this.btnlogout.TabIndex = 11;
            this.btnlogout.Text = "Return To  The Main Page";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(755, 87);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(169, 29);
            this.lblmessage.TabIndex = 12;
            this.lblmessage.Text = "ReserveHalls";
            // 
            // reserve_halls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 547);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.lblat);
            this.Controls.Add(this.txtAdditionalThings);
            this.Controls.Add(this.txtExpectedPeople);
            this.Controls.Add(this.lblenop);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.lbled);
            this.Controls.Add(this.lblet);
            this.Name = "reserve_halls";
            this.Text = "reserve_halls";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.reserve_halls_FormClosing);
            this.Load += new System.EventHandler(this.reserve_halls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblet;
        private System.Windows.Forms.Label lbled;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.Label lblenop;
        private System.Windows.Forms.TextBox txtExpectedPeople;
        private System.Windows.Forms.TextBox txtAdditionalThings;
        private System.Windows.Forms.Label lblat;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lblmessage;
    }
}