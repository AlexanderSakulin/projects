using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Document
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int WorkerId { get; set; }
        public string Info { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public virtual Car Car { get; set; } = null!;
        public virtual Worker Worker { get; set; } = null!;
    }
}
