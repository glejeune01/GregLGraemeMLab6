namespace GregLGraemeMLab6
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.lstAllTitles = new System.Windows.Forms.ListBox();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtCodeEntry = new System.Windows.Forms.TextBox();
            this.txtTitleEntry = new System.Windows.Forms.TextBox();
            this.txtAuthorEntry = new System.Windows.Forms.TextBox();
            this.txtStockEntry = new System.Windows.Forms.TextBox();
            this.txtEditionEntry = new System.Windows.Forms.TextBox();
            this.txtPriceEntry = new System.Windows.Forms.TextBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.cboBookTypeSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAllTitles
            // 
            this.lstAllTitles.FormattingEnabled = true;
            this.lstAllTitles.ItemHeight = 17;
            this.lstAllTitles.Location = new System.Drawing.Point(428, 171);
            this.lstAllTitles.Margin = new System.Windows.Forms.Padding(4);
            this.lstAllTitles.Name = "lstAllTitles";
            this.lstAllTitles.Size = new System.Drawing.Size(751, 395);
            this.lstAllTitles.TabIndex = 8;
            this.lstAllTitles.SelectedIndexChanged += new System.EventHandler(this.lstAllTitles_SelectedIndexChanged);
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(245, 517);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(112, 30);
            this.btnAddEdit.TabIndex = 7;
            this.btnAddEdit.Text = "&Add/Edit";
            this.btnAddEdit.UseVisualStyleBackColor = true;
            this.btnAddEdit.Click += new System.EventHandler(this.BtnAddEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(933, 672);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 30);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1067, 672);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblCode.ForeColor = System.Drawing.Color.MintCream;
            this.lblCode.Location = new System.Drawing.Point(13, 245);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(44, 17);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.ForeColor = System.Drawing.Color.MintCream;
            this.lblTitle.Location = new System.Drawing.Point(13, 290);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 17);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblAuthor.ForeColor = System.Drawing.Color.MintCream;
            this.lblAuthor.Location = new System.Drawing.Point(13, 335);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 17);
            this.lblAuthor.TabIndex = 3;
            this.lblAuthor.Text = "Author";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrice.ForeColor = System.Drawing.Color.MintCream;
            this.lblPrice.Location = new System.Drawing.Point(13, 380);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblEdition.ForeColor = System.Drawing.Color.MintCream;
            this.lblEdition.Location = new System.Drawing.Point(13, 425);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(71, 17);
            this.lblEdition.TabIndex = 5;
            this.lblEdition.Text = "Edition";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblStock.ForeColor = System.Drawing.Color.MintCream;
            this.lblStock.Location = new System.Drawing.Point(13, 470);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(53, 17);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(981, 13);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(198, 101);
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // txtCodeEntry
            // 
            this.txtCodeEntry.Location = new System.Drawing.Point(127, 242);
            this.txtCodeEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeEntry.Name = "txtCodeEntry";
            this.txtCodeEntry.Size = new System.Drawing.Size(230, 24);
            this.txtCodeEntry.TabIndex = 1;
            // 
            // txtTitleEntry
            // 
            this.txtTitleEntry.Location = new System.Drawing.Point(127, 287);
            this.txtTitleEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitleEntry.Name = "txtTitleEntry";
            this.txtTitleEntry.Size = new System.Drawing.Size(230, 24);
            this.txtTitleEntry.TabIndex = 2;
            // 
            // txtAuthorEntry
            // 
            this.txtAuthorEntry.Location = new System.Drawing.Point(127, 332);
            this.txtAuthorEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorEntry.Name = "txtAuthorEntry";
            this.txtAuthorEntry.Size = new System.Drawing.Size(230, 24);
            this.txtAuthorEntry.TabIndex = 3;
            // 
            // txtStockEntry
            // 
            this.txtStockEntry.Location = new System.Drawing.Point(127, 467);
            this.txtStockEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockEntry.Name = "txtStockEntry";
            this.txtStockEntry.Size = new System.Drawing.Size(230, 24);
            this.txtStockEntry.TabIndex = 6;
            // 
            // txtEditionEntry
            // 
            this.txtEditionEntry.Location = new System.Drawing.Point(127, 422);
            this.txtEditionEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditionEntry.Name = "txtEditionEntry";
            this.txtEditionEntry.Size = new System.Drawing.Size(230, 24);
            this.txtEditionEntry.TabIndex = 5;
            // 
            // txtPriceEntry
            // 
            this.txtPriceEntry.Location = new System.Drawing.Point(127, 377);
            this.txtPriceEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceEntry.Name = "txtPriceEntry";
            this.txtPriceEntry.Size = new System.Drawing.Size(230, 24);
            this.txtPriceEntry.TabIndex = 4;
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblBookType.ForeColor = System.Drawing.Color.MintCream;
            this.lblBookType.Location = new System.Drawing.Point(13, 171);
            this.lblBookType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(89, 17);
            this.lblBookType.TabIndex = 0;
            this.lblBookType.Text = "Book Type";
            // 
            // cboBookTypeSelector
            // 
            this.cboBookTypeSelector.FormattingEnabled = true;
            this.cboBookTypeSelector.Items.AddRange(new object[] {
            "Fiction",
            "Non Fiction",
            "Comic Book"});
            this.cboBookTypeSelector.Location = new System.Drawing.Point(127, 171);
            this.cboBookTypeSelector.Name = "cboBookTypeSelector";
            this.cboBookTypeSelector.Size = new System.Drawing.Size(230, 25);
            this.cboBookTypeSelector.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1216, 720);
            this.Controls.Add(this.cboBookTypeSelector);
            this.Controls.Add(this.lblBookType);
            this.Controls.Add(this.txtPriceEntry);
            this.Controls.Add(this.txtEditionEntry);
            this.Controls.Add(this.txtStockEntry);
            this.Controls.Add(this.txtAuthorEntry);
            this.Controls.Add(this.txtTitleEntry);
            this.Controls.Add(this.txtCodeEntry);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.lstAllTitles);
            this.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllTitles;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtCodeEntry;
        private System.Windows.Forms.TextBox txtTitleEntry;
        private System.Windows.Forms.TextBox txtAuthorEntry;
        private System.Windows.Forms.TextBox txtStockEntry;
        private System.Windows.Forms.TextBox txtEditionEntry;
        private System.Windows.Forms.TextBox txtPriceEntry;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.ComboBox cboBookTypeSelector;
    }
}