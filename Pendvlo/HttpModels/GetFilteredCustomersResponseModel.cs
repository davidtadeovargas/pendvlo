using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.HttpModels
{
    public class GetFilteredCustomersResponseModel : Result
    {
        public List<Customer> Customers { get; set; }
    }
}