using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AV.BO;

namespace AV.DA
{
    public class AVDBContext : DbContext
    {

        public AVDBContext(DbContextOptions<AVDBContext> options) : base(options)
        {

        }

        // Este se agrega para invocarla por fuera del servicio
        public AVDBContext(DbContextOptions options, int op) : base(options)
        {
        }

        //este método es para que no autogenere los id de tipo int
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Evento>().Property(et => et.EventoId).ValueGeneratedNever();
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}
