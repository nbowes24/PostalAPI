using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostalWebApi.Models
{
    public class TableNum
    {
        public int Id { get; set; }
        
        public int? StaffId { get; set; }
        
        public int TableNumber { get; set; }
    }
}
