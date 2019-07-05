using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class Cuenta
    {
        public int ID { get; set; }

        [MaxLength(60)]
        public string titular { get; set; }
        public Banco Banco { get; set; }

        [MaxLength(20)]
        public string cuenta { get; set; }

        [MaxLength(16)]
        public string tarjeta { get; set; }

        [MaxLength(18)]
        public string clabe { get; set; }
        public DateTime Created { get; set; }



        public Cuenta()
        {
            Created = DateTime.Now;
        }
    }
}