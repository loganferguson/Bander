using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bandter.Models
{
    public class BanderDbContext: IdentityDbContext
    {
        public BanderDbContext(DbContextOptions<BanderDbContext> options) : base(options)
                {

                }
        public DbSet<Event> Events { get; set; }
        public DbSet<Location> Locations { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
