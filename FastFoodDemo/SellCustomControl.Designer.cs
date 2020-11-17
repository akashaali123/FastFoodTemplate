namespace FastFoodDemo
{
    partial class SellCustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellCustomControl));
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.drpCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drpProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cartGrid = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addToCart = new ns1.BunifuFlatButton();
            this.lblUnitPrice = new ns1.BunifuCustomLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBill = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblNetBill = new ns1.BunifuCustomLabel();
            this.lblDiscountRate = new ns1.BunifuCustomLabel();
            this.lblGrossBill = new ns1.BunifuCustomLabel();
            this.Save = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 14);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(347, 39);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "Menu > Sell Product";
            // 
            // drpCategory
            // 
            this.drpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drpCategory.FormattingEnabled = true;
            this.drpCategory.Location = new System.Drawing.Point(111, 53);
            this.drpCategory.Name = "drpCategory";
            this.drpCategory.Size = new System.Drawing.Size(132, 28);
            this.drpCategory.TabIndex = 15;
            this.drpCategory.SelectedIndexChanged += new System.EventHandler(this.drpCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(358, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Product:";
            // 
            // drpProduct
            // 
            this.drpProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drpProduct.FormattingEnabled = true;
            this.drpProduct.Location = new System.Drawing.Point(463, 53);
            this.drpProduct.Name = "drpProduct";
            this.drpProduct.Size = new System.Drawing.Size(293, 28);
            this.drpProduct.TabIndex = 17;
            this.drpProduct.SelectedIndexChanged += new System.EventHandler(this.drpProduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Qty:";
            // 
            // txtAp
            // 
            this.txtAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAp.Location = new System.Drawing.Point(376, 90);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(50, 26);
            this.txtAp.TabIndex = 22;
            this.txtAp.TextChanged += new System.EventHandler(this.txtAp_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(302, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "A.P:";
            // 
            // txtSp
            // 
            this.txtSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSp.Location = new System.Drawing.Point(228, 90);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(52, 26);
            this.txtSp.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(154, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "S.P:";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStock.Location = new System.Drawing.Point(524, 90);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 26);
            this.txtStock.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(450, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Stock:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQty.Location = new System.Drawing.Point(80, 90);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(50, 26);
            this.txtQty.TabIndex = 30;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // cartGrid
            // 
            this.cartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Category,
            this.Qty,
            this.UnitPrice,
            this.TotalPrice,
            this.Action});
            this.cartGrid.Location = new System.Drawing.Point(-9, 187);
            this.cartGrid.Name = "cartGrid";
            this.cartGrid.Size = new System.Drawing.Size(643, 231);
            this.cartGrid.TabIndex = 31;
            this.cartGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Remove";
            this.Action.ToolTipText = "Remove";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // addToCart
            // 
            this.addToCart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addToCart.BackColor = System.Drawing.Color.DarkGray;
            this.addToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addToCart.BorderRadius = 0;
            this.addToCart.ButtonText = "Add To Cart";
            this.addToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCart.DisabledColor = System.Drawing.Color.Gray;
            this.addToCart.Iconcolor = System.Drawing.Color.Transparent;
            this.addToCart.Iconimage = ((System.Drawing.Image)(resources.GetObject("addToCart.Iconimage")));
            this.addToCart.Iconimage_right = null;
            this.addToCart.Iconimage_right_Selected = null;
            this.addToCart.Iconimage_Selected = null;
            this.addToCart.IconMarginLeft = 0;
            this.addToCart.IconMarginRight = 0;
            this.addToCart.IconRightVisible = true;
            this.addToCart.IconRightZoom = 0D;
            this.addToCart.IconVisible = true;
            this.addToCart.IconZoom = 90D;
            this.addToCart.IsTab = false;
            this.addToCart.Location = new System.Drawing.Point(601, 90);
            this.addToCart.Name = "addToCart";
            this.addToCart.Normalcolor = System.Drawing.Color.DarkGray;
            this.addToCart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addToCart.OnHoverTextColor = System.Drawing.Color.White;
            this.addToCart.selected = false;
            this.addToCart.Size = new System.Drawing.Size(155, 28);
            this.addToCart.TabIndex = 32;
            this.addToCart.Text = "Add To Cart";
            this.addToCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addToCart.Textcolor = System.Drawing.Color.White;
            this.addToCart.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUnitPrice.Location = new System.Drawing.Point(77, 131);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(166, 28);
            this.lblUnitPrice.TabIndex = 33;
            this.lblUnitPrice.Click += new System.EventHandler(this.lblUnitPrice_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(6, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 28);
            this.label7.TabIndex = 34;
            this.label7.Text = "Price: ";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(313, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 28);
            this.label8.TabIndex = 35;
            this.label8.Text = "Discount:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(408, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 26);
            this.textBox1.TabIndex = 36;
            // 
            // lblBill
            // 
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBill.Location = new System.Drawing.Point(675, 176);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(81, 28);
            this.lblBill.TabIndex = 37;
            this.lblBill.Text = "Net Bill: ";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(675, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 28);
            this.label10.TabIndex = 38;
            this.label10.Text = "Discount:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(675, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 28);
            this.label9.TabIndex = 39;
            this.label9.Text = "Gross Bill:";
            // 
            // lblNetBill
            // 
            this.lblNetBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNetBill.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNetBill.Location = new System.Drawing.Point(640, 204);
            this.lblNetBill.Name = "lblNetBill";
            this.lblNetBill.Size = new System.Drawing.Size(166, 28);
            this.lblNetBill.TabIndex = 40;
            this.lblNetBill.Text = "Hi";
            // 
            // lblDiscountRate
            // 
            this.lblDiscountRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDiscountRate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDiscountRate.Location = new System.Drawing.Point(640, 301);
            this.lblDiscountRate.Name = "lblDiscountRate";
            this.lblDiscountRate.Size = new System.Drawing.Size(166, 28);
            this.lblDiscountRate.TabIndex = 41;
            this.lblDiscountRate.Text = "Hi";
            // 
            // lblGrossBill
            // 
            this.lblGrossBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGrossBill.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGrossBill.Location = new System.Drawing.Point(640, 397);
            this.lblGrossBill.Name = "lblGrossBill";
            this.lblGrossBill.Size = new System.Drawing.Size(166, 28);
            this.lblGrossBill.TabIndex = 42;
            this.lblGrossBill.Text = "Hi";
            // 
            // Save
            // 
            this.Save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Save.BackColor = System.Drawing.Color.SlateGray;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save.BorderRadius = 0;
            this.Save.ButtonText = "Save";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.DisabledColor = System.Drawing.Color.Gray;
            this.Save.Iconcolor = System.Drawing.Color.Transparent;
            this.Save.Iconimage = ((System.Drawing.Image)(resources.GetObject("Save.Iconimage")));
            this.Save.Iconimage_right = null;
            this.Save.Iconimage_right_Selected = null;
            this.Save.Iconimage_Selected = null;
            this.Save.IconMarginLeft = 0;
            this.Save.IconMarginRight = 0;
            this.Save.IconRightVisible = true;
            this.Save.IconRightZoom = 0D;
            this.Save.IconVisible = true;
            this.Save.IconZoom = 90D;
            this.Save.IsTab = false;
            this.Save.Location = new System.Drawing.Point(601, 131);
            this.Save.Name = "Save";
            this.Save.Normalcolor = System.Drawing.Color.DarkGray;
            this.Save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Save.OnHoverTextColor = System.Drawing.Color.White;
            this.Save.selected = false;
            this.Save.Size = new System.Drawing.Size(155, 28);
            this.Save.TabIndex = 32;
            this.Save.Text = "Save";
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save.Textcolor = System.Drawing.Color.White;
            this.Save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // SellCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGrossBill);
            this.Controls.Add(this.lblDiscountRate);
            this.Controls.Add(this.lblNetBill);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.cartGrid);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drpCategory);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Name = "SellCustomControl";
            this.Size = new System.Drawing.Size(817, 438);
            this.Load += new System.EventHandler(this.SellCustomControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.ComboBox drpCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridView cartGrid;
        private ns1.BunifuFlatButton addToCart;
        private ns1.BunifuCustomLabel lblUnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private ns1.BunifuCustomLabel lblNetBill;
        private ns1.BunifuCustomLabel lblDiscountRate;
        private ns1.BunifuCustomLabel lblGrossBill;
        private ns1.BunifuFlatButton Save;
    }
}
