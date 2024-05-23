using DBBoletoBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DBBoletoBus.Infraestructure.Context
{
    public class BoletoBusContext : DbContext
    {
        public BoletoBusContext(DbContextOptions<BoletoBusContext> dbContext) : base(dbContext) { 
        
           

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asiento>().ToTable("", "");
            base.OnModelCreating(modelBuilder);
        }

    }
}
