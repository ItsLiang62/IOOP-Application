namespace Foodle_Point_Management_System
{
    partial class frmManageMenu
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
            this.btnWestern = new System.Windows.Forms.Button();
            this.btnChinese = new System.Windows.Forms.Button();
            this.btnArab = new System.Windows.Forms.Button();
            this.btnJapanese = new System.Windows.Forms.Button();
            this.btnDessertsBeverages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select a Menu Category";
            // 
            // btnWestern
            // 
            this.btnWestern.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWestern.Location = new System.Drawing.Point(47, 168);
            this.btnWestern.Name = "btnWestern";
            this.btnWestern.Size = new System.Drawing.Size(138, 219);
            this.btnWestern.TabIndex = 1;
            this.btnWestern.Text = "Western";
            this.btnWestern.UseVisualStyleBackColor = true;
            this.btnWestern.Click += new System.EventHandler(this.btnWestern_Click);
            // 
            // btnChinese
            // 
            this.btnChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinese.Location = new System.Drawing.Point(191, 168);
            this.btnChinese.Name = "btnChinese";
            this.btnChinese.Size = new System.Drawing.Size(138, 219);
            this.btnChinese.TabIndex = 2;
            this.btnChinese.Text = "Chinese";
            this.btnChinese.UseVisualStyleBackColor = true;
            // 
            // btnArab
            // 
            this.btnArab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArab.Location = new System.Drawing.Point(335, 168);
            this.btnArab.Name = "btnArab";
            this.btnArab.Size = new System.Drawing.Size(138, 219);
            this.btnArab.TabIndex = 3;
            this.btnArab.Text = "Arab";
            this.btnArab.UseVisualStyleBackColor = true;
            // 
            // btnJapanese
            // 
            this.btnJapanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJapanese.Location = new System.Drawing.Point(479, 168);
            this.btnJapanese.Name = "btnJapanese";
            this.btnJapanese.Size = new System.Drawing.Size(138, 219);
            this.btnJapanese.TabIndex = 4;
            this.btnJapanese.Text = "Japanese";
            this.btnJapanese.UseVisualStyleBackColor = true;
            // 
            // btnDessertsBeverages
            // 
            this.btnDessertsBeverages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDessertsBeverages.Location = new System.Drawing.Point(623, 168);
            this.btnDessertsBeverages.Name = "btnDessertsBeverages";
            this.btnDessertsBeverages.Size = new System.Drawing.Size(138, 219);
            this.btnDessertsBeverages.TabIndex = 5;
            this.btnDessertsBeverages.Text = "Desserts and Beverages";
            this.btnDessertsBeverages.UseVisualStyleBackColor = true;
            // 
            // frmManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDessertsBeverages);
            this.Controls.Add(this.btnJapanese);
            this.Controls.Add(this.btnArab);
            this.Controls.Add(this.btnChinese);
            this.Controls.Add(this.btnWestern);
            this.Controls.Add(this.label1);
            this.Name = "frmManageMenu";
            this.Text = "Manage Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManageMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWestern;
        private System.Windows.Forms.Button btnChinese;
        private System.Windows.Forms.Button btnArab;
        private System.Windows.Forms.Button btnJapanese;
        private System.Windows.Forms.Button btnDessertsBeverages;
    }
}