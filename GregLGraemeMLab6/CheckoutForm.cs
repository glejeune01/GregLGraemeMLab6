﻿using System;
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
    public partial class CheckoutForm : Form
    {
        public List<Book> selectedBooks;

        public CheckoutForm(List<Book> selectedBooks)
        {
            InitializeComponent();
            lstCheckout.SelectionMode = SelectionMode.One;
            this.selectedBooks = selectedBooks;
            foreach (Book book in selectedBooks)
            {
                lstCheckout.Items.Add(book.ToString());
            }
            Calculations();
        }

        private void Calculations()
        {
            decimal price = 0;
            decimal taxes,shippingCost,grandTotal;
            int items = 0;

            foreach (Book book in selectedBooks) 
            { 
                price+=book.Price;
                items++;
            }
            taxes = price * 0.15m;
            shippingCost = items * 5;
            grandTotal = taxes + shippingCost + price;

            lblItemPricesTotals.Text = price.ToString("C");
            lblTaxesTotals.Text = taxes.ToString("C");  
            lblShippingTotals.Text = shippingCost.ToString("C");
            lblGrandTotals.Text = grandTotal.ToString("C");
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            
            if (lstCheckout.SelectedIndex >= 0)
            {
                string msgTitle = "Attention";
                string msgText = "Are you sure you want to remove this item?";

                // Display a confirmation message box with "Yes" and "No" buttons.
                DialogResult result = MessageBox.Show(msgText, msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // If the user clicked "Yes", remove the selected item from the list.
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = lstCheckout.SelectedIndex;
                    Book selectedBook = selectedBooks[selectedIndex];
                    selectedBooks.Remove(selectedBook);
                    lstCheckout.Items.RemoveAt(selectedIndex);
                    Calculations();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string msgTitle = "Attention";
            string msgText = "Would you like to complete your order?";

            // Display a confirmation message box with "Yes" and "No" buttons.
            DialogResult result = MessageBox.Show(msgText, msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicked "Yes", remove the selected item from the list.
            if (result == DialogResult.Yes)
            {
                
                foreach (Book book in selectedBooks)
                {
                    // reduce the quantity of the book by 1
                    book.Stock -= 1;
                }

                MessageBox.Show("Thank you for completing your order", "Order Completed");

                // save the updated book list
                FileHandler.ExportBooks(filePath: "C:\\files\\books.txt", Program.bookArray);
                this.Close();
                OrderForm orderForm = new OrderForm();
                orderForm.ShowDialog();
            }
        }
    }
}
