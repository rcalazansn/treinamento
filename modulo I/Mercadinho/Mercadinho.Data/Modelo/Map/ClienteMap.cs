using System.Data.Entity.ModelConfiguration;

namespace Mercadinho.Data.Modelo.Map
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("tab_clientes");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(60).HasColumnName("Nome").IsRequired();

            Property(x => x.DataNascimento).HasColumnName("Nascimento").IsRequired();

            Property(x => x.DataUltimaCompra).HasColumnName("UltimaCompra").IsOptional();
        }
    }
}
