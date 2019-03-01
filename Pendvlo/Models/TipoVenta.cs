using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class TipoVenta
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }



        public TipoVenta()
        {
            Created = DateTime.Now;
        }
    }
}