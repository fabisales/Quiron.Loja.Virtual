using Quiron.LojaVirtual.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) // remover pluralização(o entity framework costuma a colocar as palavras em plural nas tabelas)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos"); // Mostrando ao programa que produto = produtos ----- isso foi feito pois ao removermos a pluralização o programa não conseguiria associar 
        }

    }
}
