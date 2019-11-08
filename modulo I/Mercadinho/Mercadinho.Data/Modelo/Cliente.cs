using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Data.Modelo
{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataUltimaCompra { get; set; }
    }
}
