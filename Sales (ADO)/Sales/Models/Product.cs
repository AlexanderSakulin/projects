using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string VendorCode { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public int IdManufacturer { get; set; }
        public int IdCategory { get; set; }
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name) &&
                    !string.IsNullOrWhiteSpace(VendorCode) &&
                    !string.IsNullOrWhiteSpace(Price);
            }
        }
    }
}
