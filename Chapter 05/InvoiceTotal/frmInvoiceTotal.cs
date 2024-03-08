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
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Access customer type textbox and store in string variable
            string customerType = txtCustomerType.Text;
            // get the subtotal amount from SubTotal Text Box
            decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);

            // set the discountPercent variable based
            // on the value of the subtotal variable
            decimal discountPercent = .0m; // the m indicates a decimal value
            // When user type R or r it will run this if statement
            if (customerType == "R" | customerType == "r")
            {
                // if subtotal is less than 100, so discount percent is 0%
                if (subtotal < 100)
                    discountPercent = .0m;
                // if subtotal is greater than or equal 100 and less than 250, so discount percent is 10%
                else if (subtotal >= 100 && subtotal < 250)
                    discountPercent = .1m;
                // if subtotal is greater than or equal 250 and less than 500, so discount percent is 25%
                else if (subtotal >= 250 && subtotal < 500)
                    discountPercent = .25m;
                // if subtotal is greater than 500, so discount percent is 30%
                else
                    discountPercent = .30m;
            }
            // When user type C or c it will run this else if statement
            else if (customerType == "C" | customerType == "c")
            {
                // When customer type is C, so the discount percent is 20%
                discountPercent = .20m;
            }
            // When user type T or t it will run this else if statement
            else if (customerType == "T" | customerType == "t")
            {
                // if subtotal is less than 500, so discount percent is 40%
                if (subtotal < 500)
                    discountPercent = .40m;
                // if subtotal is greater than or equal 500, so discount percent is 50%
                else if (subtotal >= 500)
                    discountPercent = .50m;
            }
            // When the customer type aren't R, C, T it will run this else statement
            else
                // When the customer type aren't R, C, T, so discount percent is 10%
                discountPercent = .10m;

            // calculate and assign the values for the
            // the discountaAmount and invoiceTotal variables
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            // format the values and display them  in their text boxes
            txtDiscountPercent.Text = discountPercent.ToString("p1"); // percent format with 1 decimal place
            txtDiscountAmount.Text = discountAmount.ToString("c"); // currency format
            txtTotal.Text = invoiceTotal.ToString("c");

            // move the focus cursor to the SubTotal text box
            txtSubTotal.Focus();
        }
    }
}
