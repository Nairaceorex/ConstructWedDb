using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConstructWedDb.Models;

namespace ConstructWedDb.Data
{
    public class ConstructWedDbContext : DbContext
    {
        public ConstructWedDbContext (DbContextOptions<ConstructWedDbContext> options)
            : base(options)
        {
        }

        public DbSet<ConstructWedDb.Models.Staff> Staff { get; set; }

        public DbSet<ConstructWedDb.Models.Customer> Customer { get; set; }

        public DbSet<ConstructWedDb.Models.Position> Position { get; set; }

        public DbSet<ConstructWedDb.Models.Material> Material { get; set; }

        public DbSet<ConstructWedDb.Models.Brigade> Brigade { get; set; }

        public DbSet<ConstructWedDb.Models.TypeOfJob> TypeOfJob { get; set; }

        public DbSet<ConstructWedDb.Models.Order> Order { get; set; }
    }
}
