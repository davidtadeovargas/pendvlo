using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.HttpModels
{
    public class GetFilteredProductsResponseModel : Result
    {
        public List<Product> Products { get; set; }
    }
}