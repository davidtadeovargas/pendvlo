using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Pendvlo.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("pendvlo")
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Suaje> Suajes { get; set; }
        public DbSet<MedidaEtiqueta> MedidasEtiqueta { get; set; }
        public DbSet<TipoVenta> TipoVentas { get; set; }
        public DbSet<TiposPagos> TipoPagos { get; set; }        
        public DbSet<TiposArchivo> TipoArchivos { get; set; }
        public DbSet<TiposLaminados> TipoLaminados { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<ProcedimientoImpresion> ProcedimientoImpresions { get; set; }
        public DbSet<EstatusOrdenVenta> EstatusOrdenVenta { get; set; }
        public DbSet<NotaVenta> NotasVenta { get; set; }
    }
}