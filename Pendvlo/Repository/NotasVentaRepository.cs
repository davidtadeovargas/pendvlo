using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class NotasVentaRepository : Repository
    {
        public NotasVentaRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all te users
             */
        public List<NotaVenta> getAll()
        {
            List<NotaVenta> NotaVenta = DBContext.NotasVenta
                .Include("TiposArchivo")
                .Include("TipoLaminado")
                .Include("Product")
                .Include("Customer")
                .Include("TipoPago")
                .Include("Vendedor")
                .Include("Banco")
                .Include("Sucursal")
                .ToList();
            return NotaVenta;
        }

        /*
         Create a new nota de venta
             */
        public int newNotaVenta(NotaVenta NotaVenta)
        {
            var result = DBContext.NotasVenta.Add(NotaVenta);
            DBContext.SaveChanges();
            return result.ID;
        }

        /*
         Edit nota de venta
             */
        public int editNotaVenta(NotaVenta NotaVenta)
        {
            DBContext.Entry(NotaVenta).State = System.Data.Entity.EntityState.Modified;
            var result = DBContext.SaveChanges();
            return result;
        }

        /*
         Get nota de venta
             */
        public NotaVenta getById(int id)
        {
            var NotaVenta = DBContext.NotasVenta.Where(a=>a.ID == id).FirstOrDefault();
            return NotaVenta;
        }


        /*
         Delete a nota de venta
             */
        public NotaVenta deleteById(int id)
        {
            NotaVenta NotaVenta = getById(id);
            DBContext.NotasVenta.Remove(NotaVenta);
            DBContext.SaveChanges();
            return NotaVenta;
        }
    }
}