using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models.Views
{
    public class CustomersViewModel
    {
        public List<Customer> Customers { get; set; }
        public TYPE Type { get; set; }        
    }
}