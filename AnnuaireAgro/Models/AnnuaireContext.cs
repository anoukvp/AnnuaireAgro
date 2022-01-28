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
         => optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=AnnuaireAgro;Integrated Security=True");

       
    }
}
