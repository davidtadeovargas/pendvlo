using Pendvlo.DAL;
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
         Create a new product
             */
        public int newProduct(Product Product_)
        {
            var result = DBContext.Products.Add(Product_);
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