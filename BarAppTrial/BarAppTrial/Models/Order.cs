using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BarAppTrial.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Drinks DrinkName { get; set; }

        private List<Drinks> linesCollection = new List<Drinks>();

        public void AddOrder(Drinks addDrink)
        {
            linesCollection.Add(addDrink);
        }
    }
}
