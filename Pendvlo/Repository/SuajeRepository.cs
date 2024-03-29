﻿using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class SuajeRepository : Repository
    {
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
            var result = DBContext.Suajes.Add(new Suaje { Name = "IMPRESION CONTINUA" });
            DBContext.SaveChanges();            
        }

        /*
         Create the corte completo
             */
        public void createCorteCompleto()
        {
            var result = DBContext.Suajes.Add(new Suaje { Name = "CORTE COMPLETO" });
            DBContext.SaveChanges();
        }

        /*
         Create suaje de seguridad
             */
        public void createSuajeSeguridad()
        {
            var result = DBContext.Suajes.Add(new Suaje { Name = "SUAJE DE SEGURIDAD" });
            DBContext.SaveChanges();
        }

        /*
         Create suaje
             */
        public void createSuaje()
        {
            var result = DBContext.Suajes.Add(new Suaje { Name = "SUAJE" });
            DBContext.SaveChanges();
        }

        /*
         Create suaje
             */
        public void createPleca()
        {
            var result = DBContext.Suajes.Add(new Suaje { Name = "PLECA" });
            DBContext.SaveChanges();
        }

        /*
         Get the impresion continua
             */
        public Suaje getImpresionContinua()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.Name == "IMPRESION CONTINUA").FirstOrDefault();
            return Suaje;
        }

        /*
         Get corte completo
             */
        public Suaje getCorteCompleto()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.Name == "CORTE COMPLETO").FirstOrDefault();
            return Suaje;
        }

        /*
         Get suaje de seguridad
             */
        public Suaje getSuajeSeguridad()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.Name == "SUAJE DE SEGURIDAD").FirstOrDefault();
            return Suaje;
        }

        /*
         Get suaje
             */
        public Suaje getSuaje()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.Name == "SUAJE").FirstOrDefault();
            return Suaje;
        }

        /*
         Get suaje
             */
        public Suaje getPleca()
        {
            Suaje Suaje = DBContext.Suajes.Where(m => m.Name == "PLECA").FirstOrDefault();
            return Suaje;
        }
    }
}