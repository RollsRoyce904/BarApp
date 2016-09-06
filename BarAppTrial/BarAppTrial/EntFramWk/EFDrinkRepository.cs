using System;
using System.Collections.Generic;
using BarAppTrial.Models;
using BarAppTrial.Repositories;

namespace BarAppTrial.EntFramWk
{
    public class EFDrinkRepository : IDrinksRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Drinks> Drinks
        {
            get { return context.DrinkContext; }
        }
    }
}