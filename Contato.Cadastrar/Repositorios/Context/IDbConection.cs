using Microsoft.Data.SqlClient;

namespace Contato.Cadastrar.Repositorios.Context
{
    public interface IDbConection
    {
        public SqlConnection? ObterConexao();

    }
}
