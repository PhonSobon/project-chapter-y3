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
            this.Close();
        }

        private void btnCalculateGrandTotal_Click(object sender, EventArgs e)
        {
            // Access order total textbox convert to float and store in variable
            float orderTotal = float.Parse(txtOrderTotal.Text);
            // Access customer type textbox
            string customerType = txtCustomerType.Text;
            // Create shippingCost, grandTotal variable and saleTax = 7%
            float shippingCost = 0.0f, saleTax = 0.07f; 
            // When user choose N=non-Preferred
            if(customerType == "N" || customerType == "n")
            {
                // if order total is greater than 0 and less than or equal to 25, so the shipping cost is 5$
                if (orderTotal > 0 && orderTotal <= 25)
                    shippingCost = 5;
                // if order total is greater than 25.01 and less than or equal to 500, so the shipping cost is 8$
                else if (orderTotal > 25.01 && orderTotal <= 500) 
                    shippingCost = 8;
                // if order total is greater than 500.01 and less than or equal to 1000, so the shipping cost is 10$
                else if (orderTotal > 500.01 && orderTotal <= 1000)
                    shippingCost = 10;
                // if order total is greater than 1000.01 and less than or equal to 5000, so the shipping cost is 15$
                else if (orderTotal > 1000.01 && orderTotal <= 5000)
                    shippingCost = 15;
                // if order total is greater than 5000, so the shipping cost is 20$
                else
                    shippingCost = 20;
            }
            // When user choose beside N is P=Preferred, so the shipping cost is free
            else if(customerType == "P" || customerType == "p")
            {
                shippingCost = 0;
            }
            // Sale Tax = 7% of Order Total + shipping cost : saleTax = saleTax * (ordertotal + shippingCost)
            saleTax *= (orderTotal + shippingCost);
            // Calculate Grand Total = Sale Tax + Order Total + ShippingCost
            float grandTotal = saleTax + orderTotal + shippingCost;
            // format the values and display them in their textboxes
            txtShippingCosts.Text = shippingCost.ToString("c"); // Currency format
            txtSalesTax.Text = saleTax.ToString("c"); // Currency format
            txtGrandTotal.Text = grandTotal.ToString("c"); // Currency format
        }
    }
}
