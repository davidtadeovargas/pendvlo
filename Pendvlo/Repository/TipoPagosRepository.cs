using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class TipoPagosRepository : Repository
    {
        public TipoPagosRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<TiposPagos> getAll()
        {
            List<TiposPagos> list_ = DBContext.TipoPagos.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public TiposPagos getByID(int id)
        {
            TiposPagos TiposPagos = DBContext.TipoPagos.Where(m => m.ID == id).FirstOrDefault();
            return TiposPagos;
        }

        /*
         Create efectivo
             */
        public void createEfectivo()
        {
            var result = DBContext.TipoPagos.Add(new TiposPagos { Name = "EFECTIVO" });
            DBContext.SaveChanges();            
        }

        /*
         Create transferencia
             */
        public void createTransferencia()
        {
            var result = DBContext.TipoPagos.Add(new TiposPagos { Name = "TRANSFERENCIA" });
            DBContext.SaveChanges();
        }

        /*
         Create deposito
             */
        public void createDeposito()
        {
            var result = DBContext.TipoPagos.Add(new TiposPagos { Name = "DEPOSITO" });
            DBContext.SaveChanges();
        }

        /*
         Create terminal
             */
        public void createTerminal()
        {
            var result = DBContext.TipoPagos.Add(new TiposPagos { Name = "TERMINAL" });
            DBContext.SaveChanges();
        }

        /*
         Get efectivo
             */
        public TipoVenta getEfectivo()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "EFECTIVO").FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get transferencia
             */
        public TipoVenta getTransferencia()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "TRANSFERENCIA").FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get deposito
             */
        public TipoVenta getDeposito()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "DEPOSITO").FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get terminal
             */
        public TipoVenta getTerminal()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.Name == "TERMINAL").FirstOrDefault();
            return TipoVenta;
        }
    }
}