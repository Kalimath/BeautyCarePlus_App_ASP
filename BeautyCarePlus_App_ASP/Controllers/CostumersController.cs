using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeautyCarePlus_App_ASP.Models;
using BeautyCarePlus_App_ASP.ViewModels;

namespace BeautyCarePlus_App_ASP.Controllers
{
    
    //[Authorize]
    public class CostumersController : Controller
    {
        public DatabaseService databaseService = new DatabaseService();

        // GET: Account
        public ActionResult CustomersList()
        {
            CustomersListViewModel viewModel = new CustomersListViewModel();
            viewModel.CustomerList = new List<Customer>();
            viewModel.CustomerList.Add(new Customer()
            {
                Name = "Mathieu Broeckhoven",
                Adres = "Peulisbaan 124F 2580 Putte",
                BirthDate = new DateTime(1998, 12, 27),
                InitialWeight = 60.5
            }) ;
                viewModel = new CustomersListViewModel();
                return View(viewModel);
        }
    }
}