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
            this.Close();
        }

        private void btnCalculateLetterGrade_Click(object sender, EventArgs e)
        {
            // Access Numeric Grade textbox and convert it to decimal store in variable
            decimal numericGrade = Convert.ToDecimal(txtNumericGrade.Text);
            // if numeric grade greater than or equal to 90 and less than or equal to 100, so it will display A in label Letter Grade
            if (numericGrade >= 90 && numericGrade <= 100)
            {
                lblLetterGrade.Text = "A";
            }
            // else if numeric grade greater than or equal to 80 and less than or equal to 89, so it will display B in label Letter Grade
            else if (numericGrade >= 80 && numericGrade <= 89)
            {
                lblLetterGrade.Text = "B";
            }
            // else if numeric grade greater than or equal to 70 and less than or equal to 79, so it will display C in label Letter Grade
            else if (numericGrade >= 70 && numericGrade <= 79)
            {
                lblLetterGrade.Text = "C";
            }
            // else if numeric grade greater than or equal to 60 and less than or equal to 69, so it will display D in label Letter Grade
            else if (numericGrade >= 60 && numericGrade <= 69)
            {
                lblLetterGrade.Text = "D";
            }
            // if numeric grade is less than 60, so it will display F in label Letter Grade 
            else
            {
                lblLetterGrade.Text = "F";
            }
        }
    }
}
