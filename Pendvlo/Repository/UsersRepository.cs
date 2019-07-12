using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;
using Pendvlo.Managers;

namespace Pendvlo.Repository
{
    public class UsersRepository : Repository
    {
        public UsersRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all te users
             */
        public List<User> getUsers()
        {
            List<User> Users_ = DBContext.Users.Include("Sucursal").Include("Module").OrderByDescending(s => s.ID).ToList();
            return Users_;
        }

        /*
         Create a new user
             */
        public int newUser(User User_)
        {
            var result = DBContext.Users.Add(User_);
            DBContext.SaveChanges();
            return result.ID;
        }

        /*
         Create super admin user
             */
        public int createSuperAdmin()
        {
            Sucursal Sucursal = RepositoryManager.Instance.SucursalesRepository.getLibertadSucursal();
            Module Module = RepositoryManager.Instance.ModulesRepository.getAdministrationModule();

            User User_ = new User();
            User_.Name = "SUPER ADMIN";
            User_.User_ = "sadmin";
            User_.Password = "123456";
            User_.Sales = true;
            User_.EncargadoSucursal = true;
            User_.Sucursal = Sucursal;
            User_.superAdmin = true;
            User_.Module = Module;

            var result = DBContext.Users.Add(User_);
            DBContext.SaveChanges();
            return result.ID;
        }

        /*
         Edit a new user
             */
        public int editUser(User User_)
        {
            DBContext.Entry(User_).State = System.Data.Entity.EntityState.Modified;
            var result = DBContext.SaveChanges();
            return result;
        }

        /*
         Get user by name
             */
        public User getUserByUser(string user)
        {
            var User_ = DBContext.Users.Where(a=>a.User_== user).FirstOrDefault();
            return User_;
        }


        /*
         Get super admin user
             */
        public User getSuperAdmin()
        {
            var User_ = DBContext.Users.Where(a => a.User_ == "sadmin").FirstOrDefault();
            return User_;
        }

        /*
         Get user by name
             */
        public User getUserByID(int id)
        {
            User User_ = DBContext.Users.Where(m => m.ID == id).FirstOrDefault();
            return User_;
        }

        /*
         Delete a user
             */
        public User deleteById(int id)
        {
            User User_ = getUserByID(id);
            DBContext.Users.Remove(User_);
            DBContext.SaveChanges();
            return User_;
        }
    }
}