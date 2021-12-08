using EYECANDY2.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EYECANDY2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SerieActor>()
                .HasKey(sa => new { sa.ActorId, sa.SerieId });
            modelBuilder.Entity<SerieGenero>()
                .HasKey(sg => new { sg.SerieId, sg.GeneroId });
        }



        public DbSet<Genero> Generos { get; set; }
        public DbSet<Actor> Actores { get; set; }
        public DbSet<Director> Directores { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<SerieActor> SeriesActores { get; set; }
        public DbSet<SerieGenero> SeriesGeneros { get; set; }

    }

}
