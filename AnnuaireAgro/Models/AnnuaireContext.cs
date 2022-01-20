using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAgro.Models
{
    class AnnuaireContext : DbContext
    {

        // Entités que l'on va manipuler avec le Context
        public DbSet<Collaborateur> Collaborateur { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Site> Site { get; set; }

        //Paramètrage de la DB locale
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DEV\AnnuaireAgro\Data\AnnuaireDB.mdf;Integrated Security=True");


        // Determine les relations (cardinalités) entre les entités
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Collaborateur>(entity =>
            {
                entity.HasOne(a => a.Service).WithMany(b => b.Collaborateur);
                entity.HasOne(c => c.Site).WithMany(d => d.Collaborateur);
            });
            
        }
     
    }
}
