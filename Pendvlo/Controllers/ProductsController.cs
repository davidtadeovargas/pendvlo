using Pendvlo.Managers;
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
        // GET: Product
        public ActionResult Index()
        {
            ProductsViewModel ProductsViewModel_ = new ProductsViewModel();
            ProductsViewModel_.Type = TYPE.LIST;

            return Products(ProductsViewModel_);
        }


        /*
            View all the products
             */
        private ActionResult Products(ProductsViewModel ProductsViewModel_)
        {
            /*
                Get all the products
             */
            var Products = RepositoryManager.Instance.ProductsRepository.getProducts();

            /*
                Create the model view
             */
            ProductsViewModel_.Products = Products;

            return View("~/Views/Products/Products.cshtml", ProductsViewModel_);
        }
    }
}