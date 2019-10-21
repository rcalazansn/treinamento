using System.Collections.Generic;

namespace Projeto2
{
    public class Banco
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Conta> Contas { get; set; }

        public int QuantidadeContas
        {
            get
            {
                return Contas.Count;
            }
        }

    }
}
