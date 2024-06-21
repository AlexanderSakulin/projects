using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CardNo { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(CardNo);
            }
        }
    }
}
