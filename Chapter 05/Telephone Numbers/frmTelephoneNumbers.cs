namespace Telephone_Numbers
{
    public partial class frmTelephoneNumbers : Form
    {
        public frmTelephoneNumbers()
        {
            InitializeComponent();
        }


        private void btnConverttoNumericOnly_Click(object sender, EventArgs e)
        {
            string alphanumerNum = Convert.ToString(txtAphanumericNumber.Text);
            string convertedNumber = "";
            foreach (char c in alphanumerNum)
            {
                if (char.IsLetter(c))
                {
                    switch (char.ToLower(c))
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            convertedNumber += "2";
                            break;
                        case 'd':
                        case 'e':
                        case 'f':
                            convertedNumber += "3";
                            break;
                        case 'g':
                        case 'h':
                        case 'i':
                            convertedNumber += "4";
                            break;
                        case 'j':
                        case 'k':
                        case 'l':
                            convertedNumber += "5";
                            break;
                        case 'm':
                        case 'n':
                        case 'o':
                            convertedNumber += "6";
                            break;
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                            convertedNumber += "7";
                            break;
                        case 't':
                        case 'u':
                        case 'v':
                            convertedNumber += "8";
                            break;
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            convertedNumber += "9";
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    convertedNumber += c;
                }
            }
            txtNumericOnly.Text = convertedNumber.ToString();
            txtNumericOnly.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}