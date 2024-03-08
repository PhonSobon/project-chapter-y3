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
            this.Close();
        }

        private void btnProjectStudentPopulation_Click(object sender, EventArgs e)
        {
            decimal numberOfStudentsToday = Convert.ToDecimal(txtNumberOfStudentsToday.Text);
            float annualGrowthRate = (float) Convert.ToDouble(txtAnnualGrowthRate.Text);
            int numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            float projectNumberOfStudents = 0.0f;

            int i = 1;
            while(i <= numberOfYears)
            {
                projectNumberOfStudents = (float)((float) numberOfStudentsToday * Math.Pow(1 + annualGrowthRate, i));
                i++;
            }
            txtNumberOfProjectStudents.Text = projectNumberOfStudents.ToString("N0");
        }
    }
}
