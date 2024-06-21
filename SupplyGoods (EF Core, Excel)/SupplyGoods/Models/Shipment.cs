using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyGoods.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public virtual Order Order { get; set; } = null!;
    }
}
