using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.HttpModels
{
    public class EditUserRequestModel
    {
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public bool Sales { get; set; }
        public bool encargadoSucursal { get; set; }        
        public int Module { get; set; }
        public int Sucursal { get; set; }
    }
}