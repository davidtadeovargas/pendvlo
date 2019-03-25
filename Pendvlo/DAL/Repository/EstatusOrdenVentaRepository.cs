using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class EstatusOrdenVentaRepository : Repository
    {
        public EstatusOrdenVentaRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<EstatusOrdenVenta> getAll()
        {
            List<EstatusOrdenVenta> list_ = DBContext.EstatusOrdenVenta.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public EstatusOrdenVenta getByID(int id)
        {
            EstatusOrdenVenta EstatusOrdenVenta = DBContext.EstatusOrdenVenta.Where(m => m.ID == id).FirstOrDefault();
            return EstatusOrdenVenta;
        }

        /*
         Create model
             */
        public void createPendiente()
        {
            var result = DBContext.EstatusOrdenVenta.Add(new EstatusOrdenVenta { Name = "PENDIENTE" });
            DBContext.SaveChanges();            
        }

        /*
         Create model
             */
        public void createCompletada()
        {
            var result = DBContext.EstatusOrdenVenta.Add(new EstatusOrdenVenta { Name = "COMPLETADA" });
            DBContext.SaveChanges();
        }

        /*
         Get model
             */
        public EstatusOrdenVenta getPendiente()
        {
            EstatusOrdenVenta EstatusOrdenVenta = DBContext.EstatusOrdenVenta.Where(m => m.Name == "PENDIENTE").FirstOrDefault();
            return EstatusOrdenVenta;
        }

        /*
         Get model
             */
        public EstatusOrdenVenta getCompletada()
        {
            EstatusOrdenVenta EstatusOrdenVenta = DBContext.EstatusOrdenVenta.Where(m => m.Name == "COMPLETADA").FirstOrDefault();
            return EstatusOrdenVenta;
        }        
    }
}