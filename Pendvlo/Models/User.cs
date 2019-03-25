﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string User_ { get; set; }
        public string Password { get; set; }
        public bool Sales { get; set; }
        public bool EncargadoSucursal { get; set; }
        public Sucursal Sucursal { get; set; }
        public Boolean admin { get; set; }
        public Module Module { get; set; }
        public DateTime Created { get; set; }

        public User()
        {
            Created = DateTime.Now;
            admin = false;
            EncargadoSucursal = false;
        }
    }
}