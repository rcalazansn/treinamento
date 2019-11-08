namespace Mercadinho.Data.Modelo
{
    public class Estoque : EntidadeBase
    {
        public int QtdeAtual { get; set; }
        public int QtdeMinima { get; set; }
        public Produto Produto { get; set; }
    }
}
