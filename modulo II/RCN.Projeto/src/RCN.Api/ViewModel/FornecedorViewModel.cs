using RCN.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCN.Api.ViewModel
{
    public class FornecedorViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public int TipoFornecedor { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
