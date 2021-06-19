using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorguNet.Entities
{
    public class SorguNetDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BankKredi> BankKredis { get; set; }
        public DbSet<Icra> Icras { get; set; }

    }
}
