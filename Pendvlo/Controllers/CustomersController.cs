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
    public class CustomersController : BaseController
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomersViewModel CustomersViewModel_ = new CustomersViewModel();
            CustomersViewModel_.Type = TYPE.LIST;

            return Customers(CustomersViewModel_);
        }

        /*
            Create a new customer
             */
        public ActionResult NewCustomer(NewCustomerRequestModel NewCustomerRequestModel_)
        {
            try
            {
                /*
                Validate all fields are filled
             */
                if (NewCustomerRequestModel_.razon == null || NewCustomerRequestModel_.razon == "")
                {
                    return Json(JSONManager.JsonFail("Need razon"));
                }
                if (NewCustomerRequestModel_.rfc == null || NewCustomerRequestModel_.rfc == "")
                {
                    return Json(JSONManager.JsonFail("Need RFC"));
                }
                if (NewCustomerRequestModel_.address == null || NewCustomerRequestModel_.address == "")
                {
                    return Json(JSONManager.JsonFail("Need Address"));
                }                
                if (NewCustomerRequestModel_.phone == null || NewCustomerRequestModel_.phone == "")
                {
                    return Json(JSONManager.JsonFail("Need phone"));
                }
                if (NewCustomerRequestModel_.city == null || NewCustomerRequestModel_.city == "")
                {
                    return Json(JSONManager.JsonFail("Need city"));
                }
                if (NewCustomerRequestModel_.state == null || NewCustomerRequestModel_.state == "")
                {
                    return Json(JSONManager.JsonFail("Need state"));
                }
                if (NewCustomerRequestModel_.email == null || NewCustomerRequestModel_.email == "")
                {
                    return Json(JSONManager.JsonFail("Need email"));
                }

                /*
                    Validate if the customer exists
                 */
                var Customer_ = RepositoryManager.Instance.CustomersRepository.getCustomerByRFC(NewCustomerRequestModel_.rfc);
                if (Customer_ != null)
                {
                    return Json(JSONManager.JsonFail("El cliente ya existe"));
                }

                /*
                    Persist the new customer
                 */
                User user_ = RepositoryManager.Instance.UsersRepository.getUserByID(NewCustomerRequestModel_.userID);
                if (user_ == null)
                {
                    return Json(JSONManager.JsonFail("El usuario no se encontro"));
                }

                Customer_ = new Customer();
                Customer_.RazonSocial = NewCustomerRequestModel_.razon;
                Customer_.Name = NewCustomerRequestModel_.name;
                Customer_.RFC = NewCustomerRequestModel_.rfc;
                Customer_.Address = NewCustomerRequestModel_.address;
                Customer_.CP = NewCustomerRequestModel_.CP;
                Customer_.Phone = NewCustomerRequestModel_.phone;
                Customer_.City = NewCustomerRequestModel_.city;
                Customer_.State = NewCustomerRequestModel_.state;
                Customer_.email = NewCustomerRequestModel_.email;
                Customer_.Invoice = NewCustomerRequestModel_.invoice == 1 ? true:false;
                Customer_.SalesMan = user_;

                RepositoryManager.Instance.CustomersRepository.newCustomer(Customer_);

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
            Create a new customer view
             */
        public ActionResult NewCustomerView()
        {
            return CustomersIndex(TYPE.NEW);
        }

        private ActionResult CustomersIndex(TYPE type, int ID = -1)
        {
            /*
                Get all the modules
             */
            var users = RepositoryManager.Instance.UsersRepository.getUsers();

            CustomerIndexViewModel customersIndexViewModel = new CustomerIndexViewModel();
            customersIndexViewModel.Type = type;
            customersIndexViewModel.Users = users;

            /*
                Get the complete information from the customer 
             */
            if (ID != -1)
            {
                Customer Customer = RepositoryManager.Instance.CustomersRepository.getCustomerByID(ID);
                customersIndexViewModel.Customer = Customer;
            }

            return View("~/Views/Customers/Index.cshtml", customersIndexViewModel);
        }

        /*
            Edit a cutomer
             */
        public ActionResult EditCustomer(EditCustomerRequestModel EditCustomerRequestModel_)
        {
            try
            {
                /*
                Validate all fields are filled
             */
                if (EditCustomerRequestModel_.razon == null || EditCustomerRequestModel_.razon == "")
                {
                    return Json(JSONManager.JsonFail("Need razon"));
                }
                if (EditCustomerRequestModel_.rfc == null || EditCustomerRequestModel_.rfc == "")
                {
                    return Json(JSONManager.JsonFail("Need RFC"));
                }
                if (EditCustomerRequestModel_.address == null || EditCustomerRequestModel_.address == "")
                {
                    return Json(JSONManager.JsonFail("Need Address"));
                }
                if (EditCustomerRequestModel_.phone == null || EditCustomerRequestModel_.phone == "")
                {
                    return Json(JSONManager.JsonFail("Need phone"));
                }
                if (EditCustomerRequestModel_.city == null || EditCustomerRequestModel_.city == "")
                {
                    return Json(JSONManager.JsonFail("Need city"));
                }
                if (EditCustomerRequestModel_.state == null || EditCustomerRequestModel_.state == "")
                {
                    return Json(JSONManager.JsonFail("Need state"));
                }
                if (EditCustomerRequestModel_.email == null || EditCustomerRequestModel_.email == "")
                {
                    return Json(JSONManager.JsonFail("Need email"));
                }

                /*
                    Get the customer from db
                 */
                var Customer_ = RepositoryManager.Instance.CustomersRepository.getCustomerByRFC(EditCustomerRequestModel_.rfc);
                if (Customer_ == null)
                {
                    return Json(JSONManager.JsonFail("Customer not found"));
                }

                /*
                    Edit the customer
                 */

                User User_= RepositoryManager.Instance.UsersRepository.getUserByID(EditCustomerRequestModel_.ID);

                Customer_.RazonSocial = EditCustomerRequestModel_.razon;
                Customer_.Name = EditCustomerRequestModel_.name;
                Customer_.RFC = EditCustomerRequestModel_.rfc;
                Customer_.Address = EditCustomerRequestModel_.address;
                Customer_.CP = EditCustomerRequestModel_.CP;
                Customer_.Phone = EditCustomerRequestModel_.phone;
                Customer_.City = EditCustomerRequestModel_.city;
                Customer_.State = EditCustomerRequestModel_.state;
                Customer_.email = EditCustomerRequestModel_.email;
                Customer_.Invoice = EditCustomerRequestModel_.invoice==1?true:false;
                Customer_.SalesMan = User_;

                RepositoryManager.Instance.CustomersRepository.editCustomer(Customer_);

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
            Edit a customer view
             */
        public ActionResult EditCustomerView()
        {
            CustomersViewModel CustomersViewModel_ = new CustomersViewModel();
            CustomersViewModel_.Type = TYPE.MODIFY;

            return Customers(CustomersViewModel_);
        }

        /*
            View a customer in read only view
             */
        public ActionResult ViewCustomer(int ID)
        {
            return CustomersIndex(TYPE.VIEW, ID);
        }

        /*
            Edit a customer in Index
             */
        public ActionResult EditCustomerIndex(int ID)
        {
            return CustomersIndex(TYPE.MODIFY, ID);
        }

        /*
            View all the customers
             */
        private ActionResult Customers(CustomersViewModel CustomersViewModel)
        {
            /*
                Get all the users
             */
            var Customers = RepositoryManager.Instance.CustomersRepository.getCustomers();

            /*
                Create the model view
             */
            CustomersViewModel.Customers = Customers;

            return View("~/Views/Customers/Customers.cshtml", CustomersViewModel);
        }        
    }
}