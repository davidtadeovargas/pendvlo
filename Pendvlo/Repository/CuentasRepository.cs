using Pendvlo.Managers;
using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class CuentasRepository : Repository
    {
        public CuentasRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all
             */
        public List<Cuenta> getAll()
        {
            List<Cuenta> list_ = DBContext.Cuentas.Include("Banco").OrderByDescending(s => s.ID).ToList();
            return list_;
        }

        /*
         Get by id
             */
        public Cuenta getByID(int id)
        {
            Cuenta Cuenta = DBContext.Cuentas.Where(m => m.ID == id).FirstOrDefault();
            return Cuenta;
        }

        /*
         Create a new account
             */
        public int newAccount(Cuenta cuenta)
        {
            var result = DBContext.Cuentas.Add(cuenta);
            DBContext.SaveChanges();
            return result.ID;
        }

        /*
            Edit account
                */
        public int editAccount(Cuenta cuenta)
        {
            DBContext.Entry(cuenta).State = System.Data.Entity.EntityState.Modified;
            var result = DBContext.SaveChanges();
            return result;
        }

        /*
         Delete account
             */
        public Cuenta deleteByAccount(string account)
        {
            Cuenta Cuenta = getByAccount(account);
            DBContext.Cuentas.Remove(Cuenta);
            DBContext.SaveChanges();
            return Cuenta;
        }

        /*
         Delete account
             */
        public Cuenta deleteById(int id)
        {
            Cuenta Cuenta = getByID(id);
            DBContext.Cuentas.Remove(Cuenta);
            DBContext.SaveChanges();
            return Cuenta;
        }

        /*
         Get by account
             */
        public Cuenta getByAccount(string account)
        {
            Cuenta Cuenta = DBContext.Cuentas.Include("Banco").Where(m => m.cuenta == account).FirstOrDefault();            
            return Cuenta;
        }

        /*
         Create account
             */
        public void createInitialBanamex()
        {
            Banco banco = RepositoryManager.Instance.BancoRepository.getBanamex();

            var result = DBContext.Cuentas.Add(new Cuenta
            {
                titular = "Aldo Dagoberto Robles Lopez",
                Banco = banco,
                cuenta = "8132453331",
                tarjeta = "5206980087187591",
                clabe = "002320701256920348"
            });
            DBContext.SaveChanges();            
        }

        /*
         Create account
             */
        public void createInitialScotiabank()
        {
            Banco banco = RepositoryManager.Instance.BancoRepository.getScotiabank();

            var result = DBContext.Cuentas.Add(new Cuenta
            {
                titular = "Aldo Dagoberto Robles Lopez",
                Banco = banco,
                cuenta = "01005003830",
                tarjeta = "5579209103269210",
                clabe = "044320010050038305"
            });
            DBContext.SaveChanges();
        }

        /*
         Get account
             */
        public Cuenta getInitialBanamex()
        {
            Cuenta Cuenta = DBContext.Cuentas.Where(m => m.cuenta == "8132453331").FirstOrDefault();
            return Cuenta;
        }

        /*
         Get account
             */
        public Cuenta getInitialScotiabank()
        {
            Cuenta Cuenta = DBContext.Cuentas.Where(m => m.cuenta == "01005003830").FirstOrDefault();
            return Cuenta;
        }       
    }
}