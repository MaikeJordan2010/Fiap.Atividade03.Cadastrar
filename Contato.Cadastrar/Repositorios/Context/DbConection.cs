using Contato.Cadastrar.Dominio;
using Microsoft.Data.SqlClient;

namespace Contato.Cadastrar.Repositorios.Context
{
    public class DbConection : IDbConection
    {

        private SqlConnection? _sqlConnection;
        private readonly IConfiguration _config;

        public DbConection(IConfiguration config)
        {
            _config = config;
        }


        public SqlConnection? ObterConexao()
        {
            try
            {
                if (_sqlConnection == null) {

                    var stringConexao = _config.GetConnectionString("DefaultConnection");

                    _sqlConnection = new SqlConnection(stringConexao);
                    return _sqlConnection;
                }

                return _sqlConnection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return default;
            }
        }
      
    }
}
