using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
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
    }
}