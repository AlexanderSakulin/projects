using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name);
            }
        }
    }
}
