using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostalWebApi.Models
{
    public class Menu
    {
        public int Id { get; set; }
        
        public string FoodDescription { get; set; }
        
        public decimal Price { get; set; }
        
        public bool Available { get; set; }
        
        public int CategoryId { get; set; }
    }
}
