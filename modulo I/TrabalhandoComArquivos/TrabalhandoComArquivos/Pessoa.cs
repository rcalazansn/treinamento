using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivos
{
    public class Pessoa
    {
        [JsonProperty("nome_pessoa")]
        public string Nome { get; set; }

        [JsonProperty("item.produtos")]
        public IEnumerable<Produto> Produtos { get; set; }
    }

    public class Produto
    {

    }

}
