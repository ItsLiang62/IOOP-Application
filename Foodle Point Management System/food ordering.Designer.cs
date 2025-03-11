namespace new_customer
{
    partial class food_ordering
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbCuisineType = new System.Windows.Forms.ComboBox();
            this.lstMenuItems = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            this.txtEditQuantity = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(538, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "food ordering";
            // 
            // cmbCuisineType
            // 
            this.cmbCuisineType.FormattingEnabled = true;
            this.cmbCuisineType.Location = new System.Drawing.Point(209, 106);
            this.cmbCuisineType.Name = "cmbCuisineType";
            this.cmbCuisineType.Size = new System.Drawing.Size(149, 24);
            this.cmbCuisineType.TabIndex = 9;
            this.cmbCuisineType.SelectedIndexChanged += new System.EventHandler(this.cmbCuisineType_SelectedIndexChanged);
            // 
            // lstMenuItems
            // 
            this.lstMenuItems.FormattingEnabled = true;
            this.lstMenuItems.ItemHeight = 16;
            this.lstMenuItems.Location = new System.Drawing.Point(28, 172);
            this.lstMenuItems.Name = "lstMenuItems";
            this.lstMenuItems.Size = new System.Drawing.Size(233, 100);
            this.lstMenuItems.TabIndex = 10;
            this.lstMenuItems.SelectedIndexChanged += new System.EventHandler(this.lstMenuItems_SelectedIndexChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(55, 278);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(99, 23);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "Add To cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(339, 172);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(261, 100);
            this.lstCart.TabIndex = 13;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(511, 292);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(70, 23);
            this.btnRemoveItem.TabIndex = 14;
            this.btnRemoveItem.Text = "Remove from cart";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(190, 429);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(142, 37);
            this.btnConfirmOrder.TabIndex = 15;
            this.btnConfirmOrder.Text = "payment";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.Location = new System.Drawing.Point(357, 349);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(70, 23);
            this.btnEditQuantity.TabIndex = 16;
            this.btnEditQuantity.Text = "Edit";
            this.btnEditQuantity.UseVisualStyleBackColor = true;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // txtEditQuantity
            // 
            this.txtEditQuantity.Location = new System.Drawing.Point(339, 302);
            this.txtEditQuantity.Name = "txtEditQuantity";
            this.txtEditQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtEditQuantity.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 105);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // food_ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 807);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtEditQuantity);
            this.Controls.Add(this.btnEditQuantity);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lstMenuItems);
            this.Controls.Add(this.cmbCuisineType);
            this.Controls.Add(this.panel1);
            this.Name = "food_ordering";
            this.Text = "food_ordering";
            this.Load += new System.EventHandler(this.food_ordering_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbCuisineType;
        private System.Windows.Forms.ListBox lstMenuItems;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Button btnEditQuantity;
        private System.Windows.Forms.TextBox txtEditQuantity;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}