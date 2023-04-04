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
    public partial class CheckoutForm : Form
    {
        public List<Book> selectedBooks;

        public CheckoutForm(List<Book> selectedBooks)
        {
            InitializeComponent();
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
    }
}
