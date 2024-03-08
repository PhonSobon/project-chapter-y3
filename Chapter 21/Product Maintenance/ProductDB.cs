using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Product_Maintenance
{
    public static class ProductDB
    {
        private const string dir = @"D:\Penh Polydet\Computer Science and Engineering\Year 3 Semester 2\.NET Programming\C# Project Chapter\Chapter 21\Product Maintenance\";
        private const string path = dir + "Products.txt";

        public static List<Product> GetProducts()
        {
            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            StreamReader textIn =
                new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate,
                    FileAccess.Read));

            List<Product> products = new List<Product>();
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Product product = new Product();
                product.Code = columns[0];
                product.Description = columns[1];
                product.Price =
                    Convert.ToDecimal(columns[2]);
                products.Add(product);

            }
            textIn.Close();
            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create,
                    FileAccess.Write));

            foreach (Product product in products)
            {
                textOut.Write(product.Code + "|");
                textOut.Write(product.Description + "|");
                textOut.WriteLine(product.Price);
            }
            textOut.Close();
        }
    }
}
