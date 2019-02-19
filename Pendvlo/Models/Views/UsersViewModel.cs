using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models.Views
{
    public class UsersViewModel
    {
        public List<User> Users { get; set; }
        public TYPE Type { get; set; }
    }
}