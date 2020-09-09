using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautyCarePlus_App_ASP.Models;
using BeautyCarePlus_App_ASP.ViewModels;

namespace BeautyCarePlus_App_ASP.Controllers
{
    public class GebruikerController : Controller
    {
        public ActionResult GebruikerLoginView()
        {
            var viewModel = new GebruikerLoginViewModel();
            return View(viewModel);
        }

        public ActionResult LogIn(Gebruiker gebruiker)
        {

            return Content("GebruikerLogin wordt nog niet geredirect");
        }
    }
}