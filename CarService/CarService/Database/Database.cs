using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarService
{
    public class Database : DbContext
    {
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<Document> Documents { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public Database() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;database=carservice_db;",
            new MySqlServerVersion(new Version(8, 0, 31)));
        }
    }
}
