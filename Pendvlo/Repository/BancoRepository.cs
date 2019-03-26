using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class BancoRepository : Repository
    {
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
            var result = DBContext.Bancos.Add(new Banco { Name = "BANAMEX" });
            DBContext.SaveChanges();            
        }

        /*
         Create scotiabanc
             */
        public void createScotiabank()
        {
            var result = DBContext.Bancos.Add(new Banco { Name = "SCOTIABANK" });
            DBContext.SaveChanges();
        }

        /*
         Create bancomer
             */
        public void createBancomer()
        {
            var result = DBContext.Bancos.Add(new Banco { Name = "BANCOMER" });
            DBContext.SaveChanges();
        }

        /*
         Get banamex
             */
        public Banco getBanamex()
        {
            Banco Banco = DBContext.Bancos.Where(m => m.Name == "BANAMEX").FirstOrDefault();
            return Banco;
        }

        /*
         Get scotiabank
             */
        public Banco getScotiabank()
        {
            Banco Banco = DBContext.Bancos.Where(m => m.Name == "SCOTIABANK").FirstOrDefault();
            return Banco;
        }

        /*
         Get bancomer
             */
        public Banco getBancomer()
        {
            Banco Banco = DBContext.Bancos.Where(m => m.Name == "BANCOMER").FirstOrDefault();
            return Banco;
        }
    }
}