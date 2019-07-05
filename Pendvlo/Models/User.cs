using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class User
    {
        public int ID { get; set; }

        [MaxLength(60)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string User_ { get; set; }

        [MaxLength(15)]
        public string Password { get; set; }
        public bool Sales { get; set; }
        public bool EncargadoSucursal { get; set; }
        public Sucursal Sucursal { get; set; }
        public Boolean admin { get; set; }
        public Boolean superAdmin { get; set; }
        public Module Module { get; set; }
        public DateTime Created { get; set; }

        public User()
        {
            Created = DateTime.Now;
            admin = false;
            superAdmin = false;
            EncargadoSucursal = false;
        }
    }
}