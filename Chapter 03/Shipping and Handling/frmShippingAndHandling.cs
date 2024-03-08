using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipping_and_Handling
{
    public partial class frmShippingAndHandling : Form
    {
        public frmShippingAndHandling()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Method to close the form
        }

        private void btnCalculateGrandTotal_Click(object sender, EventArgs e)
        {
            // Access Order Total and convet to decimal and store in variable
            decimal orderTotal = Convert.ToDecimal(txtOrderTotal.Text);
            // Add 10 to the variable
            orderTotal += 10;
            // Convert it to string and store it in Text Property of txtGrandTotal
            txtGrandTotal.Text = orderTotal.ToString("c");
        }
    }
}
