﻿using Pendvlo.DAL;
using Pendvlo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Managers
{
    public class RepositoryManager
    {
        private static RepositoryManager instance = null;
        private static readonly object padlock = new object();

        DBContext dBContext = new DBContext();

        /*
            List of all the repositories
             */
        public LoginReposotiry LoginRepository { get; set; }
        public UsersRepository UsersRepository { get; set; }
        public ModulesRepository ModulesRepository { get; set; }
        public CustomersRepository CustomersRepository { get; set; }
        public ProductsRepository ProductsRepository { get; set; }
        public ProcedimientosImpresionRepository ProcedimientosImpresionRepository { get; set; }
        public SuajeRepository SuajeRepository { get; set; }
        public MedidaEtiquetaRepository MedidaEtiquetaRepository { get; set; }
        public TipoVentaRepository TipoVentaRepository { get; set; }
        public TipoPagosRepository TipoPagosRepository { get; set; }
        public TipoArchivosRepository TipoArchivosRepository { get; set; }
        public SucursalesRepository SucursalesRepository { get; set; }
        public BancoRepository BancoRepository { get; set; }
        public EstatusOrdenVentaRepository EstatusOrdenVentaRepository { get; set; }
        public CuentasRepository CuentasRepository { get; set; }
        public TipoLaminadosRepository TipoLaminadosRepository { get; set; }
        public NotasVentaRepository NotasVentaRepository { get; set; }        




        RepositoryManager()
        {
            LoginRepository = new LoginReposotiry(dBContext);
            UsersRepository = new UsersRepository(dBContext);
            ModulesRepository = new ModulesRepository(dBContext);
            CustomersRepository = new CustomersRepository(dBContext);
            ProductsRepository = new ProductsRepository(dBContext);
            ProcedimientosImpresionRepository = new ProcedimientosImpresionRepository(dBContext);
            SuajeRepository = new SuajeRepository(dBContext);
            MedidaEtiquetaRepository = new MedidaEtiquetaRepository(dBContext);
            TipoVentaRepository = new TipoVentaRepository(dBContext);
            TipoPagosRepository = new TipoPagosRepository(dBContext);
            TipoArchivosRepository = new TipoArchivosRepository(dBContext);            
            SucursalesRepository = new SucursalesRepository(dBContext);
            BancoRepository = new BancoRepository(dBContext);
            EstatusOrdenVentaRepository = new EstatusOrdenVentaRepository(dBContext);
            CuentasRepository = new CuentasRepository(dBContext);
            TipoLaminadosRepository = new TipoLaminadosRepository(dBContext);
            NotasVentaRepository = new NotasVentaRepository(dBContext);            
        }

        public static RepositoryManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new RepositoryManager();
                    }
                    return instance;
                }
            }
        }
    }
}