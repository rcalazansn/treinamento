using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace DLL
{
    public class ClienteRepository : IClienteRepository
    {
        public void Inserir(Cliente cliente)
        {
            string sql = "INSERT INTO tab_clientes (NomeTitular, Nascimento) Values (@NomeTitular, @Nascimento);";

            SqlMapper.Execute(
                DLLContext.ObterConexao(),
                sql,
                new
                {
                    cliente.NomeTitular,
                    cliente.Nascimento
                });
        }

        public void Editar(Cliente cliente)
        {
            string sql = "UPDATE tab_clientes SET NomeTitular = @NomeTitular, Nascimento = @Nascimento WHERE ID = @ID;";

            SqlMapper.Execute(
                DLLContext.ObterConexao(),
                sql,
                new
                {
                    cliente.NomeTitular,
                    cliente.Nascimento,
                    cliente.Id
                });
        }

        public void Apagar(int id)
        {
            string sql = "DELETE FROM tab_clientes WHERE ID = @ID;";

            SqlMapper.Execute(DLLContext.ObterConexao(), sql, new { id });
        }

        public Cliente Obter(int id)
        {
            string sql = "SELECT * FROM tab_clientes WHERE ID = @ID;";

            return SqlMapper.Query<Cliente>(DLLContext.ObterConexao(), sql, new { id }).FirstOrDefault();
        }

        public IEnumerable<Cliente> Obter()
        {
            string sql = "SELECT * FROM tab_clientes";

            return SqlMapper.Query<Cliente>(DLLContext.ObterConexao(), sql).ToList();
        }
    }
}
