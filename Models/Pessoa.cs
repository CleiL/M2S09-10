using System.ComponentModel.DataAnnotations;

namespace labclothingcollectionbd.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        [Required, MaxLength(100)]
        public required string Nome { get; set; }
        [Required]
        public string? Genero { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required, MaxLength(11)]
        public string? Cpf { get; set; }
        [Required, MaxLength(14)]
        public string? Cnpj { get; set; }
        [Required]
        public string? Telefone { get; set; }
    }
}
