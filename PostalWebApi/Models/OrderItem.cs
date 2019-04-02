using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostalWebApi.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int MenuId { get; set; }

        public int TableOrderId { get; set; }
    }
}
