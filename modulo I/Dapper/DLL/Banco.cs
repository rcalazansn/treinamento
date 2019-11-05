using System.Collections.Generic;

namespace DLL
{
    public class Banco
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeContas { get; set; }
        public override string ToString()
        {
            return $"{Codigo}-{Nome}";
        }
    }
}
