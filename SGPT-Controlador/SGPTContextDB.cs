using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGPT_Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SGPT_Controlador
{
    class SGPTContextDB : DbContext
    {
        public DbSet<Usuarios> TblUsuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Map to the correct Chinook Database tables
            modelBuilder.Entity<Usuarios>().ToTable("Usuario", "public");

            // Chinook Database for PostgreSQL doesn't auto-increment Ids
            modelBuilder.Conventions.Remove<StoreGeneratedIdentityKeyConvention>();
        }

    }
}
