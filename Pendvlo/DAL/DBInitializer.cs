using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL
{
    public class DBInitializer : CreateDatabaseIfNotExists<DBContext>
    {        
    }
}