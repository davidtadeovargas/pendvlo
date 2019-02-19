using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class Module
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }



        public Module()
        {
            Created = DateTime.Now;
        }
    }
}