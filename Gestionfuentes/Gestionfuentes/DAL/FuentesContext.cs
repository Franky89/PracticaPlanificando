using Gestionfuentes.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Gestionfuentes.DAL
{
    public class FuentesContext : DbContext
    {
        public FuentesContext() : base("FuentesContext")
        {
        }
        public DbSet<Fuente> Fuentes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}