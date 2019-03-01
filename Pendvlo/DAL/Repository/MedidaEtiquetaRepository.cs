using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class MedidaEtiquetaRepository : Repository
    {
        /*
         Contains the first ids
             */
        private int ejeID = 0;
        private int desarrolloID = 1;        




        public MedidaEtiquetaRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<MedidaEtiqueta> getAll()
        {
            List<MedidaEtiqueta> list_ = DBContext.MedidasEtiqueta.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public MedidaEtiqueta getByID(int id)
        {
            MedidaEtiqueta MedidaEtiqueta = DBContext.MedidasEtiqueta.Where(m => m.ID == id).FirstOrDefault();
            return MedidaEtiqueta;
        }

        /*
         Create EJE
             */
        public void createEje()
        {
            var result = DBContext.MedidasEtiqueta.Add(new MedidaEtiqueta { ID = ejeID, Name = "EJE" });
            DBContext.SaveChanges();            
        }

        /*
         Create desarollo
             */
        public void createDesarrollo()
        {
            var result = DBContext.MedidasEtiqueta.Add(new MedidaEtiqueta { ID = desarrolloID, Name = "DESARROLLO" });
            DBContext.SaveChanges();
        }

        /*
         Get eje
             */
        public MedidaEtiqueta getEje()
        {
            MedidaEtiqueta MedidaEtiqueta = DBContext.MedidasEtiqueta.Where(m => m.ID == ejeID).FirstOrDefault();
            return MedidaEtiqueta;
        }

        /*
         Get desarrollo
             */
        public MedidaEtiqueta getDesarrollo()
        {
            MedidaEtiqueta MedidaEtiqueta = DBContext.MedidasEtiqueta.Where(m => m.ID == desarrolloID).FirstOrDefault();
            return MedidaEtiqueta;
        }        
    }
}