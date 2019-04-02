using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.HttpModels
{
    public class NewNotaVentaRequestModel
    {
        public int ID { get; set; }
        public long fecha { get; set; }
        public long hora { get; set; }
        public long fechaEntrega { get; set; }
        public bool requiereFactura { get; set; }
        public int tipoArchivoID { get; set; }
        public int tipoLaminadoID { get; set; }
        public int productID { get; set; }
        public int customerID { get; set; }
        public int tipoPagoID { get; set; }
        public string cuenta { get; set; }
        public int vendedorID { get; set; }
        public int bancoID { get; set; }        
        public string referencia { get; set; }
        public string observaciones { get; set; }
        public int sucursalID { get; set; }
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
    }
}