using System;
using System.Collections.Generic;

namespace TratamentoErros
{
    public class Cliente : Notificacao
    {
        public int Id { get; set; }
        public string NomeTitular { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
