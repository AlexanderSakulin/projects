namespace SupplyGoods.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; } = null!;
        public string Print
        {
            get
            {
                return $"{Name} - тел:{Phone}";
            }
        }

    }
}
