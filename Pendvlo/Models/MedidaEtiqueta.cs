using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class MedidaEtiqueta
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }



        public MedidaEtiqueta()
        {
            Created = DateTime.Now;
        }
    }
}