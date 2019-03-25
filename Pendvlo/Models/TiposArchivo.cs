using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    [Table("TiposArchivos")]
    public class TiposArchivo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }



        public TiposArchivo()
        {
            Created = DateTime.Now;
        }
    }
}