using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Method to close the form
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // get the subtotal amount from SubTotal Text Box
            decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);

            // set the discountPercent variable based
            // on the value of the subtotal variable
            decimal discountPercent = 0m; // the m indicates a decimal value
            // Business Rule
            // if subtotal greater than or equal to 500, so discount percent equal to 20%
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            // else if subtotal greater than or equal to 250 and less than 500, so discount percent equal to 15%
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            // else if subtotal greater than or equal to 100 and less than 250, so discount percent equal to 10%
            else if (subtotal >= 100 && subtotal < 250)
            {
                discountPercent = .1m;
            }

            // calculate and assign the values for the
            // the discountaAmount and invoiceTotal variables
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            // format the values and display them in their text boxes
            txtDiscountPercent.Text = discountPercent.ToString("p1"); // percent format with 1 decimal place
            txtDiscountAmount.Text = discountAmount.ToString("c"); // currency format
            txtTotal.Text = invoiceTotal.ToString("c"); // currenct format

            // move the focus cursor to the SubTotal text box
            txtSubTotal.Focus();
        }
    }
}
