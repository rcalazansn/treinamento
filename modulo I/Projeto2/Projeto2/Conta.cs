namespace Projeto2
{
    public class Conta
    {
        public int Id { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public int ClienteId { get; set; }
        public int BancoId { get; set; }
        public virtual  Cliente Cliente { get; set; }
        public virtual  Banco Banco { get; set; }
        public override string ToString()
        {
            return $"{Banco}-{Saldo}";
        }
    }
}
