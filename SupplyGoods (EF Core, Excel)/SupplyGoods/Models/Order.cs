﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyGoods.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int ProductId { get; set; }
        public int ClientId { get; set; }
        public int Quantity { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<Shipment> Shipments { get; set; } = null!;
        public string Print
        {
            get
            {
                return $"Заказ № {Id} - {Client.Name} - {Product.Name} - {Quantity}шт.";
            }
        }
    }
}
