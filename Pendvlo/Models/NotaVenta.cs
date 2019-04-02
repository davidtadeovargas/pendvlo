using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Models
{
    public class NotaVenta
    {
        public int ID { get; set; }
        public int numeroNota { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public DateTime fechaEntrega { get; set; }
        public bool requiereFactura { get; set; }
        public TiposArchivo TiposArchivo { get; set; }
        public TiposLaminados TipoLaminado { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public TiposPagos TipoPago { get; set; }
        public string cuenta { get; set; }
        public User Vendedor { get; set; }
        public Banco Banco { get; set; }
        public string observaciones { get; set; }
        public Sucursal Sucursal { get; set; }
        public double millar { get; set; }
        public double impresion { get; set; }
        public double otro { get; set; }        
        public double descuento { get; set; }
        public double grabados { get; set; }
        public double diseno { get; set; }
        public double express { get; set; }
        public double subtotal { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }
        public double anticipo { get; set; }
        public double saldo { get; set; }
        public double abono { get; set; }
        public DateTime Created { get; set; }

        public NotaVenta()
        {
            Created = DateTime.Now;
        }
    }
}