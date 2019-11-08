using System.Data.Entity.ModelConfiguration;

namespace Mercadinho.Data.Modelo.Map
{
    public class FornecedorMap : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMap()
        {
            ToTable("tab_fornecedores");

            HasKey(x => x.Id);

            Property(x => x.Codigo).HasColumnType("varchar").HasMaxLength(20).HasColumnName("Codigo").IsRequired();

            Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(60).HasColumnName("Nome").IsRequired();

            Property(x => x.Ativo).HasColumnName("Ativo").IsRequired();

            Property(x => x.DataRecebimento).HasColumnName("DataRecebimento").IsOptional();
        }
    }
}
