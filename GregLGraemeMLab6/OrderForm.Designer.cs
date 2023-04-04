
namespace GregLGraemeMLab6
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstNonFiction = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtComicSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstComicBooks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lstFiction = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFictionSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNonFictionSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title:";
            // 
            // lstNonFiction
            // 
            this.lstNonFiction.BackColor = System.Drawing.Color.Azure;
            this.lstNonFiction.FormattingEnabled = true;
            this.lstNonFiction.ItemHeight = 17;
            this.lstNonFiction.Location = new System.Drawing.Point(0, 111);
            this.lstNonFiction.Name = "lstNonFiction";
            this.lstNonFiction.Size = new System.Drawing.Size(381, 191);
            this.lstNonFiction.TabIndex = 0;
            this.lstNonFiction.SelectedIndexChanged += new System.EventHandler(this.lstNonFiction_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtComicSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lstComicBooks);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox3.Location = new System.Drawing.Point(816, 138);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(381, 302);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comic Books";
            // 
            // txtComicSearch
            // 
            this.txtComicSearch.BackColor = System.Drawing.Color.Azure;
            this.txtComicSearch.Location = new System.Drawing.Point(73, 60);
            this.txtComicSearch.Name = "txtComicSearch";
            this.txtComicSearch.Size = new System.Drawing.Size(242, 24);
            this.txtComicSearch.TabIndex = 13;
            this.txtComicSearch.TextChanged += new System.EventHandler(this.TxtComicSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MintCream;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Title:";
            // 
            // lstComicBooks
            // 
            this.lstComicBooks.BackColor = System.Drawing.Color.Azure;
            this.lstComicBooks.FormattingEnabled = true;
            this.lstComicBooks.ItemHeight = 17;
            this.lstComicBooks.Location = new System.Drawing.Point(0, 111);
            this.lstComicBooks.Name = "lstComicBooks";
            this.lstComicBooks.Size = new System.Drawing.Size(381, 191);
            this.lstComicBooks.TabIndex = 2;
            this.lstComicBooks.SelectedIndexChanged += new System.EventHandler(this.lstComicBooks_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.ForeColor = System.Drawing.Color.MintCream;
            this.btnAdd.Location = new System.Drawing.Point(816, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 68);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.IndianRed;
            this.btnCheckOut.Location = new System.Drawing.Point(1029, 474);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(168, 68);
            this.btnCheckOut.TabIndex = 9;
            this.btnCheckOut.Text = "&Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // lstFiction
            // 
            this.lstFiction.BackColor = System.Drawing.Color.Azure;
            this.lstFiction.FormattingEnabled = true;
            this.lstFiction.ItemHeight = 17;
            this.lstFiction.Location = new System.Drawing.Point(0, 111);
            this.lstFiction.Name = "lstFiction";
            this.lstFiction.Size = new System.Drawing.Size(381, 191);
            this.lstFiction.TabIndex = 1;
            this.lstFiction.SelectedIndexChanged += new System.EventHandler(this.lstFiction_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Title:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstFiction);
            this.groupBox2.Controls.Add(this.txtFictionSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox2.Location = new System.Drawing.Point(413, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(381, 302);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiction";
            // 
            // txtFictionSearch
            // 
            this.txtFictionSearch.BackColor = System.Drawing.Color.Azure;
            this.txtFictionSearch.Location = new System.Drawing.Point(73, 64);
            this.txtFictionSearch.Name = "txtFictionSearch";
            this.txtFictionSearch.Size = new System.Drawing.Size(242, 24);
            this.txtFictionSearch.TabIndex = 12;
            this.txtFictionSearch.TextChanged += new System.EventHandler(this.TxtFictionSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNonFiction);
            this.groupBox1.Controls.Add(this.txtNonFictionSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MintCream;
            this.groupBox1.Location = new System.Drawing.Point(10, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 302);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Non-Fiction";
            // 
            // txtNonFictionSearch
            // 
            this.txtNonFictionSearch.BackColor = System.Drawing.Color.Azure;
            this.txtNonFictionSearch.Location = new System.Drawing.Point(73, 67);
            this.txtNonFictionSearch.Name = "txtNonFictionSearch";
            this.txtNonFictionSearch.Size = new System.Drawing.Size(242, 24);
            this.txtNonFictionSearch.TabIndex = 11;
            this.txtNonFictionSearch.TextChanged += new System.EventHandler(this.TxtNonFictionSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(469, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Please choose from our award winning selection!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1004, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 97);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1211, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ListBox lstNonFiction;
        private System.Windows.Forms.ListBox lstComicBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstFiction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtComicSearch;
        private System.Windows.Forms.TextBox txtFictionSearch;
        private System.Windows.Forms.TextBox txtNonFictionSearch;
    }
}