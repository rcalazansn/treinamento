using System.Data.Entity.ModelConfiguration;

namespace Projeto2
{
    public class BancoMap : EntityTypeConfiguration<Banco>
    {
        public BancoMap()
        {
            ToTable("tab_bancos");

            HasKey(c => c.Id);

            Property(c => c.Codigo).IsRequired().HasMaxLength(10);
            Property(c => c.Nome).IsRequired().HasMaxLength(60); ;
        }
    }
}
