using BarAppTrial.Models;
using System.Data.Entity;

namespace BarAppTrial.EntFramWk
{
    public class EFDbContext : DbContext
    {
        public DbSet<Drinks> DrinkContext { get; set; }
    }
}