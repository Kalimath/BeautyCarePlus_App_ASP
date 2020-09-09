using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautyCarePlus_App_ASP.Models;
using BeautyCarePlus_App_ASP.ViewModels;

namespace BeautyCarePlus_App_ASP.Controllers
{
    public class UserController : Controller
    {
        public ActionResult UserLoginView()
        {
            var viewModel = new UserLoginViewModel();
            return View(viewModel);
        }

        public ActionResult LogIn(User user)
        {

            return Content("GebruikerLogin wordt nog niet geredirect");
        }
    }
}