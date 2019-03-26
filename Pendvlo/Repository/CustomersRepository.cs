using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;

namespace Pendvlo.Repository
{
    public class CustomersRepository : Repository
    {
        public CustomersRepository(DBContext dBContext) : base(dBContext)
        {

        }

        /*
         Get all te customers
             */
        public List<Customer> getCustomers()
        {
            List<Customer> Customers_ = DBContext.Customers.ToList();
            return Customers_;
        }

        /*
         Create a new customer
             */
        public int newCustomer(Customer Customer_)
        {
            var result = DBContext.Customers.Add(Customer_);
            DBContext.SaveChanges();
            return result.ID;
        }

        /*
         Edit a customer
             */
        public int editCustomer(Customer Customer_)
        {
            DBContext.Entry(Customer_).State = System.Data.Entity.EntityState.Modified;
            var result = DBContext.SaveChanges();
            return result;
        }

        /*
         Get customer by name
             */
        public Customer getCustomerByID(int id)
        {
            Customer Customer_ = DBContext.Customers.Where(m => m.ID == id).FirstOrDefault();
            return Customer_;
        }

        /*
         Get customer by rfc
             */
        public Customer getCustomerByRFC(string rfc)
        {
            Customer Customer_ = DBContext.Customers.Where(m => m.RFC == rfc).FirstOrDefault();
            return Customer_;
        }

        /*
         Delete a customer
             */
        public Customer deleteById(int id)
        {
            Customer Customer_ = getCustomerByID(id);
            DBContext.Customers.Remove(Customer_);
            DBContext.SaveChanges();
            return Customer_;
        }
    }
}