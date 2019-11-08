using Mercadinho.Data.Modelo;
using Mercadinho.Data.Modelo.Map;
using System.Data.Entity;

namespace Mercadinho.Data.Contexto
{
    public class MercadinhoContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estoque> Estoque { get; set; }

        public MercadinhoContexto() : base("conexaoDB") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());

            modelBuilder.Configurations.Add(new FornecedorMap());

            modelBuilder.Configurations.Add(new ProdutoMap());

            modelBuilder.Configurations.Add(new EstoqueMap());
        }
    }
}
