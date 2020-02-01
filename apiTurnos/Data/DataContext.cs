using apiTurnos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Data
{
    public class DataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JornadaServicio>().HasKey(x => new { x.jornadaId, x.servicioId });
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Servicio> servicios { get; set; }
        public DbSet<Precio> precios { get; set; }
        public DbSet<Jornada> jornadas { get; set; }
        public DbSet<JornadaServicio> jornadasServicios { get; set; }
        public DbSet<Usuario>usuarios { get; set; }
        public DbSet<Rol> roles { get; set; }
        public DbSet<Turno> turnos { get; set; }

    }
}
