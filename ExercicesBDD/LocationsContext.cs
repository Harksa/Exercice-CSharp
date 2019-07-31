using ExercicesBDD.Models;
using Microsoft.EntityFrameworkCore;

namespace ExercicesBDD
{
    class LocationsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=LocationsBDD.db");
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Loue> Loues { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Categorie> Categories { get; set; }
    }
}
