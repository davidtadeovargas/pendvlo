using Pendvlo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pendvlo.DAL;
using Pendvlo.Managers;

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
         Create test customers
             */
        public int createTestsCustomers()
        {
            var salesMan = RepositoryManager.Instance.UsersRepository.getSuperAdmin();

            Customer customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            var result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            customer = new Customer();
            customer.RazonSocial = "Mi razon social";
            customer.Name = "Mi nombre";
            customer.RFC = "VAVY910708LNA";
            customer.Address = "Rio tinto colonia centro";
            customer.CP = 44150;
            customer.Phone = "3310644917";
            customer.City = "Guadalajara";
            customer.State = "Jalisco";
            customer.email = "email@hotmail.com";
            customer.Invoice = true;
            customer.SalesMan = salesMan;
            result = DBContext.Customers.Add(customer);
            DBContext.SaveChanges();

            return result.ID;
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