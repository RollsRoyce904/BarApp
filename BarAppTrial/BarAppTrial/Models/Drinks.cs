using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BarAppTrial.Models
{
    public class Drinks
    {
        [Key]
        public string DrinkName { get; set; }
        public decimal Price { get; set; }
    }
}