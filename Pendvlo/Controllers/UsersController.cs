using Pendvlo.Managers;
using Pendvlo.Models;
using Pendvlo.Models.Http;
using Pendvlo.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pendvlo.Controllers
{
    public class UsersController : BaseController
    {
        public ActionResult Index()
        {
            UsersViewModel usersViewModel = new UsersViewModel();
            usersViewModel.Type = TYPE.LIST;

            return Users(usersViewModel);
        }
        

        /*
            Create a new user
             */
        public ActionResult NewUser(NewUserRequestModel newUserRequestModel)
        {
            try
            {
                /*
                Validate all fields are filled
             */
                if (newUserRequestModel.Name == null || newUserRequestModel.Name == "")
                {
                    return Json(JSONManager.JsonFail("Need Name"));
                }
                if (newUserRequestModel.User == null || newUserRequestModel.User == "")
                {
                    return Json(JSONManager.JsonFail("Need User"));
                }
                if (newUserRequestModel.Password == null || newUserRequestModel.Password == "")
                {
                    return Json(JSONManager.JsonFail("Need Password"));
                }

                /*
                    Validate if the user exists
                 */
                var User = RepositoryManager.Instance.UsersRepository.getUserByUser(newUserRequestModel.User);
                if (User != null)
                {
                    return Json(JSONManager.JsonFail("El usuario ya existe"));
                }

               /*
                   Persist the new user
                */

               Module module_ = RepositoryManager.Instance.ModulesRepository.getByID(newUserRequestModel.Module);

                User User_ = new User();
                User_.Name = newUserRequestModel.Name;
                User_.User_ = newUserRequestModel.User;
                User_.Password = newUserRequestModel.Password;
                User_.Sales = newUserRequestModel.Sales;
                User_.Module = module_;

                RepositoryManager.Instance.UsersRepository.newUser(User_);

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
        public ActionResult EditUser(EditUserRequestModel editUserRequestModel)
        {
            try
            {
                /*
                Validate all fields are filled
             */
                if (editUserRequestModel.Name == null || editUserRequestModel.Name == "")
                {
                    return Json(JSONManager.JsonFail("Need Name"));
                }
                if (editUserRequestModel.User == null || editUserRequestModel.User == "")
                {
                    return Json(JSONManager.JsonFail("Need User"));
                }
                if (editUserRequestModel.Password == null || editUserRequestModel.Password == "")
                {
                    return Json(JSONManager.JsonFail("Need Password"));
                }

                /*
                    Get the user from db
                 */
                var User_ = RepositoryManager.Instance.UsersRepository.getUserByUser(editUserRequestModel.User);
                if (User_ == null)
                {
                    return Json(JSONManager.JsonFail("User not found"));
                }

                /*
                    Edit the new user
                 */

                Module module_ = RepositoryManager.Instance.ModulesRepository.getByID(editUserRequestModel.Module);

                User_.Name = editUserRequestModel.Name;                
                User_.Password = editUserRequestModel.Password;
                User_.Sales = editUserRequestModel.Sales;
                User_.Module = module_;

                RepositoryManager.Instance.UsersRepository.editUser(User_);

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
            Edit a user view
             */
        public ActionResult EditUserView()
        {
            UsersViewModel usersViewModel = new UsersViewModel();
            usersViewModel.Type = TYPE.MODIFY;

            return Users(usersViewModel);           
        }

        private ActionResult UsersIndex(TYPE type, int ID = -1)
        {
            /*
                Get all the modules
             */
            var modules = RepositoryManager.Instance.ModulesRepository.getModules();

            UsersIndexViewModel usersViewModel = new UsersIndexViewModel();
            usersViewModel.Type = type;
            usersViewModel.Modules = modules;

            /*
                Get the complete information from the user 
             */
            if (ID != -1)
            {
                User User_ = RepositoryManager.Instance.UsersRepository.getUserByID(ID);
                usersViewModel.User = User_;
            }            

            return View("~/Views/Users/Index.cshtml", usersViewModel);
        }

        /*
            Create a new user view
             */
        public ActionResult NewUserView()
        {
            return UsersIndex(TYPE.NEW);
        }

        /*
            Edit a user in Index
             */
        public ActionResult EditUserIndex(int ID)
        {
            return UsersIndex(TYPE.MODIFY,ID);
        }


        /*
            Delete a user view
             */
        public ActionResult DeleteUserView()
        {
            UsersViewModel usersViewModel = new UsersViewModel();
            usersViewModel.Type = TYPE.DELETE;

            return Users(usersViewModel);
        }

        /*
            Delete a user
             */
        public ActionResult DeleteUser(DeleteUserRequestModel deleteUserRequestModel)
        {
            try
            {
                /*
                    Validate if the user exists
                 */
                var User = RepositoryManager.Instance.UsersRepository.getUserByID(deleteUserRequestModel.ID);
                if (User == null)
                {
                    return Json(JSONManager.JsonFail("El usuario no existe"));
                }

                /*
                    Validate if the user is not the admin user                    
                 */
                if (User.User_ == "admin")
                {
                    return Json(JSONManager.JsonFail("No se puede eliminar al usuario administrador"));
                }

                /*
                    Delete the user
                 */

                User = RepositoryManager.Instance.UsersRepository.deleteById(deleteUserRequestModel.ID);
                                
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
        private ActionResult Users(UsersViewModel usersViewModel)
        {
            /*
                Get all the users
             */
            var Users = RepositoryManager.Instance.UsersRepository.getUsers();

            /*
                Create the model view
             */
            usersViewModel.Users = Users;            

            return View("~/Views/Users/Users.cshtml", usersViewModel);
        }
    }
}