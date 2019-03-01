using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class TipoVentaRepository : Repository
    {
        /*
         Contains the first ids
             */
        private int mostradorID = 0;
        private int maquiladorID = 1;
        private int volumenID = 2;
        private int internetID = 3;




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
            var result = DBContext.TipoVentas.Add(new TipoVenta { ID = mostradorID, Name = "MOSTRADOR" });
            DBContext.SaveChanges();            
        }

        /*
         Create maquilador
             */
        public void createMaquilador()
        {
            var result = DBContext.TipoVentas.Add(new TipoVenta { ID = maquiladorID, Name = "MAQUILADOR" });
            DBContext.SaveChanges();
        }

        /*
         Create volumen
             */
        public void createVolumen()
        {
            var result = DBContext.TipoVentas.Add(new TipoVenta { ID = volumenID, Name = "VOLUMEN" });
            DBContext.SaveChanges();
        }

        /*
         Create internet
             */
        public void createInternet()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = internetID, Name = "INTERNET" });
            DBContext.SaveChanges();
        }

        /*
         Get mostrador
             */
        public TipoVenta getMostrador()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == mostradorID).FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get maquilador
             */
        public TipoVenta getMaquilador()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == maquiladorID).FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get volumen
             */
        public TipoVenta getVolumen()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == volumenID).FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get internet
             */
        public TipoVenta getInternet()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == internetID).FirstOrDefault();
            return TipoVenta;
        }
    }
}