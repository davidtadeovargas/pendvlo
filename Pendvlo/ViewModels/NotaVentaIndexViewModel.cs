using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.ViewModels
{
    public class NotaVentaIndexViewModel
    {
        public TYPE Type { get; set; }
        public NotaVenta NotaVenta { get; set; }
        public List<TiposArchivo> TiposArchivos { get; set; }
        public List<TiposLaminados> TiposLaminados { get; set; }
        public List<TiposPagos> TiposPagos { get; set; }
        public List<Banco> Bancos { get; set; }
        public List<Product> Products { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string fechaEntrega { get; set; }
        public string sucursal { get; set; }
        public string urlGetFilteredProducts { get; set; }
    }
}