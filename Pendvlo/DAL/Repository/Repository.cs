using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL.Repository
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