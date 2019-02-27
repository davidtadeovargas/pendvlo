using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models.Views
{
    public class ProductsViewModel
    {
        public TYPE Type { get; set; }
        public List<Product> Products{ get; set; }
    }
}