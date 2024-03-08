using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Customer_Maintenance
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "") 
            {
                MessageBox.Show(textBox.Tag + " is a required field. ", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch(FormatException)
            {
                MessageBox.Show(textBox.Tag + " must be a decimal number.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if(Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsPresent(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                MessageBox.Show(comboBox.Tag + " must be select.", Title);
                comboBox.Focus();
                return false;
            } 
        }
    }
}