using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("pendvlo")
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}