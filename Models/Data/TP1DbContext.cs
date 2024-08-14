using Microsoft.EntityFrameworkCore;

namespace TP1_Sotomayor.Models.Data
{
    public class TP1DbContext : DbContext
    {
        public TP1DbContext(DbContextOptions<TP1DbContext> options) : base(options)
        {

        }
        public DbSet<Equipe> Equipe { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Générer des données de départ
            modelBuilder.GenerateData();
        }


    }


}
