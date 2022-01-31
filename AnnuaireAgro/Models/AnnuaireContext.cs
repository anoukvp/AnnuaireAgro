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
         => optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DEV\AnnuaireAgro\Data\AgroBDD.mdf;Integrated Security=True;Connect Timeout=30");

       
        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Collaborateur>
           (entity =>
           {
               entity.HasOne(d => d.service).WithMany(p => p.Collaborateur);
               entity.HasOne(d => d.site).WithMany(p => p.Collaborateur);

           });
        }

    }
}
