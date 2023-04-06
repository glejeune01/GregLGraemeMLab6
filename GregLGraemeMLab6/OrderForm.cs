using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GregLGraemeMLab6
{
    public partial class OrderForm : Form
    {
        public List<Book> selectedBooks = new List<Book>();
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.bookArray = new Book[0];
            Program.bookArray = FileHandler.ImportBooks(filePath: "C:\\files\\books.txt");
            lstFiction.Items.Clear();
            lstComicBooks.Items.Clear();
            lstNonFiction.Items.Clear();
            {
                // Iterate through the bookArray and add each book to the appropriate listbox
                foreach (Book book in Program.bookArray)
                {
                    if (book is Fiction)
                    {
                        lstFiction.Items.Add(book);
                    }
                    else if (book is NonFiction)
                    {
                        lstNonFiction.Items.Add(book);
                    }
                    else if (book is ComicBook)
                    {
                        lstComicBooks.Items.Add(book);
                    }
                }
            }
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            //opens checkout form passing in the selected books
            this.Hide();
            CheckoutForm checkoutForm = new CheckoutForm(selectedBooks);
            checkoutForm.ShowDialog();
        }
        //filters the lstbox according to what lstbox text changed
        private void TxtNonFictionSearch_TextChanged(object sender, EventArgs e)
        {
            FilterListbox(lstNonFiction, txtNonFictionSearch.Text, typeof(NonFiction));
        }

        private void TxtFictionSearch_TextChanged(object sender, EventArgs e)
        {
            FilterListbox(lstFiction, txtFictionSearch.Text, typeof(Fiction));
        }

        private void TxtComicSearch_TextChanged(object sender, EventArgs e)
        {
            FilterListbox(lstComicBooks, txtComicSearch.Text, typeof(ComicBook));
        }

        private void FilterListbox(ListBox listBox, string searchText, Type bookType)
        {
            //implements the filter for the listbox searches.
            listBox.Items.Clear();

            IEnumerable<Book> booksOfType = Program.bookArray.Where(b => b.GetType() == bookType);

            foreach (Book book in booksOfType)
            {
                if (book.Title.ToLower().Contains(searchText.ToLower()))
                {
                    listBox.Items.Add(book);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {//adds a book to the selectedbook array for later usage
            string msgTitle = "Attention!";
            string success = "Success!";
            Book selectedBook = lstFiction.SelectedItem as Book
                ?? lstNonFiction.SelectedItem as Book
                ?? lstComicBooks.SelectedItem as Book;

            if (selectedBook != null)
            {
                selectedBooks.Add(selectedBook);
                MessageBox.Show($"{selectedBook.Title} has been added to your cart!", success);
            }
            else
            {
                MessageBox.Show("Please select a book to add to your cart.", msgTitle);
            }
        }
        //when selected index is changed in one list box, deselects all the others.
        private void lstNonFiction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNonFiction.SelectedIndex != -1)
            {
                lstFiction.ClearSelected();
                lstComicBooks.ClearSelected();
            }
        }

        private void lstFiction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFiction.SelectedIndex != -1)
            {
                lstComicBooks.ClearSelected();
                lstNonFiction.ClearSelected();
            }
        }

        private void lstComicBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstComicBooks.SelectedIndex != -1)
            {
                lstFiction.ClearSelected();
                lstNonFiction.ClearSelected();
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes application when needed
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    e.Cancel = false;
                    Application.Exit();
                }
            }
        }
    }
}
