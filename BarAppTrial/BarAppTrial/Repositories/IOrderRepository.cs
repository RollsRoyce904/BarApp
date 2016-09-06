using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BarAppTrial.Models;

namespace BarAppTrial.Repositories
{
    public interface OrderRepository
    {
        IEnumerable<Order> OrderRepos { get; set; }
    }
}