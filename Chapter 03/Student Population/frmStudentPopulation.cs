using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Population
{
    public partial class frmStudentPopulation : Form
    {
        public frmStudentPopulation()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Method to close the form
        }

        private void btnProjectStudentPopulation_Click(object sender, EventArgs e)
        {
            // Access Number of students today and convert to deicmal and store in variable
            decimal numberOfStudentsToday = Convert.ToDecimal(txtNumberOfStudentsToday.Text);
            // Double the number by multiply by 2
            numberOfStudentsToday *= 2;
            // Convert it to string and store it in Text Property of txtNumberOfProjectStudents
            txtNumberOfProjectStudents.Text = numberOfStudentsToday.ToString();
        }
    }
}
