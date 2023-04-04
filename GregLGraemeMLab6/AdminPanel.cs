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
            // Read the contents of the books.txt file
            string[] lines = File.ReadAllLines(@"C:\files\books.txt");

            // Add each book to the lstAllTitles list box
            foreach (string line in lines)
            {
                string[] fields = line.Split('|');
                string bookInfo = string.Join(", ", fields);
                lstAllTitles.Items.Add(bookInfo);
            }
        }

        private void BtnAddEdit_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            string code = txtCodeEntry.Text;
            string title = txtTitleEntry.Text;
            string author = txtAuthorEntry.Text;
            string genre = txtGenreEntry.Text;
            string price = txtPriceEntry.Text;
            string edition = txtEditionEntry.Text;
            string stock = txtStockEntry.Text;

            // Combine values into one string separated by commas
            string newItem = string.Format("{0},{1},{2},{3},{4},{5},{6}", code, title, author, genre, price, edition, stock);

            // Add new item to ListBox
            lstAllTitles.Items.Add(newItem);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string msgTitle = "Success!";
            string msgText = "The Peoples Library has been updated";
            MessageBox.Show(msgText, msgTitle);
            // Open the file for writing
            using (StreamWriter writer = new StreamWriter("C:\\files\\books.txt", true))
            {
                // Get the book information from the text boxes
                string code = txtCodeEntry.Text;
                string title = txtTitleEntry.Text;
                string author = txtAuthorEntry.Text;
                string genre = txtGenreEntry.Text;
                string price = txtPriceEntry.Text;
                string edition = txtEditionEntry.Text;
                string stock = txtStockEntry.Text;

                // Write the book information to the file
                writer.WriteLine($"{code}|{title}|{author}|{genre}|{price}|{edition}|{stock}");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstAllTitles.SelectedIndex != -1) // check if an item is selected
            {
                string selectedBook = lstAllTitles.SelectedItem.ToString();

                // Show message box to confirm removal
                string msgTitle = "Attention!";
                string msgText = "Are you sure you want to remove this item(s)?";
                DialogResult result = MessageBox.Show(msgText, msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lstAllTitles.Items.Remove(selectedBook); // remove from list box

                    // remove from books.txt file
                    string[] lines = File.ReadAllLines(@"C:\files\books.txt");
                    List<string> updatedLines = new List<string>();
                    foreach (string line in lines)
                    {
                        if (!line.Contains(selectedBook)) // skip the line with the selected book
                        {
                            updatedLines.Add(line);
                        }
                    }

                    // Overwrite the file with the updated content
                    File.WriteAllLines(@"C:\files\books.txt", updatedLines);
                }
            }
        }
    }
}
