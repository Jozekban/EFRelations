using Main.ManyMany;
using Main.OneMany;
using Main.OneOne;
using System.Data.Entity;

namespace Main
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Item> Item { get; set; }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
    }
}
