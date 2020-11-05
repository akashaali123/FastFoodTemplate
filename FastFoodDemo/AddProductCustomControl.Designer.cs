namespace FastFoodDemo
{
    partial class AddProductCustmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductCustmControl));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.txtRetailPrice = new ns1.BunifuMetroTextbox();
            this.txtProductName = new ns1.BunifuMetroTextbox();
            this.DrpCategory = new ns1.BunifuDropdown();
            this.txtSoldPrice = new ns1.BunifuMetroTextbox();
            this.lblSoldPrice = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(148, 103);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(213, 39);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(205, 161);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(156, 39);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblRetailPrice.Location = new System.Drawing.Point(175, 219);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(174, 39);
            this.lblRetailPrice.TabIndex = 4;
            this.lblRetailPrice.Text = "Retail Price:";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.BorderColorFocused = System.Drawing.Color.DimGray;
            this.txtRetailPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRetailPrice.BorderColorMouseHover = System.Drawing.Color.Green;
            this.txtRetailPrice.BorderThickness = 3;
            this.txtRetailPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetailPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRetailPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRetailPrice.isPassword = false;
            this.txtRetailPrice.Location = new System.Drawing.Point(368, 219);
            this.txtRetailPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(199, 39);
            this.txtRetailPrice.TabIndex = 3;
            this.txtRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderColorFocused = System.Drawing.Color.DimGray;
            this.txtProductName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductName.BorderColorMouseHover = System.Drawing.Color.Green;
            this.txtProductName.BorderThickness = 3;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProductName.isPassword = false;
            this.txtProductName.Location = new System.Drawing.Point(368, 103);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(199, 39);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DrpCategory
            // 
            this.DrpCategory.BackColor = System.Drawing.Color.Transparent;
            this.DrpCategory.BorderRadius = 3;
            this.DrpCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DrpCategory.ForeColor = System.Drawing.Color.White;
            this.DrpCategory.Items = new string[0];
            this.DrpCategory.Location = new System.Drawing.Point(368, 161);
            this.DrpCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DrpCategory.Name = "DrpCategory";
            this.DrpCategory.NomalColor = System.Drawing.Color.Silver;
            this.DrpCategory.onHoverColor = System.Drawing.Color.Green;
            this.DrpCategory.selectedIndex = -1;
            this.DrpCategory.Size = new System.Drawing.Size(199, 39);
            this.DrpCategory.TabIndex = 2;
            // 
            // txtSoldPrice
            // 
            this.txtSoldPrice.BorderColorFocused = System.Drawing.Color.DimGray;
            this.txtSoldPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoldPrice.BorderColorMouseHover = System.Drawing.Color.Green;
            this.txtSoldPrice.BorderThickness = 3;
            this.txtSoldPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoldPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSoldPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoldPrice.isPassword = false;
            this.txtSoldPrice.Location = new System.Drawing.Point(368, 277);
            this.txtSoldPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoldPrice.Name = "txtSoldPrice";
            this.txtSoldPrice.Size = new System.Drawing.Size(199, 39);
            this.txtSoldPrice.TabIndex = 4;
            this.txtSoldPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblSoldPrice
            // 
            this.lblSoldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblSoldPrice.Location = new System.Drawing.Point(184, 277);
            this.lblSoldPrice.Name = "lblSoldPrice";
            this.lblSoldPrice.Size = new System.Drawing.Size(165, 39);
            this.lblSoldPrice.TabIndex = 10;
            this.lblSoldPrice.Text = "Sold Price:";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Add Product";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(257, 348);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Green;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(199, 44);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "Add Product";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 11);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(349, 39);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Menu > Add Product";
            // 
            // AddProductCustmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txtSoldPrice);
            this.Controls.Add(this.lblSoldPrice);
            this.Controls.Add(this.DrpCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProductName);
            this.Name = "AddProductCustmControl";
            this.Size = new System.Drawing.Size(817, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRetailPrice;
        private ns1.BunifuMetroTextbox txtRetailPrice;
        private ns1.BunifuMetroTextbox txtProductName;
        private ns1.BunifuDropdown DrpCategory;
        private ns1.BunifuMetroTextbox txtSoldPrice;
        private System.Windows.Forms.Label lblSoldPrice;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
    }
}
