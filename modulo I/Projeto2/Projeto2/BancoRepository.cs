using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Projeto2
{
    public class BancoRepository : IBancoRepository
    {
        public void Inserir(Banco banco)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                context.Bancos.Add(banco);
                context.SaveChanges();
            }
        }

        public void Editar(Banco banco)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                Banco bancoDB = context.Bancos.Where(x => x.Id == banco.Id).FirstOrDefault();

                if (bancoDB != null)
                {
                    context.Entry(bancoDB).CurrentValues.SetValues(banco);
                    context.SaveChanges();
                }
            }
        }

        public void Apagar(int id)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                Banco bancoDB = context.Bancos.Where(x => x.Id == id).FirstOrDefault();

                if (bancoDB != null)
                {
                    context.Bancos.Remove(bancoDB);
                    context.SaveChanges();
                }
            }
        }

        public Banco Obter(int id)
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                return context.Bancos.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public IEnumerable<Banco> Obter()
        {
            using (Projeto2Context context = new Projeto2Context())
            {
                return context.Bancos
                .Include("Contas")
                .ToList();
            }
        }
    }
}
