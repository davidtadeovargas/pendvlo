using Pendvlo.Managers;
using Pendvlo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pendvlo.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var currentUser = SessionManager.Instance.getUser();

            var homeViewModel = new HomeViewModel();
            homeViewModel.User = currentUser;

            return View(homeViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}