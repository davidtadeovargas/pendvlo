using Pendvlo.Controllers;
using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Managers
{
    public class SessionManager
    {
        private static SessionManager instance = null;
        private static readonly object padlock = new object();

        public User user;




        private SessionManager()
        {
        }
        public static SessionManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SessionManager();
                    }
                    return instance;
                }
            }
        }
        

        public void setUser(BaseController baseController, User user_)
        {
            user = user_;
            baseController.Session["user"] = user_;
        }

        public User getUser()
        {
            return this.user;
        }

        public void logoutUser(BaseController baseController)
        {
            user = null;
            baseController.Session["user"] = null;
        }
    }
}