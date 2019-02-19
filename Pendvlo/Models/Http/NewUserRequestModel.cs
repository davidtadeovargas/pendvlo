using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models.Http
{
    public class NewUserRequestModel
    {
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Sales { get; set; }
        public int Module { get; set; }
    }
}