namespace FastFoodDemo
{
    partial class DashboardCustomControl
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
            this.lblSale = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.fromDatePick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toDatePick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSale
            // 
            this.lblSale.BackColor = System.Drawing.Color.Transparent;
            this.lblSale.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSale.Location = new System.Drawing.Point(24, 115);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(222, 79);
            this.lblSale.TabIndex = 0;
            this.lblSale.Text = "RS1200";
            this.lblSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Sale";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(266, 401);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(254, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "   Total \r\nPurchase";
            // 
            // lblPurchase
            // 
            this.lblPurchase.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchase.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.ForeColor = System.Drawing.Color.Red;
            this.lblPurchase.Location = new System.Drawing.Point(259, 115);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(222, 79);
            this.lblPurchase.TabIndex = 0;
            this.lblPurchase.Text = "RS1200";
            this.lblPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fromDatePick
            // 
            this.fromDatePick.Location = new System.Drawing.Point(62, 27);
            this.fromDatePick.Name = "fromDatePick";
            this.fromDatePick.Size = new System.Drawing.Size(200, 20);
            this.fromDatePick.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // toDatePick
            // 
            this.toDatePick.Location = new System.Drawing.Point(326, 27);
            this.toDatePick.Name = "toDatePick";
            this.toDatePick.Size = new System.Drawing.Size(200, 20);
            this.toDatePick.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(270, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(520, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Revenue";
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenue.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblRevenue.Location = new System.Drawing.Point(487, 115);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(222, 79);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.Text = "RS1000";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardCustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toDatePick);
            this.Controls.Add(this.fromDatePick);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.label4);
            this.Name = "DashboardCustomControl";
            this.Size = new System.Drawing.Size(817, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.DateTimePicker fromDatePick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toDatePick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRevenue;
    }
}
