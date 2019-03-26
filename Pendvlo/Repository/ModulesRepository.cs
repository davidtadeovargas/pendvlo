using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class ModulesRepository : Repository
    {
        public ModulesRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all te users
             */
        public List<Module> getModules()
        {
            List<Module> Modules_ = DBContext.Modules.OrderBy(s => s.Name).ToList();
            return Modules_;
        }

        /*
         Get by module id
             */
        public Module getByID(int id)
        {
            Module Module_ = DBContext.Modules.Where(m => m.ID == id).FirstOrDefault();
            return Module_;
        }

        /*
         Create the sales module
             */
        public void createSalesModule()
        {
            new Module { Name = "Ventas"};
        }

        /*
         Create the production module
             */
        public void createProductionModule()
        {            
            var result = DBContext.Modules.Add(new Module { Name = "Produccion" });
            DBContext.SaveChanges();
        }

        /*
         Create the warehouse module
             */
        public void createWareohuseModule()
        {
            var result = DBContext.Modules.Add(new Module { Name = "Almacen" });
            DBContext.SaveChanges();
        }

        /*
         Create the administration module
             */
        public void createAdministrationModule()
        {            
            var result = DBContext.Modules.Add(new Module { Name = "Administracion" });
            DBContext.SaveChanges();
        }

        /*
         Create the design module
             */
        public void createDesignModule()
        {
            var result = DBContext.Modules.Add(new Module { Name = "Diseño" });
            DBContext.SaveChanges();
        }

        /*
         Create the "atencion y servicio al cliente"
             */
        public void createAtenServCustomModule()
        {
            var result = DBContext.Modules.Add(new Module { Name = "Atencion y servicio al cliente" });
            DBContext.SaveChanges();
        }

        /*
         Create the "administracion y compras"
             */
        public void createAdminComprasModule()
        {
            var result = DBContext.Modules.Add(new Module { Name = "Administracion y compras" });
            DBContext.SaveChanges();
        }

        /*
         Get the production module
             */
        public Module getProductionModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.Name == "Produccion").FirstOrDefault();
            return Module_;
        }

        /*
         Get the warehouse module
             */
        public Module getWarehouseModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.Name == "Almacen").FirstOrDefault();
            return Module_;
        }

        /*
         Get the sales module
             */
        public Module getAtencionServCustomerModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.Name == "Atencion y servicio al cliente").FirstOrDefault();
            return Module_;
        }

        /*
         Get the adminsitration module
             */
        public Module getAdministrationModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.Name == "Administracion y compras").FirstOrDefault();
            return Module_;
        }

        /*
         Get the design module
             */
        public Module getDesignModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.Name == "Diseño").FirstOrDefault();
            return Module_;
        }

        /*
         Get module
             */
        public Module getAdminComprasModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.Name == "Administracion y compras").FirstOrDefault();
            return Module_;
        }
    }
}