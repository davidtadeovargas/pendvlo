using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class SucursalesRepository : Repository
    {
        public SucursalesRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<Sucursal> getAll()
        {
            List<Sucursal> list_ = DBContext.Sucursales.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public Sucursal getByID(int id)
        {
            Sucursal Sucursal_ = DBContext.Sucursales.Where(m => m.ID == id).FirstOrDefault();
            return Sucursal_;
        }

        /*
         Create libertad sucursal
             */
        public void createLibertadSucursal()
        {
            var result = DBContext.Sucursales.Add(new Sucursal { Name = "LIBERTAD" });
            DBContext.SaveChanges();            
        }

        /*
         Create  miguel blanco
             */
        public void createMiguelBlanco()
        {
            var result = DBContext.Sucursales.Add(new Sucursal { Name = "MIGUEL BLANCO" });
            DBContext.SaveChanges();
        }

        /*
         Get libertad
             */
        public Sucursal getLibertadSucursal()
        {
            Sucursal Sucursal = DBContext.Sucursales.Where(m => m.Name == "LIBERTAD").FirstOrDefault();
            return Sucursal;
        }

        /*
         Get corte completo
             */
        public Sucursal getMiguelBlancoSucursal()
        {
            Sucursal Sucursal = DBContext.Sucursales.Where(m => m.Name == "MIGUEL BLANCO").FirstOrDefault();
            return Sucursal;
        }        
    }
}