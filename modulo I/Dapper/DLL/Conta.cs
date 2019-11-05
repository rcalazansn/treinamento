namespace DLL
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
        public override string ToString()
        {
            return $"{Agencia}:{ContaCorrente}-{Saldo}";
        }
    }
}
