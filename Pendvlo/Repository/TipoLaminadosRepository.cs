using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class TipoLaminadosRepository : Repository
    {
        public TipoLaminadosRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<TiposLaminados> getAll()
        {
            List<TiposLaminados> list_ = DBContext.TipoLaminados.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public TiposLaminados getByID(int id)
        {
            TiposLaminados TiposLaminados = DBContext.TipoLaminados.Where(m => m.ID == id).FirstOrDefault();
            return TiposLaminados;
        }

        /*
         Create model
             */
        public void createBrillante()
        {
            var result = DBContext.TipoLaminados.Add(new TiposLaminados { Name = "BRILLANTE" });
            DBContext.SaveChanges();            
        }

        /*
         Create model
             */
        public void createMate()
        {
            var result = DBContext.TipoLaminados.Add(new TiposLaminados { Name = "MATE" });
            DBContext.SaveChanges();
        }

        /*
         Create model
             */
        public void createSin()
        {
            var result = DBContext.TipoLaminados.Add(new TiposLaminados { Name = "SIN" });
            DBContext.SaveChanges();
        }

        /*
         Get model
             */
        public TiposLaminados getBrillante()
        {
            TiposLaminados TiposLaminados = DBContext.TipoLaminados.Where(m => m.Name == "BRILLANTE").FirstOrDefault();
            return TiposLaminados;
        }

        /*
         Get model
             */
        public TiposLaminados getMate()
        {
            TiposLaminados TiposLaminados = DBContext.TipoLaminados.Where(m => m.Name == "MATE").FirstOrDefault();
            return TiposLaminados;
        }

        /*
         Get model
             */
        public TiposLaminados getSin()
        {
            TiposLaminados TiposLaminados = DBContext.TipoLaminados.Where(m => m.Name == "SIN").FirstOrDefault();
            return TiposLaminados;
        }        
    }
}