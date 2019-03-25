using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class EstatusOrdenVenta
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }



        public EstatusOrdenVenta()
        {
            Created = DateTime.Now;
        }
    }
}