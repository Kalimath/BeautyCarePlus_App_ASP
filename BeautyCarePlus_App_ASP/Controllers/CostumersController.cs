using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautyCarePlus_App_ASP.Models;

namespace BeautyCarePlus_App_ASP.Controllers
{
    
    //[Authorize]
    public class CostumersController : Controller
    {
        public List<Customer> db = new List<Customer>()
        {

        };

        // GET: Account
        public ActionResult Index()
        {

            return View();
        }
    }
}