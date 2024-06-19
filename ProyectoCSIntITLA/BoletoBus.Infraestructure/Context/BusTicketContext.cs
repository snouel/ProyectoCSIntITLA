using BoletoBus.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace BoletoBus.Infraestructure.Context
{
    public partial class BusTicketContext : DbContext
    {
        public BusTicketContext(DbContextOptions<BusTicketContext> dbContext) : base(dbContext)
        {

        }
        public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle { get; set; }
        public DbSet<Ruta> Ruta { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Viaje> Viaje { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de la relación Asiento - Bus
            modelBuilder.Entity<Asiento>()
                .HasOne(a => a.Bus)                // Un Asiento pertenece a un Bus
                .WithMany(b => b.Asientos)         // Un Bus puede tener varios Asientos
                .HasForeignKey(a => a.IdBus);     // La clave foránea en Asiento es IdBus
        }

    }
}
