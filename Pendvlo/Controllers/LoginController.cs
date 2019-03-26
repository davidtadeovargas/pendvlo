using Pendvlo.HttpModels;
using Pendvlo.Managers;
using Pendvlo.Models;
using System.Web.Mvc;

namespace Pendvlo.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        //Validate credentials for login
        [HttpPost]
        public JsonResult ValidateCredentials(LoginRequestModel loginRequestModel)
        {

            User User_ =  RepositoryManager.Instance.LoginRepository.validateLogin(loginRequestModel.user, loginRequestModel.password);

            Result response;

            if (User_ != null)
            {
                SessionManager.Instance.setUser(this, User_);
                response = JSONManager.JsonOk();
            }
            else
            {
                response = JSONManager.JsonFail("Invalid Credentials");
            }

            return Json(response);
        }

        /*
            Logout from the app
             */
        public ActionResult logout()
        {
            SessionManager.Instance.logoutUser(this) ;            
            return RedirectToAction("index", "login");
        }
    }
}