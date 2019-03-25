using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.HttpModels
{
    public class NewAccountRequestModel
    {
        public string titular { get; set; }
        public int Banco { get; set; }
        public string cuenta { get; set; }        
        public string tarjeta { get; set; }
        public string clabe { get; set; }
    }
}