using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Maintenance
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProductMaintenance());
            //Product p1 = new Product("JAV5", "Murach's Beginning Java 2, SDK 5", 52.50m);
            //Product p2 = (Product)p1.Clone();
            //p2.Code = "JSE6";
            //p2.Description = "Murach's Java SE 6";
            //MessageBox.Show(p1.GetDisplayText("\n") + "\n", "Product P1");
            //MessageBox.Show(p2.GetDisplayText("\n") + "\n", "Product P2");
        }
    }
}
