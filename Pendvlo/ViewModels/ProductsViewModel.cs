using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.ViewModels
{
    public class ProductsViewModel
    {
        public TYPE Type { get; set; }
        public List<Product> Products{ get; set; }
    }
}