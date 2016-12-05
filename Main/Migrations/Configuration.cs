namespace Main.Migrations
{
    using OneOne;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Main.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Main.DatabaseContext context)
        {
            var produkt = new Product { Name = "Chleb" };
            context.Products.AddOrUpdate(prod => prod.Name,new Product { Name = "Sok" });
            context.Products.AddOrUpdate(prod => prod.Name,new Product { Name = "Vódka" });
            context.Products.AddOrUpdate(produkt);
            context.Customers.AddOrUpdate(customer => customer.Name,new Customer { Name = "Wiesiek" ,Product = produkt });
        }
    }
}
