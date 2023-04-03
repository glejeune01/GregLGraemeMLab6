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
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.ShowDialog();
        }
    }
}
