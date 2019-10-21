using System;
using System.Collections.Generic;

namespace Projeto2
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NomeTitular { get; set; }
        public DateTime Nascimento { get; set; }
        public virtual ICollection<Conta> Contas { get; set; }

    }
}
