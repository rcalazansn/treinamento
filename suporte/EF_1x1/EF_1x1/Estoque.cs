using System.Data.Entity.ModelConfiguration;

namespace EF_1x1
{
    public class Estoque
    {
        public int Id { get; set; }
        public int QtdeAtual { get; set; }
        public int QtdeMinima { get; set; }
        public Produto Produto { get; set; }
    }

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
