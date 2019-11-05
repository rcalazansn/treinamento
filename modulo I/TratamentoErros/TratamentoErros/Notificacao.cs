using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoErros
{
    public class Notificacao
    {
        public List<string> _notificacoes { get; private set; }
        public Notificacao()
        {
            _notificacoes = new List<string>();
        }

        public void AdicionarNotificacao(string mensagem)
        {
            _notificacoes.Add(mensagem);
        }
    }
}
