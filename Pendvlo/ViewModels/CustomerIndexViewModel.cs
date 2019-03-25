using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.ViewModels
{
    public class CustomerIndexViewModel
    {
        public TYPE Type { get; set; }
        public Customer Customer { get; set; }
        public List<User> Users { get; set; }
    }
}