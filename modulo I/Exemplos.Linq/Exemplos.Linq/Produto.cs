using System;

namespace Exemplos.Linq
{
    public class Produto
    {
        private static int IdCorrente = 1;
        public Produto(long codigo, string descricao, decimal custo)
        {
            Id = IdCorrente++;
            DataCadastro = DateTime.Now;

            Codigo = codigo;
            Descricao = descricao;
            Custo = custo;
        }
        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public long Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal Venda => Math.Round(Custo * 1.35M, 2);
        public override string ToString() => $"({Id}) -> {Codigo}-{Descricao}";
    }
}
