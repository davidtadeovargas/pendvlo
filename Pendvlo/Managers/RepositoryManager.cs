using Pendvlo.DAL;
using Pendvlo.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Managers
{
    public class RepositoryManager
    {
        private static RepositoryManager instance = null;
        private static readonly object padlock = new object();

        DBContext dBContext = new DBContext();

        /*
            List of all the repositories
             */
        public LoginReposotiry LoginRepository { get; set; }
        public UsersRepository UsersRepository { get; set; }
        public ModulesRepository ModulesRepository { get; set; }
        public CustomersRepository CustomersRepository { get; set; }




        RepositoryManager()
        {
            LoginRepository = new LoginReposotiry(dBContext);
            UsersRepository = new UsersRepository(dBContext);
            ModulesRepository = new ModulesRepository(dBContext);
            CustomersRepository = new CustomersRepository(dBContext);
        }

        public static RepositoryManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RepositoryManager();
                    }
                    return instance;
                }
            }
        }
    }
}