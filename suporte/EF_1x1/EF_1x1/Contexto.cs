using System.Data.Entity;

namespace EF_1x1
{
    public class Contexto : DbContext
    {
        public Contexto() : base("conexao") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new EstoqueMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            
        }
    }
}
