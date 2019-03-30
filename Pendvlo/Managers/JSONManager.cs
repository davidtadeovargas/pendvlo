using Newtonsoft.Json;
using Pendvlo.HttpModels;
using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Pendvlo.Managers
{
    public class JSONManager
    {
        public static Result JsonOk()
        {
            Result result = new Result();
            result.Result_ = 1;

            return result;
        }

        public static Result JsonFail(string error)
        {
            Result result = new Result();
            result.Result_ = -1;
            result.error = error;

            return result;
        }

        public static Result JsonFilteredProducts(List<Product> Products)
        {

            GetFilteredProductsResponseModel GetFilteredProductsResponseModel = new GetFilteredProductsResponseModel();
            GetFilteredProductsResponseModel.Result_ = 1;
            GetFilteredProductsResponseModel.Products = Products;

            return GetFilteredProductsResponseModel;
        }
    }
}