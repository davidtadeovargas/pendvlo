using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class SuajeRepository : Repository
    {
        /*
         Contains the first ids
             */
        private int impresionContinuaID = 0;
        private int corteCompletoID = 1;
        private int suajeSeguridadID = 2;




        public SuajeRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all the suajes
             */
        public List<Suaje> getAll()
        {
            List<Suaje> list_ = DBContext.Suajes.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public Suaje getByID(int id)
        {
            Suaje proc_ = DBContext.Suajes.Where(m => m.ID == id).FirstOrDefault();
            return proc_;
        }

        /*
         Create the impresion continua
             */
        public void createImpresionContinua()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = impresionContinuaID, Name = "IMPRESION CONTINUA" });
            DBContext.SaveChanges();            
        }

        /*
         Create the corte completo
             */
        public void createCorteCompleto()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = corteCompletoID, Name = "CORTE COMPLETO" });
            DBContext.SaveChanges();
        }

        /*
         Create suaje de seguridad
             */
        public void createSuajeSeguridad()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = suajeSeguridadID, Name = "SUAJE DE SEGURIDAD" });
            DBContext.SaveChanges();
        }

        /*
         Get the impresion continua
             */
        public Suaje getImpresionContinua()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.ID == impresionContinuaID).FirstOrDefault();
            return Suaje;
        }

        /*
         Get corte completo
             */
        public Suaje getCorteCompleto()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.ID == corteCompletoID).FirstOrDefault();
            return Suaje;
        }

        /*
         Get suaje de seguridad
             */
        public Suaje getSuajeSeguridad()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.ID == suajeSeguridadID).FirstOrDefault();
            return Suaje;
        }
    }
}