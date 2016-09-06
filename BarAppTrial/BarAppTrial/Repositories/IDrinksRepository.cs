using System.Collections.Generic;
using BarAppTrial.Models;

namespace BarAppTrial.Repositories
{
    public interface IDrinksRepository
    {
        IEnumerable<Drinks> Drinks { get; }
    }
}