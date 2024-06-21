using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Position
    {
        public int Id { get; set; }
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
