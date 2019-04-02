using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PostalWebApi.Models;

namespace PostalWebApi.Models
{
    public class PostalWebApiContext : DbContext
    {
        public PostalWebApiContext (DbContextOptions<PostalWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<PostalWebApi.Models.Staff> Staff { get; set; }

        public DbSet<PostalWebApi.Models.TableNum> TableNum { get; set; }

        public DbSet<PostalWebApi.Models.Menu> Menu { get; set; }

        public DbSet<PostalWebApi.Models.Category> Category { get; set; }

        public DbSet<PostalWebApi.Models.TableOrder> TableOrder { get; set; }

        public DbSet<PostalWebApi.Models.OrderItem> OrderItem { get; set; }
    }
}
