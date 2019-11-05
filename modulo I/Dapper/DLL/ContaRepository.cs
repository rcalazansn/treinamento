using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class ContaRepository : IContaRepository
    {
        public void Inserir(Conta conta)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("INSERT INTO tab_conta");
            sql.AppendLine("(Agencia, ContaCorrente, Saldo, Limite, ClienteId, BancoId)");
            sql.AppendLine("VALUES");
            sql.AppendLine("(@Agencia, @ContaCorrente, @Saldo, @Limite, @ClienteId, @BancoId);");

            SqlMapper.Execute(
                DLLContext.ObterConexao(),
                sql.ToString(),
                new
                {
                    conta.Agencia,
                    conta.ContaCorrente,
                    conta.Saldo,
                    conta.Limite,
                    conta.ClienteId,
                    conta.BancoId,
                });
        }

        public void Editar(Conta conta)
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("UPDATE tab_conta SET");
            sql.AppendLine(" Agencia = @Agencia");
            sql.AppendLine(",ContaCorrente = @ContaCorrente");
            sql.AppendLine(",Saldo = @Saldo");
            sql.AppendLine(",Limite = @Limite");
            sql.AppendLine(",ClienteId = @ClienteId");
            sql.AppendLine(",BancoId = @BancoId");
            sql.AppendLine("WHERE Id = @Id;");

            SqlMapper.Execute(
                DLLContext.ObterConexao(),
                sql.ToString(),
                new
                {
                    conta.Agencia,
                    conta.ContaCorrente,
                    conta.Saldo,
                    conta.Limite,
                    conta.ClienteId,
                    conta.BancoId,
                    conta.Id
                });
        }

        public void Apagar(int id)
        {
            string sql = "DELETE FROM tab_conta WHERE ID = @ID;";

            SqlMapper.Execute(DLLContext.ObterConexao(), sql, new { id });
        }

        public Conta Obter(int id)
        {
            string sql = "SELECT * FROM tab_conta WHERE ID = @ID;";

            return SqlMapper.QueryFirstOrDefault<Conta>(DLLContext.ObterConexao(), sql, new { id });
        }

        public IEnumerable<Conta> Obter()
        {
            string sql = "SELECT * FROM tab_conta";

            return SqlMapper.Query<Conta>(DLLContext.ObterConexao(), sql);
        }

        public void RealizarSaque(Conta conta, decimal valor)
        {
            string sql = "UPDATE tab_conta SET saldo = (saldo - @valor) WHERE id = @id;";

            SqlMapper.Execute(DLLContext.ObterConexao(), sql, new { valor, conta.Id });
        }

        public void RealizarDeposito(Conta conta, decimal valor)
        {
            string sql = "UPDATE tab_conta SET saldo = (saldo + @valor) WHERE id =  @id;";

            SqlMapper.Execute(DLLContext.ObterConexao(), sql, new { valor, conta.Id });
        }

        public void RealizarTransferecia(Conta contaOrigem, Conta ContaDestino, decimal valor)
        {
            string sqlDebito = "UPDATE tab_conta SET saldo = (saldo - @valor) WHERE id = @id;";
            SqlMapper.Execute(DLLContext.ObterConexao(), sqlDebito, new { valor, contaOrigem.Id });

            string sqlCredito = "UPDATE tab_conta SET saldo = (saldo + @valor) WHERE id = @id;";
            SqlMapper.Execute(DLLContext.ObterConexao(), sqlCredito, new { valor, ContaDestino.Id });
        }

        public Conta Obter(string agencia, string contaCorrente)
        {
            string sql = "SELECT * FROM tab_conta WHERE Agencia = @Agencia AND ContaCorrente = @ContaCorrente;";

            return SqlMapper.Query<Conta>(DLLContext.ObterConexao(), sql, new { agencia , contaCorrente }).FirstOrDefault();
        }

        public bool ExisteSaldo(int id, decimal valor)
        {
            string sql = "SELECT Saldo FROM tab_conta WHERE ID = @ID;";

            Conta retorno = SqlMapper.Query<Conta>(DLLContext.ObterConexao(), sql, new { id }).FirstOrDefault();

            return retorno.Saldo >= valor ? true : false;
        }
    }
}
