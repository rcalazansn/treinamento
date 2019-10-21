namespace Projeto2
{
    public interface IContaRepository : IBaseRepository<Conta>
    {
        void RealizarSaque(Conta conta, decimal valor);
        void RealizarDeposito(Conta conta, decimal valor);
        void RealizarTransferecia(Conta contaOrigem, Conta ContaDestino, decimal valor);
        Conta Obter(string agencia, string contaCorrente);
        bool ExisteSaldo(int id, decimal valor);
    }
}
