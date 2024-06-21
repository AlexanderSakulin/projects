using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Number { get; set; } = null!;
        public int ClientId { get; set; }
        public virtual Client Client { get; set; } = null!;
    }
}
