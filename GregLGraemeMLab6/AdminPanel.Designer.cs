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
            this.lblGenre = new System.Windows.Forms.Label();
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
            this.txtGenreEntry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAllTitles
            // 
            this.lstAllTitles.FormattingEnabled = true;
            this.lstAllTitles.ItemHeight = 20;
            this.lstAllTitles.Location = new System.Drawing.Point(428, 171);
            this.lstAllTitles.Margin = new System.Windows.Forms.Padding(4);
            this.lstAllTitles.Name = "lstAllTitles";
            this.lstAllTitles.Size = new System.Drawing.Size(751, 444);
            this.lstAllTitles.TabIndex = 0;
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Location = new System.Drawing.Point(235, 495);
            this.btnAddEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(112, 30);
            this.btnAddEdit.TabIndex = 1;
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
            this.btnRemove.TabIndex = 2;
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
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(18, 175);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(52, 20);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Code";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(18, 218);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 20);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(18, 264);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(64, 20);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Author";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(18, 310);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(60, 20);
            this.lblGenre.TabIndex = 8;
            this.lblGenre.Text = "Genre";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(18, 356);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(18, 401);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(67, 20);
            this.lblEdition.TabIndex = 10;
            this.lblEdition.Text = "Edition";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(18, 447);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(56, 20);
            this.lblStock.TabIndex = 11;
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
            this.txtCodeEntry.Location = new System.Drawing.Point(117, 171);
            this.txtCodeEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeEntry.Name = "txtCodeEntry";
            this.txtCodeEntry.Size = new System.Drawing.Size(230, 27);
            this.txtCodeEntry.TabIndex = 13;
            // 
            // txtTitleEntry
            // 
            this.txtTitleEntry.Location = new System.Drawing.Point(117, 218);
            this.txtTitleEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitleEntry.Name = "txtTitleEntry";
            this.txtTitleEntry.Size = new System.Drawing.Size(230, 27);
            this.txtTitleEntry.TabIndex = 14;
            // 
            // txtAuthorEntry
            // 
            this.txtAuthorEntry.Location = new System.Drawing.Point(117, 260);
            this.txtAuthorEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorEntry.Name = "txtAuthorEntry";
            this.txtAuthorEntry.Size = new System.Drawing.Size(230, 27);
            this.txtAuthorEntry.TabIndex = 15;
            // 
            // txtStockEntry
            // 
            this.txtStockEntry.Location = new System.Drawing.Point(117, 443);
            this.txtStockEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockEntry.Name = "txtStockEntry";
            this.txtStockEntry.Size = new System.Drawing.Size(230, 27);
            this.txtStockEntry.TabIndex = 16;
            // 
            // txtEditionEntry
            // 
            this.txtEditionEntry.Location = new System.Drawing.Point(117, 398);
            this.txtEditionEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditionEntry.Name = "txtEditionEntry";
            this.txtEditionEntry.Size = new System.Drawing.Size(230, 27);
            this.txtEditionEntry.TabIndex = 17;
            // 
            // txtPriceEntry
            // 
            this.txtPriceEntry.Location = new System.Drawing.Point(117, 352);
            this.txtPriceEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceEntry.Name = "txtPriceEntry";
            this.txtPriceEntry.Size = new System.Drawing.Size(230, 27);
            this.txtPriceEntry.TabIndex = 18;
            // 
            // txtGenreEntry
            // 
            this.txtGenreEntry.Location = new System.Drawing.Point(117, 306);
            this.txtGenreEntry.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenreEntry.Name = "txtGenreEntry";
            this.txtGenreEntry.Size = new System.Drawing.Size(230, 27);
            this.txtGenreEntry.TabIndex = 19;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1216, 720);
            this.Controls.Add(this.txtGenreEntry);
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
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.lstAllTitles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
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
        private System.Windows.Forms.Label lblGenre;
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
        private System.Windows.Forms.TextBox txtGenreEntry;
    }
}