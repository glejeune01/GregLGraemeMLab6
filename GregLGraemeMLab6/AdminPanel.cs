using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GregLGraemeMLab6
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            Program.bookArray = Program.ImportBooks(filePath: "C:\\files\\books.txt");
            // Iterate through the bookArray and add each book to the appropriate listbox
            foreach (Book book in Program.bookArray)
            { 
                lstAllTitles.Items.Add(ToString(book));
            }
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            if (cboBookTypeSelector.Text == "Comic Book")
            {
                Book newBook = new ComicBook
                {
                    // Get values from text boxes
                    Code = int.Parse(txtCodeEntry.Text),
                    Title = txtTitleEntry.Text,
                    Author = txtAuthorEntry.Text,
                    Genre = txtGenreEntry.Text,
                    Price = decimal.Parse(txtPriceEntry.Text),
                    Edition = txtEditionEntry.Text,
                    Stock = int.Parse(txtStockEntry.Text)
                };
                Array.Resize(ref Program.bookArray, Program.bookArray.Length + 1);
                Program.bookArray[Program.bookArray.Length - 1] = newBook;
            }
            else if (cboBookTypeSelector.Text == "Fiction")
            {
                Book newBook = new Fiction
                {
                    // Get values from text boxes
                    Code = int.Parse(txtCodeEntry.Text),
                    Title = txtTitleEntry.Text,
                    Author = txtAuthorEntry.Text,
                    Genre = txtGenreEntry.Text,
                    Price = decimal.Parse(txtPriceEntry.Text),
                    Stock = int.Parse(txtStockEntry.Text)
                };
                Array.Resize(ref Program.bookArray, Program.bookArray.Length + 1);
                Program.bookArray[Program.bookArray.Length - 1] = newBook;
            }
            else if (cboBookTypeSelector.Text == "Non Fiction")
            {
                Book newBook = new NonFiction
                {
                    // Get values from text boxes
                    Code = int.Parse(txtCodeEntry.Text),
                    Title = txtTitleEntry.Text,
                    Author = txtAuthorEntry.Text,
                    Genre = txtGenreEntry.Text,
                    Price = decimal.Parse(txtPriceEntry.Text),
                    Stock = int.Parse(txtStockEntry.Text)
                };
                Array.Resize(ref Program.bookArray, Program.bookArray.Length + 1);
                Program.bookArray[Program.bookArray.Length - 1] = newBook;
            }

            lstAllTitles.Items.Clear();
            foreach(Book newBook in Program.bookArray)
            {
                lstAllTitles.Items.Add(ToString(newBook));
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Program.ExportBooks(filePath: "C:\\files\\books.txt", Program.bookArray);
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Get the selected book from the list box
            Book selectedBook = lstAllTitles.SelectedItem as Book;

            // Find its index in the array
            int index = Array.IndexOf(Program.bookArray, selectedBook);

            // Remove the book from the array
            if (index >= 0)
            {
                Array.Copy(Program.bookArray, index + 1, Program.bookArray, index, Program.bookArray.Length - index - 1);
                Array.Resize(ref Program.bookArray, Program.bookArray.Length - 1);
            }

            // Update the list box
            lstAllTitles.Items.Clear();
            foreach (Book newBook in Program.bookArray)
            {
                lstAllTitles.Items.Add(ToString(newBook));
            }
        }

        private string ToString(Book book) 
        {
            return $"{book.Title} by {book.Author}, {book.Price:C}, Stock: {book.Stock}";
        }
    }
}
