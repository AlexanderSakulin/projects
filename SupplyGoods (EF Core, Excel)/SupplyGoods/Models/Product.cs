using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyGoods.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = null!;
        public string Print 
        { 
            get 
            {
                return $"{Name} - {Price: 0 руб. 00 коп}";
            } 
        }
    }
}
