using Contato.Cadastrar.Dominio;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Contato.Cadastrar.Repositorios.Context
{
    public class DbConection
    {

        private static SqlConnection? _sqlConnection;

        public static SqlConnection? ObterConexao()
        {
            try
            {
                var builder = new ConfigurationBuilder()
                          .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

                var _config = builder.Build();

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
