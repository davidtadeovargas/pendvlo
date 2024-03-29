﻿using Pendvlo.DAL;
using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.Repository
{
    public class ProductsRepository : Repository
    {
        public ProductsRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all te products
             */
        public List<Product> getProducts()
        {
            List<Product> Products_ = DBContext.Products.ToList();
            return Products_;
        }

        /*
         Get limited products
             */
        public List<Product> getLimitedProducts(int limited, bool descending)
        {
            List<Product> Products_ = new List<Product>();
            if (descending)
            {
                Products_ = DBContext.Products.OrderByDescending(u => u.ID).Take(limited).ToList();
            }
            else
            {
                Products_ = DBContext.Products.OrderBy(u => u.ID).Take(limited).ToList();
            }
            
            return Products_;
        }

        /*
         Get limited products
             */
        public List<Product> getFilteredProducts(string code)
        {
            List<Product> Products_ = DBContext.Products.SqlQuery("Select ID," +
                                                                        " code," +
                                                                        " medidaEje," +
                                                                        " medidaDesarrollo," +
                                                                        " repeticionesEje, " +
                                                                        " repeticionesDesarrollo, " +
                                                                        " separacionEje," +
                                                                        " separacionDesarrollo," +
                                                                        " numero, " +
                                                                        " existencia," +
                                                                        " existenciaRodillos," +
                                                                        " papelCoucheMillar," +
                                                                        " papelCoucheMVMillar," +
                                                                        " papelCoucheMVCosto, " +
                                                                        " papelCoucheLMMillar," +
                                                                        " papelCoucheLMMinimo, " +
                                                                        " papelCoucheD10AMillar," +
                                                                        " papelCoucheD10AMinimo, " +
                                                                        " papelCoucheD15AMillar, " +
                                                                        " papelCoucheD15AMinimo, " +
                                                                        " papelCouchePlataMillar, " +
                                                                        " papelCouchePlataMVMillar, " +
                                                                        " papelCouchePlataMVCosto, " +
                                                                        " papelCouchePlataLMMillar," +
                                                                        " papelCouchePlataLMMinimo," +
                                                                        " papelCouchePlataD10AMillar, " +
                                                                        " papelCouchePlataD10AMinimo," +
                                                                        " papelCouchePlataD15AMillar," +
                                                                        " papelCouchePlataD15AMinimo," +
                                                                        " boppPoliesterBlancoTransMillar," +
                                                                        " boppPoliesterBlancoTransMVMillar," +
                                                                        " boppPoliesterBlancoTransMVCosto," +
                                                                        " boppPoliesterBlancoTransLMMillar," +
                                                                        " boppPoliesterBlancoTransLMMinimo," +
                                                                        " boppPoliesterBlancoTransD10AMillar," +
                                                                        " boppPoliesterBlancoTransD10AMinimo," +
                                                                        " boppPoliesterBlancoTransD15AMillar," + 
                                                                        " boppPoliesterBlancoTransD15AMinimo," +
                                                                        " boppPoliesterPlataMillar," +
                                                                        " boppPoliesterPlataMVMillar," +
                                                                        " boppPoliesterPlataMVCosto," +
                                                                        " boppPoliesterPlataLMMillar," +
                                                                        " boppPoliesterPlataLMMinimo," +
                                                                        " boppPoliesterPlataD10AMillar," +
                                                                        " boppPoliesterPlataD10AMinimo," +
                                                                        " boppPoliesterPlataD15AMillar," +
                                                                        " boppPoliesterPlataD15AMinimo," +
                                                                        " descrip," +
                                                                        " price," +
                                                                        " tax," +
                                                                        " material," +
                                                                        " descuento," +
                                                                        " precioXImpresion," +
                                                                        " precioXGrabado," +
                                                                        " precioXDiseno," +
                                                                        " precioExpress," +
                                                                        " avaible," +
                                                                        " sales, " + 
                                                                        " Created from Products where code like('%" + code + "%')").ToList();
            foreach (var Product in Products_)
            {
                Product.CreatedString = Product.Created.ToString("dd-MM-yyyy");
            }

            return Products_;
        }

        /*
         Create a new product
             */
        public int newProduct(Product Product_)
        {
            var result = DBContext.Products.Add(Product_);
            DBContext.SaveChanges();
            return result.ID;
        }

        /*
         Create tests products
             */
        public int createTestsProducts()
        {
            Product Product = new Product();
            Product.code = "PROD1";
            var result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD2";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD3";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD4";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD5";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD6";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD7";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD8";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD9";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD10";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD11";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD12";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD13";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            Product = new Product();
            Product.code = "PROD14";
            result = DBContext.Products.Add(Product);
            DBContext.SaveChanges();

            return result.ID;
        }

        /*
         Edit a product
             */
        public int editProduct(Product Product_)
        {
            DBContext.Entry(Product_).State = System.Data.Entity.EntityState.Modified;
            var result = DBContext.SaveChanges();
            return result;
        }

        /*
         Get product by id
             */
        public Product getProductByID(int id)
        {
            Product Product_ = DBContext.Products.Where(m => m.ID == id).FirstOrDefault();
            return Product_;
        }

        /*
         Get product by code
             */
        public Product getProductByCode(string code)
        {
            Product Product_ = DBContext.Products.Where(m => m.code == code).FirstOrDefault();
            return Product_;
        }

        /*
         Delete a product
             */
        public Product deleteById(int id)
        {
            Product Product_ = getProductByID(id);
            DBContext.Products.Remove(Product_);
            DBContext.SaveChanges();
            return Product_;
        }
    }
}