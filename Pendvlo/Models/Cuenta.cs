using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class Cuenta
    {
        public int ID { get; set; }
        public Banco Banco { get; set; }
        public string cuenta { get; set; }
        public string tarjeta { get; set; }
        public string clabe { get; set; }
        public DateTime Created { get; set; }



        public Cuenta()
        {
            Created = DateTime.Now;
        }
    }
}