using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
{
    public class BancoRepository : Repository
    {
        /*
         Contains the first ids
             */
        private int banamexID = 0;
        private int scotiabankID = 1;
        private int bancomerID = 2;




        public BancoRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<Banco> getAll()
        {
            List<Banco> list_ = DBContext.Bancos.OrderBy(s => s.Name).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public Banco getByID(int id)
        {
            Banco Banco = DBContext.Bancos.Where(m => m.ID == id).FirstOrDefault();
            return Banco;
        }

        /*
         Create banamex
             */
        public void createBanamex()
        {
            var result = DBContext.Bancos.Add(new Banco { ID = banamexID, Name = "BANAMEX" });
            DBContext.SaveChanges();            
        }

        /*
         Create scotiabanc
             */
        public void createScotiabank()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = scotiabankID, Name = "SCOTIABANK" });
            DBContext.SaveChanges();
        }

        /*
         Create bancomer
             */
        public void createBancomer()
        {
            var result = DBContext.Suajes.Add(new Suaje { ID = bancomerID, Name = "BANCOMER" });
            DBContext.SaveChanges();
        }

        /*
         Get banamex
             */
        public Banco getBanamex()
        {
            Banco Banco = DBContext.Bancos.Where(m => m.ID == banamexID).FirstOrDefault();
            return Banco;
        }

        /*
         Get scotiabank
             */
        public Banco getScotiabank()
        {
            Banco Banco = DBContext.Bancos.Where(m => m.ID == scotiabankID).FirstOrDefault();
            return Banco;
        }

        /*
         Get bancomer
             */
        public Banco getBancomer()
        {
            Banco Banco = DBContext.Bancos.Where(m => m.ID == bancomerID).FirstOrDefault();
            return Banco;
        }
    }
}