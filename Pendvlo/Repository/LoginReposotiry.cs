using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class LoginReposotiry : Repository
    {
        public LoginReposotiry(DBContext dBContext) : base(dBContext)
        {

        }

        public User validateLogin(string user, string password)
        {
            User User_ = DBContext.Users.Include("Sucursal").Include("Module").Where(Users => Users.User_ == user).Where(Users => Users.Password == password).FirstOrDefault();
            return User_;
        }
    }
}