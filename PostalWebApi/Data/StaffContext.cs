using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PostalWebApi.Models
{
    public class StaffContext : DbContext
    {
        public StaffContext (DbContextOptions<StaffContext> options)
            : base(options)
        {
        }

        public DbSet<PostalWebApi.Models.Staff> Staff { get; set; }
    }
}
