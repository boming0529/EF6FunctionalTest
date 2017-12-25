namespace EF7TEST.Migrations.Store
{
    using EF7TEST.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<EF7TEST.Models.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Store";
        }

        protected override void Seed(EF7TEST.Models.StoreContext context)
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Carson1", Email = "Carson1@gmail.com", RegisterOn = DateTime.Parse("2017-09-01")},
                new Customer { Name = "Carson1", Email = "Carson1@gmail.com", RegisterOn = DateTime.Parse("2017-09-01")},
                new Customer { Name = "Carson1", Email = "Carson1@gmail.com", RegisterOn = DateTime.Parse("2017-09-01")},
                new Customer { Name = "Carson1", Email = "Carson1@gmail.com", RegisterOn = DateTime.Parse("2017-09-01")},
            };
            context.Customers.AddRange(customers); //customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product { ProductId = 1050, Name = "Chemistry", Price = 3,},
                new Product { ProductId = 4022, Name = "Microeconomics", Price = 2,},
                new Product { ProductId = 3141, Name = "Calculus", Price = 5,},
                new Product { ProductId = 2021, Name = "Trigonometry", Price = 4,},
                new Product { ProductId = 2024, Name = "Composition", Price = 1,},
            };
            context.Products.AddRange(products);
            context.SaveChanges();

            var order = new List<Order>
            {
                new Order { CustomerId = 1 , ProductId = 1050, Memo = "Memo11", },
                new Order { CustomerId = 1 , ProductId = 4022, Memo = "Memo12", },
                new Order { CustomerId = 1 , ProductId = 3141, Memo = "Memo13", },
                new Order { CustomerId = 2 , ProductId = 3141, Memo = "Memo14", },
                new Order { CustomerId = 2 , ProductId = 2021, Memo = "Memo15", },
                new Order { CustomerId = 2 , ProductId = 2024, Memo = "Memo16", },
                new Order { CustomerId = 3 , ProductId = 1050, },
                new Order { CustomerId = 4 , ProductId = 1050, },
                new Order { CustomerId = 4 , ProductId = 4022, Memo = "Memo17", },
            };
            context.Orders.AddRange(order);
            context.SaveChanges();
        }
    }
}
