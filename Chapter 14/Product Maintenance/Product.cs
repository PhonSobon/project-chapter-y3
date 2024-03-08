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
        private string code;
        private string description;
        private decimal price;

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
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        // Method
        public virtual string GetDisplayText(string sep)
        {
            return Code + sep + Price.ToString("c") + sep + Description;
        }
    }
}