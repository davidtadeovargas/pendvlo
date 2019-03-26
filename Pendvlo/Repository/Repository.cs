using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class Repository
    {
        protected DBContext DBContext;




        protected Repository(DBContext DBContext_)
        {
            DBContext = DBContext_;
        }
    }
}