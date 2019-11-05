    using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
    public static class DLLContext
    {
        public static IDbConnection ObterConexao()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        }
    }
}
