using System.Data.Entity.ModelConfiguration;

namespace Mercadinho.Data.Modelo.Map
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("tab_produtos");

            HasKey(x => x.Id);

            Property(x => x.Codigo).HasColumnType("varchar").HasMaxLength(20).HasColumnName("Codigo").IsRequired();

            Property(x => x.Descricao).HasColumnType("varchar").HasMaxLength(50).HasColumnName("Descricao").IsRequired();

            Property(x => x.Ativo).HasColumnName("Ativo").IsRequired();

            Property(x => x.Lucro).HasColumnName("Lucro").IsRequired();

            Property(x => x.ValorCompra).HasColumnName("ValorCompra").IsRequired();

            HasOptional(x => x.Estoque).WithRequired(x => x.Produto);
        }
    }
}
