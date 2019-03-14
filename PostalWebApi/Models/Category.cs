using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostalWebApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        public string CategoryText { get; set; }
        
        public int DisplayOrder { get; set; }
    }
}
