using Microsoft.EntityFrameworkCore;
using RCN.Business.Model;
using RCN.Data.Mapping;

namespace RCN.Data.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
         : base(options) { }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
        }
    }
}