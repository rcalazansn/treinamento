using System;

namespace Mercadinho.Data.Modelo
{
    public class Fornecedor: EntidadeBase
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public int QuantidadeRecebimento { get; set; }
    }
}
