
namespace GregLGraemeMLab6
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lstCheckout = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblItemPricesTotals = new System.Windows.Forms.Label();
            this.lblTaxesTotals = new System.Windows.Forms.Label();
            this.lblShippingTotals = new System.Windows.Forms.Label();
            this.lblGrandTotals = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(21, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(21, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item(s) price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(21, 393);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Taxes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(21, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Shipping costs:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(21, 521);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Grand total:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.IndianRed;
            this.btnConfirm.ForeColor = System.Drawing.Color.MintCream;
            this.btnConfirm.Location = new System.Drawing.Point(472, 567);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(149, 61);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "&Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.ForeColor = System.Drawing.Color.MintCream;
            this.btnRemoveItem.Location = new System.Drawing.Point(472, 292);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(149, 61);
            this.btnRemoveItem.TabIndex = 2;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lstCheckout
            // 
            this.lstCheckout.FormattingEnabled = true;
            this.lstCheckout.ItemHeight = 17;
            this.lstCheckout.Location = new System.Drawing.Point(207, 121);
            this.lstCheckout.Name = "lstCheckout";
            this.lstCheckout.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCheckout.Size = new System.Drawing.Size(414, 157);
            this.lstCheckout.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 100);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblItemPricesTotals
            // 
            this.lblItemPricesTotals.BackColor = System.Drawing.Color.Azure;
            this.lblItemPricesTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemPricesTotals.Location = new System.Drawing.Point(207, 324);
            this.lblItemPricesTotals.Name = "lblItemPricesTotals";
            this.lblItemPricesTotals.Size = new System.Drawing.Size(127, 29);
            this.lblItemPricesTotals.TabIndex = 0;
            // 
            // lblTaxesTotals
            // 
            this.lblTaxesTotals.BackColor = System.Drawing.Color.Azure;
            this.lblTaxesTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTaxesTotals.Location = new System.Drawing.Point(207, 388);
            this.lblTaxesTotals.Name = "lblTaxesTotals";
            this.lblTaxesTotals.Size = new System.Drawing.Size(127, 29);
            this.lblTaxesTotals.TabIndex = 0;
            // 
            // lblShippingTotals
            // 
            this.lblShippingTotals.BackColor = System.Drawing.Color.Azure;
            this.lblShippingTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShippingTotals.Location = new System.Drawing.Point(207, 452);
            this.lblShippingTotals.Name = "lblShippingTotals";
            this.lblShippingTotals.Size = new System.Drawing.Size(127, 29);
            this.lblShippingTotals.TabIndex = 0;
            // 
            // lblGrandTotals
            // 
            this.lblGrandTotals.BackColor = System.Drawing.Color.Azure;
            this.lblGrandTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotals.Location = new System.Drawing.Point(207, 516);
            this.lblGrandTotals.Name = "lblGrandTotals";
            this.lblGrandTotals.Size = new System.Drawing.Size(127, 29);
            this.lblGrandTotals.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(20, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thank you for shopping!";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.MintCream;
            this.btnCancel.Location = new System.Drawing.Point(294, 567);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 61);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "C&ancel Order";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(633, 640);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGrandTotals);
            this.Controls.Add(this.lblShippingTotals);
            this.Controls.Add(this.lblTaxesTotals);
            this.Controls.Add(this.lblItemPricesTotals);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstCheckout);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ListBox lstCheckout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblItemPricesTotals;
        private System.Windows.Forms.Label lblTaxesTotals;
        private System.Windows.Forms.Label lblShippingTotals;
        private System.Windows.Forms.Label lblGrandTotals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
    }
}