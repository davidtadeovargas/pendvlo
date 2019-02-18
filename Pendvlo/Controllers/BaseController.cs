using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Pendvlo.Controllers
{
    public class BaseController : Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string actionName = filterContext.ActionDescriptor.ActionName;
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;

            /*
                If session is already set go to main page
             */
            if (Session["user"] == null)
            {
                /*
                    To prevent infinity loop in login controller
                 */
                if (controllerName.ToLower().CompareTo("login")!=0)
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                    {
                        controller = "Login",
                        action = "Index"
                    }));
                }
            }
        }
    }
}