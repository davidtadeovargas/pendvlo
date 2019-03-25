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
    public class CuentasBancariasController : BaseController
    {
        public ActionResult Index()
        {
            AccountsViewModel AccountsViewModel = new AccountsViewModel();
            AccountsViewModel.Type = TYPE.LIST;

            return Cuentas(AccountsViewModel);
        }
        

        /*
            Create a new account
             */
        public ActionResult NewAccount(NewAccountRequestModel NewAccountRequestModel)
        {
            try
            {
                /*
                    Validate all fields are filled
                 */
                if (NewAccountRequestModel.titular == null || NewAccountRequestModel.titular == "")
                {
                    return Json(JSONManager.JsonFail("Falta titular"));
                }
                if (NewAccountRequestModel.cuenta == null || NewAccountRequestModel.cuenta == "")
                {
                    return Json(JSONManager.JsonFail("Falta cuenta"));
                }
                if (NewAccountRequestModel.tarjeta == null || NewAccountRequestModel.tarjeta == "")
                {
                    return Json(JSONManager.JsonFail("Falta tarjeta"));
                }
                if (NewAccountRequestModel.clabe == null || NewAccountRequestModel.clabe == "")
                {
                    return Json(JSONManager.JsonFail("Falta clabe"));
                }

                /*
                    Validate if the account exists
                 */
                var Cuenta = RepositoryManager.Instance.CuentasRepository.getByAccount(NewAccountRequestModel.cuenta);
                if (Cuenta != null)
                {
                    return Json(JSONManager.JsonFail("La cuenta ya existe"));
                }

               /*
                   Persist the new account
                */

                Banco banco = RepositoryManager.Instance.BancoRepository.getByID(NewAccountRequestModel.Banco); //Get the bank

                Cuenta cuenta = new Cuenta();
                cuenta.titular = NewAccountRequestModel.titular;
                cuenta.Banco = banco;
                cuenta.cuenta = NewAccountRequestModel.cuenta;
                cuenta.tarjeta = NewAccountRequestModel.tarjeta;
                cuenta.clabe = NewAccountRequestModel.clabe;

                RepositoryManager.Instance.CuentasRepository.newAccount(cuenta);

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
            Edit an account
             */
        public ActionResult EditAccount(EditAccountRequestModel EditAccountRequestModel)
        {
            try
            {
                /*
                    Validate all fields are filled
                 */
                if (EditAccountRequestModel.titular == null || EditAccountRequestModel.titular == "")
                {
                    return Json(JSONManager.JsonFail("Falta titular"));
                }
                if (EditAccountRequestModel.cuenta == null || EditAccountRequestModel.cuenta == "")
                {
                    return Json(JSONManager.JsonFail("Falta cuenta"));
                }
                if (EditAccountRequestModel.tarjeta == null || EditAccountRequestModel.tarjeta == "")
                {
                    return Json(JSONManager.JsonFail("Falta tarjeta"));
                }
                if (EditAccountRequestModel.clabe == null || EditAccountRequestModel.clabe == "")
                {
                    return Json(JSONManager.JsonFail("Falta clabe"));
                }

                /*
                    Get the account from db
                 */
                var cuenta = RepositoryManager.Instance.CuentasRepository.getByAccount(EditAccountRequestModel.cuenta);
                if (cuenta == null)
                {
                    return Json(JSONManager.JsonFail("Cuenta not found"));
                }

                /*
                    Edit the account
                 */

                Banco banco = RepositoryManager.Instance.BancoRepository.getByID(EditAccountRequestModel.Banco); //Get the bank

                cuenta.titular = EditAccountRequestModel.titular;
                cuenta.Banco = banco;
                //cuenta.cuenta = EditAccountRequestModel.cuenta; // Account is not editable, it is like the primary key
                cuenta.tarjeta = EditAccountRequestModel.tarjeta;
                cuenta.clabe = EditAccountRequestModel.clabe;

                RepositoryManager.Instance.CuentasRepository.editAccount(cuenta);

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
            Edit account view
             */
        public ActionResult EditUserView()
        {
            AccountsViewModel AccountsViewModel = new AccountsViewModel();
            AccountsViewModel.Type = TYPE.MODIFY;

            return Cuentas(AccountsViewModel);           
        }

        /*
            Return the view for new or edit the account
        */
        private ActionResult AccountsIndex(TYPE type, int accountId = -1)
        {
            /*
                Get all the banks
             */
            var banks = RepositoryManager.Instance.BancoRepository.getAll();

            AccountsViewModel AccountsViewModel = new AccountsViewModel();
            AccountsViewModel.Type = type;
            AccountsViewModel.Banks = banks;            

            /*
                Get the complete information from the account
             */
            if (accountId != -1)
            {
                Cuenta Cuenta_ = RepositoryManager.Instance.CuentasRepository.getByID(accountId);
                AccountsViewModel.Cuenta = Cuenta_;
            }            

            return View("~/Views/CuentasBancarias/Index.cshtml", AccountsViewModel);
        }

        /*
            Create a new account view
             */
        public ActionResult NewAccountView()
        {
            return AccountsIndex(TYPE.NEW);
        }

        /*
            Edit an account
             */
        public ActionResult EditAccountIndex(int accountId)
        {
            return AccountsIndex(TYPE.MODIFY, accountId);
        }


        /*
            Edit account view
             */
        public ActionResult EditAccountView()
        {
            AccountsViewModel AccountsViewModel = new AccountsViewModel();
            AccountsViewModel.Type = TYPE.MODIFY;

            return Cuentas(AccountsViewModel);
        }

        /*
            Delete account view
             */
        public ActionResult DeleteAccountView()
        {
            AccountsViewModel AccountsViewModel = new AccountsViewModel();
            AccountsViewModel.Type = TYPE.DELETE;

            return Cuentas(AccountsViewModel);
        }

        /*
            Delete account
             */
        public ActionResult DeleteAccount(DeleteAccountRequestModel DeleteAccountRequestModel)
        {
            try
            {
                /*
                    Validate if the account exists
                 */
                var Cuenta = RepositoryManager.Instance.CuentasRepository.getByID(DeleteAccountRequestModel.ID);
                if (Cuenta == null)
                {
                    return Json(JSONManager.JsonFail("La cuenta no existe"));
                }

                /*
                    Delete the account
                 */

                Cuenta = RepositoryManager.Instance.CuentasRepository.deleteById(DeleteAccountRequestModel.ID);
                                
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
            View all users
             */
        private ActionResult Cuentas(AccountsViewModel AccountsViewModel)
        {
            /*
                Get all the accounts
             */
            var Accounts = RepositoryManager.Instance.CuentasRepository.getAll();

            /*
                Create the model view
             */
            AccountsViewModel.Cuentas = Accounts;            

            return View("~/Views/CuentasBancarias/Cuentas.cshtml", AccountsViewModel);
        }
    }
}