using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class ModulesRepository : Repository
    {
        /*
         Contains the first ids
             */
        private int productionID = 0;
        private int warehouseID = 1;
        private int salesID = 2;
        private int administrationID = 3;
        private int designID = 4;




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
            new Module { ID = salesID, Name = "Ventas"};
        }

        /*
         Create the production module
             */
        public void createProductionModule()
        {            
            var result = DBContext.Modules.Add(new Module { ID = productionID, Name = "Produccion" });
            DBContext.SaveChanges();
        }

        /*
         Create the warehouse module
             */
        public void createWareohuseModule()
        {
            var result = DBContext.Modules.Add(new Module { ID = warehouseID, Name = "Almacen" });
            DBContext.SaveChanges();
        }

        /*
         Create the administration module
             */
        public void createAdministrationModule()
        {            
            var result = DBContext.Modules.Add(new Module { ID = administrationID, Name = "Administracion" });
            DBContext.SaveChanges();
        }

        /*
         Create the design module
             */
        public void createDesignModule()
        {
            var result = DBContext.Modules.Add(new Module { ID = designID, Name = "Diseño" });
            DBContext.SaveChanges();
        }

        /*
         Get the production module
             */
        public Module getProductionModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.ID == productionID).FirstOrDefault();
            return Module_;
        }

        /*
         Get the warehouse module
             */
        public Module getWarehouseModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.ID == warehouseID).FirstOrDefault();
            return Module_;
        }

        /*
         Get the sales module
             */
        public Module getSalesModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.ID == salesID).FirstOrDefault();
            return Module_;
        }

        /*
         Get the adminsitration module
             */
        public Module getAdministrationModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.ID == administrationID).FirstOrDefault();
            return Module_;
        }

        /*
         Get the design module
             */
        public Module getDesignModule()
        {
            Module Module_ = DBContext.Modules.Where(m => m.ID == designID).FirstOrDefault();
            return Module_;
        }
    }
}