using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Maintenance
{
    public class Software : Product
    {
        public Software() { }

        public Software(string code, string description, string version, decimal price) : base(code, description, price)
        {
            this.Version = version;
        }

        public string Version { get; set; }

        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + ", Version " + Version;
        }
    }
}
