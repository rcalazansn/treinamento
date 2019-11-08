using System.Data.Entity.ModelConfiguration;

namespace Mercadinho.Data.Modelo.Map
{
    public class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            ToTable("tab_estoque");

            HasKey(x => x.Id);

            Property(x => x.QtdeAtual).HasColumnName("Atual").IsRequired();

            Property(x => x.QtdeMinima).HasColumnName("Minimo").IsRequired();

            HasRequired(x => x.Produto).WithOptional(x => x.Estoque);
        }
    }
}
