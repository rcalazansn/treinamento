namespace Mercadinho.Data.Modelo
{
    public class Produto : EntidadeBase
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal ValorCompra { get; set; }
        public int Lucro { get; set; }
        public decimal ValorVenda { get; set; }
        public Estoque Estoque { get; set; }
    }
}
