using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string code { get; set; }
        public string descrip { get; set; }
        public double price { get; set; }
        public string tax { get; set; }
        public bool avaible { get; set; }
        public bool sales  { get; set; }
        public DateTime Created { get; set; }

        public Product()
        {
            Created = DateTime.Now;
        }
    }
}