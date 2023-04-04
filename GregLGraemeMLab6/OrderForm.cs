using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Program.bookArray = Program.ImportBooks(filePath: "C:\\files\\books.txt");
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

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutForm checkoutForm = new CheckoutForm(selectedBooks);
            checkoutForm.ShowDialog();
        }

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
        {
            string msgTitle = "Attention";
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
    }
}
