using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Maintenance
{
    public class Product
    {
        // Field
        public string Code;
        public string Description;
        public decimal Price;

        // Default Constructor
        public Product() {}

        // Constructor with parameter
        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        // Method
        public string GetDisplayText(string sep)
        {
            return Code + sep + Price.ToString("c") + sep + Description;
        }
    }
}