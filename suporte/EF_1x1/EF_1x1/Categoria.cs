using System.Data.Entity.ModelConfiguration;

namespace EF_1x1
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }

    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {

        public CategoriaMap()
        {

            ToTable("tab_categorias");

            HasKey(x => x.Id);

            Property(x => x.Descricao).HasColumnType("varchar").HasMaxLength(50).HasColumnName("Descricao").IsRequired();

            //Property(x => x.ProdutoId).HasColumnName("ProdutoId").IsRequired();

            HasRequired(x => x.Produto).WithMany(x => x.Categorias).HasForeignKey(c => c.ProdutoId);
        }
    }
}
