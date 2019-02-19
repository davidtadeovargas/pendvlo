namespace Pendvlo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Pendvlo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Pendvlo.DAL.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Pendvlo.DAL.DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(x => x.ID,
                new User() { ID = 1, Name = "admin", User_ = "admin", Password = "123456789", Sales = 1 }
                );

            /*
                Modules
             */
            context.Modules.AddOrUpdate(x => x.ID,
                new Module { ID = 0, Name = "Produccion" }
                );
            context.Modules.AddOrUpdate(x => x.ID,
                new Module { ID = 1, Name = "Almacen" }
                );
            context.Modules.AddOrUpdate(x => x.ID,
                new Module { ID = 2, Name = "Ventas" }
                );
            context.Modules.AddOrUpdate(x => x.ID,
                new Module { ID = 3, Name = "Administracion" }
                );
        }
    }
}
