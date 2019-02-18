using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL
{
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Users.AddOrUpdate(x => x.ID,
                new User { Name = "admin", User_ = "admin", Password = "123456789", Sales = 1 }
                );

            /*var customers = new List<Customer>
            {
            //new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                //new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var users = new List<User>
            {
                new User{Name="admin",User_="admin",Password="123456789",Sales=1}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var modules = new List<Module>
            {
                //new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            };
            modules.ForEach(s => context.Modules.Add(s));
            context.SaveChanges();*/
        }
    }
}