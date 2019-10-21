using System.Data.Entity;

namespace Projeto2
{
    public class Projeto2Context : DbContext
    {
        public Projeto2Context() : base("conexao")
        {
            
        }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Banco> Bancos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conta>()
                     .HasRequired<Cliente>(c => c.Cliente)
                     .WithMany(a => a.Contas)
                     .HasForeignKey<int>(c => c.ClienteId);

            modelBuilder.Entity<Conta>()
                    .HasRequired<Banco>(c => c.Banco)
                    .WithMany(a => a.Contas)
                    .HasForeignKey<int>(c => c.BancoId);

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ContaMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new BancoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
