using Dapper;
using DLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLL
{
    public class BancoRepository : IBancoRepository
    {
        public void Inserir(Banco banco)
        {
            string sql = "INSERT INTO tab_bancos (Codigo, Nome) Values (@Codigo, @Nome);";

            SqlMapper.Execute(
                DLLContext.ObterConexao(),
                sql,
                new
                {
                    banco.Codigo,
                    banco.Nome
                });
        }

        public void Editar(Banco banco)
        {
            string sql = "UPDATE tab_bancos SET Codigo = @Codigo, Nome = @Nome WHERE ID = @ID;";

            SqlMapper.Execute(
                DLLContext.ObterConexao(),
                sql,
                new
                {
                    banco.Codigo,
                    banco.Nome,
                    banco.Id
                });
        }

        public void Apagar(int id)
        {
            string sql = "DELETE FROM tab_bancos WHERE ID = @ID;";

            SqlMapper.Execute(DLLContext.ObterConexao(), sql, new { id });
        }

        public Banco Obter(int id)
        {
            string sql = "SELECT * FROM tab_bancos WHERE ID = @ID;";

            return SqlMapper.QueryFirstOrDefault<Banco>(DLLContext.ObterConexao(), 
                                                        sql, new { id });
        }

        public IEnumerable<Banco> Obter()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT B.*, count(C.id) QuantidadeContas");
            sql.AppendLine("FROM tab_bancos AS B");
            sql.AppendLine("INNER JOIN tab_conta C ON B.ID = C.BancoId");
            sql.AppendLine("GROUP BY b.Id, b.Codigo, b.Nome");
            
            return SqlMapper.Query<Banco>(DLLContext.ObterConexao(), sql.ToString());
        }
    }
}
