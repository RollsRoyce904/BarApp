using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BarAppTrial.Models;
using BarAppTrial.Repositories;

namespace BarAppTrial.Controllers
{
    public class OrderController : Controller
    {
        private IDrinksRepository repository;
        public Order myOrders = new Order();

        public OrderController(IDrinksRepository drinkRepository)
        {
            this.repository = drinkRepository;
        }

        public RedirectToRouteResult AddOrder(Drinks drink)
        {
            myOrders.AddOrder(drink);
            return RedirectToAction("Index", "Home");
        }
    }
}