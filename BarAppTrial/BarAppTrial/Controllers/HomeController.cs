using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarAppTrial.Models;
using BarAppTrial.Repositories;


namespace BarAppTrial.Controllers
{
    public class HomeController : Controller
    {
        //public Drinks myDrinks;
        private IDrinksRepository repository;
        
        public HomeController(IDrinksRepository drinkRepository)
        {
            this.repository = drinkRepository;
        }

        public ViewResult Index()
        {             
            DrinkListViewModel model = new DrinkListViewModel
            {
                TheDrinksListView = repository.Drinks,

            };
           return View(model);
        }

        public ActionResult CreateOrder()
        {
            DrinkListViewModel model2 = new DrinkListViewModel
            {
                TheDrinksListView = repository.Drinks,
            };
            return View(model2);
        }

        public ActionResult EditOrder()
        {
            return View();
        }

        public ActionResult ViewOrders()
        {
            return View();
        }

    }
}