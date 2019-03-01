using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class ProcedimientoImpresion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }



        public ProcedimientoImpresion()
        {
            Created = DateTime.Now;
        }
    }
}