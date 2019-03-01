﻿using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class ProcedimientosImpresionRepository : Repository
    {
        /*
         Contains the first ids
             */
        private int seleccionID = 0;
        private int trocomiaID = 1;
        private int tintaID = 2;
        private int directaID = 3;        




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
            var result = DBContext.ProcedimientoImpresions.Add(new ProcedimientoImpresion { ID = seleccionID, Name = "SELECCION" });
            DBContext.SaveChanges();            
        }

        /*
         Create the trocomia module
             */
        public void createTrocomia()
        {
            var result = DBContext.ProcedimientoImpresions.Add(new ProcedimientoImpresion { ID = trocomiaID, Name = "TROCOMIA" });
            DBContext.SaveChanges();
        }

        /*
         Create the tinta directa module
             */
        public void createTintaDirecta()
        {
            var result = DBContext.ProcedimientoImpresions.Add(new ProcedimientoImpresion { ID = tintaID, Name = "TINTA DIRECTA" });
            DBContext.SaveChanges();
        }

        /*
         Get the selection
             */
        public ProcedimientoImpresion getSelection()
        {
            ProcedimientoImpresion Module_ = DBContext.ProcedimientoImpresions.Where(m => m.ID == seleccionID).FirstOrDefault();
            return Module_;
        }

        /*
         Get the tracomia
             */
        public ProcedimientoImpresion getTracomia()
        {
            ProcedimientoImpresion Module_ = DBContext.ProcedimientoImpresions.Where(m => m.ID == directaID).FirstOrDefault();
            return Module_;
        }
    }
}