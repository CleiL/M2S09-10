using System.ComponentModel.DataAnnotations;

namespace labclothingcollectionbd.Models
{
    public class Usuario: Pessoa
    {
        [Required(ErrorMessage = "O campo nome é obrigatório")]
        public required string Email { get; set; }
        public TipoUsuario Tipo { get; set; }
        public StatusUsuario Status { get; set; }
    }
    public enum TipoUsuario
    {
        Administrador,
        Gerente,
        Criador,
        Outro
    }

    public enum StatusUsuario
    {
        Ativo,
        Inativo
    }
}
