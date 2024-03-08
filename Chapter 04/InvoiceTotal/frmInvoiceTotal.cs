using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // Global Variable
        int numberOfInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAverage = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // get the entersubtotal amount from enterSubTotal Text Box
            decimal enterSubtotal = Convert.ToDecimal(txtEnterSubtotal.Text);

            // set the discountPercent variable based
            // on the value of the subtotal variable
            decimal discountPercent = .25m; // the m indicates a decimal value

            // calculate and assign the values for the
            // the discountaAmount and invoiceTotal variables
            decimal discountAmount = Math.Round(enterSubtotal * discountPercent, 2);
            decimal invoiceTotal = enterSubtotal - discountAmount;

            // format the values and display them in their text boxes
            txtSubTotal.Text = enterSubtotal.ToString("c"); // currency format
            txtDiscountPercent.Text = discountPercent.ToString("p1"); // percent format with 1 decimal place
            txtDiscountAmount.Text = discountAmount.ToString("c"); // currency format
            txtTotal.Text = invoiceTotal.ToString("c"); // currency format

            numberOfInvoices++; // increment number of invoice
            totalOfInvoices += invoiceTotal; // add invoice total to total of invoice
            // calculate invoice average = total of invoice / number of invoice
            invoiceAverage = totalOfInvoices / numberOfInvoices; 

            // format the values and display them in their text boxes
            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceOfAverage.Text = invoiceAverage.ToString("c");

            // move the focus to the Enter SubTotal text box and empty the textbox value
            txtEnterSubtotal.Text = "";
            txtEnterSubtotal.Focus();
        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            // reset value back to 0
            numberOfInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAverage = 0m;

            // empty the textbox value
            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceOfAverage.Text = "";
            // move the focus to Enter Subtotal textbox
            txtEnterSubtotal.Focus();
        }
    }
}
