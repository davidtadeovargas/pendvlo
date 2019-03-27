using Pendvlo.HttpModels;
using Pendvlo.Managers;
using Pendvlo.Models;
using Pendvlo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pendvlo.Controllers
{
    public class ProductsController : BaseController
    {

        public ActionResult Index()
        {
            ProductsViewModel ProductsViewModel = new ProductsViewModel();
            ProductsViewModel.Type = TYPE.LIST;

            return Products(ProductsViewModel);
        }


        /*
            Create a new product
             */
        public ActionResult NewProduct(NewProductRequestModel NewProductRequestModel)
        {
            try
            {
                /*
                    Validate all fields are filled
                 */
                if (NewProductRequestModel.code == null || NewProductRequestModel.code == "")
                {
                    return Json(JSONManager.JsonFail("Need code"));
                }                

                /*
                    Validate if the product exists
                 */
                var Product_ = RepositoryManager.Instance.ProductsRepository.getProductByCode(NewProductRequestModel.code);
                if (Product_ != null)
                {
                    return Json(JSONManager.JsonFail("El producto ya existe"));
                }

                /*
                    Persist the new product
                 */

                Product_ = new Product();
                Product_.code = NewProductRequestModel.code;
                Product_.medidaEje = NewProductRequestModel.medidaEje;
                Product_.medidaDesarrollo = NewProductRequestModel.medidaDesarrollo;
                Product_.repeticionesEje = NewProductRequestModel.repeticionesEje;
                Product_.repeticionesDesarrollo = NewProductRequestModel.repeticionesDesarrollo;
                Product_.separacionEje = NewProductRequestModel.separacionEje;
                Product_.separacionDesarrollo = NewProductRequestModel.separacionDesarrollo;
                Product_.numero = NewProductRequestModel.numero;
                Product_.existencia = NewProductRequestModel.existencia;
                Product_.existenciaRodillos = NewProductRequestModel.existenciaRodillos;
                Product_.papelCoucheMillar = NewProductRequestModel.papelCoucheMillar;
                Product_.papelCoucheMVMillar = NewProductRequestModel.papelCoucheMVMillar;
                Product_.papelCoucheMVCosto = NewProductRequestModel.papelCoucheMVCosto;
                Product_.papelCoucheLMMillar = NewProductRequestModel.papelCoucheLMMillar;
                Product_.papelCoucheLMMinimo = NewProductRequestModel.papelCoucheLMMinimo;
                Product_.papelCoucheD10AMillar = NewProductRequestModel.papelCoucheD10AMillar;
                Product_.papelCoucheD10AMinimo = NewProductRequestModel.papelCoucheD10AMinimo;
                Product_.papelCoucheD15AMinimo = NewProductRequestModel.papelCoucheD15AMinimo;
                Product_.papelCoucheD15AMillar = NewProductRequestModel.papelCoucheD15AMillar;
                Product_.papelCouchePlataMillar = NewProductRequestModel.papelCouchePlataMillar;
                Product_.papelCouchePlataMVMillar = NewProductRequestModel.papelCouchePlataMVMillar;
                Product_.papelCouchePlataMVCosto = NewProductRequestModel.papelCouchePlataMVCosto;
                Product_.papelCouchePlataLMMillar = NewProductRequestModel.papelCouchePlataLMMillar;
                Product_.papelCouchePlataLMMinimo = NewProductRequestModel.papelCouchePlataLMMinimo;
                Product_.papelCouchePlataD10AMillar = NewProductRequestModel.papelCouchePlataD10AMillar;
                Product_.papelCouchePlataD10AMinimo = NewProductRequestModel.papelCouchePlataD10AMinimo;
                Product_.papelCouchePlataD15AMillar = NewProductRequestModel.papelCouchePlataD15AMillar;
                Product_.papelCouchePlataD15AMinimo = NewProductRequestModel.papelCouchePlataD15AMinimo;
                Product_.boppPoliesterBlancoTransMillar = NewProductRequestModel.boppPoliesterBlancoTransMillar;
                Product_.boppPoliesterBlancoTransMVMillar = NewProductRequestModel.boppPoliesterBlancoTransMVMillar;
                Product_.boppPoliesterBlancoTransMVCosto = NewProductRequestModel.boppPoliesterBlancoTransMVCosto;
                Product_.boppPoliesterBlancoTransLMMillar = NewProductRequestModel.boppPoliesterBlancoTransLMMillar;
                Product_.boppPoliesterBlancoTransLMMinimo = NewProductRequestModel.boppPoliesterBlancoTransLMMinimo;
                Product_.boppPoliesterBlancoTransD10AMillar = NewProductRequestModel.boppPoliesterBlancoTransD10AMillar;
                Product_.boppPoliesterBlancoTransD10AMinimo = NewProductRequestModel.boppPoliesterBlancoTransD10AMinimo;
                Product_.boppPoliesterBlancoTransD15AMillar = NewProductRequestModel.boppPoliesterBlancoTransD15AMillar;
                Product_.boppPoliesterBlancoTransD15AMinimo = NewProductRequestModel.boppPoliesterBlancoTransD15AMinimo;
                Product_.boppPoliesterPlataMillar = NewProductRequestModel.boppPoliesterPlataMillar;
                Product_.boppPoliesterPlataMVMillar = NewProductRequestModel.boppPoliesterPlataMVMillar;
                Product_.boppPoliesterPlataMVCosto = NewProductRequestModel.boppPoliesterPlataMVCosto;
                Product_.boppPoliesterPlataLMMillar = NewProductRequestModel.boppPoliesterPlataLMMillar;
                Product_.boppPoliesterPlataLMMinimo = NewProductRequestModel.boppPoliesterPlataLMMinimo;
                Product_.boppPoliesterPlataD10AMillar = NewProductRequestModel.boppPoliesterPlataD10AMillar;
                Product_.boppPoliesterPlataD10AMinimo = NewProductRequestModel.boppPoliesterPlataD10AMinimo;
                Product_.boppPoliesterPlataD15AMillar = NewProductRequestModel.boppPoliesterPlataD15AMillar;
                Product_.boppPoliesterPlataD15AMinimo = NewProductRequestModel.boppPoliesterPlataD15AMinimo;

                RepositoryManager.Instance.ProductsRepository.newProduct(Product_);

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
            Edit a new user
             */
        public ActionResult EditProduct(EditProductRequestModel EditProductRequestModel)
        {
            try
            {
                /*
                    Validate all fields are filled
                 */
                if (EditProductRequestModel.code == null || EditProductRequestModel.code == "")
                {
                    return Json(JSONManager.JsonFail("Need code"));
                }                

                /*
                    Get the product from db
                 */
                var Product_ = RepositoryManager.Instance.ProductsRepository.getProductByID(EditProductRequestModel.ID);
                if (Product_ == null)
                {
                    return Json(JSONManager.JsonFail("Product not found"));
                }

                /*
                    Edit the product
                 */

                //Product_.code = EditProductRequestModel.code; //This one is not editable, is like the primary key
                Product_.medidaEje = EditProductRequestModel.medidaEje;
                Product_.medidaDesarrollo = EditProductRequestModel.medidaDesarrollo;
                Product_.repeticionesEje = EditProductRequestModel.repeticionesEje;
                Product_.repeticionesDesarrollo = EditProductRequestModel.repeticionesDesarrollo;
                Product_.separacionEje = EditProductRequestModel.separacionEje;
                Product_.separacionDesarrollo = EditProductRequestModel.separacionDesarrollo;
                Product_.numero = EditProductRequestModel.numero;
                Product_.existencia = EditProductRequestModel.existencia;
                Product_.existenciaRodillos = EditProductRequestModel.existenciaRodillos;
                Product_.papelCoucheMillar = EditProductRequestModel.papelCoucheMillar;
                Product_.papelCoucheMVMillar = EditProductRequestModel.papelCoucheMVMillar;
                Product_.papelCoucheMVCosto = EditProductRequestModel.papelCoucheMVCosto;
                Product_.papelCoucheLMMillar = EditProductRequestModel.papelCoucheLMMillar;
                Product_.papelCoucheLMMinimo = EditProductRequestModel.papelCoucheLMMinimo;
                Product_.papelCoucheD10AMillar = EditProductRequestModel.papelCoucheD10AMillar;
                Product_.papelCoucheD10AMinimo = EditProductRequestModel.papelCoucheD10AMinimo;
                Product_.papelCoucheD15AMinimo = EditProductRequestModel.papelCoucheD15AMinimo;
                Product_.papelCoucheD15AMillar = EditProductRequestModel.papelCoucheD15AMillar;
                Product_.papelCouchePlataMillar = EditProductRequestModel.papelCouchePlataMillar;
                Product_.papelCouchePlataMVMillar = EditProductRequestModel.papelCouchePlataMVMillar;
                Product_.papelCouchePlataMVCosto = EditProductRequestModel.papelCouchePlataMVCosto;
                Product_.papelCouchePlataLMMillar = EditProductRequestModel.papelCouchePlataLMMillar;
                Product_.papelCouchePlataLMMinimo = EditProductRequestModel.papelCouchePlataLMMinimo;
                Product_.papelCouchePlataD10AMillar = EditProductRequestModel.papelCouchePlataD10AMillar;
                Product_.papelCouchePlataD10AMinimo = EditProductRequestModel.papelCouchePlataD10AMinimo;                
                Product_.papelCouchePlataD15AMillar = EditProductRequestModel.papelCouchePlataD15AMillar;
                Product_.papelCouchePlataD15AMinimo = EditProductRequestModel.papelCouchePlataD15AMinimo;
                Product_.boppPoliesterBlancoTransMillar = EditProductRequestModel.boppPoliesterBlancoTransMillar;
                Product_.boppPoliesterBlancoTransMVMillar = EditProductRequestModel.boppPoliesterBlancoTransMVMillar;
                Product_.boppPoliesterBlancoTransMVCosto = EditProductRequestModel.boppPoliesterBlancoTransMVCosto;
                Product_.boppPoliesterBlancoTransLMMillar = EditProductRequestModel.boppPoliesterBlancoTransLMMillar;
                Product_.boppPoliesterBlancoTransLMMinimo = EditProductRequestModel.boppPoliesterBlancoTransLMMinimo;
                Product_.boppPoliesterBlancoTransD10AMillar = EditProductRequestModel.boppPoliesterBlancoTransD10AMillar;
                Product_.boppPoliesterBlancoTransD10AMinimo = EditProductRequestModel.boppPoliesterBlancoTransD10AMinimo;
                Product_.boppPoliesterBlancoTransD15AMillar = EditProductRequestModel.boppPoliesterBlancoTransD15AMillar;
                Product_.boppPoliesterBlancoTransD15AMinimo = EditProductRequestModel.boppPoliesterBlancoTransD15AMinimo;
                Product_.boppPoliesterPlataMillar = EditProductRequestModel.boppPoliesterPlataMillar;
                Product_.boppPoliesterPlataMVMillar = EditProductRequestModel.boppPoliesterPlataMVMillar;
                Product_.boppPoliesterPlataMVCosto = EditProductRequestModel.boppPoliesterPlataMVCosto;
                Product_.boppPoliesterPlataLMMillar = EditProductRequestModel.boppPoliesterPlataLMMillar;
                Product_.boppPoliesterPlataLMMinimo = EditProductRequestModel.boppPoliesterPlataLMMinimo;
                Product_.boppPoliesterPlataD10AMillar = EditProductRequestModel.boppPoliesterPlataD10AMillar;
                Product_.boppPoliesterPlataD10AMinimo = EditProductRequestModel.boppPoliesterPlataD10AMinimo;
                Product_.boppPoliesterPlataD15AMillar = EditProductRequestModel.boppPoliesterPlataD15AMillar;
                Product_.boppPoliesterPlataD15AMinimo = EditProductRequestModel.boppPoliesterPlataD15AMinimo;

                RepositoryManager.Instance.ProductsRepository.editProduct(Product_);

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
            Edit a product view
             */
        public ActionResult EditProductView()
        {
            ProductsViewModel ProductsViewModel = new ProductsViewModel();
            ProductsViewModel.Type = TYPE.MODIFY;

            return Products(ProductsViewModel);
        }

        /*
            Return the view for new or edit the product
             */
        private ActionResult ProductsIndex(TYPE type, int ID = -1)
        {
            ProductsIndexViewModel ProductsIndexViewModel = new ProductsIndexViewModel();
            ProductsIndexViewModel.Type = type;            

            /*
                Get the complete information from the account
             */
            if (ID != -1)
            {
                Product Product_ = RepositoryManager.Instance.ProductsRepository.getProductByID(ID);
                ProductsIndexViewModel.Product = Product_;
            }

            return View("~/Views/Products/Index.cshtml", ProductsIndexViewModel);
        }

        /*
            Create a new product view
             */
        public ActionResult NewProductView()
        {
            return ProductsIndex(TYPE.NEW);
        }

        /*
            View a product in read only view
             */
        public ActionResult ViewProduct(int ID)
        {
            return ProductsIndex(TYPE.VIEW, ID);
        }

        /*
            Edit an account in Index
             */
        public ActionResult EditProductIndex(int ID)
        {
            return ProductsIndex(TYPE.MODIFY, ID);
        }


        /*
            Delete a product view
             */
        public ActionResult DeleteProductView()
        {
            ProductsViewModel ProductsViewModel = new ProductsViewModel();
            ProductsViewModel.Type = TYPE.DELETE;

            return Products(ProductsViewModel);
        }

        /*
            Delete product
             */
        public ActionResult DeleteProduct(DeleteProductRequestModel DeleteProductRequestModel)
        {
            try
            {
                /*
                    Validate if the product exists
                 */
                var Product = RepositoryManager.Instance.ProductsRepository.getProductByID(DeleteProductRequestModel.ID);
                if (Product == null)
                {
                    return Json(JSONManager.JsonFail("El producto no existe"));
                }

                /*
                    Delete the product
                 */

                Product = RepositoryManager.Instance.ProductsRepository.deleteById(DeleteProductRequestModel.ID);

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
            View all products
             */
        private ActionResult Products(ProductsViewModel ProductsViewModel)
        {
            /*
                Get all the products
             */
            var Products = RepositoryManager.Instance.ProductsRepository.getProducts();

            /*
                Create the model view
             */
            ProductsViewModel.Products = Products;

            return View("~/Views/Products/Products.cshtml", ProductsViewModel);
        }        
    }
}