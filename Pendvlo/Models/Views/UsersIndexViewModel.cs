using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models.Views
{
    public class UsersIndexViewModel
    {
        public TYPE Type { get; set; }
        public User User { get; set; }
        public List<Module> Modules { get; set; }
    }
}