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
using System.Runtime.CompilerServices;
using System.Net.Http.Headers;
using System.Collections;

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
            Program.bookArray = FileHandler.ImportBooks(filePath: "C:\\files\\books.txt");
            lstAllTitles.Items.Clear();
            // Iterate through the bookArray and add each book to the appropriate listbox
            foreach (Book book in Program.bookArray)
            { 
                lstAllTitles.Items.Add(ToBook(book));
            }
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            lstAllTitles.SelectedIndexChanged -= lstAllTitles_SelectedIndexChanged;

            int code = Validation.IsInteger(txtCodeEntry.Text);
            bool bookFinder = Program.bookArray.Any(book => book.Code == code);
            bool allInfo = AreAllFieldsFilledOut();

            if (!allInfo)
            {
                MessageBox.Show("Please enter all information before proceeding", "Warning - Missing Info");
                return;
            }

            if (bookFinder)
            {
                DialogResult result = MessageBox.Show($"A book with code {code} already exists. Would you like to edit the existing book?", "Duplicate Code", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int matchBookIndex = Array.FindIndex(Program.bookArray, book => book.Code == code);
                    Book matchBook = Program.bookArray[matchBookIndex];

                    switch (matchBook)
                    {
                        case ComicBook comicBook:
                            comicBook.Code = code;
                            comicBook.Title = txtTitleEntry.Text;
                            comicBook.Author = txtAuthorEntry.Text;
                            comicBook.Price = Validation.IsDecimal(txtPriceEntry.Text);
                            comicBook.Stock = Validation.IsInteger(txtStockEntry.Text);
                            comicBook.Edition = txtEditionEntry.Text;
                            lstAllTitles.Items[matchBookIndex] = (comicBook);
                            break;
                        case Fiction fictionBook:
                            fictionBook.Code = code;
                            fictionBook.Title = txtTitleEntry.Text;
                            fictionBook.Author = txtAuthorEntry.Text;
                            fictionBook.Price = Validation.IsDecimal(txtPriceEntry.Text);
                            fictionBook.Stock = Validation.IsInteger(txtStockEntry.Text);
                            lstAllTitles.Items[matchBookIndex] = (fictionBook);
                            break;
                        case NonFiction nonFictionBook:
                            nonFictionBook.Code = code;
                            nonFictionBook.Title = txtTitleEntry.Text;
                            nonFictionBook.Author = txtAuthorEntry.Text;
                            nonFictionBook.Price = Validation.IsDecimal(txtPriceEntry.Text);
                            nonFictionBook.Stock = Validation.IsInteger(txtStockEntry.Text);
                            lstAllTitles.Items[matchBookIndex] = (nonFictionBook);
                            break;
                    }
                    MessageBox.Show($"The book with code {code} has been updated.", "Book Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstAllTitles.Items.Clear();

                    foreach (Book book in Program.bookArray)
                    {
                        lstAllTitles.Items.Add(ToBook(book));
                    }
                }
            }
            else
            {
                Book newBook = CreateNewBook();
                Array.Resize(ref Program.bookArray, Program.bookArray.Length + 1);
                Program.bookArray[Program.bookArray.Length - 1] = newBook;

                lstAllTitles.Items.Clear();

                foreach (Book book in Program.bookArray)
                {
                    lstAllTitles.Items.Add(ToBook(book));
                }
            }

            lstAllTitles.SelectedIndexChanged += lstAllTitles_SelectedIndexChanged;
        }


        private Book CreateNewBook()
        {
            Book newBook = null;

            int code = Validation.IsInteger(txtCodeEntry.Text);
            string title = txtTitleEntry.Text;
            string author = txtAuthorEntry.Text;
            decimal price = Validation.IsDecimal(txtPriceEntry.Text);
            int stock = Validation.IsInteger(txtStockEntry.Text);

            switch (cboBookTypeSelector.Text)
            {
                case "ComicBook":
                    string edition = txtEditionEntry.Text;
                    newBook = new ComicBook
                    {
                        Code = code,
                        Title = title,
                        Author = author,
                        Genre = "ComicBook",
                        Price = price,
                        Edition = edition,
                        Stock = stock
                    };
                    break;

                case "Fiction":
                    newBook = new Fiction
                    {
                        Code = code,
                        Title = title,
                        Author = author,
                        Genre = "Fiction",
                        Price = price,
                        Stock = stock
                    };
                    break;

                case "NonFiction":
                    newBook = new NonFiction
                    {
                        Code = code,
                        Title = title,
                        Author = author,
                        Genre = "NonFiction",
                        Price = price,
                        Stock = stock
                    };
                    break;
            }

            return newBook;
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
                string successMsg = "The Peoples Library has been updated. Would you like to make another change?";
                DialogResult dialogResult = MessageBox.Show(successMsg, successTitle, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    // exit the application
                    Application.Exit();
                }

                FileHandler.ExportBooks(filePath: "C:\\files\\books.txt", Program.bookArray);
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
            int index = lstAllTitles.SelectedIndex;
            Book selectedBook = Program.bookArray[index];

            // Show a message box to confirm deletion
            string title2 = "Attention!";
            string msg2 = "Are you sure you would like to remove this item?";
            DialogResult result = MessageBox.Show(msg2, title2, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms deletion, remove the book from the array and the list box
            if (result == DialogResult.Yes)
            {
                if (index >= 0)
                {
                    // Remove the book from the list box
                    lstAllTitles.Items.Remove(selectedBook);

                    // Remove the book from the array
                    Array.Copy(Program.bookArray, index + 1, Program.bookArray, index, Program.bookArray.Length - index - 1);
                    Array.Resize(ref Program.bookArray, Program.bookArray.Length - 1);

                    // Update the list box
                    lstAllTitles.Items.Clear();
                    foreach (Book newBook in Program.bookArray)
                    {
                        lstAllTitles.Items.Add(ToBook(newBook));
                    }
                }
            }

        }

        private void lstAllTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAllTitles.SelectedItems.Count == 1)
            {
                txtEditionEntry.Enabled = true;
                txtEditionEntry.BackColor = Color.White;
                int index = lstAllTitles.SelectedIndex;
                Book selectedBook = Program.bookArray[index];
                cboBookTypeSelector.Text = selectedBook.Genre;
                txtCodeEntry.Text = selectedBook.Code.ToString();
                txtTitleEntry.Text = selectedBook.Title;
                txtAuthorEntry.Text = selectedBook.Author;
                txtPriceEntry.Text = selectedBook.Price.ToString();
                txtStockEntry.Text = selectedBook.Stock.ToString();
                if (selectedBook is ComicBook)
                {
                    txtEditionEntry.Text = (selectedBook as ComicBook).Edition;
                }
                else
                {
                    txtEditionEntry.Enabled = false;
                    txtEditionEntry.BackColor = Color.Gray;

                }
            }
        }
        private string ToBook(Book book)
        {
            string formattedBook = $"{book.Title} by {book.Author}";
            formattedBook = formattedBook.PadRight(60);
            formattedBook += $"{book.Price:C}";
            formattedBook = formattedBook.PadRight(70);
            formattedBook += $"Stock: { book.Stock,1}";
            



            return formattedBook;
        }

        private bool AreAllFieldsFilledOut()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    if (control.Name == txtEditionEntry.Name && cboBookTypeSelector.Text != "Comic Book")
                    {
                        return true;
                    }
                    MessageBox.Show(control.Name);
                    return false;
                }
                else if (control is ComboBox comboBox && string.IsNullOrEmpty(comboBox.Text))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
