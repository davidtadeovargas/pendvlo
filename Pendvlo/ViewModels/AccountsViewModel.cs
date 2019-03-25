using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.ViewModels
{
    public class AccountsViewModel
    {
        public List<Cuenta> Cuentas { get; set; }
        public List<Banco> Banks { get; set; }
        public Cuenta Cuenta { get; set; }
        public TYPE Type { get; set; }
    }
}