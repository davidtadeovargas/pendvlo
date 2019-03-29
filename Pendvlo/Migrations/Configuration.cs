namespace Pendvlo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Pendvlo.Repository;
    using Pendvlo.Managers;
    using Pendvlo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Pendvlo.DAL.DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Pendvlo.DAL.DBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*
                Modules
             */
            RepositoryManager.Instance.ModulesRepository.createProductionModule();
            RepositoryManager.Instance.ModulesRepository.createWareohuseModule();
            RepositoryManager.Instance.ModulesRepository.createSalesModule();
            RepositoryManager.Instance.ModulesRepository.createAdministrationModule();
            RepositoryManager.Instance.ModulesRepository.createDesignModule();
            RepositoryManager.Instance.ModulesRepository.createAtenServCustomModule();
            RepositoryManager.Instance.ModulesRepository.createAdminComprasModule();

            /*
                Sucursales
             */
            RepositoryManager.Instance.SucursalesRepository.createLibertadSucursal();
            RepositoryManager.Instance.SucursalesRepository.createMiguelBlanco();

            /*
                Users
             */

            Module salesModule = RepositoryManager.Instance.ModulesRepository.getAtencionServCustomerModule();
            Module administrativeModule = RepositoryManager.Instance.ModulesRepository.getAdministrationModule();

            Sucursal sucursal = RepositoryManager.Instance.SucursalesRepository.getLibertadSucursal();

            context.Users.AddOrUpdate(x => x.ID,
                new User() { ID = 1, Name = "admin", User_ = "admin", Password = "123456789", Sales = true, admin = true, Sucursal = sucursal }
                );
            context.Users.AddOrUpdate(x => x.ID,
                new User() { ID = 1, Name = "ALEJANDRO ESPEJO", User_ = "JAER", Password = "123456789", Sales = true, Module = salesModule, Sucursal = sucursal }
                );
            context.Users.AddOrUpdate(x => x.ID,
                new User() { ID = 1, Name = "ALDO DAGOBERTO", User_ = "ADRL", Password = "123456789", Sales = true, Module = administrativeModule, Sucursal = sucursal }
                );

            /*
                Procedimientos de impresion
             */
            RepositoryManager.Instance.ProcedimientosImpresionRepository.createSelection();
            RepositoryManager.Instance.ProcedimientosImpresionRepository.createTrocomia();
            RepositoryManager.Instance.ProcedimientosImpresionRepository.createTintaDirecta();

            /*
                Suajes
             */
            RepositoryManager.Instance.SuajeRepository.createImpresionContinua();
            RepositoryManager.Instance.SuajeRepository.createCorteCompleto();
            RepositoryManager.Instance.SuajeRepository.createSuajeSeguridad();

            RepositoryManager.Instance.SuajeRepository.createSuaje();
            RepositoryManager.Instance.SuajeRepository.createPleca();

            /*
                Medida etiqueta
             */
            RepositoryManager.Instance.MedidaEtiquetaRepository.createEje();
            RepositoryManager.Instance.MedidaEtiquetaRepository.createDesarrollo();

            /*
                Tipo de ventas
             */
            RepositoryManager.Instance.TipoVentaRepository.createMostrador();
            RepositoryManager.Instance.TipoVentaRepository.createMaquilador();
            RepositoryManager.Instance.TipoVentaRepository.createVolumen();
            RepositoryManager.Instance.TipoVentaRepository.createInternet();

            /*
                Tipo de laminados
             */
            RepositoryManager.Instance.TipoLaminadosRepository.createBrillante();
            RepositoryManager.Instance.TipoLaminadosRepository.createMate();
            RepositoryManager.Instance.TipoLaminadosRepository.createSin();

            /*
                Tipo de archivos
             */
            RepositoryManager.Instance.TipoArchivosRepository.createNuevo();
            RepositoryManager.Instance.TipoArchivosRepository.createReimpresion();
            RepositoryManager.Instance.TipoArchivosRepository.createModificacion();

            /*
                Tipo de pagos
             */
            RepositoryManager.Instance.TipoPagosRepository.createEfectivo();
            RepositoryManager.Instance.TipoPagosRepository.createTransferencia();
            RepositoryManager.Instance.TipoPagosRepository.createDeposito();
            RepositoryManager.Instance.TipoPagosRepository.createTerminal();            

            /*
                Bancos
             */
            RepositoryManager.Instance.BancoRepository.createBanamex();
            RepositoryManager.Instance.BancoRepository.createBancomer();
            RepositoryManager.Instance.BancoRepository.createScotiabank();

            /*
                Cuentas
             */
            RepositoryManager.Instance.CuentasRepository.createInitialBanamex();
            RepositoryManager.Instance.CuentasRepository.createInitialScotiabank();

            /*
                Estatus de ordenes de venta
             */
            RepositoryManager.Instance.EstatusOrdenVentaRepository.createPendiente();
            RepositoryManager.Instance.EstatusOrdenVentaRepository.createCompletada();
        }
    }
}
