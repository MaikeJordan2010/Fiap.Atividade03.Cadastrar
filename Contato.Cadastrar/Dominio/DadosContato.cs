using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace Contato.Cadastrar.Dominio
{
    [Table("TabContatos")]
    public class DadosContato
    {
        [ExplicitKey]
        public string? Guid { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? DDD { get; set; }
        public string? Telefone { get; set; }
        public string? Estado { get; set; }
        public string? Municipio { get; set; }
    }
}
