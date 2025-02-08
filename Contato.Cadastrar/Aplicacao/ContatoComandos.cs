using Contato.Cadastrar.Dominio;
using Contato.Cadastrar.Repositorios.ContatosRepositorios;

namespace Contato.Cadastrar.Aplicacao
{
    public class ContatoComandos : IContatoComandos
    {
        private readonly IContatosComandosRepositorio _repositorio;

        public ContatoComandos(IContatosComandosRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public void Inserir(DadosContato dadosContato)
        {
            _repositorio.Inserir(dadosContato);
        }
    }
}
