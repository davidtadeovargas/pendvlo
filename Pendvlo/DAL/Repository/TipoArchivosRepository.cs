using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class TipoArchivosRepository : Repository
    {
        public TipoArchivosRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<TiposArchivo> getAll()
        {
            List<TiposArchivo> list_ = DBContext.TipoArchivos.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public TiposArchivo getByID(int id)
        {
            TiposArchivo TiposArchivo = DBContext.TipoArchivos.Where(m => m.ID == id).FirstOrDefault();
            return TiposArchivo;
        }

        /*
         Create model
             */
        public void createNuevo()
        {
            var result = DBContext.TipoArchivos.Add(new TiposArchivo { Name = "NUEVO" });
            DBContext.SaveChanges();            
        }

        /*
         Create model
             */
        public void createReimpresion()
        {
            var result = DBContext.TipoArchivos.Add(new TiposArchivo { Name = "REIMPRESION" });
            DBContext.SaveChanges();
        }

        /*
         Create model
             */
        public void createModificacion()
        {
            var result = DBContext.TipoArchivos.Add(new TiposArchivo { Name = "MODIFICACION" });
            DBContext.SaveChanges();
        }

        /*
         Get model
             */
        public TiposArchivo getNuevo()
        {
            TiposArchivo TiposArchivo = DBContext.TipoArchivos.Where(m => m.Name == "NUEVO").FirstOrDefault();
            return TiposArchivo;
        }

        /*
         Get model
             */
        public TiposArchivo getReimpresion()
        {
            TiposArchivo TiposArchivo = DBContext.TipoArchivos.Where(m => m.Name == "REIMPRESION").FirstOrDefault();
            return TiposArchivo;
        }

        /*
         Get model
             */
        public TiposArchivo getModificacion()
        {
            TiposArchivo TiposArchivo = DBContext.TipoArchivos.Where(m => m.Name == "MODIFICACION").FirstOrDefault();
            return TiposArchivo;
        }        
    }
}