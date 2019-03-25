using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    [Table("Sucursales")]
    public class Sucursal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }



        public Sucursal()
        {
            Created = DateTime.Now;
        }
    }
}