using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PostalWebApi.Models;

namespace PostalWebApi.Models
{
    public class StaffContext : DbContext
    {
        public StaffContext (DbContextOptions<StaffContext> options)
            : base(options)
        {
        }

        public DbSet<PostalWebApi.Models.Staff> Staff { get; set; }

        public DbSet<PostalWebApi.Models.TableNum> TableNum { get; set; }
    }
}
