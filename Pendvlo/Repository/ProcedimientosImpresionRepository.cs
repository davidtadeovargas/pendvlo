using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class ProcedimientosImpresionRepository : Repository
    {
        public ProcedimientosImpresionRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all the proccedures
             */
        public List<ProcedimientoImpresion> getAll()
        {
            List<ProcedimientoImpresion> list_ = DBContext.ProcedimientoImpresions.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public ProcedimientoImpresion getByID(int id)
        {
            ProcedimientoImpresion proc_ = DBContext.ProcedimientoImpresions.Where(m => m.ID == id).FirstOrDefault();
            return proc_;
        }

        /*
         Create the selection
             */
        public void createSelection()
        {
            var result = DBContext.ProcedimientoImpresions.Add(new ProcedimientoImpresion { Name = "SELECCION" });
            DBContext.SaveChanges();            
        }

        /*
         Create the trocomia module
             */
        public void createTrocomia()
        {
            var result = DBContext.ProcedimientoImpresions.Add(new ProcedimientoImpresion { Name = "TRICOMIA" });
            DBContext.SaveChanges();
        }

        /*
         Create the tinta directa module
             */
        public void createTintaDirecta()
        {
            var result = DBContext.ProcedimientoImpresions.Add(new ProcedimientoImpresion { Name = "TINTA DIRECTA" });
            DBContext.SaveChanges();
        }

        /*
         Get the selection
             */
        public ProcedimientoImpresion getSelection()
        {
            ProcedimientoImpresion Module_ = DBContext.ProcedimientoImpresions.Where(m => m.Name == "SELECCION").FirstOrDefault();
            return Module_;
        }

        /*
         Get the tracomia
             */
        public ProcedimientoImpresion getTracomia()
        {
            ProcedimientoImpresion Module_ = DBContext.ProcedimientoImpresions.Where(m => m.Name == "TRICOMIA").FirstOrDefault();
            return Module_;
        }

        /*
         Get model
             */
        public ProcedimientoImpresion getTintaDirecta()
        {
            ProcedimientoImpresion Module_ = DBContext.ProcedimientoImpresions.Where(m => m.Name == "TINTA DIRECTA").FirstOrDefault();
            return Module_;
        }
    }
}