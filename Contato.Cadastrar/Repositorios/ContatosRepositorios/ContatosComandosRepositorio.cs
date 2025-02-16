using Contato.Cadastrar.Dominio;
using Contato.Cadastrar.Repositorios.Context;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Contato.Cadastrar.Repositorios.ContatosRepositorios
{
    public class ContatosComandosRepositorio : IContatosComandosRepositorio
    {
        private readonly SqlConnection? _connection;

        public ContatosComandosRepositorio()
        {
            _connection = DbConection.ObterConexao();
        }

        public void Inserir(DadosContato contato)
        {
            try
            {
                if (_connection != null)
                {
                    _connection.Open();
                    _connection.Insert<DadosContato>(contato);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                _connection?.Close();
            }
        }
    }
}

