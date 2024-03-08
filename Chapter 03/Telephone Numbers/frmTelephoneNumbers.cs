using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Numbers
{
    public partial class frmTelephoneNumbers : Form
    {
        public frmTelephoneNumbers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Method to close the form
        }

        private void btnConvertToNumericOnly_Click(object sender, EventArgs e)
        {
            // Access Alphanumeric Number and store in variable
            string alphanumericNumber = txtAlphaNumericNumber.Text;
            // Store it in Text Property of txtNumericOnly
            txtNumericOnly.Text = alphanumericNumber;
        }
    }
}
