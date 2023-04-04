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
            // Show confirmation message box
            string confirmTitle = "Confirmation Required!";
            string confirmMsg = "Are you sure you would like to make this change?";
            DialogResult result = MessageBox.Show(confirmMsg, confirmTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If statement for result of save button answer
            if (result == DialogResult.Yes)
            {
                // Update the books text file
                string successTitle = "Success!";
                string successMsg = "The Peoples Library has been updated.";
                MessageBox.Show(successMsg, successTitle);
                Program.ExportBooks(filePath: "C:\\files\\books.txt", Program.bookArray);
            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if the user has selected an item in the list box
            if (lstAllTitles.SelectedItem == null)
            {
                string title = "Error!";
                string msg = "Please select an item from the list and try again.";
                MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // exit the method without doing anything else
            }

            // Get the selected book from the list box
            Book selectedBook = lstAllTitles.SelectedItem as Book;

            // Find its index in the array
            int index = Array.IndexOf(Program.bookArray, selectedBook);

            // Show a message box to confirm deletion
            string title2 = "Attention!";
            string msg2 = "Are you sure you would like to remove this item?";
            DialogResult result = MessageBox.Show(msg2, title2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms deletion, remove the book from the array and the list box
            if (result == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    // Remove the book from the array
                    Array.Copy(Program.bookArray, index + 1, Program.bookArray, index, Program.bookArray.Length - index - 1);
                    Array.Resize(ref Program.bookArray, Program.bookArray.Length - 1);

                    // Remove the book from the list box
                    lstAllTitles.Items.Remove(selectedBook);

                    // Update the list box
                    lstAllTitles.Items.Clear();
                    foreach (Book newBook in Program.bookArray)
                    {
                        lstAllTitles.Items.Add(ToString(newBook));
                    }
                }
            }
        }


        private string ToString(Book book) 
        {
            return $"{book.Title} by {book.Author}, {book.Price:C}, Stock: {book.Stock}";
        }
    }
}
