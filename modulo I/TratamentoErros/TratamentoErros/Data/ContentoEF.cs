using System.Data.Entity;

namespace TratamentoErros
{
    public class ContentoEF : DbContext
    {
        public ContentoEF() : base("conexao") { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
