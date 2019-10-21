using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            ToTable("tab_conta");

            HasKey(p => p.Id);

            Property(p => p.Agencia).IsRequired().HasMaxLength(4);
            Property(p => p.ContaCorrente).IsRequired().HasMaxLength(10);
            Property(p => p.Saldo).IsRequired();
            Property(p => p.Limite).IsRequired();
        }
    }
}
