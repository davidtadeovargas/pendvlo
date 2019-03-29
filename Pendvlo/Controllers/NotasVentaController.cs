using Pendvlo.HttpModels;
using Pendvlo.Managers;
using Pendvlo.Models;
using Pendvlo.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Pendvlo.Controllers
{
    public class NotasVentaController : BaseController
    {

        public ActionResult Index()
        {
            NotasVentaViewModel NotasVentaViewModel = new NotasVentaViewModel();
            NotasVentaViewModel.Type = TYPE.LIST;

            return NotasVenta(NotasVentaViewModel);
        }


        /*
            Create a new nota de venta
             */
        public ActionResult NewNotaVenta(NewNotaVentaRequestModel NewNotaVentaRequestModel)
        {
            try
            {
                /*
                    Validate all fields are filled
                 */
                if (NewNotaVentaRequestModel.cuenta == null || NewNotaVentaRequestModel.cuenta == "")
                {
                    return Json(JSONManager.JsonFail("Need cuenta"));
                }
                if (NewNotaVentaRequestModel.referencia == null || NewNotaVentaRequestModel.referencia == "")
                {
                    return Json(JSONManager.JsonFail("Need referencia"));
                }
                if (NewNotaVentaRequestModel.observaciones == null || NewNotaVentaRequestModel.observaciones == "")
                {
                    return Json(JSONManager.JsonFail("Need observaciones"));
                }

                /*
                    Get the required models
                 */
                TiposArchivo TipoArchivo = RepositoryManager.Instance.TipoArchivosRepository.getByID(NewNotaVentaRequestModel.tipoArchivoID);
                TiposLaminados TipoLaminado = RepositoryManager.Instance.TipoLaminadosRepository.getByID(NewNotaVentaRequestModel.tipoLaminadoID);
                Product Product = RepositoryManager.Instance.ProductsRepository.getProductByID(NewNotaVentaRequestModel.productID);
                Customer Customer = RepositoryManager.Instance.CustomersRepository.getCustomerByID(NewNotaVentaRequestModel.customerID);
                TiposPagos TipoPago = RepositoryManager.Instance.TipoPagosRepository.getByID(NewNotaVentaRequestModel.tipoPagoID);
                User Vendedor = RepositoryManager.Instance.UsersRepository.getUserByID(NewNotaVentaRequestModel.vendedorID);
                Banco Banco = RepositoryManager.Instance.BancoRepository.getByID(NewNotaVentaRequestModel.bancoID);
                Sucursal Sucursal = SessionManager.Instance.getUser().Sucursal;

                double millar = NewNotaVentaRequestModel.millar;
                double impresion = NewNotaVentaRequestModel.impresion;
                double otro = NewNotaVentaRequestModel.otro;
                double descuento = NewNotaVentaRequestModel.descuento;
                double grabados = NewNotaVentaRequestModel.grabados;
                double diseno = NewNotaVentaRequestModel.diseno;
                double express = NewNotaVentaRequestModel.express;

                double subtotal = millar + impresion + otro + grabados + diseno + express;
                subtotal = subtotal - descuento;
                double impuesto = subtotal * 1.16;
                double total = subtotal + impuesto;

                double saldo = total - NewNotaVentaRequestModel.abono;

                /*
                    Persist the new nota de venta
                 */

                NotaVenta notaVenta = new NotaVenta();
                notaVenta.fecha = DateTime.Now;
                var src = DateTime.Now;
                notaVenta.hora = src.Hour.ToString() + ":" + src.Minute.ToString() + ":" + src.Second.ToString();
                TimeSpan time = TimeSpan.FromMilliseconds(NewNotaVentaRequestModel.fechaEntrega);
                DateTime startdate = new DateTime(1970, 1, 1) + time;
                notaVenta.fechaEntrega = startdate;
                notaVenta.requiereFactura = NewNotaVentaRequestModel.requiereFactura;
                notaVenta.TiposArchivo = TipoArchivo;
                notaVenta.TipoLaminado = TipoLaminado;
                notaVenta.Product = Product;
                notaVenta.Customer = Customer;
                notaVenta.TipoPago = TipoPago;
                notaVenta.Vendedor = Vendedor;
                notaVenta.Banco = Banco;
                notaVenta.Sucursal = Sucursal;
                notaVenta.observaciones = NewNotaVentaRequestModel.observaciones;                           
                notaVenta.millar = NewNotaVentaRequestModel.millar;
                notaVenta.impresion = NewNotaVentaRequestModel.impresion;
                notaVenta.otro = NewNotaVentaRequestModel.otro;
                notaVenta.descuento = NewNotaVentaRequestModel.descuento;
                notaVenta.grabados = NewNotaVentaRequestModel.grabados;
                notaVenta.diseno = NewNotaVentaRequestModel.diseno;
                notaVenta.express = NewNotaVentaRequestModel.express;
                notaVenta.subtotal = subtotal;
                notaVenta.impuesto = impuesto;
                notaVenta.total = total;
                notaVenta.saldo = saldo;

                RepositoryManager.Instance.NotasVentaRepository.newNotaVenta(notaVenta);

                /*
                    Return all is ok
                 */
                return Json(JSONManager.JsonOk());
            }
            catch (Exception e)
            {
                return Json(JSONManager.JsonFail(e.Message));
            }

        }

        /*
            Edit a nota de venta
             */
        public ActionResult EditNotaVenta(EditNotaVentaRequestModel EditNotaVentaRequestModel)
        {
            try
            {
                /*
                    Validate all fields are filled
                 */
                if (EditNotaVentaRequestModel.cuenta == null || EditNotaVentaRequestModel.cuenta == "")
                {
                    return Json(JSONManager.JsonFail("Need cuenta"));
                }
                if (EditNotaVentaRequestModel.referencia == null || EditNotaVentaRequestModel.referencia == "")
                {
                    return Json(JSONManager.JsonFail("Need referencia"));
                }
                if (EditNotaVentaRequestModel.observaciones == null || EditNotaVentaRequestModel.observaciones == "")
                {
                    return Json(JSONManager.JsonFail("Need observaciones"));
                }

                /*
                    Get the required models
                 */
                TiposArchivo TipoArchivo = RepositoryManager.Instance.TipoArchivosRepository.getByID(EditNotaVentaRequestModel.tipoArchivoID);
                TiposLaminados TipoLaminado = RepositoryManager.Instance.TipoLaminadosRepository.getByID(EditNotaVentaRequestModel.tipoLaminadoID);
                Product Product = RepositoryManager.Instance.ProductsRepository.getProductByID(EditNotaVentaRequestModel.productID);
                Customer Customer = RepositoryManager.Instance.CustomersRepository.getCustomerByID(EditNotaVentaRequestModel.customerID);
                TiposPagos TipoPago = RepositoryManager.Instance.TipoPagosRepository.getByID(EditNotaVentaRequestModel.tipoPagoID);
                User Vendedor = RepositoryManager.Instance.UsersRepository.getUserByID(EditNotaVentaRequestModel.vendedorID);
                Banco Banco = RepositoryManager.Instance.BancoRepository.getByID(EditNotaVentaRequestModel.bancoID);
                Sucursal Sucursal = SessionManager.Instance.getUser().Sucursal;
                NotaVenta NotaVenta = RepositoryManager.Instance.NotasVentaRepository.getById(EditNotaVentaRequestModel.ID);

                double millar = EditNotaVentaRequestModel.millar;
                double impresion = EditNotaVentaRequestModel.impresion;
                double otro = EditNotaVentaRequestModel.otro;
                double descuento = EditNotaVentaRequestModel.descuento;
                double grabados = EditNotaVentaRequestModel.grabados;
                double diseno = EditNotaVentaRequestModel.diseno;
                double express = EditNotaVentaRequestModel.express;

                double subtotal = millar + impresion + otro + grabados + diseno + express;
                subtotal = subtotal - descuento;
                double impuesto = subtotal * 1.16;
                double total = subtotal + impuesto;

                double saldo = total - EditNotaVentaRequestModel.abono;

                /*
                    Edit the nota de venta
                 */
                TimeSpan time = TimeSpan.FromMilliseconds(EditNotaVentaRequestModel.fechaEntrega);
                DateTime startdate = new DateTime(1970, 1, 1) + time;
                NotaVenta.fechaEntrega = startdate;
                NotaVenta.requiereFactura = EditNotaVentaRequestModel.requiereFactura;
                NotaVenta.TiposArchivo = TipoArchivo;
                NotaVenta.TipoLaminado = TipoLaminado;
                NotaVenta.Product = Product;
                NotaVenta.Customer = Customer;
                NotaVenta.TipoPago = TipoPago;
                NotaVenta.Vendedor = Vendedor;
                NotaVenta.Banco = Banco;
                NotaVenta.Sucursal = Sucursal;
                NotaVenta.observaciones = EditNotaVentaRequestModel.observaciones;
                NotaVenta.millar = EditNotaVentaRequestModel.millar;
                NotaVenta.impresion = EditNotaVentaRequestModel.impresion;
                NotaVenta.otro = EditNotaVentaRequestModel.otro;
                NotaVenta.descuento = EditNotaVentaRequestModel.descuento;
                NotaVenta.grabados = EditNotaVentaRequestModel.grabados;
                NotaVenta.diseno = EditNotaVentaRequestModel.diseno;
                NotaVenta.express = EditNotaVentaRequestModel.express;
                NotaVenta.subtotal = subtotal;
                NotaVenta.impuesto = impuesto;
                NotaVenta.total = total;
                NotaVenta.saldo = saldo;

                RepositoryManager.Instance.NotasVentaRepository.editNotaVenta(NotaVenta);

                /*
                    Return all is ok
                 */
                return Json(JSONManager.JsonOk());
            }
            catch (Exception e)
            {
                return Json(JSONManager.JsonFail(e.Message));
            }

        }

        /*
            Edit a nota de venta view
             */
        public ActionResult EditNotaVentaView()
        {
            NotasVentaViewModel NotasVentaViewModel = new NotasVentaViewModel();
            NotasVentaViewModel.Type = TYPE.MODIFY;

            return NotasVenta(NotasVentaViewModel);
        }

        /*
            Return the view for new or edit the nota de venta
             */
        private ActionResult NotaVentaIndex(TYPE type, int ID = -1)
        {
            NotaVentaIndexViewModel NotaVentaIndexViewModel = new NotaVentaIndexViewModel();
            NotaVentaIndexViewModel.Type = type;

            /*
                Get the lists needed
             */
            List<TiposArchivo> TiposArchivos = RepositoryManager.Instance.TipoArchivosRepository.getAll();
            NotaVentaIndexViewModel.TiposArchivos = TiposArchivos;
            List<TiposLaminados> TiposLaminados = RepositoryManager.Instance.TipoLaminadosRepository.getAll();
            NotaVentaIndexViewModel.TiposLaminados = TiposLaminados;
            List<TiposPagos> TiposPagos = RepositoryManager.Instance.TipoPagosRepository.getAll();
            NotaVentaIndexViewModel.TiposPagos = TiposPagos;
            List<Banco> Bancos = RepositoryManager.Instance.BancoRepository.getAll();
            NotaVentaIndexViewModel.Bancos = Bancos;            

            /*
                Get the complete information from the nota de venta
             */
            if (ID != -1)
            {
                NotaVenta NotaVenta = RepositoryManager.Instance.NotasVentaRepository.getById(ID);
                NotaVentaIndexViewModel.NotaVenta = NotaVenta;
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                DateTime today = DateTime.Today;
                var fecha = today.ToString("dddd, dd MMMM yyyy");
                NotaVentaIndexViewModel.fecha = fecha;

                var hora = DateTime.UtcNow.ToString("HH:mm:ss");
                NotaVentaIndexViewModel.hora = hora;

                var fechaEntrega = today.ToString("yyyy-MM-dd");
                NotaVentaIndexViewModel.fechaEntrega = fechaEntrega;

                User user = SessionManager.Instance.getUser();
                var sucursal = user.Sucursal.Name;
                NotaVentaIndexViewModel.sucursal = sucursal;
            }

            return View("~/Views/NotasVenta/Index.cshtml", NotaVentaIndexViewModel);
        }

        /*
            Create a new nota de venta view
             */
        public ActionResult NewNotaVentaView()
        {
            return NotaVentaIndex(TYPE.NEW);
        }

        /*
            View a nota de venta in read only view
             */
        public ActionResult ViewNotaVenta(int ID)
        {
            return NotaVentaIndex(TYPE.VIEW, ID);
        }

        /*
            Edit a nota de venta in Index
             */
        public ActionResult EditNotaVentaIndex(int ID)
        {
            return NotaVentaIndex(TYPE.MODIFY, ID);
        }


        /*
            Delete a nota de venta view
             */
        public ActionResult DeleteNotaVentaView()
        {
            NotasVentaViewModel NotasVentaViewModel = new NotasVentaViewModel();
            NotasVentaViewModel.Type = TYPE.DELETE;

            return NotasVenta(NotasVentaViewModel);
        }

        /*
            Delete nota de venta
             */
        public ActionResult DeleteNotaVenta(DeleteNotaVentaRequestModel DeleteNotaVentaRequestModel)
        {
            try
            {
                /*
                    Validate if the nota de venta exists
                 */
                var NotaVenta = RepositoryManager.Instance.NotasVentaRepository.getById(DeleteNotaVentaRequestModel.ID);
                if (NotaVenta == null)
                {
                    return Json(JSONManager.JsonFail("La nota de venta no existe"));
                }

                /*
                    Delete the nota de venta
                 */

                NotaVenta = RepositoryManager.Instance.NotasVentaRepository.deleteById(DeleteNotaVentaRequestModel.ID);

                /*
                    Return all is ok
                 */
                return Json(JSONManager.JsonOk());
            }
            catch (Exception e)
            {
                return Json(JSONManager.JsonFail(e.Message));
            }
        }

        /*
            View all
             */
        private ActionResult NotasVenta(NotasVentaViewModel NotasVentaViewModel)
        {
            /*
                Get all the notas de venta
             */
            var NotasVenta = RepositoryManager.Instance.NotasVentaRepository.getAll();

            /*
                Create the model view
             */
            NotasVentaViewModel.NotasVenta = NotasVenta;

            return View("~/Views/NotasVenta/NotasVenta.cshtml", NotasVentaViewModel);
        }        
    }
}