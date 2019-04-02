using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostalWebApi.Models
{
    public class TableOrder
    {
        public int Id { get; set; }

        public DateTime OrderTime { get; set; }

        public bool Complete { get; set; } 

        public int StaffId { get; set; }

        public int TableNumId { get; set; }
    }
}
