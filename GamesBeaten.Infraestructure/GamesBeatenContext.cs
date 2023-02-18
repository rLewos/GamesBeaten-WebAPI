using GamesBeaten.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GamesBeaten.Infraestructure
{
    public class GamesBeatenContext : DbContext
    {
        public DbSet<Game> Game { get; set; }
        public DbSet<Plataform> Plataform { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Developer> Developer { get; set; }
        

        public GamesBeatenContext()        {        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Game> etbGame = modelBuilder.Entity<Game>();
            etbGame.HasKey(x => x.Id);
            


            base.OnModelCreating(modelBuilder);
        }
    }
}