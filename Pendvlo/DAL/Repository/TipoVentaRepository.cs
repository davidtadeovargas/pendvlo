using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class TipoVentaRepository : Repository
    {
        public TipoVentaRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<TipoVenta> getAll()
        {
            List<TipoVenta> list_ = DBContext.TipoVentas.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public TipoVenta getByID(int id)
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == id).FirstOrDefault();
            return TipoVenta;
        }

        /*
         Create mostrador
             */
        public void createMostrador()
        {
            var result = DBContext.TipoVentas.Add(new TipoVenta { Name = "MOSTRADOR" });
            DBContext.SaveChanges();            
        }

        /*
         Create model
             */
        public void createEjecutivoVentas()
        {
            var result = DBContext.TipoVentas.Add(new TipoVenta { Name = "EJECUTIVO DE VENTAS" });
            DBContext.SaveChanges();
        }

        /*
         Create maquilador
             */
        public void createMaquilador()
        {
            var result = DBContext.TipoVentas.Add(new TipoVenta { Name = "MAQUILADOR" });
            DBContext.SaveChanges();
        }

        /*
         Create volumen
             */
        public void createVolumen()
        {
            var result = DBContext.TipoVentas.Add(new TipoVenta { Name = "VOLUMEN" });
            DBContext.SaveChanges();
        }

        /*
         Create internet
             */
        public void createInternet()
        {
            var result = DBContext.Suajes.Add(new Suaje { Name = "INTERNET" });
            DBContext.SaveChanges();
        }

        /*
         Get mostrador
             */
        public TipoVenta getMostrador()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "MOSTRADOR").FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get maquilador
             */
        public TipoVenta getMaquilador()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "MAQUILADOR").FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get volumen
             */
        public TipoVenta getVolumen()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "VOLUMEN").FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get internet
             */
        public TipoVenta getInternet()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "INTERNET").FirstOrDefault();
            return TipoVenta;
        }
    }
}