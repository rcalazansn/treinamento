using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace EF_1x1
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal Lucro { get; set; }
        public decimal ValorVenda => ((ValorCompra * Lucro) / 100);
        public Estoque Estoque { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
    }

    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("tab_produtos");

            HasKey(x => x.Id);

            Property(x => x.Codigo)
                .HasColumnType("varchar") //Tipo da Coluna
                .HasMaxLength(20)         //Tamanho
                .HasColumnName("Codigo")  //Nome da coluna (caso queira diferente da propriedade)
                .IsRequired();            //obrigatorio

            Property(x => x.Descricao).HasColumnName("Descricao").IsRequired();

            Property(x => x.Ativo).HasColumnName("Ativo").IsRequired();

            Property(x => x.Lucro).HasColumnName("Lucro").IsRequired();

            Property(x => x.ValorCompra).HasColumnName("ValorCompra").IsRequired();

            HasOptional(x => x.Estoque).WithRequired(x => x.Produto);

            HasMany(c => c.Categorias).WithRequired(c => c.Produto).HasForeignKey(c => c.ProdutoId);
        }
    }
}
