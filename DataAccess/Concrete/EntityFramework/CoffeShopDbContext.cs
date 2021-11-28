using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class CoffeShopDbContext:DbContext
    {
       

        public CoffeShopDbContext(DbContextOptions<CoffeShopDbContext> options) : base(options)
        {
        }
        

        public DbSet<Customer> Customers { get; set; }
      


    }
}
