namespace Foodle_Point_Management_System
{
    partial class OrderFoodForm
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
            this.lblfood = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblcategory = new System.Windows.Forms.Label();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnEditCart = new System.Windows.Forms.Button();
            this.btnRemoveCart = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnreturn = new System.Windows.Forms.Button();
            this.lblcart = new System.Windows.Forms.Label();
            this.lblmenu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfood
            // 
            this.lblfood.AutoSize = true;
            this.lblfood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfood.Location = new System.Drawing.Point(607, 9);
            this.lblfood.Name = "lblfood";
            this.lblfood.Size = new System.Drawing.Size(152, 29);
            this.lblfood.TabIndex = 0;
            this.lblfood.Text = "Food Menu:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(659, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(522, 56);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(91, 29);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "search:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(659, 108);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(104, 24);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(506, 101);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(116, 29);
            this.lblcategory.TabIndex = 4;
            this.lblcategory.Text = "Category:";
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(0, 170);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.RowHeadersWidth = 51;
            this.dgvMenuItems.RowTemplate.Height = 24;
            this.dgvMenuItems.Size = new System.Drawing.Size(541, 210);
            this.dgvMenuItems.TabIndex = 5;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(788, 170);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(541, 211);
            this.dgvCart.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(198, 386);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(95, 39);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnEditCart
            // 
            this.btnEditCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCart.Location = new System.Drawing.Point(906, 408);
            this.btnEditCart.Name = "btnEditCart";
            this.btnEditCart.Size = new System.Drawing.Size(84, 41);
            this.btnEditCart.TabIndex = 8;
            this.btnEditCart.Text = "Edit";
            this.btnEditCart.UseVisualStyleBackColor = true;
            this.btnEditCart.Click += new System.EventHandler(this.btnEditCart_Click);
            // 
            // btnRemoveCart
            // 
            this.btnRemoveCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCart.Location = new System.Drawing.Point(1146, 408);
            this.btnRemoveCart.Name = "btnRemoveCart";
            this.btnRemoveCart.Size = new System.Drawing.Size(85, 43);
            this.btnRemoveCart.TabIndex = 9;
            this.btnRemoveCart.Text = "Delete";
            this.btnRemoveCart.UseVisualStyleBackColor = true;
            this.btnRemoveCart.Click += new System.EventHandler(this.btnRemoveCart_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(587, 516);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(213, 48);
            this.btnPayment.TabIndex = 10;
            this.btnPayment.Text = "Pay";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnProceedToPayment_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(1261, 522);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(23, 34);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.Text = " ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(1167, 527);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(64, 29);
            this.lbltotal.TabIndex = 12;
            this.lbltotal.Text = "total:";
            // 
            // btnreturn
            // 
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(12, 500);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(281, 78);
            this.btnreturn.TabIndex = 13;
            this.btnreturn.Text = "Return To  The Main Page";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblcart
            // 
            this.lblcart.AutoSize = true;
            this.lblcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcart.Location = new System.Drawing.Point(1032, 125);
            this.lblcart.Name = "lblcart";
            this.lblcart.Size = new System.Drawing.Size(57, 29);
            this.lblcart.TabIndex = 14;
            this.lblcart.Text = "Cart";
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.Location = new System.Drawing.Point(234, 138);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(73, 29);
            this.lblmenu.TabIndex = 15;
            this.lblmenu.Text = "Menu";
            // 
            // OrderFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 584);
            this.Controls.Add(this.lblmenu);
            this.Controls.Add(this.lblcart);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnRemoveCart);
            this.Controls.Add(this.btnEditCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblfood);
            this.Name = "OrderFoodForm";
            this.Text = "OrderFoodForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderFoodForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfood;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnEditCart;
        private System.Windows.Forms.Button btnRemoveCart;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Label lblcart;
        private System.Windows.Forms.Label lblmenu;
    }
}