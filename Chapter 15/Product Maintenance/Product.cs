using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Maintenance
{
    public class Product : IDisplayable, ICloneable
    {
        // Field
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


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
        public virtual string GetDisplayText(string sep)
        {
            return Code + sep + Price.ToString("c") + sep + Description;
        }

        public object Clone()
        {
            Product p = new Product();
            p.Code = this.Code;
            p.Description = this.Description;
            p.Price = this.Price;
            return p;
        }
    }
}