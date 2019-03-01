using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class TipoPagosRepository : Repository
    {
        /*
         Contains the first ids
             */
        private int efectivoID = 0;
        private int transferenciaID = 1;
        private int depositoID = 2;
        private int terminalID = 3;




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
            var result = DBContext.TipoPagos.Add(new TiposPagos { ID = efectivoID, Name = "EFECTIVO" });
            DBContext.SaveChanges();            
        }

        /*
         Create transferencia
             */
        public void createTransferencia()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = transferenciaID, Name = "TRANSFERENCIA" });
            DBContext.SaveChanges();
        }

        /*
         Create deposito
             */
        public void createDeposito()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = depositoID, Name = "DEPOSITO" });
            DBContext.SaveChanges();
        }

        /*
         Create terminal
             */
        public void createTerminal()
        {
            var result = DBContext.TipoVentas.Add(new TipoVenta { ID = terminalID, Name = "TERMINAL" });
            DBContext.SaveChanges();
        }

        /*
         Get efectivo
             */
        public TipoVenta getEfectivo()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == efectivoID).FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get transferencia
             */
        public TipoVenta getTransferencia()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == transferenciaID).FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get deposito
             */
        public TipoVenta getDeposito()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == depositoID).FirstOrDefault();
            return TipoVenta;
        }

        /*
         Get terminal
             */
        public TipoVenta getTerminal()
        {
            TipoVenta TipoVenta = DBContext.TipoVentas.Where(m => m.ID == terminalID).FirstOrDefault();
            return TipoVenta;
        }
    }
}