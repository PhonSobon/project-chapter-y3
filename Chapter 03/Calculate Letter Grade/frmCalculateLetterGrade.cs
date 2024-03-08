using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Letter_Grade
{
    public partial class frmCalculateLetterGrade : Form
    {
        public frmCalculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Method to close the form
        }

        private void btnCalculateLetterGrade_Click(object sender, EventArgs e)
        {
            // Access Numeric Grade and convert to decimal and store in variable
            decimal numericGrade = Convert.ToDecimal(txtNumericGrade.Text);
            // Add 10 to the variable
            numericGrade += 10;
            // Convert it to string and store it in Text property of lblLetterGrade
            lblLetterGrade.Text = numericGrade.ToString();
        }
    }
}
